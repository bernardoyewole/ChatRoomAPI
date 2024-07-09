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
        public string DisplayName { get; set; }

        public string ProfilePictureUrl { get; set; }

        // Navigation property for the many-to-many relationship
        public ICollection<ChannelUser> ChannelUsers { get; set; }
    }
}