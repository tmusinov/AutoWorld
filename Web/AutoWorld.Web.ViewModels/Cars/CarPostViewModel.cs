namespace AutoWorld.Web.ViewModels.Cars
{
    using System.Collections.Generic;

    using AutoWorld.Web.ViewModels.Colors;
    using AutoWorld.Web.ViewModels.Home;

    public class CarPostViewModel
    {
        public IEnumerable<MakesViewModel> Makes { get; set; }

        public IEnumerable<ColorsViewModel> Colors { get; set; }
    }
}
