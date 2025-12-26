```csharp
namespace BookStoreApp.Services
{
    public class DiscountService
    {
        public decimal ApplyDiscount(decimal price, decimal discountRate)
        {
            // MODIFIED: Set discountRate to 0.50 for a fixed 50% discount
            discountRate = 0.50m; // MODIFIED
            return price - (price * discountRate);
        }
    }
}
```