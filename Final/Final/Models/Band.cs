using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Band : BaseEntity
    {
        public string Name { get; set; }
        public List<Singer> Singers { get; set; }
    }
}
