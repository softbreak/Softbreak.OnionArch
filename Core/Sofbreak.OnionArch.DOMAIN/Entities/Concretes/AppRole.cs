using Sofbreak.OnionArch.DOMAIN.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sofbreak.OnionArch.DOMAIN.Entities.Concretes
{
    public class AppRole : BaseEntity
    {
        public string RoleName { get; set; }

        //Relational Properties
        public virtual ICollection<AppUserRole> AppUserRoles { get; set; }

    }
}
