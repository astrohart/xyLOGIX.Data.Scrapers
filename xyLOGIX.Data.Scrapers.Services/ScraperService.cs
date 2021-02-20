using HtmlAgilityPack;
using System;
using xyLOGIX.Data.Scrapers.Events;
using xyLOGIX.Data.Scrapers.Interfaces;

namespace xyLOGIX.Data.Scrapers.Services
{
    /// <summary>
    /// Scrapes content from the Web and provides parsing helper methods.
    /// </summary>
    public sealed class ScraperService : IScraperService
    {
        /// <summary>
        /// Occurs when an exception is thrown during an scraping operation.
        /// </summary>
        public event ScraperServiceExceptionRaisedEventHandler
            ScraperServiceExceptionRaised;

        /// <summary>
        /// Gets the HTML content of the Web resource with the specified
        /// <paramref name="url" />.
        /// </summary>
        /// <param name="url">
        /// (Required.) String containing the URL of the page to download and parse.
        /// </param>
        /// <returns>
        /// String containing the content obtained; blank if not found or if a
        /// problem occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="url" />, is blank.
        /// </exception>
        public string GetHtmlContent(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(url)
                );

            var result = string.Empty;

            try
            {
                result = new HtmlWeb().Load(url).Text;
            }
            catch (Exception ex)
            {
                OnScraperServiceExceptionRaised(
                    new ScraperServiceExceptionRaisedEventArgs(url, ex)
                );

                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Obtains the HTML from the specified <paramref name="url" /> and then
        /// extracts the inner-text content of the element at the
        /// <paramref
        ///     name="xpath" />
        /// provided.
        /// </summary>
        /// <param name="url">
        /// (Required.) String containing the URL of the page to download and parse.
        /// </param>
        /// <param name="xpath">
        /// (Required.) String containing the XPATH query to use in order to
        /// find the desired element.
        /// </param>
        /// <returns>
        /// String containing the inner textual content of the tag looked up by
        /// the <paramref name="xpath" /> query provided, or blank if the tag was
        /// not found or a problem occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the two required parameters,
        /// <paramref
        ///     name="url" />
        /// or <paramref name="xpath" />, are blank.
        /// </exception>
        public string GetTagContent(string url, string xpath)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(url)
                );
            if (string.IsNullOrWhiteSpace(xpath))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(xpath)
                );

            var result = string.Empty;

            try
            {
                var web = new HtmlWeb();

                var doc = web.Load(url);
                if (doc == null)
                    ThrowScraperEngineInitializationFailedException();

                var link = doc.DocumentNode.SelectSingleNode(xpath);

                if (link != null) result = link.InnerText;
            }
            catch (Exception ex)
            {
                OnScraperServiceExceptionRaised(
                    new ScraperServiceExceptionRaisedEventArgs(url, ex)
                );

                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Throws a <see cref="T:System.InvalidOperationException" /> that
        /// indicates the scraping engine could not be initialized.
        /// </summary>
        private static void ThrowScraperEngineInitializationFailedException()
            => throw new InvalidOperationException(
                "Unable to initialize HTML scraping engine."
            );

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:CoinMarketCap.Data.Scraper.Helpers.Scraper.ScraperServiceExceptionRaised" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:CoinMarketCap.Data.Scraper.Helpers.Events.ScraperServiceExceptionRaisedEventArgs" />
        /// that contains the event data.
        /// </param>
        private void OnScraperServiceExceptionRaised(
            ScraperServiceExceptionRaisedEventArgs e)
            => ScraperServiceExceptionRaised?.Invoke(this, e);
    }
}