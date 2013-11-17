using Composing_Methods;
using Xunit;

namespace ComposingMethodsFacts
{
    public class SplitTemporaryVariableFact
    {
        [Fact]
        public void should_set_right_perimeter_and_area()
        {
            var splitTemporaryVariable = new SplitTemporaryVariable();
            splitTemporaryVariable.SetPerimeterAndArea(20, 10);
            Assert.Equal(120, splitTemporaryVariable.GetDoublePerimeter());
            Assert.Equal(400, splitTemporaryVariable.GetDoubleArea());
        }
    }
}