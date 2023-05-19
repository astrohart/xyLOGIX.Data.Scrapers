using xyLOGIX.Data.Scrapers.Interfaces;
using xyLOGIX.Data.Scrapers.Services.Factories.Interfaces;

namespace xyLOGIX.Data.Scrapers.Services.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:xyLOGIX.Data.Scrapers.Interfaces.IScraperService" />
    /// interface.
    /// </summary>
    public class MakeNewScraperService : IScraperServiceFactory
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Data.Scrapers.Interfaces.IScraperService" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to a new instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Data.Scrapers.Interfaces.IScraperService" />
        /// interface.
        /// </returns>
        public IScraperService FromScratch()
            => new ScraperService();
    }
}