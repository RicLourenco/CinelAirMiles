﻿using CinelAirMiles.Common.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinelAirMiles.Web.Frontoffice.Controllers
{
    public class PartnersController : Controller
    {
        private readonly IPartnerRepository _partnerRepository;

        public PartnersController(
            IPartnerRepository partnerRepository)
        {
            _partnerRepository = partnerRepository;
        }

        // GET: Partners
        public async Task<IActionResult> Index()
        {
            return View(await _partnerRepository.GetAll().ToListAsync());
        }
    }
}
