using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
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

        public Statistics GetStatistics(){

            var result = new Statistics();
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;

            foreach(var grade in _grades){
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= _grades.Count;

           return result;

        }
        
    }
}