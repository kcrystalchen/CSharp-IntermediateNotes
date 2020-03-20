using System;

namespace Inheritance
{
    public class PresentationObject
    {
        // defined two properties
        public int Width { get; set; }
        public int Height { get; set; }

        // defined two Methods
        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
          

    }
}
