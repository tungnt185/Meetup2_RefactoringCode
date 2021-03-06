﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.RemoveDoubleNegative
{
    /// <summary>
    /// Kỹ thuật này làm code trở nên dễ hiểu hơn, tránh hiểu nhầm dẫn đến side effect
    /// </summary>
    public class Order
    {
        public void Checkout(IEnumerable<Product> products, Customer customer)
        {
            if (customer.IsFlagged)
            {
                // the customer account is flagged
                // log some errors and return
                return;
            }

            // normal order processing
        }
    }

    public class Customer
    {
        public decimal Balance { get; private set; }

        public bool IsFlagged
        {
            get { return Balance >= 30m; }
        }
    }
}
