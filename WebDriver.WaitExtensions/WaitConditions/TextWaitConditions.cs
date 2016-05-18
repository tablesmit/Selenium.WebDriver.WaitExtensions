using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebDriver.WaitExtensions.WaitConditions
{
    public class TextWaitConditions : WaitConditionsBase, ITextWaitConditions
    {
        private readonly IWebElement _webelement;

        public TextWaitConditions(IWebElement webelement, int waitMs) : base(waitMs)
        {
            _webelement = webelement;
        }

        public bool ToEqual(string text)
        {
            return WaitFor(() => _webelement.Text == text);
        }
        public bool ToNotEqual(string text)
        {
            return WaitFor(() => _webelement.Text != text);
        }
        public bool ToContain(string text)
        {
            return WaitFor(() => _webelement.Text.Contains(text));
        }
        public bool ToNotContain(string text)
        {
            return WaitFor(() => !_webelement.Text.Contains(text));
        }

    }
}