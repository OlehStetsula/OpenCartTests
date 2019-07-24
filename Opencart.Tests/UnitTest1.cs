﻿using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.IO;
using System.Reflection;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void LogIn()
        {
            IWebDriver mydriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            IWebDriver FFdriver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            FFdriver.Quit();
            mydriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            mydriver.Navigate().GoToUrl(@"http://192.168.17.128/opencart/upload/");
            mydriver.Manage().Window.Maximize();
            mydriver.FindElement(By.XPath("//span[contains(text(),'My Account')]")).Click();
            mydriver.FindElement(By.XPath("//a[contains(text(),'Login')]")).Click();
            mydriver.FindElement(By.Id("input-email")).SendKeys("johnsmith@gmail.com");
            mydriver.FindElement(By.Id("input-password")).SendKeys("12121212" + Keys.Enter);
            

        }

       
    }
}