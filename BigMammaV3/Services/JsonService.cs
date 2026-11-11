using BigMammaV3.Interfaces;
using System.Text.Json;

namespace BigMammaV3.Services;

public class JsonService : IJsonService
{
    public T? Read<T>(string filepath)
    {
        if (!File.Exists(filepath)) { return default; }
        
        string json = File.ReadAllText(filepath);

        if (string.IsNullOrEmpty(json))
        {
            return default;
        }

        return JsonSerializer.Deserialize<T>(json);
        
    }

    public void Write<T>(string filepath, T data)
    {
        DirectoryExistsValidation(filepath);

        string json = JsonSerializer.Serialize<T>(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filepath, json);
    }

    private void DirectoryExistsValidation(string filepath)
    {
        string? directory = Path.GetDirectoryName(filepath);
        if (!string.IsNullOrEmpty(directory))
        {
            Directory.CreateDirectory(directory);
        }

    }
}
