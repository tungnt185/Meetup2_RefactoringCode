using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.ExtractInterface
{
    public class FileLoggingBefore
    {
        public bool Logging()
        {
            return true;
        }
    }

    public class RegistrationProcessorBefore
    {
        public bool Logging(FileLoggingBefore log)
        {
            return log.Logging();
        }
    }
}
