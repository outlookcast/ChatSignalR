using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatSignalR.Models
{
    public class Message
    {
        public string UserName { get; set; }
        public string MessageBody { get; set; }
        public DateTime Time { get; set; }
        public Guid Id { get; set; }
    }
}
