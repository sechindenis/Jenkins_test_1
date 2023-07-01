using Task4.Elements;

namespace Task4.Forms
{
    public abstract class BaseForm
    {
        private BaseElement _element;

        public BaseForm()
        {
        }

        // to change
        public BaseForm(BaseElement element)
        {
            _element = element;
        }

        // название изменено с IsPageOpen на IsFormDisplayed
        public bool IsFormDisplayed()
        {
            // to check
            return _element.IsDisplayed();
        }
    }
}