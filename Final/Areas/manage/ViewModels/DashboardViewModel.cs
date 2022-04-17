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
        public List<Tours> Tours { get; set; }
        public List<Order> Order { get; set; }
        public List<Contact> Messages { get; set; }
        public List<WebSiteVisitor> Visitors { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
