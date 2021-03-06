﻿namespace CinelAirMiles.Common.Entities
{
    using System.Collections.Generic;

    public class Partner : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Benefit> Benefits { get; set; }
    }
}
