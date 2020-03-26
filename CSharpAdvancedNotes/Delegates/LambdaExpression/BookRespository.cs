using System.Collections.Generic;

namespace LambdaExpression
{
    partial class Program
    {
        public class BookRespository
        {
            public List<Book> GetBooks()   // creating a new method returns a List with Book properties
            {
                List<Book> bookList =  new List<Book>  // returning a list of Book from the database
                {
                new Book() { Title = "Title 1", Price = 5 },
                new Book() { Title = "Title 2", Price = 7 },
                new Book() { Title = "Title 3", Price = 17 }
                };

                return bookList;
            }
        }
    }


}
