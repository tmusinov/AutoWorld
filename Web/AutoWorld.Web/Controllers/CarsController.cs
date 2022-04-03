namespace AutoWorld.Web.Controllers
{
    using System.Threading.Tasks;

    using AutoWorld.Data.Models;
    using AutoWorld.Services.Data;
    using AutoWorld.Web.ViewModels.Cars;
    using AutoWorld.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class CarsController : Controller
    {
        private readonly IMakesService makesService;
        private readonly ICarsService carsService;
        private readonly UserManager<ApplicationUser> userManager;

        public CarsController(IMakesService makesService, ICarsService carsService, UserManager<ApplicationUser> userManager)
        {
            this.makesService = makesService;
            this.carsService = carsService;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Cars()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult PostCar()
        {
            var viewModel = this.makesService.GetAllNames<MakesViewModel>();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> PostCar(CarInputModel car)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var userId = this.userManager.GetUserId(this.User);

            await this.carsService.AddCarAsync(car, userId);

            return this.Redirect("/");
        }
    }
}
