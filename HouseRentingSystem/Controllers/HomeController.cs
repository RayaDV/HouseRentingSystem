﻿using HouseRentingSystem.Core.Contracts.House;
using HouseRentingSystem.Core.Models.Home;
using HouseRentingSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HouseRentingSystem.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IHouseService houseService;
        public HomeController(IHouseService houseService)
        {
			this.houseService = houseService;
		}

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model = await houseService.LastThreeHouses();

            return View(model);
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
