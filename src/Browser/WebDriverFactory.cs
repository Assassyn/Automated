namespace Automated.Test.Browser
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;

    public sealed class WebDriverFactory
    {
        public FluentWebDriver GetDriver(string url)
        {
            var driver = this.CreateDriver(AvailableDrivers.Firefox);
            driver.Url = url;

            return new FluentWebDriver(driver);
        }

        private IWebDriver CreateDriver(AvailableDrivers driver)
        {
            switch (driver)
            {
                case AvailableDrivers.Firefox:
                default:
                    return this.GetFirefoxDriver();
            }
        }

        private IWebDriver GetFirefoxDriver() => new FirefoxDriver();
    }
}