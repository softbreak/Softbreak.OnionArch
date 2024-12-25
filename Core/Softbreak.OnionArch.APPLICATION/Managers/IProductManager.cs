using Sofbreak.OnionArch.DOMAIN.Entities.Concretes;
using Softbreak.OnionArch.APPLICATION.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.APPLICATION.Managers
{
    public interface IProductManager: IManager<Product,ProductDto>
    {
    }
}
