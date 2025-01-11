using Sofbreak.OnionArch.DOMAIN.Entities.Concretes;
using Softbreak.OnionArch.CONTRACT.Repositories;
using Softbreak.OnionArch.Persistence.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.Persistence.Repositories
{
    public class OrderDetailRepository:BaseRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(MyContext context):base(context)
        {

        }
    }
}
