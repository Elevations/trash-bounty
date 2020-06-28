using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrashBountyAPI.Service;
using Microsoft.AspNetCore.Cors;
using TrashBountyLib.Models;
using TrashBountyLib.Models.Results;
using TrashBountyLib;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace TrashBountyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly IConfiguration _configuration;

        public UsersController(UserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
        }

        [HttpGet]
        public ActionResult<List<APIUser>> Get()
        {
            List<User> users = _userService.Get();
            return users.Select(u => new APIUser() { Id = u.Id, Email = u.Email, Username = u.Username, ProfileImageLink = u.ProfileImageLink }).ToList();
        }
            

        [HttpGet("{id:length(24)}", Name = "GetUser")]
        public ActionResult<APIUser> Get(string id)
        {
            var user = _userService.Get(id);

            if (user == null)
            {
                return NotFound();
            }

            return new APIUser() { Id = user.Id, Email = user.Email, Username = user.Username, ProfileImageLink = user.ProfileImageLink };
        }

        // Register
        [HttpPost]
        public async Task<IActionResult> Post(NewUser user)
        {
            // GET all the users
            List<User> users = new List<User>();
            users = _userService.Get();

            // Email check
            User newUser = new User { Username = user.Username, Password = Encrypter.Hash(user.Password), Email = user.Email };
            if (users.FindIndex(u => u.Email.Equals(user.Email)) != -1)
            {
                Console.WriteLine("Email already taken");
                return Ok(new RegisterResult { Successful = false, Errors = new List<string>(){ "Email already taken" } });
            }

            var result = await _userService.CreateAsync(newUser);

            return Ok(new RegisterResult {  Successful = true });
        }

        // Login
        [HttpPost("{id:length(24)}")]
        public async Task<IActionResult> Post(ReturningUser u, string id)
        {
            var user = _userService.Get(id);

            if (!Encrypter.Validate(u.Password, user.Password))
                return BadRequest(new LoginResult { Successful = false, Error = "Incorrect Password" });

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.UserData, user.Id)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));

            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtAudience"],
                claims,
                expires: expiry,
                signingCredentials: creds
            );

            return Ok(new LoginResult { Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token) });
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, User userIn)
        {
            var user = _userService.Get(id);

            if (user == null)
            {
                return NotFound();
            }

            _userService.Update(id, userIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var user = _userService.Get(id);

            if (user == null)
            {
                return NotFound();
            }

            _userService.Remove(user.Id);

            return NoContent();
        }
    }
}
