using Task4.Elements;
using Task4.Forms;

namespace Task4.Pages
{
    public class MainPage
    {
        // изменить элемент для проверки открытия страницы, если в этом есть смысл
        private ButtonElement _mainPageLogo = new ButtonElement(By.XPath("//div[contains(@class, 'logo')]/*[contains(@id, 'logo_holder')]"));
        private MiddleNavigationForm _middleNavigationForm = new MiddleNavigationForm();

        public MainPage()
        {

        }

        public bool IsDisplayed()
        {
            return _mainPageLogo.IsDisplayed();
        }

        public void MouseHoverTabAndClickMostPlayed()
        {
            _middleNavigationForm.MouseHoverTabAndClickMostPlayed();
        }
    }
}