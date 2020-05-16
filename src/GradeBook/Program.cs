using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Vinamra GradeBook");
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.AddGrade(77.5);
            book.ShowStatistics();

        }
    }
}
