using System.Collections.Generic;
using System.Linq;
using Composing_Methods.ReferenceClasses;

namespace Composing_Methods
{
    public class ExtractMethods
    {
        private readonly List<Order> orders;

        public ExtractMethods(List<Order> orders)
        {
            this.orders = orders;
        }

        public string PrintOwning(string name, int previousAmount)
        {
            var customerOwns = string.Empty;
            double outstanding = 10 + previousAmount;

            // print banner
            customerOwns += "****/n";
            customerOwns += "**Customer Owns**/n";
            customerOwns += "****/n";

            // calculate outstanding
            outstanding = outstanding + orders.Sum(o => o.GetAmount());

            //print details
            customerOwns += "name:" + name + "/n";
            customerOwns += "amount:" + outstanding;
            return customerOwns;
        }
    }
}