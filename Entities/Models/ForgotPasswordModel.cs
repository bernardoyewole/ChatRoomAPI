using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
