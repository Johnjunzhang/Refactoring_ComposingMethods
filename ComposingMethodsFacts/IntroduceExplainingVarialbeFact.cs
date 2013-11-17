using Composing_Methods;
using Xunit;

namespace ComposingMethodsFacts
{
    public class IntroduceExplainingVarialbeFact
    {
        [Fact]
        public void should_get_true_given_platform_is_MAC_and_browser_is_IE_and_resize_is_1()
        {
            var introduceVariable = new IntroduceExplainingVariableExample1();
            Assert.True(introduceVariable.IsResizableIEInMac("MAC", "IE", 1));
        }

        [Fact]
        public void should_get_false_given_platform_is_Windows_and_browser_is_Chrome_and_resize_is_0()
        {
            var introduceVariable = new IntroduceExplainingVariableExample1();
            Assert.False(introduceVariable.IsResizableIEInMac("Windows", "Chrome", 0));
        }

        [Fact]
        public void should_get_right_given_quantity_is_1000_and_item_price_is_2()
        {
            var introduceVariable = new IntroduceExplainingVariableExample2(1000, 2);
            Assert.Equal(2050, introduceVariable.GetPrice());
        }

        [Fact]
        public void should_get_right_given_quantity_is_200_and_item_price_is_60()
        {
            var introduceVariable = new IntroduceExplainingVariableExample2(200, 2);
            Assert.Equal(440, introduceVariable.GetPrice());
        }
    }
}