namespace AutoWorld.Web.ViewModels.Dealerships
{
    using System;

    using AutoMapper;
    using AutoWorld.Data.Models;
    using AutoWorld.Services.Mapping;

    public class DealershipInListViewModel : IMapFrom<Dealership>, IHaveCustomMappings
    {
        public string UserId { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string PhoneNumber { get; set; }

        public string LogoPictureUrl { get; set; }

        public string Description { get; set; }

        public string FullAddress { get; set; }

        public int Stars { get; set; }

        public DateTime DealerSince { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Dealership, DealershipInListViewModel>()
                .ForMember(x => x.LogoPictureUrl, opt =>
                    opt.MapFrom(x =>
                        "/images/dealerships/" + x.LogoPicture.Id + "." + x.LogoPicture.Extension));
        }
    }
}
