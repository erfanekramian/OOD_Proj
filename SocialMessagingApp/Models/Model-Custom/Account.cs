using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMessagingApp.Models
{
    public partial class Acccount : SendMessageable
    {
        public override bool delete(Message m, Chat c)
        {
            return c.DeleteMessage(m.Id);

        }

        public override bool Send(Message m, Chat c)
        {
            c.AddMessage(m);
            return true;
        }
    }
}