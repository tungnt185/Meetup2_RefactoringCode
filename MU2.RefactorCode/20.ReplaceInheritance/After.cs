using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.ReplaceInheritance
{
    /// <summary>
    /// Tuân thủ nguyên lý kế thừa của OOP
    /// Class cha phải là class bao hàm ý nghĩa của class con
    /// Nếu không thì cần chuyển sang sử dụng quan hệ composition tức là class này sẽ sử dụng class kia
    /// </summary>
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
