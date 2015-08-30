using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.ReplaceInheritance
{
    public class SanitationBefore
    {
        public string WashHands()
        {
            return "Cleaned!";
        }
    }

    public class ChildBefore : SanitationBefore
    {
    }
}
