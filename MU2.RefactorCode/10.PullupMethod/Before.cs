using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.PullupMethod
{
    public abstract class VehicleBefore
    {
        // other methods
    }

    public class CarBefore : VehicleBefore
    {
        public void Turn(Direction direction)
        {
            // code here
        }
    }

    public class MotorcycleBefore : VehicleBefore
    {

    }

    public enum Direction
    {
        Left,
        Right
    }
}
