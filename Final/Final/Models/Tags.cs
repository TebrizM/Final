using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Tags
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List <Blog> Blogs { get; set; }
    }
}
