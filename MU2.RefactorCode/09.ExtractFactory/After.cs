using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.ExtractFactory
{
    /// <summary>
    /// Sử dụng factory cho việc khởi tạo đối tượng để việc khởi tạo đối tượng tập trung ở một nơi. 
    /// Tuân thủ đúng nguyên lý Single Responsibility Principle
    /// Class sử dụng đối tượng không cần quan tâm đối tượng đó được khởi tạo như thế nào, nó chỉ cần có đối tượng đó để bắt đầu làm việc.
    /// </summary>
    public class PoliceCarController
    {
        public PoliceCar New(int mileage, bool serviceRequired)
        {
            return InitializeObjectFactory.CreatePoliceCar(mileage, serviceRequired);
        }
    }

    internal class InitializeObjectFactory
    {

        internal static PoliceCar CreateBus()
        {
            throw new NotImplementedException();
        }

        internal static PoliceCar CreatePoliceCar(int mileage, bool serviceRequired)
        {
            throw new NotImplementedException();
        }
    }
}
