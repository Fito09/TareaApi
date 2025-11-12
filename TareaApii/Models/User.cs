using System.ComponentModel.DataAnnotations;

namespace TareaApii.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string UserName { get; set; } = string.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;

        public DateTime FechaNacimiento { get; set; }
        public int edad;

        public int RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
