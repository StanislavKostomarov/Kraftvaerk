using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using GoogleTest.Pages;
using System;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Collections.Generic;

namespace GoogleTest.Tests
{
    [TestFixture]
    public class GoogleSearchTests
    {
        private IWebDriver driver;
        private GoogleMainPage googleMainPage;
        private GoogleResultsPage googleResultsPage;
        private WebDriverWait wait;

        public GoogleSearchTests()
        {
        }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            googleMainPage = new GoogleMainPage(driver);
            googleResultsPage = new GoogleResultsPage(driver);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Test]
        [Category("Google")]
        [Category("Smoke")]
        public void CheckGoogleSearchFirstResult()
        {
            //preparation
            var word = "yandex.ru";

            //execution
            var results = FindResultsInGoogle(word);

            //check
            Assert.IsTrue(results.Count > 0, "Test exception: No elements in search results");
            Assert.IsTrue(results[0].Contains(word), "Test exception: The first result doesn't contain \"" + word + "\" in link: "+ results[0]);

            //additional check: to be sure that is not syandex.ru or something like that
            Assert.IsTrue((results[0] == "https://www.yandex.ru/") || (results[0] == "https://yandex.ru/"), "Result is not a yandex.ru page");
        }

        public List<string> FindResultsInGoogle(string word)
        {
            Assert.IsTrue(word.Length > 0, "Test exception: String is empty");
            googleMainPage.Open();
            googleMainPage.Search(word);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(googleResultsPage.NextButtonXPath)));
            return googleResultsPage.GetResultsHyperlinks();
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}


