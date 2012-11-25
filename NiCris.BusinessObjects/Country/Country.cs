using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NiCris.BusinessObjects
{
    public class Country : Entity
    {
        // public Continent Continent { get; set; }
        public int continentId { get; set; }

        public string name { get; set; }
        public string image { get; set; }
        
        public string capital { get; set; }
        public string population { get; set; }
        public string gdp { get; set; }

        public bool visited { get; set; }
    }
}
