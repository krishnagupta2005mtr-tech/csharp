using System;

namespace Q1_StudentUtility
{
    class StudentUtility
    {
        public static double CalculatePercentage(double obtained, double total)
        {
            return (obtained / total) * 100;
        }

        public static string CalculateGrade(double percentage)
        {
            if (percentage >= 90)
                return "A+";
            else if (percentage >= 80)
                return "A";
            else if (percentage >= 70)
                return "B";
            else if (percentage >= 60)
                return "C";
            else if (percentage >= 50)
                return "D";
            else
                return "F";
        }

        public static double CalculateAttendancePercentage(
            int attendedClasses, int totalClasses)
        {
            return ((double)attendedClasses / totalClasses) * 100;
        }

        static void Main(string[] args)
        {
            double percentage =
                StudentUtility.CalculatePercentage(450, 500);

            Console.WriteLine("Percentage: " + percentage + "%");
            Console.WriteLine("Grade: " +
                StudentUtility.CalculateGrade(percentage));

            double attendance =
                StudentUtility.CalculateAttendancePercentage(80, 90);

            Console.WriteLine("Attendance: " + attendance + "%");

            Console.ReadKey();
        }
    }
}