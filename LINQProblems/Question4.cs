using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace LINQProblems
{
    class Question4
    {
        public Question4()
        {

        }
        public string GetLetterFrequency(string stringValue)
        {
            string result = "";
            var splitSortedString = stringValue.Split().OrderBy(x => x);
            var valuesToSearch = splitSortedString.Distinct();
            foreach (var character in valuesToSearch)
            {
                int charFrequency = splitSortedString.Count(c => c.Equals(character));
                result += character.ToString() + charFrequency.ToString();
            }
            return result;
        }
        //Will take in a string of letters, alphabatize it, then return a string corresponding to frequency of letter 
        //(Terrill would return E1I1L2Rr2T1)
        //Will need to convert to uppercase as well
        //1. Will sort in alphabetical order
        //2. Will split on each value
            //.Split
        //3. will have a counter for each value (starts at 1)
        //4. Will get count for each unique value, then return format LETTERNUMBER
        //Will create a string of this
    }
}
