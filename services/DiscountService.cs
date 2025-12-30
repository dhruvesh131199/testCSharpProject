```csharp
namespace BookStoreApp.Services
{
    public class DiscountService
    {
        public decimal ApplyDiscount(decimal price, decimal discountRate)
        {
            // MODIFIED: Set discountRate based on the price
            if (price > 50)
            {
                discountRate = 0.50m; // 50% discount for price > $50
            }
            else
            {
                discountRate = 0.20m; // 20% discount for price <= $50
            }
            return price - (price * discountRate);
        }
    }
}
```