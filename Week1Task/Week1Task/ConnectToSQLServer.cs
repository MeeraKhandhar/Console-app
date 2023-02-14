using System;
using System.Data.SqlClient;

namespace Week1Task
{
    class ConnectToSQLServer
    {
       /* public static void Main(string[] args)
        {
            string ConnectionString = "Data Source = DESKTOP-IBNN0RU; Database = sample; Integrated Security = True";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    Console.WriteLine("Enter student ID:");
                    string StudentID = Console.ReadLine();

                    Console.WriteLine("Enter first name:");
                    string FirstName = Console.ReadLine();

                    Console.WriteLine("Enter last name:");
                    string LastName = Console.ReadLine();

                    Console.WriteLine("Enter department name:");
                    string DepartmentName = Console.ReadLine();

                    Console.WriteLine("Enter date admitted (YYYY-MM-DD):");
                    DateTime DateAdmitted = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Enter date of birth (YYYY-MM-DD):");
                    DateTime DOB = DateTime.Parse(Console.ReadLine());

                    cmd.CommandText = "INSERT INTO tbl_Student (StudentID, FirstName, LastName, DepartmentName, DOB) VALUES (@StudentID, @FirstName, @LastName, @DepartmentName, @DOB)";

                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@DepartmentName", DepartmentName);
                    cmd.Parameters.AddWithValue("@DOB", DOB);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Data inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to insert data.");
                    }
                }
                conn.Close();
                Console.ReadKey();
            }
        }*/
    }
}




