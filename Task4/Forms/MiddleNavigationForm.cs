using Task4.Elements;

namespace Task4.Forms
{
    public class MiddleNavigationForm : BaseForm
    {
        private const string newAndNoteworthyLocator = "//div[contains(@class, 'flyout_tab') and contains(@id, 'noteworthy_tab')]";

        private ButtonElement _newAndNoteworthy = new ButtonElement(By.XPath($"{newAndNoteworthyLocator}"));
        private NewAndNoteworthyFlyoutTabForm _newAndNoteworthyFlyoutTabForm = new NewAndNoteworthyFlyoutTabForm();

        public MiddleNavigationForm()
        {
        }

        public MiddleNavigationForm(BaseElement element) : base(element)
        {
        }

        public void MouseHoverTabAndClickMostPlayed()
        {
            MouseHoverNewAndNoteworthy();
            _newAndNoteworthyFlyoutTabForm.ClickMostPlayed();
        }

        private void MouseHoverNewAndNoteworthy()
        {
            new Actions(Browser.GetDriver())
                .MoveToElement(_newAndNoteworthy.GetElement())
                .Perform();
        }
    }
}