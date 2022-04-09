namespace AutoWorld.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoWorld.Data.Models;
    using AutoWorld.Web.ViewModels.Cars;
    using AutoWorld.Web.ViewModels.Dealerships;

    public interface IDealershipsService
    {

        Task<bool> CreateDealershipAsync(CreateDealershipInputModel input, ApplicationUser user, string picturePath);

        IEnumerable<T> GetAll<T>(int page, int itemsPerPage);

        Task<IEnumerable<CarInListViewModel>> GetAllDealershipCars(int page, string dealershipId, string userId, int itemsPerPage);

        T GetById<T>(string id);

        int GetCount();

        int GetDealershipsCarsCount(string dealershipId);

        DealershipInfoViewModel GetDealershipInfo(string id);
    }
}
