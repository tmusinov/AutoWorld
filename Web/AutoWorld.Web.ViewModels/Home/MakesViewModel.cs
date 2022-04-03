namespace AutoWorld.Web.ViewModels.Home
{
    using System.Collections.Generic;

    using AutoWorld.Data.Models;
    using AutoWorld.Services.Mapping;

    public class MakesViewModel : IMapFrom<Make>
    {
        public string Name { get; set; }
    }
}
