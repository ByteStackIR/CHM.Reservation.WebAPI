using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.PolicyTypes
{
    public static class PolicyTypes
    {
        public static class Users
        {
            public const string Manage = "users.add";
            public const string EditRole = "users.edit.role.policy";
        }

        public static class Teams
        {
            public const string Manage = "teams.manage.policy";

            public const string AddRemove = "teams.addremove.policy";
        }
    }
}
