﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CinelAirMiles.Common.Models
{
    public class MilesViewModel
    {
        [Display(Name = "Quantity")]
        public int Miles { get; set; }


        public string Type { get; set; }


        [Display(Name = "Credit date")]
        public DateTime CreditDate { get; set; }


        [Display(Name = "Expiry date")]
        public DateTime ExpiryDate { get; set; }


        public string Description { get; set; }
    }
}