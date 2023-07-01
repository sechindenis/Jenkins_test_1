namespace Task4.Elements
{
    // изменить название класса!!!!!!!!!!!!!!!!!!!!!!!!!
    public class TextElement : BaseElement
    {
        public TextElement(By locator) : base(locator)
        {
        }

        public TextElement(IWebElement element) : base(element)
        {            
        }

        public string GetText()
        {
            return GetElement().Text;
        }
    }
}