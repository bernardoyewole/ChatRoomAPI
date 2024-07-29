using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class UpdateProfileModel
    {
        [Required]
        public string Email { get; set; }

        public IFormFile Picture { get; set; }

        public string DisplayName { get; set; }

        public string? Status { get; set; }

        public string About { get; set; }
    }
}
