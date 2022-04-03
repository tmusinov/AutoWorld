namespace AutoWorld.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoWorld.Data.Common.Repositories;
    using AutoWorld.Data.Models;
    using AutoWorld.Services.Mapping;

    public class MakesService : IMakesService
    {
        private readonly IDeletableEntityRepository<Make> makesRepository;

        public MakesService(IDeletableEntityRepository<Make> makesRepository)
        {
            this.makesRepository = makesRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            var query = this.makesRepository.All().OrderBy(x => x.Name);

            return query.To<T>().ToList();
        }
    }
}
