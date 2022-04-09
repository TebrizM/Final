using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.ViewModels
{
    public class CheckoutViewModel
    {
        public OrderViewModel Orders { get; set; }
        public Order Order { get; set; }
    }
}
