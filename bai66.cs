using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class CsvHelper
{
    public static double[,] ReadCsvFile(string filePath, bool hasHeader = true)
    {
        List<List<double>> data = new List<List<double>>();

        using (var reader = new StreamReader(filePath))
        {
            string line;

            if (hasHeader)
            {
                // Bỏ qua dòng header
                reader.ReadLine();
            }

            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',')
                                .Select(double.Parse)
                                .ToList();
                data.Add(values);
            }
        }

        int rows = data.Count;
        int cols = data[0].Count;

        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = data[i][j];
            }
        }

        return result;
    }
}
