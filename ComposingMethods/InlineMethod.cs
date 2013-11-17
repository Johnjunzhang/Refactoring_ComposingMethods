namespace Composing_Methods
{
    public class InlineMethod
    {
        private readonly decimal numberOfLateDeliveries;

        public InlineMethod(decimal numberOfLateDeliveries)
        {
            this.numberOfLateDeliveries = numberOfLateDeliveries;
        }

        public int GetRating()
        {
            return (MoreThanFiveLateDeliveries()) ? 2 : 1;
        }

        private bool MoreThanFiveLateDeliveries()
        {
            return numberOfLateDeliveries > 5;
        }
    }
}