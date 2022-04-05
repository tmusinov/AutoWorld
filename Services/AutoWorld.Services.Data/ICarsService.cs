namespace AutoWorld.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoWorld.Web.ViewModels.Cars;
    using AutoWorld.Web.ViewModels.Home;

    public interface ICarsService
    {
        Task AddCarAsync(CreateCarInputModel carInput, string userId, string picturePath);

        IEnumerable<T> GetAll<T>(int page, int itemsPerPage);

        IEnumerable<T> SearchCars<T>(CarsSearchInputModel car);

        int GetCount();

        T GetById<T>(int id);
    }
}
