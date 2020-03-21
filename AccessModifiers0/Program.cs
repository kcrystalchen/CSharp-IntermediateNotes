using Amazon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers0
{



    //public class GoldCustomer : Customer  // inheritance from Customer class
    //{
    //    public void OfferVouchar()  // method OfferVouchar
    //    {
    //      //  var rating =  this.CalculateRating(excludeOrders: true);
    //    }
    //}

                                                
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();  // Customer class is from Amazon namespace
            Amazon.RateCaculator calculator = new RateCaculator();
            customer.Promote();
        }
    }
}
