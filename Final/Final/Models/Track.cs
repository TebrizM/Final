using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Track : BaseEntity
    {
       public string Name { get; set; }
        public string SingerId { get; set; }

        public int TrackLength { get; set; }
       public string PlayBtn { get; set; }
        
        public Singer Singer { get; set; }
    }
}
