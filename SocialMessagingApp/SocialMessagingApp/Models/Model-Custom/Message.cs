using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMessagingApp.Models
{
    public abstract partial class Message
    {
        public TestEntities testEntities = new TestEntities();
        public int setSentFlag()
        {
            if (testEntities.Messages.Find(this.Id) == this)
                return 1;
            return 0;
        }
        public abstract Message match(string s);
        
    }
}