﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CinelAirMiles.Web.Frontoffice.Models
{
    public class NewsChannelViewModel
    {
        [XmlElement("item")]
        public List<NewsItemViewModel> Item { get; set; }
    }
}
