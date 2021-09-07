using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V85.Page;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UnitTestProjectEK
{
    [TestFixture]
    public class LinksCheckNew

    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void ShowAllWindow(IList<string> AllWindows)
        {
            int count = AllWindows.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Окно "+i+" // "+AllWindows[i]);
            }
        }

        public string FindNewWindow(IList<string> newWindows, IList<string> oldWindows)
        {
            string newWindow = "";
            string oldWindow = "";
            int oldCount = oldWindows.Count;
            for (int i = 0; i < oldCount + 1; i++)
            {
                if (newWindows.ElementAt(i) == oldWindows.ElementAt(0))
                {
                    oldWindow = newWindows.ElementAt(i);
                    i++;
                }
                else
                {
                    newWindow = newWindows.ElementAt(i);
                }

            }
            return newWindow;
        }

        [Test]
        public void CheckAllLinks()
        {
            driver.Url = "http://localhost:8080/litecart/admin/";
            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");
            driver.FindElement(By.Name("login")).Click();
           
            driver.Url = "http://localhost:8080/litecart/admin/?app=countries&doc=edit_country&country_code=AF";
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class='fa fa-external-link']")));
            IList<IWebElement> links = driver.FindElements(By.CssSelector("[class='fa fa-external-link']"));
            int linksCount = links.Count;
            Console.WriteLine("Всего ссылок: "+linksCount);

            IList<string> newWindows = driver.WindowHandles;
            ShowAllWindow(newWindows);

            string originalWindow = driver.CurrentWindowHandle;
            Console.WriteLine("Original Window is "+originalWindow);

            IList<string> existingWindows = driver.WindowHandles;
            int oldCount = existingWindows.Count;

            for (int i = 0; i < linksCount; i++)
            {
                wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class='fa fa-external-link']")));
                IList<IWebElement> links2 = driver.FindElements(By.CssSelector("[class='fa fa-external-link']"));
                links2[i].Click();

                IList<string> existingWindowss = driver.WindowHandles;
                ShowAllWindow(existingWindowss);

                wait.Until(driver => driver.WindowHandles.Count == (oldCount + 1));

                driver.SwitchTo().Window(driver.WindowHandles.Last());
                driver.Close();
                driver.SwitchTo().Window(originalWindow);
            }
           
        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
            driver = null;
        }


    }
}
