using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.Rename
{
    /// <summary>
    /// Đổi tên class, property, function cho rõ ràng dễ đọc, dễ bảo trì sau này
    /// </summary>
    public class Employee
    {
        public string FirstName { get; set; }

        public decimal CalculateHourlyPay()
        {
            // code to calculate hourly payrate
            return 0m;
        }
    }
}
