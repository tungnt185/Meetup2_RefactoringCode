using System.Collections.Generic;
using System.Linq;

namespace MU2.RefactorCode.DesignByContractCheck
{
    public class CashRegisterBefore
    {
        public decimal TotalOrder(IEnumerable<Product> products, Customer customer)
        {
            decimal orderTotal = products.Sum(product => product.Price);

            customer.Balance += orderTotal;

            return orderTotal;
        }
    }

    public class Customer
    {
        public decimal Balance { get; internal set; }
    }

    public class Product
    {
        public int Price { get; internal set; }
    }
}