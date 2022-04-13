namespace AutoWorld.Services.Data
{
    using System.Linq;

    using AutoWorld.Web.ViewModels.Cars;
    using AutoWorld.Web.ViewModels.Home;

    public interface ICommonService
    {
        IQueryable<CarInListViewModel> Filter(IQueryable<CarInListViewModel> query, CarsSearchInputModel car, int page, int itemsPerPage);
    }
}
