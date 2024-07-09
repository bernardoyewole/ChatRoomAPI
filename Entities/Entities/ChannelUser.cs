using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    // Stores the association between users and channels.
    public  class ChannelUser
    {
        public int ChannelId { get; set; }

        public Channel Channel { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
