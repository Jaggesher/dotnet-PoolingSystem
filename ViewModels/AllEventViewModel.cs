using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace dotnet_PoolingSystem.Models
{
    public class AllEventViewModel
    {
        [Required]
        [StringLength(50, ErrorMessage ="Roll cannot be longer than 50 characters")]
        [Display(Name = "Your Roll")]
        public string Roll { get; set; }

        [Required]
        public Guid EventId { get; set; }

        [Required]
        public Guid OptionId {get; set; }

        public IEnumerable<Event> Events { get; set; }
        
    }
}