using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.PreventGodClass
{
    public class CustomerOrderService
    {
        public decimal CalculateOrderDiscount(IEnumerable<Product> products,
        Customer customer)
        {
            return 0;
        }

        public bool CustomerIsValid(Customer customer, Order order)
        {
            return true;
        }

        public IEnumerable<string> GatherOrderErrors(IEnumerable<Product> products,
        Customer customer)
        {
            return null;
        }
    }

    public class CustomerRegistrationService
    {

        public void Register(Customer customer)
        {
            // do work
        }

        public void ForgotPassword(Customer customer)
        {
            // do work
        }
    }
}
