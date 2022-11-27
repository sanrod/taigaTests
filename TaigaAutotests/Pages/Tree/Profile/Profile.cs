using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaigaAutotests.PageElement;

namespace TaigaAutotests.Pages.Tree.Profile
{
    public class Profile: PageBase
    {
        public WebElement UserName = new(isHidden: false, "//a[contains(@tg-nav, 'username') and not(@title)]");
        public WebElement Status = new(isHidden: false, "//a[contains(@tg-nav, 'username') and not(@title)]/../span");
    }
}
