using System.IO;
using System.Text.Json;
using Google.Protobuf;

namespace CNTK.Proto.Test
{
    /// <summary>Convenience <see cref="Dictionary"/> extension methods.</summary>
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Writes the given <paramref name="dictionary"/> data to the 
        /// given <paramref name="filePath"/> in indented JSON encoding.
        /// </summary>
        public static void WriteIndentedJsonToFile(this Dictionary dictionary, string filePath)
        {
            var jsonText = JsonFormatter.Default.Format(dictionary);
            var jsonElement = JsonSerializer.Deserialize<JsonElement>(jsonText);

            var options = new JsonSerializerOptions() { WriteIndented = true };

            var jsonTextPretty = JsonSerializer.Serialize(jsonElement, options);
            File.WriteAllText(filePath, jsonTextPretty);
        }
    }
}
