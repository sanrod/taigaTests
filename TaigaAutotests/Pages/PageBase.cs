using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaigaAutotests.Driver;

namespace TaigaAutotests.Pages
{
    public abstract class PageBase
    {
        protected Browser _driver = Browser.GetInstance();
        protected string Url { get; set; }
        public void Open()
        {
            _driver.GoToUrl(Url);
        }

        public void SetUrl(string url)
        {
            Url = url;
        }

        public String GetUrl()
        {
            return Url;
        }

        public void Refresh()
        {
            _driver.Refresh();
        }
    }
}
