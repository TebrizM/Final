using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Tags : BaseEntity
    {
   
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
