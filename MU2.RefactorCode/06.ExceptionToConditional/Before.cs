using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.ExceptionToConditional
{
    public class MicrowaveBefore
    {
        private bool foodcooked;

        private IMicrowaveMotor Motor { get; set; }

        public bool Start(object food)
        {
            bool foodCooked = false;
            try
            {
                Motor.Cook(food);
                foodCooked = true;
            }
            catch (InUseException)
            {
                foodcooked = false;
            }

            return foodCooked;
        }

       
    }

    public interface IMicrowaveMotor
    {
        bool IsInUse { get; set; }

        void Cook(object food);
    }

    [Serializable]
    public class InUseException : Exception
    {
        public InUseException()
        {
        }

        public InUseException(string message) : base(message)
        {
        }

        public InUseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InUseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
