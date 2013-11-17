using System;

namespace Composing_Methods
{
    public class IntroduceExplainingVariableExample2
    {
        private readonly double quantity;
        private readonly double itemPrice;

        public IntroduceExplainingVariableExample2(double quantity, double itemPrice)
        {
            this.quantity = quantity;
            this.itemPrice = itemPrice;
        }

        public double GetPrice()
        {
            // price is base price - quantity discount + shipping
            return quantity * itemPrice -
                Math.Max(0, quantity - 500) * itemPrice * 0.05 +
                Math.Min(quantity * itemPrice * 0.1, 100.0);
        }
    }
}