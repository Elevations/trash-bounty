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

namespace TrashBountyAPI.Controllers
{
    [Route("api/users/images")]
    [ApiController]
    public class UserImagesController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly IHostEnvironment _environment;

        public UserImagesController(UserService userService, IHostEnvironment environment)
        {
            _userService = userService;
            _environment = environment;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PostImage([FromForm] IFormFile image)
        {
            if (image == null || image.Length == 0)
            {
                return BadRequest("Upload a file");
            }

            string fileName = image.FileName;
            string extension = Path.GetExtension(fileName);
            string[] allowedExtensions = { ".jpg", ".png", ".bmp" };
            if (!allowedExtensions.Contains(extension))
            {
                return BadRequest("Unsupported image type");
            }
            string newFileName = $"{Guid.NewGuid()}{extension}";
            string filePath = Path.Combine(_environment.ContentRootPath, "wwwroot", "images", "profiles", newFileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                await image.CopyToAsync(fileStream);
            }

            string userId = User.FindFirstValue(ClaimTypes.UserData);
            User newUser = _userService.Get(userId);
            newUser.ProfileImageLink = $"https://localhost:44399/images/profiles/{newFileName}";
            _userService.Update(userId, newUser);

            return Ok($"https://localhost:44399/images/profiles/{newFileName}");
        }
    }
}
