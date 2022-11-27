using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TaigaAutotests.PageElement;

namespace TaigaAutotests.Pages
{
    public class Main: PageBase
    {
        public WebElement LogIn = new(isHidden: false, xpath: "//div[contains(text(), 'Log in')]/..");
    }
}
