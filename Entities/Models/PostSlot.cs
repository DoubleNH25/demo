using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PostSlot
    {
        public string? DateSlot { get; set; }
        public List<string> slot { get; set; } = new List<string>();
        public string? PricePerSlot { get; set; }
    }
}
