using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaigaAutotests.Driver;

namespace TaigaAutotests.PageElement
{
    public class WebElement
    {
        private readonly Browser Browser = Browser.GetInstance();
        private bool IsHidden { get; set; }
        private string XPath { get; set; }
        private IWebElement? Element { get; set; }
        private bool ReloadObject = true;
        private int TimeoutInSec = 30;

        public WebElement(bool isHidden, string xpath)
        {
            IsHidden = isHidden;
            XPath = xpath;
        }

        public void SetElement(IWebElement element)
        {
            Element = element;
            ReloadObject = false;
        }

        public Boolean Exists(int timeoutInSec)
        {
            CheckCondition(timeoutInSec);
            return Element != null;
        }

        public void Click()
        {
            CheckCondition(TimeoutInSec);
            CheckNull();
            Element?.Click();
        }

        public void JClick()
        {
            CheckCondition(TimeoutInSec);
            CheckNull();
             
            Browser.ExecuteJs("");

        }
        private void CheckNull()
        {
            if (Element == null)
            {
                try
                {
                    throw new Exception($"Element with xpath = (%s) is not found");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }

        public String GetText()
        {
            CheckCondition(TimeoutInSec);
            CheckNull();
            return Element.Text;
        }

        public void SendKeys(String text)
        {
            CheckCondition(TimeoutInSec);
            CheckNull();
            Element.SendKeys(text);
        }

        private void CheckCondition(int timeoutInSec)
        {
            if (!ReloadObject)
            {
                return;
            }
            if (!IsHidden)
            {
                Element = Browser.FindElement(XPath, timeoutInSec);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
