namespace AutoWorld.Web.ViewModels.Cars
{
    using System;
    using System.Linq;

    using AutoMapper;
    using AutoWorld.Data.Models;
    using AutoWorld.Services.Mapping;

    public class CarInListViewModel : IMapFrom<Car>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string PictureUrl { get; set; }

        public string MakeName { get; set; }

        public string ModelName { get; set; }

        public DateTime CreatedOn { get; set; }

        public decimal Price { get; set; }

        public string Modification { get; set; }

        public string CarTitle => string.Concat(this.MakeName + " " + this.ModelName + " " + this.Modification).Substring(0, 18) + "...";

        public string Description { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Car, CarInListViewModel>()
                .ForMember(x => x.PictureUrl, opt =>
                    opt.MapFrom(x =>
                        x.ImageUrl != null ?
                        x.ImageUrl :
                        "/images/recipes/" + x.Pictures.FirstOrDefault().Id + "." + x.Pictures.FirstOrDefault().Extension));
        }
    }
}
