using Microsoft.AspNetCore.Identity;
using Sofbreak.OnionArch.DOMAIN.Entities.Abstracts;
using Sofbreak.OnionArch.DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sofbreak.OnionArch.DOMAIN.Entities.Concretes
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }


        //Relational Properties
        public virtual AppUserProfile Profile { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<AppUserRole> AppUserRoles { get; set; }


    }
}
