using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{

    class Program
    {
        static void Main(string[] args)
        {
            Nullable<DateTime> date0 = DateTime.Today; // Nullable is a generic structure in the system space
            Nullable<DateTime> date9 = null; // Nullable is a generic structure in the system space
            DateTime? date1 = null;


            Console.WriteLine("GetValueOrDefault(): " + date1.GetValueOrDefault()); 
            Console.WriteLine("HasValue: " + date1.HasValue); 
            //Console.WriteLine("date.value: " + date0.Value);


            DateTime? date2 = new DateTime(2020, 1, 1);
            DateTime date3 = date1.GetValueOrDefault(); // date3 can either get default value or the actual value if it is available
            DateTime date4 = date3;

            Console.WriteLine("date3: " + date3);


            if(date0 != null)
            {
                date1 = date0.GetValueOrDefault();
                Console.WriteLine("when date0 is not null: " + date1);
            }
            else
            {
                date1 = DateTime.Today;
                Console.WriteLine(date1);
            }

            DateTime? date5 = DateTime.Today.AddDays(2);
            DateTime date6 = date5 ?? DateTime.Today;
            Console.WriteLine("Date6: " + date6); 



        }
    }
}
