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

        public IEnumerable<T> GetAllNames<T>()
        {
            var query = this.makesRepository.AllAsNoTracking().OrderBy(x => x.Name);

            return query.To<T>().ToList();
        }

        public ICollection<string> GetMakeModels(string makeName)
        {
            var make = this.makesRepository.All().Where(x => x.Name == makeName).Select(x => x.Models.Select(d => d.Name)).First();
            return make.ToList();
        }
    }
}
