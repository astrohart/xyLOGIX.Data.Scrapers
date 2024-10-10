namespace xyLOGIX.Data.Scrapers.Events
{
    /// <summary>
    /// Defines the method signature for the handlers of a
    /// <c>ScraperServiceExceptionRaised</c> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the
    /// event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see
    ///     cref="T:xyLOGIX.Data.Scrapers.Events.ScraperServiceExceptionRaisedEventArgs" />
    /// that contains the event data.
    /// </param>
    public delegate void ScraperServiceExceptionRaisedEventHandler(
        object sender,
        ScraperServiceExceptionRaisedEventArgs e
    );
}