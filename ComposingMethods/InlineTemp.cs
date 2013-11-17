using Composing_Methods.ReferenceClasses;

namespace Composing_Methods
{
    public class InlineTemp
    {
        private readonly Order order;

        public InlineTemp(int amount)
        {
            order = new Order(amount);
        }

        public bool IsAmountOver1000()
        {
            var amount = order.GetAmount();
            return amount > 1000;
        }
    }
}