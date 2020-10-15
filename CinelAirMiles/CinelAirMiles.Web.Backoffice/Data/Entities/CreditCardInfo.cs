﻿using CinelAirMiles.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinelAirMiles.Web.Backoffice.Data.Entities
{
    public class CreditCardInfo : IEntity
    {
        public int Id { get; set; }


        public Client Client { get; set; }


        public int ClientId { get; set; }


        public string FirstName { get; set; }


        public string LastName { get; set; }


        public string Number { get; set; }


        public string CVC { get; set; }


        public string Month { get; set; }


        public string Year { get; set; }
    }
}
