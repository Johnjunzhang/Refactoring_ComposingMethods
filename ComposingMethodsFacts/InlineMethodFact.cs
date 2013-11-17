using Composing_Methods;
using Xunit;

namespace ComposingMethodsFacts
{
    public class InlineMethodFact
    {
        [Fact]
        public void should_get_rating_2_given_more_than_five_late_deliveries()
        {
            const int numberOfLateDeliveries = 6;
            var inlineMethod = new InlineMethod(numberOfLateDeliveries);
            Assert.Equal(2, inlineMethod.GetRating());
        }

        [Fact]
        public void should_get_rating_1_given_less_than_five_late_deliveries()
        {
            const int numberOfLateDeliveries = 4;
            var inlineMethod = new InlineMethod(numberOfLateDeliveries);
            Assert.Equal(1, inlineMethod.GetRating());
        }
    }
}