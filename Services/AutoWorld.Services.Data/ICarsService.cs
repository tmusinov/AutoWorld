namespace AutoWorld.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoWorld.Web.ViewModels.Cars;
    using AutoWorld.Web.ViewModels.Home;

    public interface ICarsService
    {
        Task AddCarAsync(CarInputModel carInput, string userId);

        IEnumerable<T> GetAll<T>();

        IEnumerable<T> SearchCars<T>(CarsSearchInputModel car);
    }
}
