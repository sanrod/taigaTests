using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaigaAutotests.TestData.DTOs;

namespace TaigaAutotests.Helpers
{
    public class TestDataReader
    {
        public User GetTestUser()
        {
            string path = PathFinder.GetRootDirectory();
            using StreamReader r = new($"{path}/TestData/TestData.json");
            string json = r.ReadToEnd();
            return JsonConvert.DeserializeObject<User>(json);
        }
    }
}
