using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Blog : BaseEntity
    {
        public string Name { get; set; }

        public List<BlogImage> BlogImages { get; set; }
        public List<BlogComment> BlogComments { get; set; }

    }
}
