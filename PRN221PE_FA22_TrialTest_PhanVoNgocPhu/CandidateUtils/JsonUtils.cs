using System.Text.Json.Serialization;
using System.Text.Json;

namespace CandidateUtils
{
    public static class JsonUtils<T>
    {
        public static void writeJson(List<T> list, string path)
        {
            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                WriteIndented = true
            };
            string jsonData = JsonSerializer.Serialize(list, options);
            // Write the JSON string to a file
            File.WriteAllText(path, jsonData);
        }
    }
}
