using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    // Stores information about private chats between two users.
    public class PrivateChat
    {
        public int Id { get; set; }

        public string User1Id { get; set; }

        public ApplicationUser User1 { get; set; }

        public string User2Id { get; set; }

        public ApplicationUser User2 { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}
