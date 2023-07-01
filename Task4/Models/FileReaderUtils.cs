namespace Task4.Models
{
    public class FileReaderUtils
    {
        public static T GetData<T>(string dataPath) where T : new()
        {
            var serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            T data = new();

            using (var sw = new StreamReader(dataPath))
            using (var reader = new JsonTextReader(sw))
            {
                data = serializer.Deserialize<T>(reader);
            }

            return data;
        }
    }
}