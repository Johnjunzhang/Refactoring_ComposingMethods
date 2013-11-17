using Composing_Methods;
using Xunit;

namespace ComposingMethodsFacts
{
    public class InlineTempFact
    {
        [Fact]
        public void should_get_true_given_amount_over_1000()
        {
            var inlineTemp = new InlineTemp(2000);
            Assert.True(inlineTemp.IsAmountOver1000());
        }

        [Fact]
        public void should_get_false_given_amount_less_than_1000()
        {
            var inlineTemp = new InlineTemp(500);
            Assert.False(inlineTemp.IsAmountOver1000());
        }
    }
}