using System;
using System.Collections.Generic;

namespace GradingStudents
{
    internal class Program
    {
        // easy
        // link to challenge https://www.hackerrank.com/challenges/grading/problem
        private static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = gradingStudents(grades);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                int diff = 5 - (grades[i] % 5);
                if (grades[i] + diff < 40)
                    continue;
                else if (diff < 3)
                    grades[i] += diff;
            }

            return grades;
        }
    }
}