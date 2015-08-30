using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.ExtractFactory
{
    public class PoliceCarControllerBefore
    {
        public PoliceCar New(int mileage, bool serviceRequired)
        {
            PoliceCar policeCar = new PoliceCar();
            policeCar.ServiceRequired = serviceRequired;
            policeCar.Mileage = mileage;

            return policeCar;
        }

    }
    public class PoliceCar
    {
        public int Mileage { get; internal set; }
        public bool ReadForService { get; internal set; }
        public bool ServiceRequired { get; internal set; }
    }
}
