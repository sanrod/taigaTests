using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaigaAutotests.PageElement;

namespace TaigaAutotests.Pages.Tree.Discover
{
    public class Discover : PageBase
    {
        public WebElement LogIn = new(isHidden: false, "//a[@title='Login']");
    }
}
