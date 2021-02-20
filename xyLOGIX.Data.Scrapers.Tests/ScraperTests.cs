using NUnit.Framework;
using System;
using xyLOGIX.Data.Scrapers.Events;
using xyLOGIX.Data.Scrapers.Interfaces;

namespace xyLOGIX.Data.Scrapers.Tests
{
   /// <summary>
   /// Unit tests for objects that implement the <see
   /// cref="T:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraper"/> interface.
   /// </summary>
   [TestFixture]
   public class ScraperTests
   {
      /// <summary>
      /// Content of the &lt;h1&gt; tag of the example.com website.
      /// </summary>
      private const string EXAMPLE_COM_HEADER_CONTENT = "Example Domain";

      /// <summary>
      /// Valid XPATH to the &lt;h1&gt; tag of the example.com website.
      /// </summary>
      private const string INVALID_EXAMPLE_COM_HEADER_XPATH = "/html/body/h1";

      private const string INVALID_URL = "http:/sdfjklsdfjklsjklsdfjkl/";

      /// <summary>
      /// XPATH that is total gibberish.
      /// </summary>
      private const string NONSENSE_XPATH = "/asdfjksdfkl/sajsksl";

      /// <summary>
      /// Valid XPATH to the &lt;h1&gt; tag of the example.com website.
      /// </summary>
      private const string VALID_EXAMPLE_COM_HEADER_XPATH = "/html/body/div/h1";

      /// <summary>
      /// URL of the example.com website.
      /// </summary>
      private const string VALID_EXAMPLE_COM_URL = "http://example.com";

      /// <summary>
      /// Reference to an instance of a class that implements the <see
      /// cref="T:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraper"/> interface.
      /// </summary>
      /// <remarks>
      /// This is the object that provides scraping services.
      /// </remarks>
      private IScraper _scraper;

      /// <summary>
      /// Initializes the dependency variable <see
      /// cref="F:xyLOGIX.Data.Scrapers.Tests.ScraperTests._scraper"/> .
      /// </summary>
      [SetUp]
      public void Initialize()
      {
         _scraper = new Scraper();
         _scraper.ScraperExceptionRaised += OnExceptionRaised;
      }

      /// <summary>
      /// Asserts the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraper.GetHtmlContent"/>
      /// method returns nothing when fed a nonsensical website URL from which
      /// to retrieve the HTML content.
      /// </summary>
      [Test]
      public void Test_GetHtmlContent_ReturnsNothing_WhenGivenInvalidURL()
      {
         var content = string.Empty;
         Assert.DoesNotThrow(
            () => content = _scraper.GetHtmlContent(INVALID_URL)
         );
         Assert.IsEmpty(content);
      }

      /// <summary>
      /// Asserts the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraper.GetHtmlContent"/>
      /// method throws a <see cref="T:System.ArgumentException"/> when given a
      /// blank value for the URL from which to obtain content from.
      /// </summary>
      [Test]
      public void
         Test_GetHtmlContent_ThrowsArgumentException_WhenGivenBlankURL()
      {
         var content = string.Empty;
         Assert.Throws<ArgumentException>(
            () => content = _scraper.GetHtmlContent(string.Empty)
         );
         Assert.IsEmpty(content);
      }

      /// <summary>
      /// Asserts the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.IScraper.GetHtmlContent"/>
      /// method returns the HTML content for the homepage of the example.com
      /// website when fed a valid URL for the website.
      /// </summary>
      [Test]
      public void Test_GetHtmlContent_Works_For_ExampleDotCom()
      {
         var content = "";
         Assert.DoesNotThrow(
            () => content = _scraper.GetHtmlContent(VALID_EXAMPLE_COM_URL)
         );
         Assert.IsNotEmpty(content);
      }

      /// <summary>
      /// Asserts the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.IScraper.GetTagContent"/>
      /// method returns the correct content of the &lt;h1&gt; tag in the body
      /// of the homepage HTML content of the example.com website when fed valid XPATH.
      /// </summary>
      [Test]
      public void Test_GetTagContent_ForExampleDotComH1_Works()
      {
         var content = "";
         Assert.DoesNotThrow(
            () => content = _scraper.GetTagContent(
               VALID_EXAMPLE_COM_URL, VALID_EXAMPLE_COM_HEADER_XPATH
            )
         );
         Assert.IsNotEmpty(content);
         Assert.AreEqual(EXAMPLE_COM_HEADER_CONTENT, content);
      }

