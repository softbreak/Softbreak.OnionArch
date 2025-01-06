using AutoMapper;
using Sofbreak.OnionArch.DOMAIN.Entities.Concretes;
using Softbreak.OnionArch.APPLICATION.Dtos.AppRoles;
using Softbreak.OnionArch.APPLICATION.Dtos.AppUserProfiles;
using Softbreak.OnionArch.APPLICATION.Dtos.AppUserRoles;
using Softbreak.OnionArch.APPLICATION.Dtos.AppUsers;
using Softbreak.OnionArch.APPLICATION.Dtos.Categories;
using Softbreak.OnionArch.APPLICATION.Dtos.OrderDetails;
using Softbreak.OnionArch.APPLICATION.Dtos.Orders;
using Softbreak.OnionArch.APPLICATION.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.APPLICATION.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            #region ProductMapping
            CreateMap<Product, ProductDto>().ReverseMap();
            #endregion

            #region CategoryMapping
            CreateMap<Category, CategoryDto>().ReverseMap();
            #endregion

            #region OrderMapping

            CreateMap<Order, OrderDto>().ReverseMap();
            #endregion

            #region OrderDetailMapping
            CreateMap<OrderDetail, OrderDetailDto>().ReverseMap();
            #endregion

            #region AppRoleMapping
            CreateMap<AppRole, AppRoleDto>().ReverseMap();

            #endregion

            #region AppUserMapping
            CreateMap<AppUser, AppUserDto>().ReverseMap();
            #endregion

            #region AppUserRoleMapping
            CreateMap<AppUserRole, AppUserRoleDto>().ReverseMap();
            #endregion

            #region AppUserProfileMapping
            CreateMap<AppUserProfile, AppUserProfileDto>().ReverseMap();
            #endregion
        }
    }
}
