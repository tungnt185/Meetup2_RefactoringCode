using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.EncapsulateCollection
{
    public class MedicalRecordBefore
    {
        public DateTime DateArchived { get; private set; }
        public bool Archived { get; private set; }

        public void ArchiveRecord()
        {
            Archived = true;
            DateArchived = DateTime.Now;
        }

        public void CloseRecord()
        {
            Archived = true;
            DateArchived = DateTime.Now;
        }
    }
}
