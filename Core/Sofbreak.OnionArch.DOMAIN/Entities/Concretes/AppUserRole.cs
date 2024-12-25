using Sofbreak.OnionArch.DOMAIN.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sofbreak.OnionArch.DOMAIN.Entities.Concretes
{
    public class AppUserRole: BaseEntity
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        //Relational Properties
        public virtual AppUser AppUsers { get; set; }
        public virtual AppRole AppRoles { get; set; }

    }
}
