using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaigaAutotests.Controllers;
using TaigaAutotests.Helpers;
using TaigaAutotests.TestData.DTOs;

namespace TaigaAutotests.Tests
{
    [TestClass]
    public class API
    {
        [TestMethod]
        public void Login()
        {
            User user = new TestDataReader().GetTestUser();
            SoftAssertions softAssertions = new();
            AuthRequest request = new()
            {
                Username = user.UserName,
                Password = user.Password,
                Type = "normal"
            };

            RestResponse response = new Auth().Login(request);
            softAssertions.AddTrue("checkResponse status", response.StatusCode == System.Net.HttpStatusCode.OK);
            AuthResponse? authResponse = JsonConvert.DeserializeObject<AuthResponse>(response.Content);
            softAssertions.AddTrue("check response name", authResponse.Email == user.UserName);
            softAssertions.AddTrue("check full name", authResponse.FullName == "automationTestUser");
            softAssertions.AssertAll();
        }
    }
}
