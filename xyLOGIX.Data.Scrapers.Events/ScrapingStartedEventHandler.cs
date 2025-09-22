namespace xyLOGIX.Data.Scrapers.Events
{
    /// <summary>
    /// Defines the method signature for the handlers of the
    /// <see cref="E:CoinMarketCap.Data.Scraper.CoinMarketCapScraper.ScrapingStarted" />
    /// event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the
    /// event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see cref="T:CoinMarketCap.Data.Scraper.ScrapingStartedEventArgs" /> that
    /// contains the event data.
    /// </param>
    public delegate void ScrapingStartedEventHandler(
        [NotLogged] object sender,
        [NotLogged] ScrapingStartedEventArgs e
    );
}