namespace AutoWorld.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoWorld.Data.Common.Repositories;
    using AutoWorld.Data.Models;
    using AutoWorld.Services.Mapping;
    using AutoWorld.Web.ViewModels.Cars;
    using AutoWorld.Web.ViewModels.Colors;
    using AutoWorld.Web.ViewModels.Home;
    using Microsoft.EntityFrameworkCore;

    public class UsersService : IUsersService
    {
        private readonly IDeletableEntityRepository<Car> carRepository;
        private readonly IRepository<Color> colorRepository;
        private readonly IDeletableEntityRepository<Make> makeRepository;
        private readonly IRepository<ApplicationUser> userRepository;
        private readonly IRepository<Watchlist> watchlistRepository;

        public UsersService(
            IDeletableEntityRepository<Car> carRepository,
            IRepository<Color> colorRepository,
            IDeletableEntityRepository<Make> makeRepository,
            IRepository<ApplicationUser> userRepository,
            IRepository<Watchlist> watchlistRepository)
        {
            this.carRepository = carRepository;
            this.colorRepository = colorRepository;
            this.makeRepository = makeRepository;
            this.userRepository = userRepository;
            this.watchlistRepository = watchlistRepository;
        }

        public async Task<string> AddCarToWatchlist(int id, string userId)
        {
            var user = this.userRepository.All().Where(x => x.Id == userId).Select(x => new { x.Id, x.Watchlists }).First();

            if (!user.Watchlists.Any(x => x.UserId == user.Id && x.CarId == id))
            {
                var watchlist = new Watchlist { CarId = id, UserId = user.Id };

                await this.watchlistRepository.AddAsync(watchlist);
                await this.watchlistRepository.SaveChangesAsync();

                return "created";
            }
            else
            {
                var watchlist = this.watchlistRepository.All().Where(x => x.CarId == id && x.UserId == userId).First();

                this.watchlistRepository.Delete(watchlist);
                await this.watchlistRepository.SaveChangesAsync();

                return "deleted";
            }
        }

        public IEnumerable<CarInListViewModel> GetAll(int page, int itemsPerPage, string userId)
        {
            var cars = this.carRepository.AllAsNoTracking()
                .Where(x => x.UserId == userId)
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .Select(x => new CarInListViewModel
                {
                    Id = x.Id,
                    IsInWatchlist = this.watchlistRepository.All().Any(d => d.UserId == userId && d.CarId == x.Id),
                    MakeName = x.Make.Name,
                    ModelName = x.Model.Name,
                    Modification = x.Modification,
                    Year = x.Year,
                    Location = x.Location,
                    Mileage = x.Mileage,
                    ColorName = x.Color.Name,
                    UserPhoneNumber = x.User.PhoneNumber,
                    Currency = x.Currency.ToString(),
                    CreatedOn = x.CreatedOn,
                    Price = x.Price,
                    Description = x.Description,
                    PictureUrl = x.ImageUrl != null ? x.ImageUrl : "/images/cars/" + x.Pictures.OrderBy(x => x.CreatedOn).FirstOrDefault().Id + "." + x.Pictures.OrderBy(x => x.CreatedOn).FirstOrDefault().Extension,
                })
                .ToList();
            return cars;
        }

        public CarEditViewModel GetCarById(int carId)
        {
            var car = this.carRepository.AllAsNoTracking().Where(x => x.Id == carId)
                .Select(x => new CarEditViewModel
                {
                    Make = x.Make.Name,
                    Model = x.Model.Name,
                    Modification = x.Modification,
                    Year = x.Year.ToString(),
                    Gearbox = x.Gearbox,
                    Currency = x.Currency,
                    EngineType = x.EngineType,
                    EuroStandard = x.EuroStandard,
                    Location = x.Location,
                    Power = (int)x.Power,
                    Price = (int)x.Price,
                    Description = x.Description,
                    Makes = this.makeRepository.AllAsNoTracking().Select(x => new MakesViewModel { Name = x.Name }).ToList(),
                    Colors = this.colorRepository.AllAsNoTracking().Select(x => new ColorsViewModel { Name = x.Name }).ToList(),
                }).FirstOrDefault();

            return car;
        }

        public int GetCount(string userId)
        {
            return this.carRepository.AllAsNoTracking().Where(x => x.UserId == userId).Count();
        }
    }
}
