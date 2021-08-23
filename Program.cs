using System;

namespace Week2Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student();
            student1.Name = "Pablo Gamez";
            student1.Major = "Computer Science";
            student1.AddSubjects("Math", "English", "Geology");
            student1.PrintStudentInfo();
        }
    }
}
