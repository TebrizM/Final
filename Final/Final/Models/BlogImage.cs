using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class BlogImage
    {
        public string Image { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
