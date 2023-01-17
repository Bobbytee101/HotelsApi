using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsApi.Models
{
    public class Hotels
    {
      
        public int Id { get; set; }
       
        public string Name { get; set; }
        
        public string Address { get; set; }

        public double Rating { get; set; }

        public int CountryId { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Completed { get; set; }

    }
}
