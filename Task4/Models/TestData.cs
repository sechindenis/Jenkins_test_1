using Task4.Models.DTOs;

namespace Task4.Models
{
    // уточнить после проверки, что оставить - статику или не статику
    // если статику, то почему не сделать все поля readonly?
    // поудалять лишние поля отсюда и из TestDataDTO
    // также поудалять из TestData.json лишнее
    public static class TestData
    {
        private const string testDataPath = "TestData.json";

        private static TestDataDTO _testData = FileReaderUtils.GetData<TestDataDTO>(testDataPath);

        static TestData()
        {
            Url = _testData.Url;
            NumberOfTopPlayedGames = _testData.NumberOfTopPlayedGames;
        }

        public static string Url { get; set; }

        public static List<string> Languages { get; set; }

        public static string YearOfSigning { get; set; }

        public static int NumberOfTopPlayedGames { get; set; }
    }
}