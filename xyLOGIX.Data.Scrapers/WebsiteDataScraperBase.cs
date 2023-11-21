using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Model;
using PostSharp.Patterns.Threading;
using System;
using System.Collections.Generic;
using xyLOGIX.Core.Debug;
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
    public abstract class
        WebsiteDataScraperBase<TModel> : IWebsiteDataScraper<TModel>
        where TModel : class
    {
        /// <summary>
        /// Instance of an object that implements the
        /// <see cref="T:xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object manages the scrapedDataPaginator of scraped data for this
        /// class.
        /// </remarks>
        [Reference] protected IScrapedDataPaginator _scrapedDataPaginator;

        /// <summary>
        /// Reference to an instance of an object that provides scraping
        /// services.
        /// </summary>
        [Reference] protected IScraperService _scraperService;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Data.Scrapers.Services.Factories.Interfaces.IScraperServiceFactory" />
        /// interface which is responsible for giving us access to scraper service objects.
        /// </summary>
        [Reference] protected IScraperServiceFactory _scraperServiceFactory;

        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Data.Scrapers.WebsiteDataScraperBase" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static WebsiteDataScraperBase() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Data.Scrapers.WebsiteDataScraperBase" /> and returns a
        /// reference to it.
        /// </summary>
        /// <param name="scrapedDataPaginator">
        /// (Required.) Reference to an instance of an
        /// object that implements the
        /// <see cref="T:xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator" />
        /// interface.
        /// </param>
        /// <param name="scraperServiceFactory">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Data.Scrapers.Services.Factories.Interfaces.IScraperServiceFactory" />
        /// interface.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if either of the
        /// required parameters, <paramref name="scrapedDataPaginator" /> or
        /// <paramref name="scraperServiceFactory" />, were passed a
        /// <see langword="null" /> reference as an argument.
        /// </exception>
        [Log(AttributeExclude = true)]
        protected WebsiteDataScraperBase(
            IScrapedDataPaginator scrapedDataPaginator,
            IScraperServiceFactory scraperServiceFactory
        )
        {
            _scrapedDataPaginator = scrapedDataPaginator ??
                                    throw new ArgumentNullException(
                                        nameof(scrapedDataPaginator)
                                    );
            _scraperServiceFactory = scraperServiceFactory ??
                                     throw new ArgumentNullException(
                                         nameof(scraperServiceFactory)
                                     );

            _scraperService = _scraperServiceFactory.Make();
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Data.Scrapers.WebsiteDataScraperBase" /> and returns a
        /// reference to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected WebsiteDataScraperBase()
        {
            _scrapedDataPaginator = null;
            _scraperServiceFactory = null;
            _scraperService = null;
        }

        /// <summary>
        /// Gets the
        /// <see cref="T:xyLOGIX.Data.Scrapers.Constants.WebsitesToScrape" /> value that
        /// indicates which website this scraper is being used to pull data from.
        /// </summary>
        public abstract WebsitesToScrape Website { get; }

        /// <summary> Occurs when the scrape operation is complete. </summary>
        public event EventHandler ScrapeComplete;

        /// <summary> Occurs when scraping is about to start. </summary>
        public event ScrapingStartedEventHandler ScrapingStarted;

        /// <summary> Determines whether we can scrape data or not. </summary>
        /// <param name="url">
        /// (Required.) String containing the URL from which data is
        /// about to be scraped.
        /// </param>
        /// <returns>
        /// <see langword="true" /> to allow the scraping operation to continue;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="url" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        public bool CanScrape(string url)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(url)) return result;

                // Create a new ScrapingStartedEventArgs, initialized with the URL
                // passed, and then pass it to the OnScrapingStarted method. This
                // method invokes the ScrapingStarted event. In handlers of the
                // event, clients of this object can set the Cancel property of the
                // event argument object to true. If they do so, then we need to
                // report that the scraping operation must be stopped.
                var cea = new ScrapingStartedEventArgs(url);
                OnScrapingStarted(cea);
                result = cea.Cancel == false;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            return result;
        }

        /// <summary> Gets a value indicating whether we're at the end of the data. </summary>
        /// <returns>
        /// <see langword="true" /> if there are more data to follow;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks> Think of the data to be scraped as being akin to a stream. </remarks>
        public virtual bool HasMore()
            => _scrapedDataPaginator != null &&
               _scrapedDataPaginator.CurrentPage <=
               _scrapedDataPaginator.TotalPages;

        /// <summary> Rewinds the scraper back to the beginning of the data. </summary>
        /// <remarks> Think of the data to be scraped being akin to a stream. </remarks>
        public virtual void Rewind()
            => _scrapedDataPaginator?.First();

        /// <summary>
        /// Scrapes all the pages of available data until all data has been
        /// retrieved.
        /// </summary>
        /// <returns>
        /// Collection of instances of <typeparamref name="TModel" />, one
        /// element for each page of data.
        /// </returns>
        /// <remarks>
        /// If this method fails to retrieve all the pages, it returns the pages
        /// it has, or, if the error was unrecoverable, the empty collection.
        /// <para />
        /// Pages are listed in the order in which they were obtained.
        /// </remarks>
        public IReadOnlyCollection<TModel> ScrapeAll()
            => throw new NotImplementedException();

        /// <summary>
        /// Scrapes the data from the current page, and returns it serialized
        /// into an instance of the <typeparamref name="TModel" />.
        /// </summary>
        /// <returns>
        /// Reference to an instance of <typeparamref name="TModel" /> that
        /// contains the data from the current page.
        /// </returns>
        public abstract TModel ScrapeCurrentPage();

        /// <summary> Scrapes all the pages of data within a certain range of page numbers. </summary>
        /// <param name="first">
        /// (Required.) An <see cref="T:System.Int32" /> denoting the
        /// number of the first page of data to be retrieved.
        /// </param>
        /// <param name="last">
        /// (Required.) An <see cref="T:System.Int32" /> denoting the
        /// number of the last page of data to be retrieved.
        /// </param>
        /// <returns>
        /// If successful, a collection of instances of
        /// <typeparamref name="TModel" />, one element for each page of data retrieved;
        /// the empty collection otherwise.
        /// </returns>
        /// <remarks>
        /// If the <paramref name="first" /> page is after the
        /// <paramref name="last" />, or if <paramref name="first" /> is less than
        /// <c>zero</c>, or if <paramref name="last" /> is greater than the total number of
        /// pages, then this method returns the empty collection.
        /// <para />
        /// The empty collection is also returned if an error occurred during the scraping
        /// operation.
        /// </remarks>
        public IReadOnlyCollection<TModel> ScrapeRange(int first, int last)
            => throw new NotImplementedException();

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Data.Scrapers.WebsiteDataScraperBase.ScrapeComplete" />
        /// event.
        /// </summary>
        [Yielder]
        protected virtual void OnScrapeComplete()
            => ScrapeComplete?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Data.Scrapers.WebsiteDataScraperBase.ScrapingStarted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:CoinMarketCap.Data.Scraper.ScrapingStartedEventArgs" /> that
        /// contains the event data.
        /// </param>
        [Yielder]
        protected virtual void OnScrapingStarted(ScrapingStartedEventArgs e)
            => ScrapingStarted?.Invoke(this, e);
    }
}