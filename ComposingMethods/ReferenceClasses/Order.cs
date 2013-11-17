namespace Composing_Methods.ReferenceClasses
{
    public class Order
    {
        private readonly double amount;

        public Order(double amount)
        {
            this.amount = amount;
        }

        public double GetAmount()
        {
            return amount;
        }
    }
}