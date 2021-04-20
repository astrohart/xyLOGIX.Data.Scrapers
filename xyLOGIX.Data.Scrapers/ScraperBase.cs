using System;
using xyLOGIX.Data.Paginators.Interfaces;
using xyLOGIX.Data.Scrapers.Constants;
using xyLOGIX.Data.Scrapers.Events;
using xyLOGIX.Data.Scrapers.Interfaces;
using xyLOGIX.Data.Scrapers.Services.Factories.Interfaces;

namespace xyLOGIX.Data.Scrapers
{
    /// <summary>
    /// Defines methods, events, and properties that all data-scraper objects
    /// share in common with each other.
    /// </summary>
    public abstract class ScraperBase : IScraper
    {
        /// <summary>
        /// Instance of an object that implements the
        /// <see
        ///     cref="T:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IPaginator" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object manages the paginator of scraped data for this class.
        /// </remarks>
        protected IPaginator _paginator;

        /// <summary>
        /// Reference to an instance of an object that provides scraping services.
        /// </summary>
        protected IScraperService _scraperService;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Data.Scrapers.Services.Factories.Interfaces.IScraperServiceFactory" />
        /// interface which is responsible for giving us access to scraper
        /// service objects.
        /// </summary>
        protected IScraperServiceFactory _scraperServiceFactory;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:xyLOGIX.Data.Scrapers.ScraperBase" />
        /// and returns a reference
        /// to it.
        /// </summary>
        /// <param name="paginator">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:xyLOGIX.Data.Paginators.Interfaces.IPaginator" /> interface.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="paginator" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        protected ScraperBase(IPaginator paginator)
            => _paginator = paginator ??
                            throw new ArgumentNullException(nameof(paginator));

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:xyLOGIX.Data.Scrapers.ScraperBase" />
        /// and returns a reference
        /// to it.
        /// </summary>
        protected ScraperBase()
            => _paginator = null;

        /// <summary>
        /// Occurs when the scrape operation is complete.
        /// </summary>
        public event EventHandler ScrapeComplete;

        /// <summary>
        /// Occurs when scraping is about to start.
        /// </summary>
        public event ScrapingStartedEventHandler ScrapingStarted;

        /// <summary>
        /// Gets the
        /// <see
        ///     cref="T:xyLOGIX.Data.Scrapers.Constants.WebsitesToScrape" />
        /// value
        /// that indicates which website this scraper is being used to pull data from.
        /// </summary>
        public abstract WebsitesToScrape Website { get; }

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
        public bool CanScrape(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(url)
                );

            // Create a new ScrapingStartedEventArgs, initialized with the URL
            // passed, and then pass it to the OnScrapingStarted method. This
            // method invokes the ScrapingStarted event. In handlers of the
            // event, clients of this object can set the Cancel property of the
            // event argument object to true. If they do so, then we need to
            // report that the scraping operation must be stopped.
            var cea = new ScrapingStartedEventArgs(url);
            OnScrapingStarted(cea);
            return cea.Cancel == false;
        }

        /// <summary>
        /// Gets a value indicating whether we're at the end of the data.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if there are more data to follow; <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// Think of the data to be scraped as being akin to a stream.
        /// </remarks>
        public virtual bool HasMore()
            => _paginator != null &&
               _paginator.CurrentPage <= _paginator.TotalPages;

        /// <summary>
        /// Rewinds the scraper back to the beginning of the data.
        /// </summary>
        /// <remarks>
        /// Think of the data to be scraped being akin to a stream.
        /// </remarks>
        public virtual void Rewind()
            => _paginator?.First();

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:xyLOGIX.Data.Scrapers.ScraperBase.ScrapeComplete" />
        /// event.
        /// </summary>
        protected virtual void OnScrapeComplete()
            => ScrapeComplete?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:xyLOGIX.Data.Scrapers.ScraperBase.ScrapingStarted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:CoinMarketCap.Data.Scraper.ScrapingStartedEventArgs" />
        /// that
        /// contains the event data.
        /// </param>
        protected virtual void OnScrapingStarted(ScrapingStartedEventArgs e)
            => ScrapingStarted?.Invoke(this, e);
    }
}