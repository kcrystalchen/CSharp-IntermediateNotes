using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    partial class Program
    {
        private static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
        static void Main(string[] args)
        {
            // args => express  // LambdaExpress
            // number => number*number;  
            Func<int, int> square = number => number * number; //  first int is the argument data type, the second int is the return value datatype
            Console.WriteLine(square(5));

            // () => ... || x => .... || (x, y, z) => ...

            const int factor = 5;

            Func<int,int> multipler = n => n * factor;
            var result = multipler(10);
            Console.WriteLine(result);

            // Not LanbdaExpression

            List<Book> books = new BookRespository().GetBooks();
            List<Book> cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
                Console.WriteLine(book.Price);

            }



            // with LanbdaExpression
            List<Book> books0 = new BookRespository().GetBooks();
            List<Book> cheapBooks0 = books0.FindAll(book => book.Price < 10);



        }
    }


}
