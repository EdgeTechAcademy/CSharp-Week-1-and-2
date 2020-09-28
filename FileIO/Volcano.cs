using System;
using System.Collections.Generic;
using System.Text;

namespace FileIO
{
    class Volcano
    {
        public string Country { get; set; }
        public int Death { get; set; }
        public int Elevation { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int VEI { get; set; }
        public int Year { get; set; }

        public Volcano(string country, int death, int elevation, string location, string name, string type, int vei, int year)
        {
            Country = country;
            Death = death;
            Elevation = elevation;
            Location = location;
            Name = name;
            Type = type;
            VEI = vei;
            Year = year;
        }

        public override string ToString()
        {
            return $"In {this.Year} a {this.Type} erupted in {this.Location} killing {this.Death} souls";
        }
    }
}
