using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Track : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 150)]
        public string Name { get; set; }
        public int AlbumId { get; set; }

        public int GenreId { get; set; }
        public int TrackLength { get; set; }
        public string PlayBtn { get; set; }
        public Genre Genre { get; set; }

        public Album Album { get; set; }

    }
}
