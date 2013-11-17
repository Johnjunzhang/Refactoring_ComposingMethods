using Composing_Methods;
using Xunit;

namespace ComposingMethodsFacts
{
    public class ReplaceMethodWithMethodObjectFact
    {
        [Fact]
        public void should_get_right_gamma_given()
        {
            var replaceMethodWithMethodObject = new ReplaceMethodWithMethodObject();
            var gamma = replaceMethodWithMethodObject.Gamma(10, 5, 100);
            Assert.Equal(7600, gamma);
        }
    }
}