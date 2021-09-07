using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UnitTestProjectEK
{/*
    [TestFixture]
    public class LinksCheck

    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void SwitchAndBack(IWebElement button)
        {
           string originalWindow = driver.CurrentWindowHandle;
            Console.WriteLine(originalWindow);
            IList < string > existingWindows = driver.WindowHandles;
           int oldCount = existingWindows.Count;
           button.Click();
           wait.Until(driver => driver.WindowHandles.Count == (oldCount + 1));
            IList<string> newWindows = driver.WindowHandles;
            string newWindow = "";
            string oldWindow = "";
            for (int i = 0; i < oldCount + 1; i++)
            {
                if (newWindows.ElementAt(i) == existingWindows.ElementAt(0))
                {
                    oldWindow = newWindows.ElementAt(i);
                    i++;
                }
                else
                {
                    newWindow = newWindows.ElementAt(i);
                    Console.WriteLine(newWindow);
                }
            }

            driver.SwitchTo().Window(newWindow);
            driver.Close();
            wait.Until(driver => driver.WindowHandles.Count == (oldCount));
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            wait.Until(ExpectedConditions.UrlContains("country"));
            //driver.SwitchTo().Window(originalWindow);
        }

        [Test]
        public void CheckAllLinks()
        {
            driver.Url = "http://localhost:8080/litecart/admin/";
            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");
            driver.FindElement(By.Name("login")).Click();
            driver.Url = "http://localhost:8080/litecart/admin/?app=countries&doc=countries";
            driver.FindElement(By.CssSelector("[href$=country]")).Click();

            IList<IWebElement> links = driver.FindElements(By.CssSelector("[class='fa fa-external-link']"));
            int linksCount = links.Count;

            IList<string> newWindows = driver.WindowHandles;
            Console.WriteLine(newWindows);

            SwitchAndBack(links[0]);



            string originalWindow = driver.CurrentWindowHandle;
            Console.WriteLine(originalWindow);
            // IWebElement header= driver.FindElement(By.CssSelector("[class='fa-stack icon-wripper']"));
            // Console.WriteLine(header.Text);
            
            for (int i = 0; i < linksCount; i++)
            {
                
                //wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class='fa fa-external-link']")));
                IList<IWebElement> linksTemp = driver.FindElements(By.CssSelector("[class='fa fa-external-link']"));
                SwitchAndBack(linksTemp[i]);
            }
            




        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
            driver = null;
        }


    }*/
}
