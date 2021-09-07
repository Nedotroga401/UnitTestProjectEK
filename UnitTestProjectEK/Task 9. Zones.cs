using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UnitTestProjectEK
{/*
   [TestFixture]
    public class CheckZones

    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void CheckForList(string[] ListS, int s)
        {
            string[] list_after = new string[s];
            for (int j = 0; j < s; j++)
            {
                list_after[j] = ListS[j];
            }

            Array.Sort(list_after);

            bool flag = true;
            for (int l = 0; l < s; l++)
            {
                if (list_after[l] != ListS[l]) flag = false;

            }

            if (flag)
            {
                Console.WriteLine("Расположены в алфавитном порядке");
            }
            else
            {
                Console.WriteLine("Расположены не в алфавитном порядке");
            }
        }

        [Test]
        public void CheckCountriesList()
        {
            driver.Url = "http://localhost:8080/litecart/admin/";
            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");
            driver.FindElement(By.Name("login")).Click();
            driver.Url = "http://localhost:8080/litecart/admin/?app=geo_zones&doc=geo_zones";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            IWebElement table = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=dataTable]")));
            IList<IWebElement> allCountries = driver.FindElements(By.CssSelector("[class=row]"));
            int size = allCountries.Count;
            string[] countries = new string[size];
            int[] zones = new int[size];

            for (int i=0; i < size; i++)
            {
                countries[i] = allCountries[i].FindElement(By.CssSelector("[href]")).GetAttribute("value");
            }

            allCountries[0].FindElement(By.CssSelector("[href]")).Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("table-zones")));
            
            IList<IWebElement> allZones = driver.FindElements(By.CssSelector("[name$='[zone_code]']"));
            int s = allZones.Count;
            Console.WriteLine("В этой стране есть"+s+" зон(ы)");
            string[] zoness = new string[s];

            for (int k = 0; k < s; k++)
            {
                SelectElement Select = new SelectElement(allZones[k]);
                zoness[k] = Select.SelectedOption.GetAttribute("text");
            }

            CheckForList(zoness, s);

            //Chech for USA

            driver.Url = "http://localhost:8080/litecart/admin/?app=geo_zones&doc=geo_zones";

            IWebElement table2 = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=dataTable]")));
            IList<IWebElement> allCountries2 = driver.FindElements(By.CssSelector("[class=row]"));
            int size2 = allCountries2.Count;
            string[] countries2 = new string[size2];
            int[] zones2 = new int[size2];

            for (int j = 0; j < size2; j++)
            {
                countries2[j] = allCountries2[j].FindElement(By.CssSelector("[href]")).GetAttribute("value");
            }

            allCountries2[1].FindElement(By.CssSelector("[href]")).Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("table-zones")));

            IList<IWebElement> allZones2 = driver.FindElements(By.CssSelector("[name$='[zone_code]']"));
            int s2 = allZones2.Count;
            Console.WriteLine("В этой стране есть" + s2 + " зон(ы)");
            string[] zoness2 = new string[s2];

            for (int l = 0; l < s2; l++)
            {
                SelectElement Select = new SelectElement(allZones2[l]);
                zoness2[l] = Select.SelectedOption.GetAttribute("text");
                
            }
        
            CheckForList(zoness2, s2);

        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
            driver = null;
        }


    }*/
}
