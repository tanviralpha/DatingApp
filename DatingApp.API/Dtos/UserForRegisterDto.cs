using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

         [Required]
         [StringLength(8, MinimumLength = 4, ErrorMessage = "You must give password between 4 to 8 charecter.")]
        public string Password { get; set; }

    }
}