using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaigaAutotests.Driver;

namespace TaigaAutotests.Tests
{
    [TestClass]
    public class SuiteBase
    {
        [TestInitialize]
        public void Setup()
        {
            Browser _ = Browser.GetInstance();
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.GetInstance().StopDriver();
        }

    }
}
