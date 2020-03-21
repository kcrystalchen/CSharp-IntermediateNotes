using System;

namespace Amazon
{


    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public void Promote()
        {
            RateCaculator caculator = new RateCaculator();
            var rating = caculator.CalculatorMethod(this);  // this means the customer object in this method


        }


    }
}
