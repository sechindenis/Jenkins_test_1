using Task4.Models;
using Task4.Pages;
using Task4.Elements;
using Task4.Forms;

namespace Task4
{
    public class Tests
    {
        // пернести в TestData.json
        private const int firstComparingTopGameNumber = 1;
        private const int secondComparingTopGameNumber = 2;
        private const int thirdComparingTopGameNumber = 3;

        [SetUp]
        public void Setup()
        {
            // написать хоть что-то
        }

        // name is to change
        [Test]
        public void Test()
        {
            Browser.GetDriver().Navigate().GoToUrl(TestData.Url);

            var mainPage = new MainPage();

            Assert.That(mainPage.IsDisplayed(), Is.True, "Main Page is not displayed");
            
            // уточнить про методы (вопрос есть в списке вопросов к 04.07.2023)
            //mainPage.MouseHoverNewAndNoteworthy();
            //mainPage.ClickMostPlayed();

            mainPage.MouseHoverTabAndClickMostPlayed();

            var mostPlayedPage = new MostPlayedPage();

            Assert.That(mostPlayedPage.IsDisplayed(), Is.True, "Most Played page is not displayed");

            var currentPlayersNumberTextsCollection = mostPlayedPage.GetCurrentPlayersNumberTextElements();            
            var topCurrentPlayersNumbers = GetTopCurrentPlayersNumbers(TestData.NumberOfTopPlayedGames, currentPlayersNumberTextsCollection);

            Assert.That(topCurrentPlayersNumbers[firstComparingTopGameNumber - 1], 
                Is.GreaterThan(topCurrentPlayersNumbers[secondComparingTopGameNumber - 1]),
                "Top 1st game in the list has not more Current Players than 2nd");

            Assert.That(topCurrentPlayersNumbers[secondComparingTopGameNumber - 1], 
                Is.GreaterThan(topCurrentPlayersNumbers[thirdComparingTopGameNumber - 1]),
                "Top 2nd game in the list has not more Current Players than 3rd");
        }

        [TearDown]
        public void TearDown()
        {
            Browser.QuitDriver();
        }

        private List<int> GetTopCurrentPlayersNumbers(int topNumber, LinkedList<TextElement> currentPlayersNumberTextsCollection)
        {
            var topCurrentPlayersNumbers = new List<int>(topNumber);
            var i = 0;
            int currentPlayersNumber;

            while (i < topNumber)
            {
                var stringOfCurrentPlayersNumber = currentPlayersNumberTextsCollection.ElementAt(i).GetText().RemoveWhiteSpaces();

                if (int.TryParse(stringOfCurrentPlayersNumber, out currentPlayersNumber))
                {
                    topCurrentPlayersNumbers.Add(currentPlayersNumber);
                    i++;
                }
                else
                {
                    throw new Exception($"{stringOfCurrentPlayersNumber} is not a number");
                }
            }

            return topCurrentPlayersNumbers;
        }
    }
}