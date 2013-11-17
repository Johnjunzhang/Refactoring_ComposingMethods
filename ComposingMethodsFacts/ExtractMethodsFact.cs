using System.Collections.Generic;
using Composing_Methods;
using Composing_Methods.ReferenceClasses;
using Xunit;

namespace ComposingMethodsFacts
{
    public class ExtractMethodsFact
    {
        [Fact]
        public void should_get_right_customer_owns()
        {
            const string expectedCustomerOwns = "****/n**Customer Owns**/n****/nname:ExtractMethod/namount:140";
            var orders = new List<Order> {new Order(10), new Order(20)};
            var extractMethods = new ExtractMethods(orders);
            var owns = extractMethods.PrintOwning("ExtractMethod", 100);
            Assert.Equal(expectedCustomerOwns, owns);
        }
    }
}
