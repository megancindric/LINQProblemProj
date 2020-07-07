using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQProblems
{
   public class Question1
    {
        public List<string> words;
        //Will use LINQ to return all words containing th from a list
        public Question1()
        {
           words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        }
        public void SearchForTH()
            { 
            List<string> wordsWithTh = (List<string>)words.Where(w => w.Contains("th"));
            foreach(var w in wordsWithTh)
            {
                Console.WriteLine(w);
            }

        }

    }
}
