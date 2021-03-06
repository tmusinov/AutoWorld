namespace AutoWorld.Web.ViewModels.Cars
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using AutoWorld.Data.Models;
    using AutoWorld.Services.Mapping;
    using AutoWorld.Web.ViewModels.Colors;
    using AutoWorld.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Http;

    public class CarEditViewModel : IMapFrom<Car>
    {
        public IEnumerable<MakesViewModel> Makes { get; set; }

        public IEnumerable<ColorsViewModel> Colors { get; set; }

        public int Id { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        public string Modification { get; set; }

        [Required]
        [Display(Name = "Engine type")]
        [Range(1, 7, ErrorMessage = "Select engine type.")]
        public EngineType EngineType { get; set; }

        [Display(Name = "Power [hp]")]
        public int Power { get; set; }

        public EuroStandard EuroStandard { get; set; }

        [Required]
        [Range(1, 3, ErrorMessage = "Select gearbox.")]
        public Gearbox Gearbox { get; set; }

        [Required]
        [Range(1, 11, ErrorMessage = "Select category.")]
        public Category Category { get; set; }

        [Required]
        [Range(300, 2_000_000, ErrorMessage = "The field Price must be between 300 and 2 000 000.")]
        public int Price { get; set; }

        [Required]
        [Range(1, 3, ErrorMessage = "Select currency.")]
        public Currency Currency { get; set; }

        [Display(Name = "Production month")]
        [Required(ErrorMessage = "Production month is required")]
        public string Month { get; set; }

        [Display(Name = "Production year")]
        [Required(ErrorMessage = "Production year is required")]
        public string Year { get; set; }

        [Required]
        [Display(Name = "Mileage [km]")]
        [Range(1, 10_000_00)]
        public int Mileage { get; set; }

        public string Color { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Validity { get; set; }

        [Required]
        public string Condition { get; set; }

        public bool IsVIP { get; set; }

        public string Description { get; set; }
    }
}
