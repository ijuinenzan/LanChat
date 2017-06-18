using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanChat
{
    public enum MessageType
    {
        Me,
        Other
    }
    public class MessageItem
    {
        public DateTime Time
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }

        public string Content
        {
            get;
            set;
        }

        public MessageType Type
        {
            get;
            set;
        }
    }
}
