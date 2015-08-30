using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.RemoveDuplication
{
    public class MedicalRecord
    {
        public DateTime DateArchived { get; private set; }
        public bool Archived { get; private set; }

        public void ArchiveRecord()
        {
            SwitchToArchived();
        }

        public void CloseRecord()
        {
            SwitchToArchived();
        }

        private void SwitchToArchived()
        {
            Archived = true;
            DateArchived = DateTime.Now;
        }
    }
}
