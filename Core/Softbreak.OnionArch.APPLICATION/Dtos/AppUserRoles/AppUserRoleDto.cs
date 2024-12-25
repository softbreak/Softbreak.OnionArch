using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.APPLICATION.Dtos.AppUserRoles
{
    public  class AppUserRoleDto:BaseDto
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
