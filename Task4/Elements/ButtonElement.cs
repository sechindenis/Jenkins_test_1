using Task4.Models;

namespace Task4.Elements
{
    public class ButtonElement : BaseElement
    {
        public ButtonElement(By locator) : base(locator)
        {
        }

        public ButtonElement(IWebElement element) : base(element)
        {
        }

        // to check
        public void Click()
        {
            GetElement().Click();
        }

        // to check
        public string GetLink()
        {
            return GetElement().GetAttribute("href");
        }
    }
}