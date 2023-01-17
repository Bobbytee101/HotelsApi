using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsApi.Models.Country
{
    public class country
    {
        public int Id { get; set; }
        public List<Hotels> Hotels { get; set; }
    }
}
