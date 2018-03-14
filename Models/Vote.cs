using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_PoolingSystem.Models
{
    public class Vote
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Roll { get; set; }
        public String EventId { get; set; }
        public Event Event {get; set;}
        
    }
}