using System.ComponentModel.DataAnnotations;

namespace TrashBountyLib.Models
{
    public class ReturningUser
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}