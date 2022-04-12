using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.ViewModels
{
    public class OrderViewModel
    {
        public List<OrderItemViewModel> OrderItems { get; set; }
        public decimal TotalPrice { get; set; }
        public ToursViewModel ToursViewModels {get;set;}
    }
}
