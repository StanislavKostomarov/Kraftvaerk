using OpenQA.Selenium;

namespace GoogleTest.Pages
{
    public class GoogleMainPage : BasePage
    {
        public override string Url { get; } = "https://www.google.com";
        public override string Name { get; } = "Google";
        private IWebDriver driver;

        public GoogleMainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Open()
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void Search(string searchedString)
        {
            var searchTextbox = driver.FindElement(By.Name("q"));
            searchTextbox.SendKeys(searchedString);
            searchTextbox.Submit();
        }
    }
}
