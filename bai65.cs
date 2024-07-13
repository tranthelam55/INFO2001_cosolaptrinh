using System;
using System.IO;
using System.Collections.Generic;

public static class CsvHelper
{
    public static bool WriteToCSV(string filePath, Dictionary<string, double> data)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Ghi header
                writer.WriteLine("Key,Value");

                // Ghi dữ liệu
                foreach (var pair in data)
                {
                    writer.WriteLine($"{pair.Key},{pair.Value.ToString("F8")}"); // Ghi số với 8 chữ số thập phân
                }
            }
            return true;
        }
        catch
        {
            return false;
        }
    }
}
