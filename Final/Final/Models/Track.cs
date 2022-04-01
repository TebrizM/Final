using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Track : BaseEntity
    {
        [StringLength(maximumLength: 150)]
        public string Name { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
