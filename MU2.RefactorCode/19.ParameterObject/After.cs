using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.ParameterObject
{
    public class RegistrationContext
    {
        public decimal Amount { get; set; }
        public Student Student { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public decimal Credits { get; set; }
    }

    public class Registration
    {
        public void Create(RegistrationContext registrationContext)
        {
            // do work
        }
    }
}
