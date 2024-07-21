using System.Diagnostics;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using System.ComponentModel;

namespace xyLOGIX.Data.Scrapers.Events
{
    /// <summary>
    /// Defines the data that is passed by all events of type
    /// <see cref="T:xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventHandler" />.
    /// </summary>
    [ExplicitlySynchronized]
    public class ScrapingStartedEventArgs : CancelEventArgs
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventArgs" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static ScrapingStartedEventArgs() { }

        /// <summary>
        /// Creates a new instance of
        /// <see cref="T:xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        public ScrapingStartedEventArgs() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="url">
        /// (Required.) String containing the URL of the web page that
        /// is about to be scraped.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the
        /// <paramref name="url" /> parameter is blank.
        /// </exception>
        [Log(AttributeExclude = true)]
        public ScrapingStartedEventArgs(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(url)
                );

            Url = url;
        }

        /// <summary> Gets the URL of the web page that is about to be scraped. </summary>
        public string Url { [DebuggerStepThrough] get; }
    }
}