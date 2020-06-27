using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrashBountyAPI.Models;
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
using System.Collections.Generic;

/*namespace TrashBountyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrashController : ControllerBase
    {
        private readonly TrashService _trashService;
        private readonly IConfiguration _configuration;

        public TrashController(TrashService tService, IConfiguration configuration)
        {
            _trashService = tService;
            _configuration = configuration;
        }

        [HttpGet]
        public ActionResult<List<Bounty>> Get() =>
            _trashService.Get();

        [HttpGet("{id:length(24)}", Name = "GetBounty")]
        public ActionResult<Bounty> Get(string id)
        {
            var bounty = _trashService.Get(id);

            if (bounty == null)
            {
                return NotFound();
            }

            return bounty;
        }

        // Register
        [HttpPost]
        public async Task<IActionResult> Post(Bounty bounty)
        {
            // GET all the users
            List<Bounty> bounties = new List<Bounty>();
            bounties = _trashService.Get();

            // Email check
            Bounty newBounty = new Bounty(); // seems like some naming stuff is wrong here - actually no
            //if (bounties.FindIndex(b => u.Email.Equals(user.Email)) != -1)
            //{
            //    Console.WriteLine("Email already taken");
            //    return Ok(new RegisterResult { Successful = false, Errors = new List<string>() { "Email already taken" } });
            //}

            var result = await _trashService.CreateAsync(newBounty);

            return Ok(new RegisterResult { Successful = true });
        }

        // Login
        //[HttpPost("{id:length(24)}")]
        //public async Task<IActionResult> Post(ReturningUser u, string id)
        //{
        //    var user = _userService.Get(id);

        //    if (!Encrypter.Validate(u.Password, user.Password))
        //        return BadRequest(new LoginResult { Successful = false, Error = "Incorrect Password" });

        //    var claims = new[]
        //    {
        //        new Claim(ClaimTypes.Name, user.Username),
        //        new Claim(ClaimTypes.Email, user.Email),
        //        new Claim(ClaimTypes.UserData, user.Id)
        //    };

        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
        //    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        //    var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));

        //    var token = new JwtSecurityToken(
        //        _configuration["JwtIssuer"],
        //        _configuration["JwtAudience"],
        //        claims,
        //        expires: expiry,
        //        signingCredentials: creds
        //    );

        //    return Ok(new LoginResult { Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token) });
        //}

        //[HttpPut("{id:length(24)}")]
        //public IActionResult Update(string id, User userIn)
        //{
        //    var user = _userService.Get(id);

        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    _userService.Update(id, userIn);

        //    return NoContent();
        //}

        //[HttpDelete("{id:length(24)}")]
        //public IActionResult Delete(string id)
        //{
        //    var user = _userService.Get(id);

        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    _userService.Remove(user.Id);

        //    return NoContent();
        //}
    }
}*/