using System;
using System.Text.Json;

namespace CircleInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;

            // Nhập bán kính r
            while (true)
            {
                Console.Write("Nhập bán kính (r): ");
                if (double.TryParse(Console.ReadLine(), out r) && r > 0)
                    break;
                Console.WriteLine("Bán kính không hợp lệ. Vui lòng nhập lại.");
            }

            // Gọi hàm tính toán thông tin hình tròn
            string circleInfo = GetCircleInfo(r);
            Console.WriteLine(circleInfo);
        }

        static string GetCircleInfo(double r)
        {
            // Tính toán thông tin hình tròn
            double area = Math.PI * r * r;
            double circumference = 2 * Math.PI * r;
            double diameter = 2 * r;

            // Tạo đối tượng JSON
            var circleInfo = new
            {
                dien_tich = area,
                chu_vi = circumference,
                duong_kinh = diameter
            };

            // Trả về chuỗi JSON
            return JsonSerializer.Serialize(circleInfo);
        }
    }
}
