using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.APPLICATION.Dtos.Orders
{
    public class OrderDto:BaseDto
    {
        public string ShippedAddress { get; set; }
        public int? AppUserId { get; set; }
    }
}
