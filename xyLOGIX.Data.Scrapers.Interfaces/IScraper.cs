using System;
using xyLOGIX.Data.Scrapers.Constants;
using xyLOGIX.Data.Scrapers.Events;

namespace xyLOGIX.Data.Scrapers.Interfaces
{
    /// <summary>
    /// Defines the methods and properties that all scraper objects have in common.
    /// </summary>
    /// <typeparam name="T">
    /// Name of a POCO type that encapsulates one record of data from the
    /// scraped website.
    /// </typeparam>
    public interface IScraper<T> where T : class
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
        /// Gets the <typeparamref name="T" /> object serialized from the JSON
        /// that is scraped from the target website's results.
        /// </summary>
        /// <returns>
        /// Reference to an instance of <typeparamref name="T" /> that
        /// contains the scraped data for the current page, or <see langword="null" /> if an
        /// error occurred while processing the data request.
        /// </returns>
        /// <remarks>
        /// With each call, this method advances to the next page.
        /// </remarks>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if neither the
        /// <see
        ///     cref="F:CoinMarketCap.Data.Scraper.CoinMarketCapScraper._paginator" />
        /// or
        /// <see
        ///     cref="F:CoinMarketCap.Data.Scraper.CoinMarketCapScraper._scraper" />
        /// fields have been initialized.
        /// </exception>
        T GetDataFromCurrentPage();

        /// <summary>
        /// Gets a value indicating whether we're at the end of the data.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if there are more data to follow; <see langword="false" /> otherwise.
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
    }
}