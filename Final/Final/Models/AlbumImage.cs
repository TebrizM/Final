using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class AlbumImage : BaseEntity
    {
        public string Image { get; set; }
        public int AlbumId { get; set; }
        public bool? AlbumStatus { get; set; }

        public Album Album { get; set; }
    }
}
