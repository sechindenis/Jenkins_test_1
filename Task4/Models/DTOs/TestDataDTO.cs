namespace Task4.Models.DTOs
{
    // поудалять лишние поля отсюда и из TestData
    [JsonObject]
    public class TestDataDTO
    {
        public string Url { get; set; }

        public int NumberOfTopPlayedGames { get; set; }
    }
}