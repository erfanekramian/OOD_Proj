using SocialMessagingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialMessagingApp.Controllers
{
    

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public void addGroup()
        {
            TestEntities testEntities = new TestEntities();

            Group group = new Group();
            //group.LastSeenMessageId = 1;
            //group.Description = "aaaaa";
            group.CreatorId = 2;
            group.Description = "Family Group";

            testEntities.Chats.Add(group);

            testEntities.SaveChanges();
            List<Acccount> acccounts = new List<Acccount>();
            for (int i = 1; i <= 3; i++)
                acccounts.Add(testEntities.Acccounts.Find(i));
            group.AddMember(acccounts);
            var chat = testEntities.Chats.Find(4);
            chat.SearchMessage("che");
            testEntities.SaveChanges(); ;

            
            
            
            
            
            
            
            testEntities.SaveChanges();
            
           
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}