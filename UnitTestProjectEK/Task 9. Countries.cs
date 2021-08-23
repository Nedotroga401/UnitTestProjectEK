﻿using System;
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

            CheckSortForList(countries, size);

            allCountries[37].FindElement(By.CssSelector("[href]")).Click();
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=dataTable]")));
            IList<IWebElement> allZones = driver.FindElements(By.CssSelector("[name$='[name]']"));
            int s = allZones.Count;
            Console.WriteLine("В этой стране есть"+s+" зон(ы)");
            string[] zoness = new string[size];
            for (int k = 0; k < s; k++)
            {
                zoness[k] = allZones[k].GetAttribute("value").ToString();
            }

            

            CheckSortForList(zoness, s);

            driver.Url = "http://localhost:8080/litecart/admin/?app=countries&doc=countries";


            IList<IWebElement> allCountries2 = driver.FindElements(By.CssSelector("[class=row]"));
            int size2 = allCountries2.Count;
            string[] countries2 = new string[size];
            int[] zones2 = new int[size];
            

            for (int i = 0; i < size; i++)
            {
                IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=row]")));
                IWebElement value = allCountries2[i].FindElement(By.CssSelector("[href]"));
                countries2[i] = value.Text.ToString();
            }

            allCountries2[222].FindElement(By.CssSelector("[href]")).Click();
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=dataTable]")));
            IList<IWebElement> allZonesUS = driver.FindElements(By.CssSelector("[name$='[name]']"));
            int ss = allZonesUS.Count;
            Console.WriteLine("В этой стране есть" + ss + " зон(ы)");
            string[] zonesUS = new string[size];
            for (int m = 0; m < ss; m++)
            {
                zonesUS[m] = allZonesUS[m].GetAttribute("value").ToString();
                
            }

            

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
