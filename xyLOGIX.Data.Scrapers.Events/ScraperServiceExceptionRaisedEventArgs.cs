using System;

namespace xyLOGIX.Data.Scrapers.Events
{
    /// <summary>
    /// Defines the data that is passed by all <c>ScraperServiceExceptionRaised</c> events.
    /// </summary>
    public class ScraperServiceExceptionRaisedEventArgs : EventArgs
    {
       /// <summary>
       /// Creates a new instance of
       /// <see
       ///     cref="T:CoinMarketCap.Data.Scraper.Helpers.Events.ExceptionRaisedEventArgs" />
       /// and returns a reference to it.
       /// </summary>
       /// <param name="url">
       /// (Required.) String containing the URL of the content currently being parsed.
       /// </param>
       /// <param name="exception">
       /// (Required.) A <see cref="T:System.Exception" /> that describes the error.
       /// </param>
       /// <exception cref="T:System.ArgumentException">
       /// Thrown if the required parameter, <paramref name="url" />, is blank.
       /// </exception>
       /// <exception cref="T:System.ArgumentNullException">
       /// Thrown if the required parameter, <paramref name="exception" /> is <see langword="null" />.
       /// </exception>
       public ScraperServiceExceptionRaisedEventArgs(string url, Exception exception)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(url)
                );
            Url = url;
            Exception = exception ??
                        throw new ArgumentNullException(nameof(exception));
        }

       /// <summary>
       /// Gets a <see cref="T:System.Exception" /> that describes the error.
       /// </summary>
       public Exception Exception { get; }

        /// <summary>
        /// Gets a string containing the URL of the web content currently being parsed.
        /// </summary>
        public string Url { get; }
    }
}