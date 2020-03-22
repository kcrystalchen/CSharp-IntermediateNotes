using System;

namespace AbstractClassesAndMembers
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw(); 

        public void Copy()
        {
            Console.WriteLine("Copy shape into ClipBoard");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape");
        }
    }
}
