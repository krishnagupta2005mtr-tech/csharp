using System;

namespace Q9_AppConfiguration
{
    static class AppConfiguration
    {
        public static string ConnectionString =
            "Server=localhost;Database=CollegeDB;Trusted_Connection=True;";

        public static string ApplicationName =
            "Student Management System";

        public static string Version = "1.0";

        public static void DisplayConfiguration()
        {
            Console.WriteLine("Application Name: "
                + ApplicationName);

            Console.WriteLine("Version: " + Version);

            Console.WriteLine("Connection String: "
                + ConnectionString);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AppConfiguration.DisplayConfiguration();

            Console.ReadKey();
        }
    }
}