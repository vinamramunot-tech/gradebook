using System.Collections.Generic;
using System;

namespace GradeBook
{
    class Book
    {
        List<double> _grades;
        private string _name;
        public Book(string name)
        {
            _grades = new List<double>();
            _name = name;

        }
        public void AddGrade(double grade)
        {
            _grades.Add(grade);
        }

        public void ShowStatistics(){

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var num in _grades){
                lowGrade = Math.Min(num, lowGrade);
                highGrade = Math.Max(num, highGrade);
                result += num;
            }

            result /= _grades.Count;

            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N2}");

        }
        
    }
}