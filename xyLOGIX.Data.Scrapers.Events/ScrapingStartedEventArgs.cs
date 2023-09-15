using System;
using System.ComponentModel;

namespace xyLOGIX.Data.Scrapers.Events
{
///  <summary> Defines the data that is passed by all events of type <see cref="T:xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventHandler"/>. </summary>
   public class ScrapingStartedEventArgs : CancelEventArgs
   {
///  <summary> Constructs a new instance of <see cref="T:xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventArgs"/> and returns a reference to it. </summary> <param name="url"> (Required.) String containing the URL of the web page that is about to be scraped. </param> <exception cref="T:System.ArgumentException"> Thrown if the <paramref name="url"/> parameter is blank. </exception>
      public ScrapingStartedEventArgs(string url)
      {
         if (string.IsNullOrWhiteSpace(url))
            throw new ArgumentException(
               "Value cannot be null or whitespace.", nameof(url)
            );

         Url = url;
      }

///  <summary> Gets the URL of the web page that is about to be scraped. </summary>
      public string Url { get; }
   }
}
