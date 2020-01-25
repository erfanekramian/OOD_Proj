using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMessagingApp.Models
{
    public abstract partial class Chat
    {
        public TestEntities testEntities = new TestEntities();
        public bool AddMessage(Message m)
        {
            m.ChatId = this.Id;
            testEntities.Messages.Add(m);
            testEntities.SaveChanges();
            if (testEntities.Messages.Find(m.Id) != null)
                return true;
            return false;
        }
        public bool SendNotification()
        {
            return true;
        }
        public bool DeleteMessage(int msgid)
        {
            var item = testEntities.Messages.Find(msgid);
            if (item != null)
            {
                testEntities.Messages.Remove(item);
                testEntities.SaveChanges();
                if (testEntities.Messages.Find(msgid) == null)
                    return true;
                return false;

            }
            return false;
            
            

        }
        public List<Message> SearchMessage(string s)
        {
            //var query = (from message in testEntities.Messages.OfType<MediaFile>() where message.Caption.Contains(s)
            //             select message);
            //var query2 = (from message in testEntities.Messages.OfType<Text>() where message.text1.Contains(s) select message);

            List<Message> messages = new List<Message>();
            var query = (from message in testEntities.Messages
                         where message.ChatId == this.Id
                         select message).ToList();


            foreach (var item in query)
            {
                if(item.match(s)!=null)
                    messages.Add(item);
            }
                
            
            return messages;

        }
        public List<Acccount> SearchMember(string s)
        {
            var query = (from account in testEntities.Acccounts
                         where account.FirstName.Contains(s) || account.LastName.Contains(s)
                         select account);
            List<Acccount> acccounts = new List<Acccount>();
            foreach (var item in acccounts)
                acccounts.Add(item);
            return acccounts;

        }

    }
}