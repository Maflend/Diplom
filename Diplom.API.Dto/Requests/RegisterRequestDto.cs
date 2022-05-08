using System.ComponentModel.DataAnnotations;

namespace Diplom.API.Dto.Requests
{
    public class RegisterRequestDto
    {
        [Required]
        [MinLength(6)]
        public string UserName { get; set; }
        [Required]
        public int Age { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
