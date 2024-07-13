using System;

class bai49
{
    static void Main()
    {
       
        int[] intArray = { 10, 5, 8, 3, 15 };
        dynamic min_value = FindMinValue(intArray);
        Console.WriteLine($"Minimum value of int array: {min_value.ToString()}");

       
        uint[] uintArray = { 10, 5, 8, 3, 15 };
        min_value = FindMinValue(uintArray);
        Console.WriteLine($"Minimum value of uint array: {min_value.ToString()}");

        
        float[] floatArray = { 10.5f, 5.2f, 8.1f, 3.7f, 15.3f };
        min_value = FindMinValue(floatArray);
        Console.WriteLine($"Minimum value of float array: {min_value.ToString()}");

       
        double[] doubleArray = { 10.5, 5.2, 8.1, 3.7, 15.3 };
        min_value = FindMinValue(doubleArray);
        Console.WriteLine($"Minimum value of double array: {min_value.ToString()}");
    }

    static dynamic FindMinValue<T>(T[] array) where T : IComparable<T>
    {
        T minValue = array[0];

        foreach (T item in array)
        {
            if (item.CompareTo(minValue) < 0)
            {
                minValue = item;
            }
        }

        return minValue;
    }
}
