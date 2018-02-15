using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LetsStartTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ClickElelemntById()
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.qtptutorial.net/automation-practice/");

            var elementById = driver.FindElement(By.Id("idExample"));

            elementById.Click();

            var header = driver.FindElement(By.CssSelector("h1.main_title"));

            string headerText = header.Text.ToString();

            string successText = "Button success";

            Assert.AreEqual(headerText, successText );

            driver.Close();
        }

        [TestMethod]
        public void ClickElementByClass()
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.qtptutorial.net/automation-practice/");

            var elementByClass = driver.FindElement(By.ClassName("buttonClassExample"));

            elementByClass.Click();

            var header = driver.FindElement(By.CssSelector("h1.main_title"));

            string headerText = header.Text.ToString();

            string successText = "Button success";

            Assert.AreEqual(headerText, successText);

            driver.Close();
        }

        [TestMethod]
        public void ClickElementByName()
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.qtptutorial.net/automation-practice/");

            var elementByName = driver.FindElement(By.Name("NameExample"));

            elementByName.Click();

            var header = driver.FindElement(By.CssSelector("h1.main_title"));

            string headerText = header.Text.ToString();

            string successText = "Button success";

            Assert.AreEqual(headerText, successText);

            driver.Close();
        }

        [TestMethod]
        public void ClickElementsAndExit()
        {
            var driver = new ChromeDriver();

            string successText = "Button success";

            driver.Navigate().GoToUrl("https://www.qtptutorial.net/automation-practice/");

            var elementById = driver.FindElement(By.Id("idExample"));

            elementById.Click();

            var header = driver.FindElement(By.CssSelector("h1.main_title"));

            Assert.IsTrue( header.Text.ToString().Equals(successText) );

            driver.Navigate().Back();

            var elementByClass = driver.FindElement(By.ClassName("buttonClassExample"));

            elementByClass.Click();

            header = driver.FindElement(By.CssSelector("h1.main_title"));

            Assert.IsTrue(header.Text.ToString().Equals(successText));

            driver.Navigate().Back();

            var elementByName = driver.FindElement(By.Name("NameExample"));

            elementByName.Click();

            header = driver.FindElement(By.CssSelector("h1.main_title"));

            Assert.IsTrue(header.Text.ToString().Equals(successText));

            driver.Close();
        }
    }
}
