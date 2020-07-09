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
        
        public List<String> SearchForTH(List<string> wordsToSearch)
         { 
            List<string> wordsWithTh = (List<string>)wordsToSearch.Where(w => w.Contains("th"));
            return wordsWithTh;
        }

    }
}
