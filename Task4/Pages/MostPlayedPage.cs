using Task4.Elements;
using Task4.Forms;
using Task4.Models;

namespace Task4.Pages
{
    public class MostPlayedPage
    {
        private const string currentPlayersNumberElementsXPath = "//*[contains(@class, 'weeklytopsellers_ConcurrentCell')]";
        //private const int _numberOfTopPlayedGames = 100;

        // перенести при необходимости в Form-классы
        private ButtonElement _mostPlayedGameElement = new ButtonElement(By.XPath($"{currentPlayersNumberElementsXPath}"));

        public MostPlayedPage()
        {

        }

        public bool IsDisplayed()
        {
            return _mostPlayedGameElement.IsDisplayed();
        }

        public LinkedList<TextElement> GetCurrentPlayersNumberTextElements()
        {
            var wait = new WebDriverWait(Browser.GetDriver(), TimeSpan.FromSeconds(ConfigData.Timeout));
            var collectionOfIWebElements = wait.Until(e => Browser.GetDriver().FindElements(By.XPath($"{currentPlayersNumberElementsXPath}")));
            var listOfTextElements = new LinkedList<TextElement>();

            foreach (var element in collectionOfIWebElements)
            {
                listOfTextElements.AddLast(new TextElement(element));
            }

            return listOfTextElements;
        }
    }
}