using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocialMessagingApp.Models;
using System.Linq;

namespace SocialMessagingAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestEntities testEntities = new TestEntities();
            Acccount NewAcccount = new Acccount();
            NewAcccount.FirstName = "Hassan";
            NewAcccount.LastName = "kamrani";
            NewAcccount.UserName = "hassankamrani";
            testEntities.Acccounts.Add(NewAcccount);
            testEntities.SaveChanges();
            var query = (from account in testEntities.Acccounts
                         where account.UserName == NewAcccount.UserName
                         select account).ToList();
            Assert.AreEqual(query[0], NewAcccount);

            
        }
    }
}
