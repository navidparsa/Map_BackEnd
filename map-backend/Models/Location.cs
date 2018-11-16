using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace map_backend.Models
{
    public class Location
    {
        public int ID { get; set; }
        public decimal lat { get; set; }
        public decimal lng { get; set; }
        public string label{ get; set; }
        public string OwnerId { get; set; }

    }
}
