using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Contact : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Text { get; set; }
    }
}
