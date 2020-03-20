using System;

namespace Inheritance
{
    public class Text : PresentationObject
    {
        // creating two properties
        public int FontSize { get; set; }
        public string FontName { get; set; }

        // create a method
        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);

        }


    }
}
