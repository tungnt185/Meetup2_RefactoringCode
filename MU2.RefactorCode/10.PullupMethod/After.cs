using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.PullupMethod
{
    public abstract class Vehicle
    {
        public void Turn(Direction direction)
        {
            // code here
        }
    }

    public class Car : Vehicle
    {

    }

    public class Motorcycle : Vehicle
    {

    }
    
}
