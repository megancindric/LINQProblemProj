using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LINQProblems
{
    class Question2
    {
        public static List<string> ProvideDistinctList(List<string> listOfStrings)
        {
            var distinctWords = listOfStrings.Distinct().ToList();
            return distinctWords;
        }
        //Will take in a list of strings, then return a copy w/o duplicates
        //•
    }
}
