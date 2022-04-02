namespace AutoWorld.Data.Models
{
    using AutoWorld.Data.Common.Models;

    public class Extra : BaseDeletableModel<int>
    {
        public string Type { get; set; }

        public string Name { get; set; }
    }
}
