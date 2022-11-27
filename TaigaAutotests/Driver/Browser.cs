using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaigaAutotests.Helpers;

namespace TaigaAutotests.Driver
{
    public sealed class Browser
    {
        private readonly IWebDriver driver;
        private readonly string MainWindowHendler;
        private static Browser? Instance { get; set; }
        private Browser()
        {
            driver = StartChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().PageLoad = new TimeSpan(0, 0, 60);
            driver.Manage().Timeouts().AsynchronousJavaScript = new TimeSpan(0, 0, 60);
            MainWindowHendler = driver.CurrentWindowHandle;
        }
        private ChromeDriver StartChromeDriver()
        {
            string path = PathFinder.GetRootDirectory();
            System.Environment.SetEnvironmentVariable("webdriver.chrome._driver", $"{path}\\chromedriver.exe");
            ChromeOptions options = new();
            options.AddArgument("disable-extensions");
            options.AddArgument("--disable-notifications");
            options.AddArguments("ignore-certificate-errors", "ignore-urlfetcher-cert-requests", "allow-insecure-localhost");
            options.AddUserProfilePreference("download.default_directory", "downloads\\");
            options.AddUserProfilePreference("safebrowsing.enabled", "false");
            options.AddUserProfilePreference("acceptInsecureCerts", "true");
            return new ChromeDriver(options);
        }

        public static Browser GetInstance()
        {
            Instance ??= new Browser();
            return Instance;
        }

        public void SwitchToNewTab()
        {
            ReadOnlyCollection<string> handles = driver.WindowHandles;
            foreach (string handle in handles)
            {
                if (!handle.Equals(MainWindowHendler))
                {
                    driver.SwitchTo().Window(handle);
                    break;
                }
            }
        }

        public IWebElement? FindElement(string xpath, int timeoutInSec)
        {
            IWait<IWebDriver> fluentWait = new WebDriverWait(driver, new TimeSpan(0, 0, timeoutInSec))
            {
                PollingInterval = new TimeSpan(0, 0, 0, 0, 200)
            };
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement element;
            try
            {
                element = fluentWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(xpath)));
            }
            catch (Exception)
            {
                return null;
            }

            return element;
        }

        public List<IWebElement> FindElements(string xpath, int timeoutInSec)
        {
            IWait<IWebDriver> fluentWait = new WebDriverWait(driver, new TimeSpan(0, 0, timeoutInSec))
            {
                PollingInterval = new TimeSpan(0, 0, 0, 0, 200)
            };
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            return fluentWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(xpath))).ToList();
        }

        public List<IWebElement> FindHiddenElements(String xpath, int timeoutInSec)
        {
            IWait<IWebDriver> fluentWait = new WebDriverWait(driver, new TimeSpan(0, 0, timeoutInSec))
            {
                PollingInterval = new TimeSpan(0, 0, 0, 0, 200)
            };
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return fluentWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(xpath))).ToList();
        }

        public void Back()
        {
            driver.Navigate().Back();
        }

        public String GetUrl()
        {
            return driver.Url;
        }

        public void Refresh()
        {
            driver.Navigate().Refresh();
        }

        public void GoToUrl(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void StopDriver()
        {
            driver.Quit();
        }

        public void ExecuteJs(string script)
        {
            driver.ExecuteJavaScript(script);
        }
    }
}
