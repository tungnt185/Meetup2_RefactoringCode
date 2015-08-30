using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.ExceptionToConditional
{
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
