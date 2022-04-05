namespace AutoWorld.Web.ViewModels.Colors
{
    using AutoWorld.Data.Models;
    using AutoWorld.Services.Mapping;

    public class ColorsViewModel : IMapFrom<Color>
    {
        public string Name { get; set; }
    }
}
