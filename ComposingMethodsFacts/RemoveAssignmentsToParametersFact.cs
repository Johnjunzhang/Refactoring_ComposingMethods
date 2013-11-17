using Composing_Methods;
using Xunit;

namespace ComposingMethodsFacts
{
    public class RemoveAssignmentsToParametersFact
    {
        [Fact]
        public void should_get_discount_7_given_value_is_over_50_and_quantity_is_over_100_and_yearToEnd_is_over_10000()
        {
            var removeAssignmentsToParameters = new RemoveAssignmentsToParameters();
            Assert.Equal(53, removeAssignmentsToParameters.Discount(60, 200, 20000));
        }

        [Fact]
        public void should_get_discount_5_given_value_is_less_than_50_and_quantity_is_over_100_and_yearToEnd_is_over_10000()
        {
            var removeAssignmentsToParameters = new RemoveAssignmentsToParameters();
            Assert.Equal(35, removeAssignmentsToParameters.Discount(40, 200, 20000));
        }
    }
}