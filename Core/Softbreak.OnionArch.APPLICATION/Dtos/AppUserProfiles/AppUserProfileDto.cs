using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.APPLICATION.Dtos.AppUserProfiles
{
    public class AppUserProfileDto : BaseDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
