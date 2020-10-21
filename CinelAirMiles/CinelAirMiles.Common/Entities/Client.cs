﻿namespace CinelAirMiles.Common.Entities
{
    using System;
    using System.Collections.Generic;

    public class Client : IEntity
    {
        public int Id { get; set; }


        public User User { get; set; }


        public string UserId { get; set; }


        public IEnumerable<Mile> Miles { get; set; }


        public int FlownSegments { get; set; }


        public bool Active { get; set; }


        public string MilesProgramNumber { get; set; }


        public bool IsInReferrerProgram { get; set; }


        public DateTime MembershipDate { get; set; }


        public ProgramTier ProgramTier { get; set; }


        public int ProgramTierId { get; set; }
    }
}