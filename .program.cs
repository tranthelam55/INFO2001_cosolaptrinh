using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace db_student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // set encoding UTF-8 cho Console
            String connectionString = "Server=DESKTOP-D9JM063\\SQLEXPRESS;Database=CMCUNI;User ID=sa;Password=cmcuni;";

            List<Student> list_sv = null;
            SqlConnection connection = null;
            connection = db_lib.MoKetNoi(connectionString);
            if (connection == null)
                Console.WriteLine("Không kết nối được CSDL với xâu kết nối là:" + connectionString);
            else
            {
                //Gọi hàm đọc thông tin sinh viên
                list_sv = db_lib.DocSinhvien(connection);
                // Hiển thị danh sách sinh viên
                for (int i = 0; i < list_sv.Count; i++)
                    Console.WriteLine(list_sv[i].StudentID + "," + list_sv[i].FirstName + "," + list_sv[i].LastName + "," + list_sv[i].Age + "," + list_sv[i].Gender);
            }//else

            //////////////////////////////
        }// Main
    }//Program
}//db_student
