using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMessagingApp.Models
{
    public partial class MediaFile
    {
        public override Message match(string s)
        {

            if (this.Caption.Contains(s))
                return this;
            else
                return null;
        }
    }
}