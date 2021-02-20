using CoinMarketCap.Data.Scraper;
using System;
using System.ComponentModel;
using xyLOGIX.Data.Scrapers.Constants;
using xyLOGIX.Data.Scrapers.Interfaces;

namespace xyLOGIX.Data.Scrapers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:xyLOGIX.Data.Scrapers.Factories.IScraper" />
    /// interface.
    /// </summary>
    public static class GetScraper
    {
        /// <summary>
        /// Creates an instance of an object implementing the
        /// <see
        ///     cref="T:xyLOGIX.Data.Scrapers.Factories.IScraper" />
        /// interface which
        /// corresponds to the value specified in <paramref name="website" />,
        /// and returns a reference to it.
        /// </summary>
        /// <param name="website">
        /// One of the
        /// <see
        ///     cref="T:xyLOGIX.Data.Scrapers.Factories.ScraperType" />
        /// values that
        /// describes what type of object you want.
        /// </param>
        /// <returns>
        /// A reference to the instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Data.Scrapers.Factories.IScraper" />
        /// interface which
        /// corresponds to the value specified in <paramref name="website" />.
        /// </returns>
        /// <remarks>
        /// This method will throw an exception if there are no types
        /// implemented that correspond to the value of <paramref name="website" />.
        /// </remarks>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// Thrown if the value passed in <paramref name="website" /> does not
        /// correspond to the set of available enumeration values.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if there is no corresponding concrete type defined that
        /// implements the
        /// <see
        ///     cref="T:xyLOGIX.Data.Scrapers.Factories.IScraper" />
        /// interface and
        /// which corresponds to the value passed in the
        /// <paramref
        ///     name="website" />
        /// parameter.
        /// </exception>
        public static IScraper For(WebsitesToScrape website)
        {
            if (!Enum.IsDefined(typeof(WebsitesToScrape), website))
                throw new InvalidEnumArgumentException(
                    nameof(website), (int) website, typeof(WebsitesToScrape)
                );
            IScraper result = null;

            switch (website)
            {
                case WebsitesToScrape.CoinMarketCep:
                    result = new CoinMarketCapScraper();
                    break;

                case WebsitesToScrape.Unknown:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(website), website, null
                    );
            }

            return result;
        }
    }
}