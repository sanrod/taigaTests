using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaigaAutotests.Driver;
using TaigaAutotests.Helpers;
using TaigaAutotests.Pages;
using TaigaAutotests.TestData.DTOs;

namespace TaigaAutotests.Tests
{
    [TestClass]
    public class UI: SuiteBase
    {
        [TestMethod]
        public void Login()
        {
            WebPages pages = new();
            User user = new TestDataReader().GetTestUser();
            SoftAssertions softAssertions = new();

            pages.MainTaiga.Open();
            pages.MainTaiga.LogIn.Click();
            Browser.GetInstance().SwitchToNewTab();
            pages.Discover.LogIn.Click();
            pages.Login.UserName.SendKeys(user.UserName);
            pages.Login.Password.SendKeys(user.Password);
            pages.Login.LogInButton.Click();
            pages.Main.Chevron.Click();
            pages.Main.Profile.Click();
            
            softAssertions.AddTrue("username check", pages.Profile.UserName.GetText() == "automationTestUser");
            softAssertions.AddTrue("status check", pages.Profile.Status.GetText() == "has joined Taiga");
            softAssertions.AssertAll();
        }
    }
}
