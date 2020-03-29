using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {

        static void Main(string[] args)
        {
            IEnumerable<Book> books = new BookRespository().GetBooks();


            // option 1:
            List<Book> cheapBooks = new List<Book>();

            foreach (var book in books)
            {
                if (book.Price > 10)
                {
                    cheapBooks.Add(book);
                }
            }

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            // LINQ Extension METHODS
            // option 2: Enumerable books.Where(), the where method is for filter the criteria that matches certain conditions, and it returns a list of the books

            IEnumerable<Book> cheapBooks0 = books.Where(book => book.Price > 10);
            foreach (var book in cheapBooks0)
            {
                Console.WriteLine(" books using .Where() filter: " + book.Title);
            }


            // option 3: OrderBy method 
            IEnumerable<Book> cheapBook1 = books.OrderBy(book => book.Title);
            foreach (var book in cheapBook1)
            {
                Console.WriteLine(" books using OrderBy: " + book.Title);
            }

            // option 4: select method, convert and return the book to a list of string book is a string
            IEnumerable<string> cheapBook2 = books.Select(book => book.Title);
            foreach (var book in cheapBook2)
            {
                Console.WriteLine(" books using Select: " + book);
            }


            // Query Operators
            // option 5: the output is the same output as the Extension method
            IEnumerable<string> cheapBook3 = from book in books
                                             where book.Price < 10
                                             orderby book.Title
                                             select book.Title;

            // LINQ extension methods
            // option 6: return only one book single or singleOrDefault method based on the condition
            var book0 = books.Single(book => book.Title == "ASP.NET MVC");
            var book1 = books.SingleOrDefault(book => book.Title == "ASP.NEC0");
            Console.WriteLine(book0.Title);
            Console.WriteLine(book1 != null);


            // option 7: return the first object in the collection
            var book2 = books.First(book => book.Title == "C# Advanced Topics");
            var book3 = books.FirstOrDefault(book => book.Title == "C# Advanced Topics");
            var book4 = books.Last(book => book.Title == "C# Advanced Topics");
            var book5 = books.LastOrDefault(book => book.Title == "C# Advanced Topics");
            Console.WriteLine(book2.Title + " " + book2.Price);

            // option 8: skip two objects and get three objects
            var books6 = books.Skip(2).Take(3);
            foreach (var book in books6)
            {
                Console.WriteLine(book.Title);
            }


            // option 9: returns how many books:count
            var countBooks = books.Count();
            Console.WriteLine(countBooks);

            // option 10: return max something in the collection
            var maxBooks = books.Max(book => book.Price);
            Console.WriteLine(maxBooks);

            // option 11:  return min something in the collection
            var minBooks = books.Min(book => book.Price);
            Console.WriteLine(minBooks);


            // option 12: return the sum from the collection
            var sumBooks = books.Sum(book => book.Price);
            Console.WriteLine(sumBooks); 
            
            
            // option 12: return the average from the collection
            var aveBooks = books.Average(book => book.Price);
            Console.WriteLine(aveBooks);
        }
    }
}
