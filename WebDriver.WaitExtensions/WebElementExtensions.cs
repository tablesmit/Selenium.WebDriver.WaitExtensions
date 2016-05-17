using OpenQA.Selenium;

namespace WebDriver.WaitExtensions
{
    public static class WebElementExtensions
    {
        public static IElementWaitTypeSelection Wait(this IWebElement webelement , int ms = 500)
        {
            return new ElementWaitTypeSelection(webelement, ms);
        }

    }
}