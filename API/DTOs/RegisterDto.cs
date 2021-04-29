using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto 
    {
        #region Properties
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; } 
        #endregion
    }
}
