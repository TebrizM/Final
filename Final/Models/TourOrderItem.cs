using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class TourOrderItem
    {
        public int Id { get; set; }

        public string AppUserId { get; set; }
        public int ToursId { get; set; }
        public int Count { get; set; }
        public DateTime CreatedAt { get; set; }

        public AppUser AppUser { get; set; }
        public Tours Tours { get; set; }
    }
}
