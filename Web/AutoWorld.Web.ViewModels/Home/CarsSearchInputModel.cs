﻿namespace AutoWorld.Web.ViewModels.Home
{
    using AutoWorld.Data.Models;

    public class CarsSearchInputModel
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public int Year { get; set; }

        public EngineType EngineType { get; set; }

        public Gearbox Gearbox { get; set; }
    }
}