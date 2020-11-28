namespace Generics
{
    //Sadece product class olan bir �ey i�in �al���r
    public class DiscountCaculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}