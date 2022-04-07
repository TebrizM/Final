using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.ViewModels
{
    public class BlogDetailViewModel
    {
        public Blog Blogs { get; set; }
        public List<Blog> Blog { get; set; }
        public BlogComment BlogComments { get; set; }
        public Tags Tags { get; set; }
    }
}
