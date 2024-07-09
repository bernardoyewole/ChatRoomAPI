using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    // Stores information about each message sent in the chat.
    public class Message
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime Timestamp { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int? ChannelId { get; set; }

        public Channel Channel { get; set; }

        public int? PrivateChatId { get; set; }

        public PrivateChat PrivateChat { get; set; }
    }
}
