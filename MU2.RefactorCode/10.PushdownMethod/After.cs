using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.PushdownMethod
{
    /// <summary>
    /// Ngược lại của pullup là pushdown method.
    /// Giảm độ phức tạp của code base khi có những hàm không cần sử dụng cho nhiều lớp con
    /// </summary>
    public abstract class Animal
    {
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            // code to bark
        }
    }

    public class Cat : Animal
    {
    }
}
