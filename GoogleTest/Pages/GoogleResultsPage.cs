using OpenQA.Selenium;
using System.Collections.Generic;

namespace GoogleTest.Pages
{
    public class GoogleResultsPage : BasePage
    {
        private IWebDriver driver;
        public override string Url { get; } = "";
        public override string Name { get; } = "Google Search";
        public string NextButtonXPath { get; } = "//div[@id='navcnt']//a[@class='pn']";
        public string SearchResultXPath { get; } = "//div[@class=\"g\"]//cite[@class=\"iUh30\"]";

        public GoogleResultsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public List<string> GetResultsHyperlinks()
        {
            var links = new List<string>();
            var result = driver.FindElements(By.XPath(SearchResultXPath));

            foreach (var i in result)
            {
                links.Add(i.Text);
            }
            return links;
        }
    }
}
