using Composing_Methods;
using Xunit;

namespace ComposingMethodsFacts
{
    public class ReplaceTempWithQueryFact
    {
        [Fact]
        public void should_get_right_discount_given_base_price_is_over_1000()
        {
            var replaceTempWithQuery = new ReplaceTempWithQuery(1000, 2);
            Assert.Equal(1900, replaceTempWithQuery.GetPrice());
        }

        [Fact]
        public void should_get_right_discount_given_base_price_is_less_than_1000()
        {
            var replaceTempWithQuery = new ReplaceTempWithQuery(400, 2);
            Assert.Equal(784, replaceTempWithQuery.GetPrice());
        }
    }
}