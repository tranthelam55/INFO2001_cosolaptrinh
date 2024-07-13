using System;
using System.IO;

public static class CsvHelper
{
    public static bool WriteToCSV(string filePath, float[,] data)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                int rows = data.GetLength(0);
                int cols = data.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        writer.Write(data[i, j].ToString("F4")); // Ghi số với 4 chữ số thập phân
                        if (j < cols - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();
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
