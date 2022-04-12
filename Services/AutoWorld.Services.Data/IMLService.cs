namespace AutoWorld.Services.Data
{
    using AutoWorld.Web.ViewModels.Cars;

    public interface IMLService
    {
        MLCarDTO GetValues(CarPredictInputModel input);
    }
}