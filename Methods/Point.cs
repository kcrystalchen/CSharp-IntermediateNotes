using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        // create a constructor Point
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // add method to move the point to a different locations
        public void Move(int x, int y)
        {
            // change the values of the field using these arguments
            this.X = x;
            this.Y = y;
        }

        // overload this method by creating another version of this that takes a different signature 
        public void Move(Point newLocation) // passing Point object newLocation 
        {
            this.X = newLocation.X; // using Point object newLocation to change the value of the field  X and Y
            this.Y = newLocation.Y;
        }

        // OR overloading methods, using the overload move method to call the first move method 
        // this way, it sets x and y in one place

        //public void Move(Point newLocation0)
        //{
        // if it passes a not-object here, it will throw an exception
        // if(newLocation == null){
        //    throw new ArgumentException("NewLocation");
        //  }
        //    Move(newLocation0.X, newLocation0.Y);
        //}


    }
}
