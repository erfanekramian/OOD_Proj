using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMessagingApp.Models
{
    public partial class Group
    {
        TestEntities testEntities = new TestEntities();
        public bool AddMember(List<Acccount> acccounts)
        {
            
            foreach(var item in acccounts)
            {
                GroupAccount groupAccount = new GroupAccount();
                groupAccount.AccountId = item.Id;
                groupAccount.GroupId = this.Id;
                testEntities.GroupAccounts.Add(groupAccount);
                testEntities.SaveChanges();
                
            }
            return true;
            
                
            
        }
        public bool RemoveMember(List<Acccount> acccounts)
        {
            foreach (var item in acccounts)
            {
                
                testEntities.GroupAccounts.Remove(testEntities.GroupAccounts.Find(item.Id));
                testEntities.SaveChanges();
               
            }
            return true;
        }
        public bool AddAdmin(List<Acccount> acccounts)
        {
            foreach (var item in acccounts)
            {
                AdminGroup adminGroup = new AdminGroup();
                adminGroup.AccountId = item.Id;
                adminGroup.GroupId = this.Id;
                testEntities.AdminGroups.Add(adminGroup);
                testEntities.SaveChanges();

            }
            return true;
        }
        public bool RemoveAdmin(List<Acccount> acccounts)
        {
            foreach (var item in acccounts)
            {

                testEntities.AdminGroups.Remove(testEntities.AdminGroups.Find(item.Id));
                testEntities.SaveChanges();

            }
            return true;
        }
        public List<Acccount> SearchMember(string s)
        {
            var query = (from groupaccount in testEntities.GroupAccounts join account  in testEntities.Acccounts on groupaccount.AccountId equals account.Id
                         where account.FirstName.Contains(s) || account.LastName.Contains(s) 
                         select account);
            List<Acccount> acccounts = new List<Acccount>();
            foreach (var item in query)
                acccounts.Add(item);
            return acccounts;
        }

    }
}