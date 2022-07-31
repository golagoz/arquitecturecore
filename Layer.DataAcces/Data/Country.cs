using System;
using System.Collections.Generic;

namespace Layer.DataAcces.Data
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Iso2 { get; set; } = null!;
        public string Iso3 { get; set; } = null!;

        public virtual ICollection<City> Cities { get; set; }
    }
}
