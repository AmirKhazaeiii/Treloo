using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Context
{
    public class UserRoleContext
    {
        private IRoleService iroleService;
        public UserRoleContext(IRoleService roleService)
        {
            this.iroleService = roleService;
        }
        public string getRoleName()
        {
            return iroleService.getRoleName();
        }
    }
}
