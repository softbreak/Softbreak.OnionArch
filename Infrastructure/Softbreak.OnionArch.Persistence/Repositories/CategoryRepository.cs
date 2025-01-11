﻿using Sofbreak.OnionArch.DOMAIN.Entities.Concretes;
using Softbreak.OnionArch.CONTRACT.Repositories;
using Softbreak.OnionArch.Persistence.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category> , ICategoryRepository
    {
        public CategoryRepository(MyContext context) : base(context)
        {

        }
    }
}
