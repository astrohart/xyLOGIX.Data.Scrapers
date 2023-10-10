<a name='assembly'></a>
# xyLOGIX.Data.Scrapers.Services.Tests

## Contents

- [Resources](#T-xyLOGIX-Data-Scrapers-Services-Tests-Properties-Resources 'xyLOGIX.Data.Scrapers.Services.Tests.Properties.Resources')
  - [Culture](#P-xyLOGIX-Data-Scrapers-Services-Tests-Properties-Resources-Culture 'xyLOGIX.Data.Scrapers.Services.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Data-Scrapers-Services-Tests-Properties-Resources-ResourceManager 'xyLOGIX.Data.Scrapers.Services.Tests.Properties.Resources.ResourceManager')
- [ScraperServiceTests](#T-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests')
  - [EXAMPLE_COM_HEADER_CONTENT](#F-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-EXAMPLE_COM_HEADER_CONTENT 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.EXAMPLE_COM_HEADER_CONTENT')
  - [INVALID_EXAMPLE_COM_HEADER_XPATH](#F-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-INVALID_EXAMPLE_COM_HEADER_XPATH 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.INVALID_EXAMPLE_COM_HEADER_XPATH')
  - [NONSENSE_XPATH](#F-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-NONSENSE_XPATH 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.NONSENSE_XPATH')
  - [VALID_EXAMPLE_COM_HEADER_XPATH](#F-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-VALID_EXAMPLE_COM_HEADER_XPATH 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.VALID_EXAMPLE_COM_HEADER_XPATH')
  - [VALID_EXAMPLE_COM_URL](#F-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-VALID_EXAMPLE_COM_URL 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.VALID_EXAMPLE_COM_URL')
  - [_scraperService](#F-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-_scraperService 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests._scraperService')
  - [Initialize()](#M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Initialize 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.Initialize')
  - [OnScraperServiceExceptionRaised(sender,e)](#M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-OnScraperServiceExceptionRaised-System-Object,xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventArgs- 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.OnScraperServiceExceptionRaised(System.Object,xyLOGIX.Data.Scrapers.Events.ScraperServiceExceptionRaisedEventArgs)')
  - [Test_GetHtmlContent_ReturnsNothing_WhenGivenInvalidURL()](#M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetHtmlContent_ReturnsNothing_WhenGivenInvalidURL 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.Test_GetHtmlContent_ReturnsNothing_WhenGivenInvalidURL')
  - [Test_GetHtmlContent_ThrowsArgumentException_WhenGivenBlankURL()](#M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetHtmlContent_ThrowsArgumentException_WhenGivenBlankURL 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.Test_GetHtmlContent_ThrowsArgumentException_WhenGivenBlankURL')
  - [Test_GetHtmlContent_Works_For_ExampleDotCom()](#M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetHtmlContent_Works_For_ExampleDotCom 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.Test_GetHtmlContent_Works_For_ExampleDotCom')
  - [Test_GetTagContent_ForExampleDotComH1_Works()](#M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ForExampleDotComH1_Works 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.Test_GetTagContent_ForExampleDotComH1_Works')
  - [Test_GetTagContent_ReturnsBlankValue_WhenProvidedInvalidXPATH()](#M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ReturnsBlankValue_WhenProvidedInvalidXPATH 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.Test_GetTagContent_ReturnsBlankValue_WhenProvidedInvalidXPATH')
  - [Test_GetTagContent_ReturnsNothing_WhenGivenInvalidData_ForBothParameters()](#M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ReturnsNothing_WhenGivenInvalidData_ForBothParameters 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.Test_GetTagContent_ReturnsNothing_WhenGivenInvalidData_ForBothParameters')
  - [Test_GetTagContent_ReturnsNothing_WhenGivenInvalidURL_ButValidXPATH()](#M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ReturnsNothing_WhenGivenInvalidURL_ButValidXPATH 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.Test_GetTagContent_ReturnsNothing_WhenGivenInvalidURL_ButValidXPATH')
  - [Test_GetTagContent_ReturnsNothing_WhenGivenValidURL_ButInvalidXPATH()](#M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ReturnsNothing_WhenGivenValidURL_ButInvalidXPATH 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.Test_GetTagContent_ReturnsNothing_WhenGivenValidURL_ButInvalidXPATH')
  - [Test_GetTagContent_ThrowArgumentException_WhenGivenBlankURL_AndBlankXPATH()](#M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ThrowArgumentException_WhenGivenBlankURL_AndBlankXPATH 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.Test_GetTagContent_ThrowArgumentException_WhenGivenBlankURL_AndBlankXPATH')
  - [Test_GetTagContent_ThrowArgumentException_WhenGivenBlankURL_AndNonBlankXPATH()](#M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ThrowArgumentException_WhenGivenBlankURL_AndNonBlankXPATH 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.Test_GetTagContent_ThrowArgumentException_WhenGivenBlankURL_AndNonBlankXPATH')
  - [Test_GetTagContent_ThrowArgumentException_WhenGivenNonBlankURL_AndBlankXPATH()](#M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ThrowArgumentException_WhenGivenNonBlankURL_AndBlankXPATH 'xyLOGIX.Data.Scrapers.Services.Tests.ScraperServiceTests.Test_GetTagContent_ThrowArgumentException_WhenGivenNonBlankURL_AndBlankXPATH')

<a name='T-xyLOGIX-Data-Scrapers-Services-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Data.Scrapers.Services.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Data-Scrapers-Services-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Data-Scrapers-Services-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests'></a>
## ScraperServiceTests `type`

##### Namespace

xyLOGIX.Data.Scrapers.Services.Tests

##### Summary

Unit tests for objects that implement the [IScraperService](#T-CoinMarketCap-Data-Scraper-Helpers-Interfaces-IScraperService 'CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraperService') interface.

<a name='F-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-EXAMPLE_COM_HEADER_CONTENT'></a>
### EXAMPLE_COM_HEADER_CONTENT `constants`

##### Summary

Content of the <h1> tag of the example.com website.

<a name='F-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-INVALID_EXAMPLE_COM_HEADER_XPATH'></a>
### INVALID_EXAMPLE_COM_HEADER_XPATH `constants`

##### Summary

Valid XPATH to the <h1> tag of the example.com website.

<a name='F-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-NONSENSE_XPATH'></a>
### NONSENSE_XPATH `constants`

##### Summary

XPATH that is total gibberish.

<a name='F-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-VALID_EXAMPLE_COM_HEADER_XPATH'></a>
### VALID_EXAMPLE_COM_HEADER_XPATH `constants`

##### Summary

Valid XPATH to the <h1> tag of the example.com website.

<a name='F-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-VALID_EXAMPLE_COM_URL'></a>
### VALID_EXAMPLE_COM_URL `constants`

##### Summary

URL of the example.com website.

<a name='F-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-_scraperService'></a>
### _scraperService `constants`

##### Summary

Reference to an instance of a class that implements the [IScraperService](#T-CoinMarketCap-Data-Scraper-Helpers-Interfaces-IScraperService 'CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraperService') interface.

##### Remarks

This is the object that provides scraping services.

<a name='M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the dependency variable [_scraper](#F-xyLOGIX-Data-Scrapers-Tests-ScraperTests-_scraper 'xyLOGIX.Data.Scrapers.Tests.ScraperTests._scraper') .

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-OnScraperServiceExceptionRaised-System-Object,xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventArgs-'></a>
### OnScraperServiceExceptionRaised(sender,e) `method`

##### Summary

Handles the [](#E-CoinMarketCap-Data-Scraper-Helpers-Interfaces-IScraperService-ExceptionRaised 'CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraperService.ExceptionRaised') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [xyLOGIX.Data.Scrapers.Events.ScraperServiceExceptionRaisedEventArgs](#T-xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventArgs 'xyLOGIX.Data.Scrapers.Events.ScraperServiceExceptionRaisedEventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method reports the error information to the console.

<a name='M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetHtmlContent_ReturnsNothing_WhenGivenInvalidURL'></a>
### Test_GetHtmlContent_ReturnsNothing_WhenGivenInvalidURL() `method`

##### Summary

Asserts the [GetHtmlContent](#M-CoinMarketCap-Data-Scraper-Helpers-Interfaces-IScraperService-GetHtmlContent 'CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraperService.GetHtmlContent') method returns nothing when fed a nonsensical website URL from which to retrieve the HTML content.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetHtmlContent_ThrowsArgumentException_WhenGivenBlankURL'></a>
### Test_GetHtmlContent_ThrowsArgumentException_WhenGivenBlankURL() `method`

##### Summary

Asserts the [GetHtmlContent](#M-CoinMarketCap-Data-Scraper-Helpers-Interfaces-IScraperService-GetHtmlContent 'CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraperService.GetHtmlContent') method throws a [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') when given a blank value for the URL from which to obtain content from.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetHtmlContent_Works_For_ExampleDotCom'></a>
### Test_GetHtmlContent_Works_For_ExampleDotCom() `method`

##### Summary

Asserts the [GetHtmlContent](#M-CoinMarketCap-Data-Scraper-Helpers-IScraperService-GetHtmlContent 'CoinMarketCap.Data.Scraper.Helpers.IScraperService.GetHtmlContent') method returns the HTML content for the homepage of the example.com website when fed a valid URL for the website.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ForExampleDotComH1_Works'></a>
### Test_GetTagContent_ForExampleDotComH1_Works() `method`

##### Summary

Asserts the [GetTagContent](#M-CoinMarketCap-Data-Scraper-Helpers-IScraperService-GetTagContent 'CoinMarketCap.Data.Scraper.Helpers.IScraperService.GetTagContent') method returns the correct content of the <h1> tag in the body of the homepage HTML content of the example.com website when fed valid XPATH.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ReturnsBlankValue_WhenProvidedInvalidXPATH'></a>
### Test_GetTagContent_ReturnsBlankValue_WhenProvidedInvalidXPATH() `method`

##### Summary

Asserts the [GetTagContent](#M-CoinMarketCap-Data-Scraper-Helpers-Interfaces-IScraperService-GetTagContent 'CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraperService.GetTagContent') method returns the empty string when fed a valid URL for the example.com website but invalid XPATH for the page header.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ReturnsNothing_WhenGivenInvalidData_ForBothParameters'></a>
### Test_GetTagContent_ReturnsNothing_WhenGivenInvalidData_ForBothParameters() `method`

##### Summary

Asserts the [GetTagContent](#M-CoinMarketCap-Data-Scraper-Helpers-Interfaces-IScraperService-GetTagContent 'CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraperService.GetTagContent') method returns the empty string when fed invalid (but non-blank) data for both its parameters.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ReturnsNothing_WhenGivenInvalidURL_ButValidXPATH'></a>
### Test_GetTagContent_ReturnsNothing_WhenGivenInvalidURL_ButValidXPATH() `method`

##### Summary

Asserts the [GetTagContent](#M-CoinMarketCap-Data-Scraper-Helpers-Interfaces-IScraperService-GetTagContent 'CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraperService.GetTagContent') method returns the empty string when fed an invalid URL for its url parameter, despite being provided valid XPATH.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ReturnsNothing_WhenGivenValidURL_ButInvalidXPATH'></a>
### Test_GetTagContent_ReturnsNothing_WhenGivenValidURL_ButInvalidXPATH() `method`

##### Summary

Asserts the [GetTagContent](#M-CoinMarketCap-Data-Scraper-Helpers-Interfaces-IScraperService-GetTagContent 'CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraperService.GetTagContent') method returns the empty string when fed a valid URL for its url parameter, despite being provided invalid XPATH.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ThrowArgumentException_WhenGivenBlankURL_AndBlankXPATH'></a>
### Test_GetTagContent_ThrowArgumentException_WhenGivenBlankURL_AndBlankXPATH() `method`

##### Summary

Asserts the [GetTagContent](#M-CoinMarketCap-Data-Scraper-Helpers-Interfaces-IScraperService-GetTagContent 'CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraperService.GetTagContent') method throws a [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') when the empty string is passed for both of its parameters.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ThrowArgumentException_WhenGivenBlankURL_AndNonBlankXPATH'></a>
### Test_GetTagContent_ThrowArgumentException_WhenGivenBlankURL_AndNonBlankXPATH() `method`

##### Summary

Asserts the [GetTagContent](#M-CoinMarketCap-Data-Scraper-Helpers-Interfaces-IScraperService-GetTagContent 'CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraperService.GetTagContent') method throws a [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') when a non-blank string is passed for its xpath parameter, and the empty string is passed for its url parameter.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Scrapers-Services-Tests-ScraperServiceTests-Test_GetTagContent_ThrowArgumentException_WhenGivenNonBlankURL_AndBlankXPATH'></a>
### Test_GetTagContent_ThrowArgumentException_WhenGivenNonBlankURL_AndBlankXPATH() `method`

##### Summary

Asserts the [GetTagContent](#M-CoinMarketCap-Data-Scraper-Helpers-Interfaces-IScraperService-GetTagContent 'CoinMarketCap.Data.Scraper.Helpers.Interfaces.IScraperService.GetTagContent') method throws a [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') when a non-blank string is passed for its URL parameter, and the empty string is passed for its xpath parameter.

##### Parameters

This method has no parameters.
