using PostSharp.Patterns.Threading;
using xyLOGIX.Data.Scrapers.Interfaces;

namespace xyLOGIX.Data.Scrapers.Services.Factories.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a
    /// scraper-service factory object.
    /// </summary>
    [Synchronized]
    public interface IScraperServiceFactory
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:xyLOGIX.Data.Scrapers.Interfaces.IScraperService" /> interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to a new instance of an object that implements the
        /// <see cref="T:xyLOGIX.Data.Scrapers.Interfaces.IScraperService" /> interface.
        /// </returns>
        IScraperService Make();
    }
}