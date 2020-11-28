namespace Generics
{
    //Sadece product class olan bir þey için çalýþýr
    public class DiscountCaculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}