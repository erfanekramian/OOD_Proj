//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocialMessagingApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personal : Chat
    {
        public int FirstAccountId { get; set; }
        public int SecondAccountId { get; set; }
    
        public virtual Acccount Acccount { get; set; }
        public virtual Acccount Acccount1 { get; set; }
    }
}
