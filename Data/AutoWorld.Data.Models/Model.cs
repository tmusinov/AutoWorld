namespace AutoWorld.Data.Models
{
    using AutoWorld.Data.Common.Models;

    public class Model : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public int MakeId { get; set; }

        public Make Make { get; set; }
    }
}
