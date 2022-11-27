using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaigaAutotests.Helpers
{
    public static class PathFinder
    {
        public static string GetRootDirectory()
        {
            string dir = Directory.GetCurrentDirectory();
            Regex reg = new(".{0,}TaigaAutotests");
            return reg.Match(dir).Captures.First().Value;
        }
    }
}
