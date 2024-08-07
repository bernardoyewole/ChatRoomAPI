﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? DisplayName { get; set; }

        public byte[]? Picture { get; set; }

        public string? Status { get; set; }
        
        public string? About {  get; set; }

        public bool IsFirstTimeUser { get; set; } = true;

        // Navigation property for the many-to-many relationship
        public ICollection<ChannelUser> ChannelUsers { get; set; }
    }
}
