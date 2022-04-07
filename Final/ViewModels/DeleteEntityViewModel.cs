using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.ViewModels
{
    public class DeleteEntityViewModel
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
    }
}
