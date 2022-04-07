using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Singer : BaseEntity
    {

        public string Name { get; set; }
        public bool isBand { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public List<AlbumTrack> Tracks { get; set; }
        public List<Album> Albums { get; set; }

    }
}
