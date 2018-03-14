using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_PoolingSystem.Models
{
    public class Option
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public String EventId { get; set; }

        public Event Event { get; set; }
        
    }
}