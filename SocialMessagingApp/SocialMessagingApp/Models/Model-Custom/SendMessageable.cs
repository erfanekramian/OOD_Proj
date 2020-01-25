using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMessagingApp.Models
{
    public abstract class SendMessageable
    {
        public abstract bool Send(Message m, Chat c);
        public abstract bool delete(Message m, Chat c);
    }
}