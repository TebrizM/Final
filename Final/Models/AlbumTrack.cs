using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class AlbumTrack
    {

        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string TackName { get; set; }
        public string GeneratedSource { get; set; }
        [NotMapped]
        public IFormFile TrackSource { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
