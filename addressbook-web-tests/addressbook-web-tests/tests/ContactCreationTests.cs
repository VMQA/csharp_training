﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {

        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("Bob");
            contact.Lastname = "Smith";
            app.Contacts.Create(contact);
            app.Navigator.Logout();
        }
    }
}

//In Main bracnh - Задание №6: Реализовать двухуровневую архитектуру тестов + Лекция 2.5. Делаем новый тест без рекордера

