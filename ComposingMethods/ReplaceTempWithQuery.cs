namespace Composing_Methods
{
    public class ReplaceTempWithQuery
    {
        private readonly decimal quantity;
        private readonly decimal itemPrice;

        public ReplaceTempWithQuery(decimal quantity, decimal itemPrice)
        {
            this.quantity = quantity;
            this.itemPrice = itemPrice;
        }

        public decimal GetPrice()
        {
            var basePrice = quantity*itemPrice;
            decimal discountFactor;
            if (basePrice > 1000)
                discountFactor = 0.95M;
            else
                discountFactor = 0.98M;

            return basePrice*discountFactor;
        }
    }
}