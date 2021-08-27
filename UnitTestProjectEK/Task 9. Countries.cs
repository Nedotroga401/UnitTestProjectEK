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
{
   [TestFixture]
    public class CheckCountries

    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void CheckSortForList(string[] ListS, int s)
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
            driver.Url = "http://localhost:8080/litecart/admin/?app=countries&doc=countries";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            //Check Countries list
            IList<IWebElement> allCountries = driver.FindElements(By.CssSelector("[class=row]"));
            int size = allCountries.Count;
            string[] countries = new string[size];
            int[] zones = new int[size];

            for (int i=0; i < size; i++)
            {
                IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=row]")));
                IWebElement value = allCountries[i].FindElement(By.CssSelector("[href]"));
                countries[i] = value.Text.ToString();
             }

            Console.WriteLine("Всего в списке " + size + " стран");
            CheckSortForList(countries, size);
            

            //Check Canada zones list
            
            allCountries[37].FindElement(By.CssSelector("[href]")).Click();
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=dataTable]")));
            IList<IWebElement> allZones = driver.FindElements(By.CssSelector("[name$='[name]']"));
            int s = allZones.Count;
            
            string[] zoness = new string[s];
            for (int k = 0; k < s; k++)
            {
                zoness[k] = allZones[k].GetAttribute("value").ToString();
            }

            int sc = s - 1;
            Console.WriteLine("В стране " + countries[37] +" есть " + sc + " зон(ы)");
            CheckSortForList(zoness, s);
            

            //Check USA zones list

            driver.Url = "http://localhost:8080/litecart/admin/?app=countries&doc=countries";
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=dataTable]")));
            IList<IWebElement> allCountries2 = driver.FindElements(By.CssSelector("[class=row]"));
            
            allCountries2[223].FindElement(By.CssSelector("[href]")).Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("table-zones")));
            
            IList<IWebElement> allZonesUS = driver.FindElements(By.CssSelector("[name$='[name]']"));
            int ss = allZonesUS.Count;
            
            string[] zonesUS = new string[ss];
            for (int m = 0; m < ss; m++)
            {
                zonesUS[m] = allZonesUS[m].GetAttribute("value").ToString();
                
            }
            int ssc = ss - 1;
            Console.WriteLine("В стране " + countries[223]+ " есть "+ssc + " зон(ы)");
            CheckSortForList(zonesUS, ss);
              
         
        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
            driver = null;
        }


    }
}
