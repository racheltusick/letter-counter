using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LetterCounterNamespace
{
    public class LetterCounter
    {
        public char[] Count(string v)
        {
            char[] instead = v.ToLower().ToCharArray();
            List<char> things = new List<char>(instead); 
            //This makes a list out of the array that exists (i.e., instead)             
            //for (int i = 0; i < instead.Length; i++)
            ////foreach (char c in v)
            //{
            //    things.Add(instead[i]);
            //    //things = things.Distinct().ToList(); 
            //    //List<char> test = new List<char>(new char[] { 'a', 'b', 'd', 'c', 'd', 'c' }); 
            //}
            things.Sort(); //sorts alphabetically  

            var q = from s in things
                    group s by s into g
                    orderby g.Count() descending
                    select g.Key; 

            return q.ToArray(); // return an empty array so it compiles (all tests will fail)
        } 
    }
}
