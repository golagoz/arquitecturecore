using System;
using System.Collections.Generic;

namespace Layer.DataAcces.Data
{
    public partial class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; } = null!;
    }
}
