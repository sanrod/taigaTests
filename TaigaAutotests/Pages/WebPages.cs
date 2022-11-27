using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaigaAutotests.Pages.Tree;
using TaigaAutotests.Pages.Tree.Discover;
using TaigaAutotests.Pages.Tree.Profile;

namespace TaigaAutotests.Pages
{
    public class WebPages
    {
        public Main MainTaiga
        {
            get
            {
                Main page = new();
                page.SetUrl("https://www.taiga.io/");
                return page;
            }
        }

        public Discover Discover
        {
            get
            {
                Discover discover = new();
                discover.SetUrl("https://tree.taiga.io/discover");
                return discover;
            }
        }

        public Login Login
        {
            get
            {
                Login login = new();
                login.SetUrl("https://tree.taiga.io/login?next=%252Fdiscover");
                return login;
            }
        }

        public Profile Profile
        {
            get
            {
                Profile profile = new();
                profile.SetUrl("https://tree.taiga.io/profile");
                return profile;
            }
        }

        public TaigaAutotests.Pages.Tree.Main Main
        {
            get
            {
                TaigaAutotests.Pages.Tree.Main page = new();
                page.SetUrl("https://tree.taiga.io/");
                return page;
            }
        }
    }
}
