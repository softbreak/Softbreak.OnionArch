﻿using Sofbreak.OnionArch.DOMAIN.Entities.Concretes;
using Softbreak.OnionArch.APPLICATION.Dtos.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.APPLICATION.Managers
{
    public interface IProfileManager:IManager<AppUserProfile,ProfileDto>
    {
    }
}