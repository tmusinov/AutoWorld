﻿namespace AutoWorld.Web.Controllers
{
    using AutoWorld.Services;
    using Microsoft.AspNetCore.Mvc;

    public class TestController : Controller
    {
        private readonly ICarsScrapperService carsScrapperService;

        public TestController(ICarsScrapperService carsScrapperService)
        {
            this.carsScrapperService = carsScrapperService;
        }

        public IActionResult PopulateDb()
        {
            this.carsScrapperService.PopulateDb(10);
            return this.View();
        }
    }
}