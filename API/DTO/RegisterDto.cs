using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8, ErrorMessage = "Password cannot exceed 8 characters", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
