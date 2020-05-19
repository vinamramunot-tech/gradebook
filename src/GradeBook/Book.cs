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

            for(int index = 0; index < _grades.Count; index++)
            {

                result.Low = Math.Min(_grades[index], result.Low);
                result.High = Math.Max(_grades[index], result.High);
                result.Average += _grades[index];
            }

            result.Average /= _grades.Count;

            switch(result.Average){
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }

            return result;

        }

    }
}