namespace Task4.Elements
{
    // изменить название класса!!!!!!!!!!!!!!!!!!!!!!!!!
    public class TextFieldElement : BaseElement
    {
        public TextFieldElement(By locator) : base(locator)
        {
        }

        public TextFieldElement(IWebElement element) : base(element)
        {
        }

        // to check
        public void SendKeys(string text)
        {
            GetElement().SendKeys(text);
        }
    }
}