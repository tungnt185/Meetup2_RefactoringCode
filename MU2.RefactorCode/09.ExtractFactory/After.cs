using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.ExtractFactory
{
    
    public class PoliceCarController
    {
        public PoliceCar New(int mileage, bool serviceRequired)
        {
            return InitializeObjectFactory.CreatePoliceCar(mileage, serviceRequired);
        }
    }

    internal class InitializeObjectFactory
    {

        internal static PoliceCar CreateBus()
        {
            throw new NotImplementedException();
        }

        internal static PoliceCar CreatePoliceCar(int mileage, bool serviceRequired)
        {
            throw new NotImplementedException();
        }
    }
}
