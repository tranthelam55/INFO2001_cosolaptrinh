//c1
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class JsonHelper
{
    public static Dictionary<string, int> ReadJsonFile(string filePath)
    {
        string jsonContent = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<Dictionary<string, int>>(jsonContent);
    }
}
//c2
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public static class JsonHelper
{
    public static Dictionary<string, int> ReadJsonFile(string filePath)
    {
        string jsonContent = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<Dictionary<string, int>>(jsonContent);
    }
}
