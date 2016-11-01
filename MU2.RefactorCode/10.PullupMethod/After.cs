using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.PullupMethod
{
    /// <summary>
    /// Sử dụng khi mà một phương thức cần được sử dụng ở nhiều class kế thừa
    /// Cần phân tích kỹ khi sử dụng vì nó sẽ làm tăng độ phức tạp của code base 
    /// </summary>
    public abstract class Vehicle
    {
        public void Turn(Direction direction)
        {
            // code here
        }
    }

    public class Car : Vehicle
    {

    }

    public class Motorcycle : Vehicle
    {

    }
    
}
