namespace AutoWorld.Data.Models
{
    using System.Collections.Generic;

    using AutoWorld.Data.Common.Models;

    public class Extra : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public ICollection<CarsExtras> CarsExtras { get; set; }
    }
}
