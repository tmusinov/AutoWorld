namespace AutoWorld.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum Currency
    {
        [Display(Name = "")]
        Unknown = 0,
        [Display(Name = "лв.")]
        BGN = 1,
        USD = 2,
        EUR = 3,
    }
}
