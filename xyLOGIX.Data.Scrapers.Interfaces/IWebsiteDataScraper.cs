using System;
using xyLOGIX.Data.Scrapers.Constants;
using xyLOGIX.Data.Scrapers.Events;

namespace xyLOGIX.Data.Scrapers.Interfaces
{
    /// <summary>
    /// Defines the methods and properties that all scraper objects have in common.
    /// </summary>
    public interface IWebsiteDataScraper<TModel> where TModel : class
    {
        /// <summary>
        /// Gets the
        /// <see
        ///     cref="T:xyLOGIX.Data.Scrapers.Constants.WebsitesToScrape" />
        /// value
        /// that indicates which website this scraper is being used to pull data from.
        /// </summary>
        WebsitesToScrape Website { get; }

        /// <summary>
        /// Occurs when the scrape operation is complete.
        /// </summary>
        event EventHandler ScrapeComplete;

        /// <summary>
        /// Occurs when scraping is about to start.
        /// </summary>
        event ScrapingStartedEventHandler ScrapingStarted;

        /// <summary>
        /// Determines whether we can scrape data or not.
        /// </summary>
        /// <param name="url">
        /// (Required.) String containing the URL from which data is about to be scraped.
        /// </param>
        /// <returns>
        /// <see langword="true" /> to allow the scraping operation to continue;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="url" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        bool CanScrape(string url);

        /// <summary>
        /// Gets a value indicating whether we're at the end of the data.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if there are more data to follow;
        /// <see
        ///     langword="false" />
        /// otherwise.
        /// </returns>
        /// <remarks>
        /// Think of the data to be scraped as being akin to a stream.
        /// </remarks>
        bool HasMore();

        /// <summary>
        /// Rewinds the scraper back to the beginning of the data.
        /// </summary>
        /// <remarks>
        /// Think of the data to be scraped being akin to a stream.
        /// </remarks>
        void Rewind();

        /// <summary>
        /// Scrapes the data from the current page, and returns it serialized into an
        /// instance of the <typeparamref name="TModel" />.
        /// </summary>
        /// <returns>
        /// Reference to an instance of <typeparamref name="TModel" /> that
        /// contains the data from the current page.
        /// </returns>
        TModel Scrape();
    }
}