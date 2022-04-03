namespace AutoWorld.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoWorld.Web.ViewModels.Cars;

    public interface ICarsService
    {
        Task AddCarAsync(CarInputModel carInput, string userId);

        IEnumerable<T> GetAll<T>();
    }
}