      /// <summary>
      /// Asserts the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraper.GetTagContent"/>
      /// method returns the empty string when fed a valid URL for the
      /// example.com website but invalid XPATH for the page header.
      /// </summary>
      [Test]
      public void
         Test_GetTagContent_ReturnsBlankValue_WhenProvidedInvalidXPATH()
      {
         var content = string.Empty;
         Assert.DoesNotThrow(
            () => content = _scraper.GetTagContent(
               VALID_EXAMPLE_COM_URL, INVALID_EXAMPLE_COM_HEADER_XPATH
            )
         );
         Assert.IsEmpty(content);
      }

      /// <summary>
      /// Asserts the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraper.GetTagContent"/>
      /// method returns the empty string when fed invalid (but non-blank) data
      /// for both its parameters.
      /// </summary>
      [Test]
      public void
         Test_GetTagContent_ReturnsNothing_WhenGivenInvalidData_ForBothParameters()
      {
         var content = string.Empty;
         Assert.DoesNotThrow(
            () => content = _scraper.GetTagContent(INVALID_URL, NONSENSE_XPATH)
         );
         Assert.IsEmpty(content);
      }

      /// <summary>
      /// Asserts the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraper.GetTagContent"/>
      /// method returns the empty string when fed an invalid URL for its url
      /// parameter, despite being provided valid XPATH.
      /// </summary>
      [Test]
      public void
         Test_GetTagContent_ReturnsNothing_WhenGivenInvalidURL_ButValidXPATH()
      {
         var content = string.Empty;
         Assert.DoesNotThrow(
            () => content = _scraper.GetTagContent(
               INVALID_URL, VALID_EXAMPLE_COM_HEADER_XPATH
            )
         );
         Assert.IsEmpty(content);
      }

      /// <summary>
      /// Asserts the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraper.GetTagContent"/>
      /// method returns the empty string when fed a valid URL for its url
      /// parameter, despite being provided invalid XPATH.
      /// </summary>
      [Test]
      public void
         Test_GetTagContent_ReturnsNothing_WhenGivenValidURL_ButInvalidXPATH()
      {
         var content = string.Empty;
         Assert.DoesNotThrow(
            () => content = _scraper.GetTagContent(
               VALID_EXAMPLE_COM_URL, NONSENSE_XPATH
            )
         );
         Assert.IsEmpty(content);
      }

      /// <summary>
      /// Asserts the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraper.GetTagContent"/>
      /// method throws a <see cref="T:System.ArgumentException"/> when the
      /// empty string is passed for both of its parameters.
      /// </summary>
      [Test]
      public void
         Test_GetTagContent_ThrowArgumentException_WhenGivenBlankURL_AndBlankXPATH()
      {
         var content = string.Empty;
         Assert.Throws<ArgumentException>(
            () => content = _scraper.GetTagContent(string.Empty, string.Empty)
         );
         Assert.IsEmpty(content);
      }

      /// <summary>
      /// Asserts the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraper.GetTagContent"/>
      /// method throws a <see cref="T:System.ArgumentException"/> when a
      /// non-blank string is passed for its xpath parameter, and the empty
      /// string is passed for its url parameter.
      /// </summary>
      [Test]
      public void
         Test_GetTagContent_ThrowArgumentException_WhenGivenBlankURL_AndNonBlankXPATH()
      {
         var content = string.Empty;
         Assert.Throws<ArgumentException>(
            () => content = _scraper.GetTagContent(
               string.Empty, INVALID_EXAMPLE_COM_HEADER_XPATH
            )
         );
         Assert.IsEmpty(content);
      }

      /// <summary>
      /// Asserts the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraper.GetTagContent"/>
      /// method throws a <see cref="T:System.ArgumentException"/> when a
      /// non-blank string is passed for its URL parameter, and the empty string
      /// is passed for its xpath parameter.
      /// </summary>
      [Test]
      public void
         Test_GetTagContent_ThrowArgumentException_WhenGivenNonBlankURL_AndBlankXPATH()
      {
         var content = string.Empty;
         Assert.Throws<ArgumentException>(
            () => content = _scraper.GetTagContent(INVALID_URL, string.Empty)
         );
         Assert.IsEmpty(content);
      }

      /// <summary>
      /// Handles the <see
      /// cref="E:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraper.ExceptionRaised"/> event.
      /// </summary>
      /// <param name="sender">
      /// Reference to an instance of the object that raised the event.
      /// </param>
      /// <param name="e">
      /// An <see cref="T:System.EventArgs"/> that contains the event data.
      /// </param>
      /// <remarks>
      /// This method reports the error information to the console.
      /// </remarks>
      private static void OnExceptionRaised(object sender,
         ScraperExceptionRaisedEventArgs e)
      {
         Console.WriteLine(
            $"Error scraping page with URL '{e.Url}'.\nException\n{e.Exception}"
         );
      }
   }
}