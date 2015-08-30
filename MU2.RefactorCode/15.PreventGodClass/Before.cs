using System.Collections.Generic;
using System.Linq;

namespace MU2.RefactorCode.PreventGodClass
{
    public class CustomerService
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

        public void Register(Customer customer)
        {
            // do work
        }

        public void ForgotPassword(Customer customer)
        {
            // do work
        }
    }

    public class Customer
    {
    }

    public class Order
    {
    }

    public class Product
    {
    }
}