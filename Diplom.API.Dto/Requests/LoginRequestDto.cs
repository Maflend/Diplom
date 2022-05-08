using System.ComponentModel.DataAnnotations;

namespace Diplom.API.Dto.Requests
{
    public class LoginRequestDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
