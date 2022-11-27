using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaigaAutotests.PageElement;

namespace TaigaAutotests.Pages.Tree.Discover
{
    public class Login : PageBase
    {
        public WebElement UserName = new(isHidden: false, xpath: "//input[@autofocus]");
        public WebElement Password = new(isHidden: false, xpath: "//input[@name='password']");
        public WebElement LogInButton = new(isHidden: false, xpath: "//button[@title='Login']");
    }
}
