namespace AutoWorld.Web.ViewModels.Dealerships
{
    using System;
    using System.Collections.Generic;

    using AutoWorld.Data.Models;
    using AutoWorld.Services.Mapping;
    using AutoWorld.Web.ViewModels.Cars;

    public class SingleDealershipViewModel : PagingViewModel, IMapFrom<Dealership>, IMapFrom<Car>
    {
        public IEnumerable<CarInListViewModel> DealershipCars { get; set; }

        public virtual DealershipInfoViewModel DealershipInfo { get; set; }
    }
}
