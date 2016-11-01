using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.ExtractInterface
{
    /// <summary>
    /// Kỹ thuật này giúp code trở nên rất linh hoạt dễ bảo trì mở rộng khi cần.
    /// Giúp code loose coupling và dễ dàng áp dụng unit test khi cần
    /// </summary>
    public interface ILogging
    {
        bool Logging();
    }

    public class FileLogging : ILogging
    {
        public bool Logging()
        {
            //Log vao file
            return true;
        }
    }
    public class DatabaseLogging : ILogging
    {
        public bool Logging()
        {
            //Log vao Database
            return true;
        }
    }

    public class RegistrationProcessor
    {
        public bool Logging(ILogging log)
        {
            return log.Logging();
        }
    }

    public class Test
    {
        void RegisterUser()
        {
            RegistrationProcessor registrationProcess = new RegistrationProcessor();
            FileLogging fileLog = new FileLogging();
            DatabaseLogging dbLog = new DatabaseLogging();
            registrationProcess.Logging(dbLog);
        }
    }
}
