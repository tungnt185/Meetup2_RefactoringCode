using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.ExceptionToConditional
{
    /// <summary>
    /// Tránh việc dùng exception để control flow vì exception sẽ gây tốn performance
    /// Exception chỉ nên dùng đúng mục đích của nó là để xử lý exception
    /// Chúng ta có thể thực hiện kiểm tra trạng thái của đối tượng trước khi thực hiện action thay vì để exception xử lý chúng.
    /// </summary>
    public class Microwave
    {
        private IMicrowaveMotor Motor { get; set; }

        public bool Start(object food)
        {
            if (Motor.IsInUse)
                return false;

            Motor.Cook(food);

            return true;
        }
    }
}
