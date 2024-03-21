using Microsoft.Testing.Platform.Extensions.TestHostControllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineShoePortal.Tests
{
    internal class TS05_Locators
    {
        // lauch a browser and navigate to the website under test
        [Test]
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://google.com");
            driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
            Thread.Sleep(2000);

            //// find the element by ID
            //IWebElement element = driver.FindElement(By.Id("login"));
            //Console.WriteLine("Element found by ID: " + element.Text);

            //// find the element by Name
            //element = driver.FindElement(By.Name("username"));
            //Console.WriteLine("Element found by Name: " + element.Text);

            //// find the element by Class Name
            //element = driver.FindElement(By.ClassName("login"));
            //Console.WriteLine("Element found by Class Name: " + element.Text);

            //// find the element by Tag Name
            //element = driver.FindElement(By.TagName("a"));
            //Console.WriteLine("Element found by Tag Name: " + element.Text);

            //// find the element by Link Text
            //element = driver.FindElement(By.LinkText("Login"));
            //Console.WriteLine("Element found by Link Text: " + element.Text);

            //// find the element by Partial Link Text
            //element = driver.FindElement(By.PartialLinkText("Log"));
            //Console.WriteLine("Element found by Partial Link Text: " + element.Text);

            //// find the element by CSS Selector
            //element = driver.FindElement(By.CssSelector("#login"));
            //Console.WriteLine("Element found by CSS Selector: " + element.Text);

            //// find the element by XPath
            //element = driver.FindElement(By.XPath("//*[@id='login']"));
            //Console.WriteLine("Element found by XPath: " + element.Text);

            driver.Quit();
        }

    }
}
