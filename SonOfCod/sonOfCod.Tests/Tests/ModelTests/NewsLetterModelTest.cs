using Microsoft.AspNetCore.Mvc;
using sonOfCod.Controllers;
using sonOfCod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace sonOfCod.Tests.Tests.ModelTests
{

    public class NewsLetterModelTest
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        [Fact]
        public void Saves_to_Db_Newsletter_Test()
        {
            MailingList maillist = new MailingList() { };
            maillist.CustomerEmail = "email";
            maillist.CustomerFirstName = "first";
            maillist.CustomerLastName = "last";

            db.MailingLists.Add(maillist);
            db.SaveChanges();

            MailingList foundlist = db.MailingLists.FirstOrDefault(x => x.CustomerFirstName == "first");

            Assert.Equal(maillist.CustomerFirstName, foundlist.CustomerFirstName);

            db.MailingLists.Remove(maillist);
            db.SaveChanges();

        }
    }
}
