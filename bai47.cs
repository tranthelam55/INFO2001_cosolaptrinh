//Ở code sử dụng biến kiểu Diction sau, key là trường nào? 
using System;
using System.Collections.Generic;

class bai47
{
    static void Main()
    {
        // Khởi tạo một Dictionary mới
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        // Thêm các phần tử vào Dictionary
        myDictionary.Add("Apple", 1);
        myDictionary.Add("Banana", 2);
        myDictionary.Add("Cherry", 3);

        // In ra các phần tử trong Dictionary
        foreach (KeyValuePair<string, int> kvp in myDictionary)
        {
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
}
//Trong đoạn code sử dụng biến kiểu Dictionary được hiển thị, khóa (key) của Dictionary là kiểu string. Cụ thể, các key được định nghĩa là "Apple", "Banana" và "Cherry".
