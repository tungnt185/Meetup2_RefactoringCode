using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.SwitchToPolymorphism
{
    public class ClientCodeBefore
    {
        public decimal CalculateShipping()
        {
            ShippingInfoBefore shippingInfo = new ShippingInfoBefore();
            return shippingInfo.CalculateShippingAmount(StateBefore.Alaska);
        }
    }

    public enum StateBefore
    {
        Alaska,
        NewYork,
        Florida
    }

    public class ShippingInfoBefore
    {
        public decimal CalculateShippingAmount(StateBefore shipToState)
        {
            switch (shipToState)
            {
                case StateBefore.Alaska:
                    return GetAlaskaShippingAmount();
                case StateBefore.NewYork:
                    return GetNewYorkShippingAmount();
                case StateBefore.Florida:
                    return GetFloridaShippingAmount();
                default:
                    return 0m;
            }
        }

        private decimal GetAlaskaShippingAmount()
        {
            return 15m;
        }

        private decimal GetNewYorkShippingAmount()
        {
            return 10m;
        }

        private decimal GetFloridaShippingAmount()
        {
            return 3m;
        }
    }
}
