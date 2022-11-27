using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaigaAutotests.Driver;

namespace TaigaAutotests.PageElement
{
    public class WebElementCollection
    {
        private readonly Browser Driver = Browser.GetInstance();
        private readonly string XPath;
        private readonly bool isHidden;
        private List<IWebElement>? _baseCollection;

        public WebElementCollection(string xpath, bool isHidden)
        {
            XPath = xpath;
            this.isHidden = isHidden;
        }

        public List<WebElement> ConvertToListCollection()
        {
            CheckCondition();
            List<WebElement> newCollection = new();
            foreach (IWebElement element in _baseCollection)
            {
                WebElement newElement = new(false, XPath);
                newElement.SetElement(element);
                newCollection.Add(newElement);
            }
            return newCollection;
        }
        private void CheckCondition()
        {
            int _timeoutInSec = 10;
            if (isHidden)
            {
                _baseCollection = Driver.FindHiddenElements(XPath, _timeoutInSec);
                return;
            }
            _baseCollection = Driver.FindElements(XPath, _timeoutInSec);
        }
    }
}
