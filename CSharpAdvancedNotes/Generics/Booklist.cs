using System;

namespace Generics
{
    public class Booklist
    {
        // Not Generics examples:
        public void Add(Book book)
        {
          
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get {throw new NotImplementedException();}
        }
    
    }
}
