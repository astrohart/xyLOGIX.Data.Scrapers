<a name='assembly'></a>
# xyLOGIX.Data.Scrapers

## Contents

- [Resources](#T-xyLOGIX-Data-Scrapers-Properties-Resources 'xyLOGIX.Data.Scrapers.Properties.Resources')
  - [Culture](#P-xyLOGIX-Data-Scrapers-Properties-Resources-Culture 'xyLOGIX.Data.Scrapers.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Data-Scrapers-Properties-Resources-ResourceManager 'xyLOGIX.Data.Scrapers.Properties.Resources.ResourceManager')
- [WebsiteDataScraperBase\`1](#T-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase`1')
  - [#ctor(scrapedDataPaginator,scraperServiceFactory)](#M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-#ctor-xyLOGIX-Data-Paginators-Interfaces-IScrapedDataPaginator,xyLOGIX-Data-Scrapers-Services-Factories-Interfaces-IScraperServiceFactory- 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase`1.#ctor(xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator,xyLOGIX.Data.Scrapers.Services.Factories.Interfaces.IScraperServiceFactory)')
  - [#ctor()](#M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-#ctor 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase`1.#ctor')
  - [_scrapedDataPaginator](#F-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-_scrapedDataPaginator 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase`1._scrapedDataPaginator')
  - [_scraperService](#F-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-_scraperService 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase`1._scraperService')
  - [_scraperServiceFactory](#F-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-_scraperServiceFactory 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase`1._scraperServiceFactory')
  - [Website](#P-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-Website 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase`1.Website')
  - [CanScrape(url)](#M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-CanScrape-System-String- 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase`1.CanScrape(System.String)')
  - [HasMore()](#M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-HasMore 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase`1.HasMore')
  - [OnScrapeComplete()](#M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-OnScrapeComplete 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase`1.OnScrapeComplete')
  - [OnScrapingStarted(e)](#M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-OnScrapingStarted-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventArgs- 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase`1.OnScrapingStarted(xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventArgs)')
  - [Rewind()](#M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-Rewind 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase`1.Rewind')
  - [ScrapeAll()](#M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-ScrapeAll 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase`1.ScrapeAll')
  - [ScrapeCurrentPage()](#M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-ScrapeCurrentPage 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase`1.ScrapeCurrentPage')
  - [ScrapeRange(first,last)](#M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-ScrapeRange-System-Int32,System-Int32- 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase`1.ScrapeRange(System.Int32,System.Int32)')

<a name='T-xyLOGIX-Data-Scrapers-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Data.Scrapers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Data-Scrapers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Data-Scrapers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1'></a>
## WebsiteDataScraperBase\`1 `type`

##### Namespace

xyLOGIX.Data.Scrapers

##### Summary

Defines methods, events, and properties that all data-scraper objects
share in common with each other.

<a name='M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-#ctor-xyLOGIX-Data-Paginators-Interfaces-IScrapedDataPaginator,xyLOGIX-Data-Scrapers-Services-Factories-Interfaces-IScraperServiceFactory-'></a>
### #ctor(scrapedDataPaginator,scraperServiceFactory) `constructor`

##### Summary

Constructs a new instance of
[WebsiteDataScraperBase](#T-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase')
and returns a reference
to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scrapedDataPaginator | [xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator](#T-xyLOGIX-Data-Paginators-Interfaces-IScrapedDataPaginator 'xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator') | (Required.) Reference to an instance of an object that implements
the [IScrapedDataPaginator](#T-xyLOGIX-Data-Paginators-Interfaces-IScrapedDataPaginator 'xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator')
interface. |
| scraperServiceFactory | [xyLOGIX.Data.Scrapers.Services.Factories.Interfaces.IScraperServiceFactory](#T-xyLOGIX-Data-Scrapers-Services-Factories-Interfaces-IScraperServiceFactory 'xyLOGIX.Data.Scrapers.Services.Factories.Interfaces.IScraperServiceFactory') | (Required.) Reference to an instance of an object that implements the
[IScraperServiceFactory](#T-xyLOGIX-Data-Scrapers-Services-Factories-Interfaces-IScraperServiceFactory 'xyLOGIX.Data.Scrapers.Services.Factories.Interfaces.IScraperServiceFactory')
interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if either of the required parameters,
`scrapedDataPaginator` or
`scraperServiceFactory`, were passed a
`null` reference as an argument. |

<a name='M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[WebsiteDataScraperBase](#T-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase')
and returns a reference
to it.

##### Parameters

This constructor has no parameters.

<a name='F-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-_scrapedDataPaginator'></a>
### _scrapedDataPaginator `constants`

##### Summary

Instance of an object that implements the
[IScrapedDataPaginator](#T-xyLOGIX-Data-Paginators-Interfaces-IScrapedDataPaginator 'xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator')
interface.

##### Remarks

This object manages the scrapedDataPaginator of scraped data for this class.

<a name='F-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-_scraperService'></a>
### _scraperService `constants`

##### Summary

Reference to an instance of an object that provides scraping services.

<a name='F-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-_scraperServiceFactory'></a>
### _scraperServiceFactory `constants`

##### Summary

Reference to an instance of an object that implements the
[IScraperServiceFactory](#T-xyLOGIX-Data-Scrapers-Services-Factories-Interfaces-IScraperServiceFactory 'xyLOGIX.Data.Scrapers.Services.Factories.Interfaces.IScraperServiceFactory')
interface which is responsible for giving us access to scraper
service objects.

<a name='P-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-Website'></a>
### Website `property`

##### Summary

Gets the
[WebsitesToScrape](#T-xyLOGIX-Data-Scrapers-Constants-WebsitesToScrape 'xyLOGIX.Data.Scrapers.Constants.WebsitesToScrape')
value
that indicates which website this scraper is being used to pull data from.

<a name='M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-CanScrape-System-String-'></a>
### CanScrape(url) `method`

##### Summary

Determines whether we can scrape data or not.

##### Returns

`true` to allow the scraping operation to continue;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the URL from which data is about to be scraped. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `url`, is passed
a blank or `null` string for a value. |

<a name='M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-HasMore'></a>
### HasMore() `method`

##### Summary

Gets a value indicating whether we're at the end of the data.

##### Returns

`true` if there are more data to follow;
`false` otherwise.

##### Parameters

This method has no parameters.

##### Remarks

Think of the data to be scraped as being akin to a stream.

<a name='M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-OnScrapeComplete'></a>
### OnScrapeComplete() `method`

##### Summary

Raises the
[](#E-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase-ScrapeComplete 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase.ScrapeComplete')
event.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-OnScrapingStarted-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventArgs-'></a>
### OnScrapingStarted(e) `method`

##### Summary

Raises the
[](#E-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase-ScrapingStarted 'xyLOGIX.Data.Scrapers.WebsiteDataScraperBase.ScrapingStarted')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventArgs](#T-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventArgs 'xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventArgs') | A
[ScrapingStartedEventArgs](#T-CoinMarketCap-Data-Scraper-ScrapingStartedEventArgs 'CoinMarketCap.Data.Scraper.ScrapingStartedEventArgs')
that
contains the event data. |

<a name='M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-Rewind'></a>
### Rewind() `method`

##### Summary

Rewinds the scraper back to the beginning of the data.

##### Parameters

This method has no parameters.

##### Remarks

Think of the data to be scraped being akin to a stream.

<a name='M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-ScrapeAll'></a>
### ScrapeAll() `method`

##### Summary

Scrapes all the pages of available data until all data has been retrieved.

##### Returns

Collection of instances of `TModel`, one element
for each page of data.

##### Parameters

This method has no parameters.

##### Remarks

If this method fails to retrieve all the pages, it returns the pages
it has, or, if the error was unrecoverable, the empty collection.



Pages are listed in the order in which they were obtained.

<a name='M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-ScrapeCurrentPage'></a>
### ScrapeCurrentPage() `method`

##### Summary

Scrapes the data from the current page, and returns it serialized into an
instance of the `TModel`.

##### Returns

Reference to an instance of `TModel` that
contains the data from the current page.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Scrapers-WebsiteDataScraperBase`1-ScrapeRange-System-Int32,System-Int32-'></a>
### ScrapeRange(first,last) `method`

##### Summary

Scrapes all the pages of data within a certain range of page numbers.

##### Returns

If successful, a collection of instances of `TModel`, one
element for each page of data retrieved; the empty collection otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) An [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') denoting the
number of the first page of data to be retrieved. |
| last | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) An [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') denoting the
number of the last page of data to be retrieved. |

##### Remarks

If the `first` page is after the
`last`, or if `first` is less than
`zero`, or if `last` is greater than the total number of
pages, then this method returns the empty collection.



The empty collection is also returned if an error occurred during the scraping
operation.
