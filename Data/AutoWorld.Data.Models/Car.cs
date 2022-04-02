﻿namespace AutoWorld.Data.Models
{
    using System.Collections.Generic;

    using AutoWorld.Data.Common.Models;

    public class Car : BaseDeletableModel<int>
    {
        public Car()
        {
            this.Pictures = new List<Picture>();
            this.Extras = new List<Extra>();
        }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int MakeId { get; set; }

        public virtual Make Make { get; set; }

        public int ModelId { get; set; }

        public virtual Model Model { get; set; }

        public string ImageUrl { get; set; }

        public string Modification { get; set; }

        public decimal Price { get; set; }

        public EngineType EngineType { get; set; }

        public Gearbox Gearbox { get; set; }

        public int Power { get; set; }

        public string Year { get; set; }

        public int Mileage { get; set; }

        public int Views { get; set; }

        public bool IsVIP { get; set; }

        public int ColorId { get; set; }

        public virtual Color Color { get; set; }

        public EuroStandard EuroStandard { get; set; }

        public Currency Currency { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }

        public virtual ICollection<Extra> Extras { get; set; }
    }
}