using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.EncapsulateCollection
{
    public class OrderBefore
    {
        private List<OrderLine> _orderLines;
        private int _orderTotal;

        public IEnumerable<OrderLine> OrderLines
        {
            get { return _orderLines; }
            set { _orderLines = value.ToList(); }

        }

        public class OrderLine
        {
            public int Total { get; internal set; }
        }
    }
}
