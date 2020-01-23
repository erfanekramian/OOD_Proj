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

            //Group group = new Group();
            //group.LastSeenMessageId = 1;
            //group.Description = "aaaaa";
            Personal personal = new Personal();
            personal.LastSeenMessageId = 1;
            personal.SecondAccountId = 2;
            personal.FirstAccountId = 3;

            
            
            
            
            testEntities
            testEntities.Chats.Add(personal);
            
            testEntities.SaveChanges();
            
           
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}