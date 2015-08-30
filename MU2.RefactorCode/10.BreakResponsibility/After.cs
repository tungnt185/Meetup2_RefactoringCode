using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.BreakResponsibility
{
    public class Video
    {
        public void RentVideo(Video video, Customer customer)
        {
            customer.Videos.Add(video);
        }
    }

    public class Customer
    {
        public IList<decimal> LateFees { get; set; }
        public IList<Video> Videos { get; set; }

        public void PayFee(decimal fee)
        {
        }

        public decimal CalculateBalance(Customer customer)
        {
            return customer.LateFees.Sum();
        }
    }
}
