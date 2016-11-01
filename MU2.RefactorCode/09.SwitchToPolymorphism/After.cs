using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.SwitchToPolymorphism
{
    /// <summary>
    /// Áp dụng cho các switch lớn thay đổi liên tục khi có những điều kiện mới thêm vào.
    /// Sử dụng strategy pattern để đóng gói các condition thành từng class riêng.
    /// Việc này giúp cho class sử dụng nó không cần thay đổi khi bổ sung thêm điều kiện
    /// Như ở đây chỉ cần thêm implementation và thêm vào config dictionary
    /// </summary>
    public class ClientCode
    {
        public decimal CalculateShipping()
        {
            ShippingInfo shippingInfo = new ShippingInfo();
            return shippingInfo.CalculateShippingAmount(State.Alaska);
        }
    }

    public enum State
    {
        Alaska,
        NewYork,
        Florida
    }

    public class ShippingInfo
    {
        private IDictionary<State, IShippingCalculation> ShippingCalculations { get; set; }

        public ShippingInfo()
        {
            ShippingCalculations = new Dictionary<State, IShippingCalculation>
 {
 { State.Alaska, new AlaskShippingCalculation() },
 { State.NewYork, new NewYorkShippingCalculation() },
 { State.Florida, new FloridaShippingCalculation() }
 };
        }

        public decimal CalculateShippingAmount(State shipToState)
        {
            return ShippingCalculations[shipToState].Calculate();
        }
    }

    public interface IShippingCalculation
    {
        decimal Calculate();
    }

    public class AlaskShippingCalculation : IShippingCalculation
    {
        public decimal Calculate()
        {
            return 15m;
        }
    }

    public class NewYorkShippingCalculation : IShippingCalculation
    {
        public decimal Calculate()
        {
            return 10m;
        }
    }

    public class FloridaShippingCalculation : IShippingCalculation
    {
        public decimal Calculate()
        {
            return 3m;
        }
    }
}
