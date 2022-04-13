namespace AutoWorld.Services.Data
{
    using System.Collections.Generic;

    using System.Threading.Tasks;

    using AutoWorld.Web.ViewModels.Cars;

    public interface IUsersService
    {
        IEnumerable<CarInListViewModel> GetAll(int page, int itemsPerPage, string userId);

        int GetCount(string userId);

        CarEditViewModel GetCarById(int carId);

        Task<string> AddCarToWatchlist(int id, string userId);
    }
}
