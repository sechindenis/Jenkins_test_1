using Task4.Elements;

namespace Task4.Forms
{
    public class NewAndNoteworthyFlyoutTabForm : BaseForm
    {
        private const string mostPlayedLink = "store.steampowered.com/charts/mostplayed/";

        private ButtonElement _mostPlayedButton = new ButtonElement(By.XPath($"//a[contains(@class, 'popup_menu_item') " +
                                                                             $"and contains(@href, '{mostPlayedLink}')]"));

        public NewAndNoteworthyFlyoutTabForm()
        {
        }

        public NewAndNoteworthyFlyoutTabForm(BaseElement element) : base(element)
        {
        }

        public void ClickMostPlayed()
        {
            _mostPlayedButton.Click();
        }
    }
}