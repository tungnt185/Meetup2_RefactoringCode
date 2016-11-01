using System.Collections.Generic;
using System.Linq;

namespace MU2.RefactorCode.RemoveMultipleIf
{
    public class SecurityBefore
    {
        public ISecurityChecker SecurityChecker { get; set; }

        public SecurityBefore(ISecurityChecker securityChecker)
        {
            SecurityChecker = securityChecker;
        }

        public bool HasAccess(User user, Permission permission,
        IEnumerable<Permission> exemptions)
        {
            bool hasPermission = false;

            if (user != null)
            {
                if (permission != null)
                {
                    if (exemptions.Count() == 0)
                    {
                        if (SecurityChecker.CheckPermission(user, permission) ||
                        exemptions.Contains(permission))
                        {
                            hasPermission = true;
                        }
                    }
                }
            }

            return hasPermission;
        }
    }

    public class User
    {
    }

    public class Permission
    {
    }

    public interface ISecurityChecker
    {
        bool CheckPermission(User user, Permission permission);
    }
}