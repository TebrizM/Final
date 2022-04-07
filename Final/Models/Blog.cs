using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Blog : BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public string Desc { get; set; }
        public string Quote { get; set; }
        [NotMapped]
        public IFormFile BlogImage { get; set; }
        public List<BlogComment> BlogComments { get; set; }
        public List<BlogTags> BlogTags { get; set; }
 
        [NotMapped]
        public List<int> TagIds { get; set; }

    }
}
