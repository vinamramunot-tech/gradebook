using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
    {
        List<double> _grades;
        public string Name;
        public Book(string name)
        {
            _grades = new List<double>();
            Name = name;

        }
        public void AddGrade(double grade)
        {
            
            if (grade <= 100 && grade >= 0)
            {
                _grades.Add(grade);
            }else{
                Console.WriteLine("Invalid value");
            }

        }

        public Statistics GetStatistics()
        {

            var result = new Statistics();
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;

            var index = 0;
            while(index < _grades.Count)
            {
                result.Low = Math.Min(_grades[index], result.Low);
                result.High = Math.Max(_grades[index], result.High);
                result.Average += _grades[index];
                index += 1;
            }

            result.Average /= _grades.Count;

            return result;

        }

    }
}