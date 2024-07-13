using System;

class bai50
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
//Được
//Về cách viết min_value = FindMin(intArray); thay vì min_value = FindMin<int>(intArray);, việc này có thể thực hiện được vì C# có khả năng suy luận kiểu dữ liệu tự động. Khi bạn gọi FindMinValue(intArray), trình biên dịch C# sẽ tự động suy luận ra rằng T là int và sẽ sinh mã tương ứng.
//Khi khai báo dynamic min_value;, biến min_value có thể lưu trữ bất kỳ kiểu dữ liệu nào, và việc gán giá trị vào nó sẽ được thực hiện ở thời điểm chạy (runtime) thay vì ở thời điểm biên dịch (compile-time). Điều này rất hữu ích khi bạn không biết trước kiểu dữ liệu của giá trị sẽ được gán cho min_value, chẳng hạn như khi bạn muốn lưu trữ kết quả trả về từ hàm FindMinValue() mà không cần chỉ định cụ thể kiểu dữ liệu.
