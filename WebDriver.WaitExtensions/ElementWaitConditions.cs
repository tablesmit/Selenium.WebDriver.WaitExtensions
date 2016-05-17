using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebDriver.WaitExtensions
{
    public class ElementWaitConditions : IElementWaitConditions
    {
        private readonly IWebDriver _webDriver;
        private readonly int _waitMs;
        private readonly By _by;

        public ElementWaitConditions(IWebDriver webDriver, int waitMs, By @by)
        {
            _webDriver = webDriver;
            _waitMs = waitMs;
            _by = @by;
        }

        public IWebElement ToExist()
        {
            new WebDriverWait(_webDriver, TimeSpan.FromMilliseconds(_waitMs))
                .Until(ExpectedConditions.ElementExists(_by));

            return _webDriver.FindElement(_by);
        }

        public void ToNotExist()
        {
            new WebDriverWait(_webDriver, TimeSpan.FromMilliseconds(_waitMs))
                .Until<bool>(ElementDoesntExists);
        }

        private bool ElementDoesntExists(IWebDriver driver)
        {
            try
            {
                driver.FindElement(_by);
                return false;
            }
            catch (NoSuchElementException nssex)
            {
                return true;
            }
        }
    }
}