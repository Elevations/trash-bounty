using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using TrashBountyLib;
using TrashBountyLib.Models;
using TrashBountyAPI.Service;
using Microsoft.AspNetCore.Authorization;
using System.Drawing;

namespace TrashBountyAPI.Controllers
{
    [Route("api/bounty")]
    [ApiController]
    public class BountyController : ControllerBase
    {
        private readonly BountyService _bountyService;
        private readonly UserService _userService;
        private readonly IHostEnvironment _environment;

        public BountyController(BountyService bountyService, UserService userService, IHostEnvironment env)
        {
            _bountyService = bountyService;
            _userService = userService;
            _environment = env;
        }

        [HttpGet("open/{limit:int}")]
        public ActionResult<List<Bounty>> Get(int limit)
        {
            return _bountyService.GetOpen(limit);
        }

        [HttpGet("close/{limit:int}")]
        public ActionResult<List<Bounty>> GetClosed(int limit)
        {
            return _bountyService.GetClosed(limit);
        }

        [HttpPost("open")]
        [Authorize]
        public async Task<IActionResult> Post(NewBounty newBounty)
        {
            // Save the image to the web api
            var imgDataByteArray = Convert.FromBase64String(newBounty.ImageData);

            var imgDataStream = new MemoryStream(imgDataByteArray);

            // Validate Image
            try
            {
                Image.FromStream(imgDataStream);
            }
            catch (Exception e)
            {
                return BadRequest("Not a valid image");
            }
            

            imgDataStream.Position = 0;
            string newFileName = $"{Guid.NewGuid()}.png";
            string filePath = Path.Combine(_environment.ContentRootPath, "wwwroot", "images", "bounties", newFileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                fileStream.Write(imgDataByteArray);
            }

            // Post the bounty
            Bounty bounty = new Bounty() { Latitude = newBounty.Latitude, Longitude = newBounty.Longitude, Description = newBounty.Description, BountyPictureLinks = new List<string>() };
            bounty.PosterId = User.FindFirstValue(ClaimTypes.UserData);
            bounty.BountyPictureLinks.Add($"https://localhost:44399/images/bounties/{newFileName}");
            bool success = await _bountyService.CreateOpenAsync(bounty);
            if (!success)
                return BadRequest("Could not insert the bounty into the database");

            // Link the bounty posted to the user
            User poster = _userService.Get(User.FindFirstValue(ClaimTypes.UserData));
            poster.PostedBountyIds.Add(bounty.Id);
            _userService.Update(poster.Id, poster);

            return Ok("Post successful");
        }

        [HttpPost("close")]
        [Authorize]
        public async Task<IActionResult> PostClosed(NewCompletedBounty newBounty)
        {
            // Save the image to the web api

            var imgDataByteArray = Convert.FromBase64String(newBounty.ImageData);

            var imgDataStream = new MemoryStream(imgDataByteArray);
            imgDataStream.Position = 0;
            string newFileName = $"{Guid.NewGuid()}.png";
            string filePath = Path.Combine(_environment.ContentRootPath, "wwwroot", "images", "bounties", newFileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                fileStream.Write(imgDataByteArray);
            }

            // Post the bounty
            CompletedBounty completedBounty = new CompletedBounty() { BountyId = newBounty.BountyId, CompletedBountyPictureLinks = new List<string>(), UserIds = new List<string>() };
            completedBounty.UserIds.Add(User.FindFirstValue(ClaimTypes.UserData));
            completedBounty.CompletedBountyPictureLinks.Add($"https://localhost:44399/images/bounties/{newFileName}");
            Bounty bounty = _bountyService.GetOpen(completedBounty.BountyId);
            bounty.CompletedBounty = completedBounty;

            _bountyService.RemoveOpen(bounty.Id);
            await _bountyService.CreateCloseAsync(bounty);

            // Link up with the user(s)
            foreach (string id in completedBounty.UserIds)
            {
                User u = _userService.Get(id);
                u.CompletedBountyIds.Add(bounty.Id);
                _userService.Update(id, u);
            }
;
            return Ok("Post successful");
        }
    }
}
