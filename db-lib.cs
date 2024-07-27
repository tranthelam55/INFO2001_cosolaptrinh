using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace db_student
{
    public class Student
    {
        public string StudentID;
        public string FirstName;
        public string LastName;
        public int Age;
        public string Gender;
    }

    public class Course
    {
        public string CourseID;
        public string CourseName;
        public int Credits;
    }

    public class Registration
    {
        public string RegistrationID;
        public string StudentID;
        public string CourseID;
        public DateTime RegistrationDate;
    }

    public class db_lib
    {
        public SqlConnection connection = null;
        public static SqlConnection MoKetNoi(string connectionString)
        {
            SqlConnection connection = null;
            //String connectionString = "Server=DESKTOP-D9JM063\\SQLEXPRESS;Database=CMCUNI;User ID=sa;Password=cmcuni;";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch
            {
                return null;
            }
        }// MoKetNoi

        public static List<Student> DocSinhvien(SqlConnection connection)
        {
            List<Student> list_sv = new List<Student>();
            SqlCommand command = new SqlCommand("SELECT * FROM Students", connection); using System;
            using System.Collections.Generic;
            using System.Data.SqlClient;
            using System.Linq;
            using System.Text;

namespace db_student
    {
        public class Student
        {
            public string StudentID;
            public string FirstName;
            public string LastName;
            public int Age;
            public string Gender;
        }

        public class Course
        {
            public string CourseID;
            public string CourseName;
            public int Credits;
        }

        public class Registration
        {
            public string RegistrationID;
            public string StudentID;
            public string CourseID;
            public DateTime RegistrationDate;
        }

        public class db_lib
        {
            public SqlConnection connection = null;
            public static SqlConnection MoKetNoi(string connectionString)
            {
                SqlConnection connection = null;
                //String connectionString = "Server=DESKTOP-D9JM063\\SQLEXPRESS;Database=CMCUNI;User ID=sa;Password=cmcuni;";
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    return connection;
                }
                catch
                {
                    return null;
                }
            }// MoKetNoi

            public static List<Student> DocSinhvien(SqlConnection connection)
            {
                List<Student> list_sv = new List<Student>();
                SqlCommand command = new SqlCommand("SELECT * FROM Students", connection);
