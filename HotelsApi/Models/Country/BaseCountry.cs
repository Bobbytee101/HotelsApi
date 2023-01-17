using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsApi.Models.Country
{
    public class BaseCountry
    {
        [Required]
        public string name { get; set; }
        public string ShortName { get; set; }
    }
}
