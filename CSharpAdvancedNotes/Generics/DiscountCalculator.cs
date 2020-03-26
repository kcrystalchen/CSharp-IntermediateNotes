namespace Generics
{
    public class DiscountCalculator<T> where T : Product
    {
        public float calculateDiscount(T Product)
        {
            return Product.Price;
        }
    }
}
