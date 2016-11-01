using System.Collections.Generic;
using System.Linq;

namespace MU2.RefactorCode.RemoveDoubleNegative
{
    public class OrderBefore
    {
        public void Checkout(IEnumerable<Product> products, CustomerBefore customer)
        {
            if (!customer.IsNotFlagged)
            {
                // the customer account is flagged
                // log some errors and return
                return;
            }

            // normal order processing
        }
    }

    public class Product
    {
    }

    public class CustomerBefore
    {
        public decimal Balance { get; private set; }

        public bool IsNotFlagged
        {
            get { return Balance < 30m; }
        }
    }
}