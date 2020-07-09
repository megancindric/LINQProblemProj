using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            //Will calculate class grade average after dropping the lowest grade for each student
            //Will take in a list of strings of grades (one string), drop lowest, average the rest of that string, then average all averages
            List<string> classGrades = new List<string>(){
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
            };

            foreach(string gradeString in classGrades)
            {
                var splitGradeString = gradeString.Split();
                //Now we have a list of arrays of strings of grades

            }

            var splitGrades = Convert.ToInt32(splitStringGrades);
            splitGrades.Ord
            foreach (var stringOfNum in classGrades)
            {
                var splitString = stringOfNum.Split(",");
                //First split into separate string values
                foreach (var item in splitString)
                {

                }

            }
            //1.Split each value on ,
            //var splitGrades1 = splitGrades.Select(a => Convert.ToInt32(a));
            //Convert each value to a number
           
            //order in ascending order using OrderBy, then SKIP(1);
            //var splitGrades2 = splitGrades.OrderBy(b => b);
           // var splitGrades4 = splitGrades.Skip(1);
            //average remaining 4 values
            //.Average();
            //average all values
            //.Average();
            /*
            •	Expected output: 86.125*/

             

           
        }
       
    }
}

