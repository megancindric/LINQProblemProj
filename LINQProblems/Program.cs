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

         /* Question 2
          
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            var distinctWords = names.Distinct();
            foreach (var word in distinctWords)
            {
                Console.WriteLine(word);
            }

         */

         /* QUESTION 1
          
          List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            var wordsWithTh = words.Where(w => w.Contains("th"));
                foreach (var w in wordsWithTh)
                {
                    Console.WriteLine(w);
                }
            
         */

            Console.ReadLine();
        }
       
    }
}

