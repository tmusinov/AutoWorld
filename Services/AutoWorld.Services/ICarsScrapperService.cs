namespace AutoWorld.Services
{
    using System.Collections.Concurrent;

    public interface ICarsScrapperService
    {
        ConcurrentBag<RawPropery> PopulateDb(int pagesCount);
    }
}
