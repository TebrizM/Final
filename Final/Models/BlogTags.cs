using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class BlogTags
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public int TagsId { get; set; }
        public Blog Blog { get; set; }  
        public Tags Tag { get; set; }
    }
}
