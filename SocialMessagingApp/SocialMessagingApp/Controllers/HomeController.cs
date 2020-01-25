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
        public void addGroup(string Name)
        {
            TestEntities testEntities = new TestEntities();

            //Group group = new Group();
            //group.LastSeenMessageId = 1;
            //group.Description = "aaaaa";
            //Group group = new Group();
            //group.CreatorId = 2;
            //group.Description = "Group for DA project";

            //testEntities.Chats.Add(group);

            //testEntities.SaveChanges();
            //List<Acccount> acccounts = new List<Acccount>();
            //for (int i = 1; i <= 3; i++)
            //    acccounts.Add(testEntities.Acccounts.Find(i));
            //group.AddMember(acccounts);
            //Text text = new Text();
            //text.text1 = "salam chetori?";
            //text.SenderId = 2;
            //var group = testEntities.Chats.Find(4);
            //group.AddMessage(text);

            Group group = new Group();
            group.Description = Name;
            group.CreatorId = 2;
            testEntities.Chats.Add(group);
            testEntities.SaveChanges();
            //personal.LastSeenMessageId = 1;
            //personal.SecondAccountId = 2;
            //personal.FirstAccountId = 3;






            //testEntities.Chats.Add(personal);

            //testEntities.SaveChanges();


        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}