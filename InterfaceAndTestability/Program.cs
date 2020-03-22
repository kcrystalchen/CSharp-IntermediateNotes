using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndTestability
{

    public class Order   // define isShipped or not || define TotalPrice of the order
    {
        public int Id { get; set; }
        public bool IsShipped 
        { get { return Shipment != null; }
        }
        public float TotalPrice { get; set; }
        public Shipment Shipment { get; set; }
        public DateTime DatePlace { get; set; }

    }



    public class OrderProcessor 
    // validating is shipped or not || Get a ship cost and date based on ShippingCalculator class
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
           _shippingCalculator = shippingCalculator;
        }

        
        public void Process(Order order) // pass in the order object into Process method
        {
            if(order.IsShipped)
            {
                throw new InvalidOperationException("This order is already processed.");
            } else
            {
                order.Shipment = new Shipment  // create an object type of Shipment and assign it to shipment property
                {
                    Cost = _shippingCalculator.CalculateShipping(order),
                    ShippingDate = DateTime.Today.AddDays(1)
                };
            }
        }


    }


    public class Shipment  // shipment class has two properties
    {
        public float Cost { get; set; }
        public DateTime ShippingDate { get; set; }
    }

    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }


    public class ShippingCalculator : IShippingCalculator 
    // shippingCalculator implements IShippingCalculator
    // based on order from Order class to calculate the shipping 
    {
        public float CalculateShipping(Order order)
        {
            if(order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }
            else
            {
                return 0;
            }

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor(new ShippingCalculator());
            Order order = new Order { DatePlace = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);

        }
    }
}
