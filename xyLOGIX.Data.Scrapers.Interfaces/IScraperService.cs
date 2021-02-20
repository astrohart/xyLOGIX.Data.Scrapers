using xyLOGIX.Data.Scrapers.Events;

namespace xyLOGIX.Data.Scrapers.Interfaces
{
   /// <summary>
   /// Defines the public-exposed methods and properties of a scraper object.
   /// </summary>
   public interface IScraperService
   {
      /// <summary>
      /// Occurs when an exception is thrown during an operation.
      /// </summary>
      event ScraperExceptionRaisedEventHandler ScraperExceptionRaised;

      /// <summary>
      /// Gets the HTML content of the Web resource with the specified <paramref name="url"/>.
      /// </summary>
      /// <param name="url">
      /// (Required.) String containing the URL of the page to download and parse.
      /// </param>
      /// <returns>
      /// String containing the content obtained; blank if not found or if a
      /// problem occurred.
      /// </returns>
      /// <exception cref="T:System.ArgumentException">
      /// Thrown if the required parameter, <paramref name="url"/>, is blank.
      /// </exception>
      string GetHtmlContent(string url);

      /// <summary>
      /// Obtains the HTML from the specified <paramref name="url"/> and then
      /// extracts the inner-text content of the element at the <paramref
      /// name="xpath"/> provided.
      /// </summary>
      /// <param name="url">
      /// (Required.) String containing the URL of the page to download and parse.
      /// </param>
      /// <param name="xpath">
      /// (Required.) String containing the XPATH query to use in order to find
      /// the desired element.
      /// </param>
      /// <returns>
      /// String containing the inner textual content of the tag looked up by
      /// the <paramref name="xpath"/> query provided, or blank if the tag was
      /// not found or a problem occurred.
      /// </returns>
      /// <exception cref="T:System.ArgumentException">
      /// Thrown if either of the two required parameters, <paramref
      /// name="url"/> or <paramref name="xpath"/>, are blank.
      /// </exception>
      string GetTagContent(string url, string xpath);
   }
}