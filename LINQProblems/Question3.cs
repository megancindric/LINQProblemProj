using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LINQProblems
{
    class Question3
    {
        public double GetAverageGradeWithoutMinGrade(List<string> classGrades)
        {
            double finalAverage = 0;
            foreach (string gradeString in classGrades)
            {
                finalAverage += gradeString.Split(',').Select(int.Parse).ToArray().OrderBy(x => x).Skip(1).Average();
                //var splitSortedSkippedInts
                //var splitGradeInts = gradeString.Split(',').Select(int.Parse);
                //var orderedGrades = splitGradeInts.ToArray().OrderBy(s => s);
                //var skippedSmallest = orderedGrades.Skip(1);
                // var averagedGrades = skippedSmallest.Average();
            }
            finalAverage /= classGrades.Count;
            return finalAverage;
        }

    }
}
	//Expected output: 86.125

    

