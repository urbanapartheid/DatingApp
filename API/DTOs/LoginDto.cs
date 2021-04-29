using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class LoginDto
    {
        #region Properties
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        #endregion
    }
}
