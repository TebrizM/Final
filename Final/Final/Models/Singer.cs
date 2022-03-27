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
        public byte Age { get; set; }
        public int GenderId {get;set;}
        public string Image { get; set; }
        public bool isBand { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public List<Track> Tracks { get; set; }
        public List<Album> Albums { get; set; }
        public Gender Gender { get; set; }
    }
}
