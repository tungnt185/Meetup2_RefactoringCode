using System.Collections.Generic;
using System.Linq;

namespace MU2.RefactorCode.BreakResponsibility
{
    public class VideoBefore
    {
        public void PayFee(decimal fee)
        {
        }

        public void RentVideo(VideoBefore video, CustomerBefore customer)
        {
            customer.Videos.Add(video);
        }

        public decimal CalculateBalance(CustomerBefore customer)
        {
            return customer.LateFees.Sum();
        }
    }

    public class CustomerBefore
    {
        public IList<decimal> LateFees { get; set; }
        public IList<VideoBefore> Videos { get; set; }
    }
}