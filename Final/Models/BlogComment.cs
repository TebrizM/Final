using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class BlogComment
    {
        public int Id { get; set; }
        public int BlogId { get; set; }

        public string AppUserId { get; set; }

        public AppUser AppUser { get; set; }
        public Blog Blog { get; set; }
        [Range(1, 5)]
        public byte Rate { get; set; }
        public DateTime CreatedAt { get; set; }
        [StringLength(maximumLength: 350)]
        public string Text { get; set; }
    }
}
