namespace Automated.Test.Browser
{
    using System.Collections.Generic;
    using System.Linq;
    using OpenQA.Selenium;

    public sealed class Element
    {
        private readonly FluentWebDriver driver;
        private readonly IWebElement element;

        public Element(FluentWebDriver driver, IWebElement element)
        {
            this.driver = driver;
            this.element = element;
        }
    }

    /// <summary>
    /// Fluent wrapper for Selenium webdriver
    /// </summary>
    public sealed class FluentWebDriver
    {
        private readonly IWebDriver driver;

        internal FluentWebDriver(IWebDriver driver) => this.driver = driver;

        public Element FindElement(By bySelector, string locator)
        {
            var element = this.driver.FindElement(bySelector);

            return new Element(element);
        }

        public IEnumerable<Element> FindElements(By bySelector, string locator)
        {
            var elements = this.driver.FindElements(bySelector);

            return elements.Select(element => new Element(element));
        }
    }
}