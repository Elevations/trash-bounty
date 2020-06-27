using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using TrashBountyLib.Models;

namespace TrashBountyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IHostEnvironment _environment;

        public ImagesController(IHostEnvironment environment)
        {
            _environment = environment;
        }

        [HttpPost]
        public async Task<IActionResult> PostImage(string data)
        {
            /*
            var userId = ;

            if (data.Image == null || data.Image.Length == 0)
            {
                return BadRequest("Upload a file");
            }

            string fileName = image.FileName;
            string extension = Path.GetExtension(fileName);

            string[] allowedExtensions = { ".jpg", ".png", ".bmp" };

            if (!allowedExtensions.Contains(extension))
            {
                return BadRequest("File is not a valid image");
            }

            string newFileName = $"{Guid.NewGuid()}{extension}";
            string filePath = Path.Combine(_environment.ContentRootPath, "wwwroot", "Images", newFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                await image.CopyToAsync(fileStream);
            }

            return Ok($"Images/{newFileName}");
            */
            return Ok("Wait dyude");
        }
    }
}
