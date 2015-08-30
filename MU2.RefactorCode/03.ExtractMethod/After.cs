using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.ExtractMethod
{
    public class Receipt
    {
        private IList<decimal> Discounts { get; set; }
        private IList<decimal> ItemTotals { get; set; }

        public decimal CalculateGrandTotal()
        {
            decimal subTotal = CalculateSubTotal();

            subTotal = CalculateSubTotalAfterDiscounts(subTotal);

            subTotal = CalculateSubTotalIncludeTax(subTotal);

            return subTotal;
        }

        private decimal CalculateSubTotalIncludeTax(decimal subTotal)
        {
            decimal tax = subTotal * 0.065m;

            subTotal += tax;
            return subTotal;
        }

        private decimal CalculateSubTotalAfterDiscounts(decimal subTotal)
        {
            if (Discounts.Count > 0)
            {
                foreach (decimal discount in Discounts)
                    subTotal -= discount;
            }
            return subTotal;
        }

        private decimal CalculateSubTotal()
        {
            decimal subTotal = 0m;
            foreach (decimal itemTotal in ItemTotals)
                subTotal += itemTotal;
            return subTotal;
        }
    }
}
