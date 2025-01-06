using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sofbreak.OnionArch.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.Persistence.Configurations
{
    public class AppUserRoleConfiguration : BaseConfiguration<AppUserRole>
    {
        public override void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            base.Configure(builder);
            //builder.Ignore(x => x.Id);

            //builder.HasKey(x => new
            //{
            //    x.UserId,
            //    x.RoleId
            //});
        }
    }
}
