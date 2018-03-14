using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_PoolingSystem.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public String Description { get; set; }

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public ICollection<Option> Options { get; set; }
    }
}