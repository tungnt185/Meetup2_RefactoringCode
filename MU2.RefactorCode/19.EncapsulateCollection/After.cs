using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.EncapsulateCollection
{
    /// <summary>
    /// Kỹ thuật này đảm bảo các class sử dụng order không thay đổi OrderLines một cách không chính xác có thể dẫn đến lỗi
    /// Đảm bảo nguyên tắc đóng gói của OOP
    /// </summary>
    public class Order
    {
        private List<OrderLine> _orderLines;
        private int _orderTotal;

        public IEnumerable<OrderLine> OrderLines
        {
            get { return _orderLines; }
        }

        public void AddOrderLine(OrderLine orderLine)
        {
            _orderTotal += orderLine.Total;
            _orderLines.Add(orderLine);
        }

        public void RemoveOrderLine(OrderLine orderLine)
        {
            orderLine = _orderLines.Find(o => o == orderLine);
            if (orderLine == null) return;

            _orderTotal -= orderLine.Total;
            _orderLines.Remove(orderLine);
        }

        public class OrderLine
        {
            public int Total { get; internal set; }
        }
    }
}
