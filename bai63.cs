//c1
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;

public static class JsonHelper
{
    public static bool WriteJsonFile(string filePath, Dictionary<string, int> data)
    {
        try
        {
            string jsonContent = JsonConvert.SerializeObject(data);
            File.WriteAllText(filePath, jsonContent);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
//c2
using System.IO;
using System.Text.Json;

public static class JsonHelper
{
    public static bool WriteJsonFile(string filePath, Dictionary<string, int> data)
    {
        try
        {
            string jsonContent = JsonSerializer.Serialize(data);
            File.WriteAllText(filePath, jsonContent);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
