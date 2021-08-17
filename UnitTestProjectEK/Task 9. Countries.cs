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

        [Test]
        public void CheckCountriesList()
        {
            driver.Url = "http://localhost:8080/litecart/admin/";
            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");
            driver.FindElement(By.Name("login")).Click();
            driver.Url = "http://localhost:8080/litecart/admin/?app=countries&doc=countries";

            
           IList<IWebElement> allCountries = driver.FindElements(By.CssSelector("[class=row]"));
           int size = allCountries.Count;
           string[] countries = new string[size];
           int[] zones = new int[size];

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            for (int i=0; i < size; i++)
            {
                IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=row]")));
                IWebElement value = allCountries[i].FindElement(By.CssSelector("[href]"));
                countries[i] = value.Text.ToString();
             }

            string[] countries_before = new string[size];
            for (int j = 0; j < size; j++)
            {
                countries_before[j] = countries[j];
            }

            Array.Sort(countries);
          
            bool flag = true;
            for (int l = 0; l < size; l++)
            {
                if (countries_before[l] != countries[l]) flag = false;

            }

            if (flag)
            {
                Console.WriteLine("Страны расположены в алфавитном порядке");
            }
            else
            {
                Console.WriteLine("Страны расположены не в алфавитном порядке");
            }

            allCountries[37].Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[class=header]")));
            IList<IWebElement> allZones = driver.FindElements(By.CssSelector("[name$='[name]']"));
            int s = allZones.Count;
            string[] zoness = new string[size];

            for (int k = 0; k < s; k++)
            {
                zoness[k] = allZones[k].GetAttribute("value").ToString();
                Console.WriteLine(zoness[k]);
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
