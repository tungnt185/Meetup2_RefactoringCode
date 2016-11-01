using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.PushdownMethod
{
    public abstract class AnimalBefore
    {
        public void Bark()
        {
            // code to bark
        }
    }

    public class DogBefore : AnimalBefore
    {

    }

    public class CatBefore : AnimalBefore
    {

    }
}
