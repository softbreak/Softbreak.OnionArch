using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.APPLICATION.Dtos.AppUsers
{
    public class AppUserDto:BaseDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
