using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.manage.ViewModels
{
    public class DashboardViewModel
    {
        public List<AppUser> Users { get; set; }
        public List<Album> Albums { get; set; }
        public List<Tours> Tours { get; set; }
        public List<Order> Order { get; set; }
        public List<Contact> Messages { get; set; }
        public List<WebSiteVisitor> Visitors { get; set; }
        public List<Genre> Genres { get; set; }



        public List<AppUser> JanuaryyUsers { get; set; }
        public List<AppUser> FebruaryyUsers { get; set; }
        public List<AppUser> MarchUsers { get; set; }
        public List<AppUser> AprilUsers { get; set; }
        public List<AppUser> MayUsers { get; set; }
        public List<AppUser> JuneUsers { get; set; }
        public List<AppUser> JulyUsers { get; set; } 
        public List<AppUser> AugustUsers { get; set; } 
        public List<AppUser> SeptemberUsers { get; set; } 
        public List<AppUser> OctoberUsers { get; set; }  
        public List<AppUser> NovemberUsers { get; set; }  
        public List<AppUser> DecemberUsers { get; set; }  
    }
}
