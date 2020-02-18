using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace VideolySeleniumTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:44350/Customers/Customers");
            IWebElement customer = driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr[1]/td[1]/a"));
        }
    }
}
