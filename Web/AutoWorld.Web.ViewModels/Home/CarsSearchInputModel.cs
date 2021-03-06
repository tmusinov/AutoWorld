namespace AutoWorld.Web.ViewModels.Home
{
    using System.Collections.Generic;

    using AutoWorld.Data.Models;
    using AutoWorld.Web.ViewModels.Cars;

    public class CarsSearchInputModel : PagingViewModel
    {
        public IEnumerable<CarInListViewModel> Cars { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public decimal MinPrice { get; set; }

        public decimal MaxPrice { get; set; }

        public int Year { get; set; }

        public EngineType EngineType { get; set; }

        public Gearbox Gearbox { get; set; }
    }
}
