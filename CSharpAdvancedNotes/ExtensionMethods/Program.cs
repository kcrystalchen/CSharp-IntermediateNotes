using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    public static class StringExtension
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            string post = "a bc de fg";
            //string post = "This is supposed to be a very long post blah blah blah...";
            var stortenedPost = post.Shorten(2);

            IEnumerable<int> numbers = new List<int>() { 1,5,2,10,2,18};

            int maxNum = numbers.Max();
            Console.WriteLine(maxNum);

            Console.WriteLine("check shortenedPost : " + stortenedPost);
        }
    }
}
