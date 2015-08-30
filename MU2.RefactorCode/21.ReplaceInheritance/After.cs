using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.ReplaceInheritance
{
    public class Sanitation
    {
        public string WashHands()
        {
            return "Cleaned!";
        }
    }

    public class Child
    {
        private Sanitation Sanitation { get; set; }

        public Child()
        {
            Sanitation = new Sanitation();
        }

        public string WashHands()
        {
            return Sanitation.WashHands();
        }
    }
}
