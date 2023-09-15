using xyLOGIX.Data.Scrapers.Interfaces;
using xyLOGIX.Data.Scrapers.Services.Factories.Interfaces;

namespace xyLOGIX.Data.Scrapers.Services.Factories
{
///  <summary> Creates instances of objects that implement the <see cref="T:xyLOGIX.Data.Scrapers.Interfaces.IScraperService" /> interface. </summary>
    public class ScraperServiceFactory : IScraperServiceFactory
    {
///  <summary> Creates a new instance of an object that implements the <see cref="T:xyLOGIX.Data.Scrapers.Interfaces.IScraperService" /> interface and returns a reference to it. </summary> <returns> Reference to a new instance of an object that implements the <see cref="T:xyLOGIX.Data.Scrapers.Interfaces.IScraperService" /> interface. </returns>
        public IScraperService Make()
            => new ScraperService();
    }
}
