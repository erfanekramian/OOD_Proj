using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMessagingApp.Models
{
    public partial class Text : Message
    {
        public override Message match(string s)
        {

            if (this.text1.Contains(s))
                return this;
            else
                return null;
        }

    }
}