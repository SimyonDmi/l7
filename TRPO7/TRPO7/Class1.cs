using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TRPO7
{
    [TestFixture]
    public class Class1
    {
        IWebDriver webDriver = new ChromeDriver();

        [TestCase]
        public void mainTitle()
        {
            webDriver.Url = "https://sibsutis.ru/";
            Assert.AreEqual("Сибирский государственный университет телекоммуникаций и информатики", webDriver.Title);

            webDriver.Close();
        }

        [TearDown]
        public void testEnd()
        {
            webDriver.Quit();
        }

        [TestCase]
        public void vidimost()
        {
            webDriver.Url = "https://sibsutis.ru/";
            IWebElement element = webDriver.FindElement(By.XPath("//*[@id=\"qqq\"]"));
            //element.Click();
            bool status = element.Displayed;

            Assert.AreEqual(status, true);
            //Assert.IsTrue(status);

            webDriver.Close();
        }

        [TearDown]
        public void vidEnd()
        {
            webDriver.Quit();
        }

        [TestCase]
        public void perposil()
        {
            webDriver.Url = "https://sibsutis.ru/";
            IWebElement element = webDriver.FindElement(By.XPath("//*[@id=\"mainMenu\"]/a[5]"));

            element.Click();

           // Assert.AreEqual(stat, true);
            //Assert.IsTrue(status);

            webDriver.Close();
        }

        [TearDown]
        public void silEnd()
        {
            webDriver.Quit();
        }

        [TestCase]
        public void vodtext()
        {
            webDriver.Url = "https://sibsutis.ru/";

            IWebElement element = webDriver.FindElement(By.XPath("//*[@id=\"qqq\"]"));
            element.SendKeys("какой-то текст");

            IWebElement elemen = webDriver.FindElement(By.XPath("//*[@id=\"layout\"]/div[2]/div[2]/div[2]/div[3]/form/input[2]"));

            elemen.Click();

            webDriver.Close();
        }

        [TearDown]
        public void vodEnd()
        {
            webDriver.Quit();
        }

    }
}
