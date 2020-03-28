using System;
using System.Linq;

namespace System

{
    // creating an extension method, we need to create a static class
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)  // first extension method, it has to be public static
        {
            if (numberOfWords < 0)
            {
                throw new ArgumentOutOfRangeException("Number of word should be greater than 0");
            }
            if (numberOfWords == 0)
            {
                return "";
            }
            else
            {
                var eachWordFromString = str.Split(' '); // string converts to an array
                Console.WriteLine("here : " + eachWordFromString.Length);

                if (eachWordFromString.Length <= numberOfWords)
                {
                    Console.WriteLine("str : " + str);
                    return str;
                }
                else
                {
                 // Console.WriteLine(string.Join(" ",eachWordFromString.Take(numberOfWords)));
                  return string.Join(" ", eachWordFromString.Take(numberOfWords)); // convert to a string and take from the starting index to the numberOfWords index
                }
            }
       
        }
    }
}
