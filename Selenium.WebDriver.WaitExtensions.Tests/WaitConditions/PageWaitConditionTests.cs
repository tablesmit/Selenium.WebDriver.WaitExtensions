using NUnit.Framework;
using OpenQA.Selenium;

namespace Selenium.WebDriver.WaitExtensions.Tests.WaitConditions
{
    [TestFixture]
    public class PageWaitConditionTests
    {
        private readonly IWebDriver Driver = MySetUpClass.Driver;

        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().Refresh();
        }

        [Test]
        public void ShouldWaitForPageTitleToEqual()
        {
            Driver.Wait(2500).ForPage().TitleToEqual("WebDriver.WaitExtensions Test Page");
        }

        [Test]
        public void ShouldWaitForDocumentReady()
        {
            Driver.Wait(2500).ForPage().ReadyStateComplete();
        }

        [Test]
        public void ShouldTimeoutWaitingForPageTitleToEqual()
        {
            Assert.Throws<WebDriverTimeoutException>( () => Driver.Wait(500).ForPage().TitleToEqual("Not the page title"));
        }

        [Test]
        public void ShouldWaitForPageTitleToContain()
        {
            Driver.Wait(2500).ForPage().TitleToContain("WaitExtensions");
        }

        [Test]
        public void ShouldTimeoutWaitingForPageTitleToContain()
        {
            Assert.Throws<WebDriverTimeoutException>(() => Driver.Wait(500).ForPage().TitleToContain("Not the page title"));
        }
        [Test]
        public void ShouldWaitForUrlToEqual()
        {
            var url =
                @"file:///C:/src/Selenium.WebDriver.WaitExtensions/Selenium.WebDriver.WaitExtensions.Tests/bin/debug/Test.html";

            Driver.Wait(2500).ForPage().UrlToEqual(url);
        }

        [Test]
        public void ShouldTimeoutWaitingForUrlToEqual()
        {
            Assert.Throws<WebDriverTimeoutException>(() => Driver.Wait(500).ForPage().UrlToEqual("Not the url"));
        }

        [Test]
        public void ShouldWaitForUrlToContain()
        {
            Driver.Wait(2500).ForPage().UrlToContain(@"Test.html");
        }


        [Test]
        public void ShouldTimeoutWaitingForUrlToContainl()
        {
            Assert.Throws<WebDriverTimeoutException>(() => Driver.Wait(500).ForPage().UrlToContain("Not the url"));
        }
        [Test]
        public void ShouldWaitForUrlToMatch()
        {
            Driver.Wait(2500).ForPage().UrlToMatch(@".*html");
        }

        [Test]
        public void ShouldTimeoutWaitingForUrlToMatch()
        {
            Assert.Throws<WebDriverTimeoutException>(() => Driver.Wait(500).ForPage().UrlToMatch("Not the url"));
        }

    }
}
