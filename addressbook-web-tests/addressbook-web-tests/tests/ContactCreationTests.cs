using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
       

        [Test]
        public void ContactCreationTest()
        {
            OpenHomePage();
            Login(new AccountData ("admin", "secret"));
            GoToAddNewPage();
            ContactData contact = new ContactData("Bob");
            contact.Lastname = "Smith";
            FillContactForm(contact);
            SubmitContactCreation();
            ReturnToHomePage();
            Logout();
        }
    }
}