using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocialMessagingApp.Models;
using SocialMessagingApp.Controllers;

namespace SocialMessagingAppUnitTest
{
    [TestClass]
    public class UnitTest1:Chat
    {
        [TestMethod]
        public void TestMethod1()
        {
            SocialMessagingAppEntities socialMessagingAppEntities = new SocialMessagingAppEntities();
            Group group = new Group();
            group.Description = "Group Test";
            group.CreatorId = 2;
            
            socialMessagingAppEntities.Chats.Add(group);
            socialMessagingAppEntities.SaveChanges();
            Assert.AreEqual(group, socialMessagingAppEntities.Chats.Find(group.Id));
            
            
            

        }
    }
}
