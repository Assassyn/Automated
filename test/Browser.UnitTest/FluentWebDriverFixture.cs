namespace Browser.UnitTest
{
    using Automated.Test.Browser;
    using OpenQA.Selenium;
    using Xunit;

    public sealed class FluentWebDriverFixture
    {
        private readonly WebDriverFactory factory;

        public FluentWebDriverFixture() => this.factory = new WebDriverFactory();

        [Fact]
        public void CanAccessGoogle()
        {
            var driver = this.factory.GetDriver("http://google.com");

            driver
                .FindElement(By.Id("lst-ib"));
            //.Assert(Is.HtmlInput);
        }
    }
}