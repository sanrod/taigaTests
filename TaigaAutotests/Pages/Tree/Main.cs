using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaigaAutotests.PageElement;

namespace TaigaAutotests.Pages.Tree
{
    public class Main: PageBase
    {
        public WebElement Chevron = new(isHidden: false, "//button[@class='chevron']");
        public WebElement Profile = new(isHidden: false, "//a[@class='profile-link avatar']");
    }
}
