namespace AutoWorld.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoWorld.Data.Common.Repositories;
    using AutoWorld.Data.Models;
    using AutoWorld.Services.Mapping;

    public class ColorsService : IColorsService
    {
        private readonly IRepository<Color> colorRepository;

        public ColorsService(IRepository<Color> colorRepository)
        {
            this.colorRepository = colorRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            var query = this.colorRepository.All();

            return query.To<T>().ToList();
        }
    }
}
