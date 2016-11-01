using System.Collections.Generic;
using System.Linq;

namespace MU2.RefactorCode.ParameterObject
{
    public class RegistrationBefore
    {
        public void Create(decimal amount, Student student,
         IEnumerable<Course> courses, decimal credits)
        {
            // do work
        }
    }

    public class Course
    {
    }

    public class Student
    {

    }
}