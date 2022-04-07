using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Album : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        public int SingerId { get; set; }
        public string Image { get; set; }
        public string Desc { get; set; }
        public int GenreId { get; set; }
        [NotMapped]
        public IFormFile AlbumImage { get; set; }
        public Singer Singer { get; set; }
        public List<AlbumTrack> AlbumTracks { get; set; }
        public Genre Genres { get; set; }
    }
}
