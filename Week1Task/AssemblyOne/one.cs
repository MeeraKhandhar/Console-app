using System;
using Week1Task;

namespace AssemblyOne
{
    /*public class AssemblyOneBaseClass
    {
        private string privateVariable = "private";
        protected string protectedVariable = "protected";
        internal string internalVariable = "internal";
        protected internal string protectedInternalVariable = "protected internal";
        public string publicVariable = "public";

        public void TestAccess()
        {
            //Accessible
            Console.WriteLine(privateVariable);
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }

    public class AssemblyDerivedClass : AssemblyOneBaseClass
    {
        public void TestAccessInDerivedClass()
        {
            // Not accessible
            // Console.WriteLine(privateVariable);
            
            //Accessible
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);

        }
    }
    class Program1
    {
        public static void Main(string[] args)
        {
            //AssemblyBaseClass objBase = new AssemblyBaseClass();
            //objBase.TestAccess();

            //AssemblyDerivedClas objDerivedClass = new AssemblyDerivedClass();
            ////objDerivedClass.TestAccessInDerivedClass();
            //objDerivedClass.TestAccess();
            sample obj = new sample();
            
            Console.ReadKey();
        }
    }*/
    /*string insertSql = "INSERT INTO tbl_Student (StudentID,FirstName,LastName,DepartmentName,DateAdmitted,DOB) VALUES (@StudentID,@FirstName,@LastName,@DepartmentName,@DateAdmitted,@DOB)";
    SqlCommand command = new SqlCommand(insertSql, conn);

    command.Parameters.AddWithValue("@StudentID", " ");
                    command.Parameters.AddWithValue("@FirstName", " ");
                    command.Parameters.AddWithValue("@LastName", " ");
                    command.Parameters.AddWithValue("@DepartmentName", " ");
                    command.Parameters.AddWithValue("@DateAdmitted", " ");
                    command.Parameters.AddWithValue("@DOB", " ");
                    int rowsAffected = command.ExecuteNonQuery();
    Console.WriteLine("Rows affected: {0}", rowsAffected);







        
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Data inserted successfully.");
                    }
                    else
{
    Console.WriteLine("Failed to insert data.");
}*/
}
