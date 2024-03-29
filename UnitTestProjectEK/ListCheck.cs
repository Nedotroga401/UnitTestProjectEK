﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UnitTestProjectEK
{/*
    [TestFixture]
    public class ListCheck

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
        public void AllButtonsClick()
        {
           
            driver.Url = "http://localhost:8080/litecart/admin/";
            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");
            driver.FindElement(By.Name("login")).Click();
            IList<IWebElement> allButtons = driver.FindElements(By.Id("app-"));
            int count = allButtons.Count;
            
            for (int i = 0; i < count; i++)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.Id("app-")));
                IList<IWebElement> allButtonss = driver.FindElements(By.Id("app-"));
                

                if (allButtonss[i] != null && allButtonss[i].Displayed && allButtonss[i].Enabled)
                    allButtonss[i].Click();

                IList<IWebElement> allButtonsss = driver.FindElements(By.Id("app-"));
                IList<IWebElement> inlist = allButtonsss[i].FindElements(By.CssSelector("[id^=doc]"));
                int incount = inlist.Count;

                if (driver.FindElement(By.TagName("h1"))!= null)
                {
                    Console.WriteLine("Заголовок есть");
                }
                else
                {
                    Console.WriteLine("Заголовка нет");
                }

                for (int j = 0; j < incount; j++)
                {
                   
                    IWebElement allButtonCheck = driver.FindElement(By.CssSelector("[class=docs]"));
                    IList<IWebElement> inlist2 = allButtonCheck.FindElements(By.CssSelector("[id^=doc]"));
                    if (inlist2[j]!=null&&inlist2[j].Displayed&&inlist2[j].Enabled)
                    inlist2[j].Click();

                    if (driver.FindElement(By.TagName("h1")) != null)
                    {
                        Console.WriteLine("Заголовок есть");
                    }
                    else
                    {
                        Console.WriteLine("Заголовка нет");
                    }
                }
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
