using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOverriding
{

    public class Canvas 
    {  // class Canvas is getting the list of shapes, and setup logic to do something based on the shapes 
       public void DrawShapes(List<Shape> shapes) // receive a list of shapes, the name of the List is called shapes
        {
            foreach(var shape in shapes) // loop through all the shapes
            {
                shape.Draw(); // invoke each shape type 
            }
        }
    }


    // Circle and Rectangle both are type of the Shape
    public class Circle : Shape
    {
        // 1. defined Circle (class Circle) as a shape type
        // 2. creating Circle action and inheritance Shape class access 
        // 3. because drawing a Circle algorithm is different than Rectangle, so it needs overriding the default drawing algorithm 
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }

    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle");
        }
    }

    public class Shape
    {  // class Shape is to setup the shapes for each shape Type and setup default Draw() algorithm 
        
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {
            // default Draw algorithm
            Console.WriteLine("No Draw");
        }

    }



    public class Position
    {
        // something
    }

  
    class Program
    {
        static void Main(string[] args)
        {
            // create a list of Shapes 
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            
            Canvas canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
