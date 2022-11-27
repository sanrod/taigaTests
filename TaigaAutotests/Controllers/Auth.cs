using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaigaAutotests.TestData.DTOs;

namespace TaigaAutotests.Controllers
{
    public class Auth
    {
        private RestClient Client { get; set; }
        public Auth()
        {
            Client = new("https://api.taiga.io");
        }

        public RestResponse Login(AuthRequest body)
        {
            RestRequest request = new()
            {
                Method = Method.Post,
                Resource = "api/v1/auth"
            };
            request.AddBody(body);
            return Client.Execute(request);
        }
    }
}
