using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.RemoveMultipleIf
{
    public class Security
    {
        public ISecurityChecker SecurityChecker { get; set; }

        public Security(ISecurityChecker securityChecker)
        {
            SecurityChecker = securityChecker;
        }

        public bool HasAccess(User user, Permission permission,
        IEnumerable<Permission> exemptions)
        {
            if (user == null || permission == null)
                return false;

            if (exemptions.Contains(permission))
                return true;

            return SecurityChecker.CheckPermission(user, permission);
        }
    }
}
