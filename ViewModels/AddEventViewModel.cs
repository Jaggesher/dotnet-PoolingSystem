using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace dotnet_PoolingSystem.Models
{
    public class AddEventViewModel
    {
        [Required]
        [StringLength(50, ErrorMessage ="Event Title cannot be longer than 50 characters")]
        [Display(Name = "Event Title")]
        public string Title { get; set; }

        [Required]
        [StringLength(1000,ErrorMessage ="Event Description  cannot be longer than 50 characters")]
        [Display(Name = "Event Description")]

        public String Description { get; set; }

        [Required]
        [Display(Name = "Start Date & Time")]
        public DateTime StartDateTime { get; set; }

        [Required]
        [Display(Name = "End Date & Time")]
        public DateTime EndDateTime { get; set; }

        [Required]
        [Display(Name ="Options")]
        public List<String> Options { get; set; }
    }
}