using System;
using xyLOGIX.Data.Scrapers.Events;

namespace xyLOGIX.Data.Scrapers.Interfaces
{
    /// <summary>
    /// Defines the methods and properties that all scraper objects have in common.
    /// </summary>
    public interface IScraper
    {
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
        /// <c>true</c> to allow the scraping operation to continue;
        /// <c>false</c> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="url"/>, is passed
        /// a blank or <c>null</c> string for a value.
        /// </exception>
        bool CanScrape(string url);

        /// <summary>
        /// Gets a value indicating whether we're at the end of the data.
        /// </summary>
        /// <returns>
        /// <c>true</c> if there are more data to follow; <c>false</c> otherwise.
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