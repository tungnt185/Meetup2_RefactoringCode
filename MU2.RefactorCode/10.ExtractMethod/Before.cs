using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.ExtractMethod
{
    public class OrderLineItemBefore
    {
        public decimal Price { get; private set; }
    }

    public class OrderBefore
    {
        private IList<OrderLineItemBefore> OrderLineItems { get; set; }
        private IList<decimal> Discounts { get; set; }
        private decimal Tax { get; set; }

        public decimal Calculate()
        {
            decimal subTotal = 0m;

            // Total up line items
            foreach (OrderLineItemBefore lineItem in OrderLineItems)
            {
                subTotal += lineItem.Price;
            }

            // Subtract Discounts
            foreach (decimal discount in Discounts)
                subTotal -= discount;

            // Calculate Tax
            decimal tax = subTotal * Tax;

            // Calculate GrandTotal
            decimal grandTotal = subTotal + tax;

            return grandTotal;
        }
    }
}
