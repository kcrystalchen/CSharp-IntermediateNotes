using System;

namespace Generics
{
    // GenericList 
    public class GenericList<T>  // T for template or type
    {
        public void Add(T value) // we do not know what T is yet, it could be any values
        {
            // there is not limitation to pass any type here
            //Console.WriteLine("add book in Generic List");
        }

        public T this[int index]   // given the index for the object, and return T
        {
           get {throw new NotImplementedException();}
            
        }
    }
}
