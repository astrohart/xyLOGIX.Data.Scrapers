<a name='assembly'></a>
# xyLOGIX.Data.Scrapers

## Contents

- [Resources](#T-xyLOGIX-Data-Scrapers-Properties-Resources 'xyLOGIX.Data.Scrapers.Properties.Resources')
  - [Culture](#P-xyLOGIX-Data-Scrapers-Properties-Resources-Culture 'xyLOGIX.Data.Scrapers.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Data-Scrapers-Properties-Resources-ResourceManager 'xyLOGIX.Data.Scrapers.Properties.Resources.ResourceManager')
- [ScraperBase](#T-xyLOGIX-Data-Scrapers-ScraperBase 'xyLOGIX.Data.Scrapers.ScraperBase')
  - [#ctor(paginator)](#M-xyLOGIX-Data-Scrapers-ScraperBase-#ctor-xyLOGIX-Data-Paginators-Interfaces-IPaginator- 'xyLOGIX.Data.Scrapers.ScraperBase.#ctor(xyLOGIX.Data.Paginators.Interfaces.IPaginator)')
  - [_paginator](#F-xyLOGIX-Data-Scrapers-ScraperBase-_paginator 'xyLOGIX.Data.Scrapers.ScraperBase._paginator')
  - [_scraperService](#F-xyLOGIX-Data-Scrapers-ScraperBase-_scraperService 'xyLOGIX.Data.Scrapers.ScraperBase._scraperService')
  - [_scraperServiceFactory](#F-xyLOGIX-Data-Scrapers-ScraperBase-_scraperServiceFactory 'xyLOGIX.Data.Scrapers.ScraperBase._scraperServiceFactory')
  - [Website](#P-xyLOGIX-Data-Scrapers-ScraperBase-Website 'xyLOGIX.Data.Scrapers.ScraperBase.Website')
  - [CanScrape(url)](#M-xyLOGIX-Data-Scrapers-ScraperBase-CanScrape-System-String- 'xyLOGIX.Data.Scrapers.ScraperBase.CanScrape(System.String)')
  - [HasMore()](#M-xyLOGIX-Data-Scrapers-ScraperBase-HasMore 'xyLOGIX.Data.Scrapers.ScraperBase.HasMore')
  - [OnScrapeComplete()](#M-xyLOGIX-Data-Scrapers-ScraperBase-OnScrapeComplete 'xyLOGIX.Data.Scrapers.ScraperBase.OnScrapeComplete')
  - [OnScrapingStarted(e)](#M-xyLOGIX-Data-Scrapers-ScraperBase-OnScrapingStarted-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventArgs- 'xyLOGIX.Data.Scrapers.ScraperBase.OnScrapingStarted(xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventArgs)')
  - [Rewind()](#M-xyLOGIX-Data-Scrapers-ScraperBase-Rewind 'xyLOGIX.Data.Scrapers.ScraperBase.Rewind')

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

<a name='T-xyLOGIX-Data-Scrapers-ScraperBase'></a>
## ScraperBase `type`

##### Namespace

xyLOGIX.Data.Scrapers

##### Summary

Defines methods, events, and properties that all data-scraper objects
share in common with each other.

<a name='M-xyLOGIX-Data-Scrapers-ScraperBase-#ctor-xyLOGIX-Data-Paginators-Interfaces-IPaginator-'></a>
### #ctor(paginator) `constructor`

##### Summary

Constructs a new instance of
[ScraperBase](#T-xyLOGIX-Data-Scrapers-ScraperBase 'xyLOGIX.Data.Scrapers.ScraperBase')
and returns a reference
to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| paginator | [xyLOGIX.Data.Paginators.Interfaces.IPaginator](#T-xyLOGIX-Data-Paginators-Interfaces-IPaginator 'xyLOGIX.Data.Paginators.Interfaces.IPaginator') | (Required.) Reference to an instance of an object that implements
the [IPaginator](#T-xyLOGIX-Data-Paginators-Interfaces-IPaginator 'xyLOGIX.Data.Paginators.Interfaces.IPaginator') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `paginator`, is
passed a `null` value. |

<a name='F-xyLOGIX-Data-Scrapers-ScraperBase-_paginator'></a>
### _paginator `constants`

##### Summary

Instance of an object that implements the
[IPaginator](#T-CoinMarketCap-Data-Scraper-Helpers-Interfaces-IPaginator 'CoinMarketCap.Data.Scraper.Helpers.Interfaces.IPaginator')
interface.

##### Remarks

This object manages the paginator of scraped data for this class.

<a name='F-xyLOGIX-Data-Scrapers-ScraperBase-_scraperService'></a>
### _scraperService `constants`

##### Summary

Reference to an instance of an object that provides scraping services.

<a name='F-xyLOGIX-Data-Scrapers-ScraperBase-_scraperServiceFactory'></a>
### _scraperServiceFactory `constants`

##### Summary

Reference to an instance of an object that implements the
[IScraperServiceFactory](#T-xyLOGIX-Data-Scrapers-Services-Factories-Interfaces-IScraperServiceFactory 'xyLOGIX.Data.Scrapers.Services.Factories.Interfaces.IScraperServiceFactory')
interface which is responsible for giving us access to scraper
service objects.

<a name='P-xyLOGIX-Data-Scrapers-ScraperBase-Website'></a>
### Website `property`

##### Summary

Gets the
[WebsitesToScrape](#T-xyLOGIX-Data-Scrapers-Constants-WebsitesToScrape 'xyLOGIX.Data.Scrapers.Constants.WebsitesToScrape')
value
that indicates which website this scraper is being used to pull data from.

<a name='M-xyLOGIX-Data-Scrapers-ScraperBase-CanScrape-System-String-'></a>
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

<a name='M-xyLOGIX-Data-Scrapers-ScraperBase-HasMore'></a>
### HasMore() `method`

##### Summary

Gets a value indicating whether we're at the end of the data.

##### Returns

`true` if there are more data to follow; `false` otherwise.

##### Parameters

This method has no parameters.

##### Remarks

Think of the data to be scraped as being akin to a stream.

<a name='M-xyLOGIX-Data-Scrapers-ScraperBase-OnScrapeComplete'></a>
### OnScrapeComplete() `method`

##### Summary

Raises the
[](#E-xyLOGIX-Data-Scrapers-ScraperBase-ScrapeComplete 'xyLOGIX.Data.Scrapers.ScraperBase.ScrapeComplete')
event.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Scrapers-ScraperBase-OnScrapingStarted-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventArgs-'></a>
### OnScrapingStarted(e) `method`

##### Summary

Raises the
[](#E-xyLOGIX-Data-Scrapers-ScraperBase-ScrapingStarted 'xyLOGIX.Data.Scrapers.ScraperBase.ScrapingStarted')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventArgs](#T-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventArgs 'xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventArgs') | A
[ScrapingStartedEventArgs](#T-CoinMarketCap-Data-Scraper-ScrapingStartedEventArgs 'CoinMarketCap.Data.Scraper.ScrapingStartedEventArgs')
that
contains the event data. |

<a name='M-xyLOGIX-Data-Scrapers-ScraperBase-Rewind'></a>
### Rewind() `method`

##### Summary

Rewinds the scraper back to the beginning of the data.

##### Parameters

This method has no parameters.

##### Remarks

Think of the data to be scraped being akin to a stream.
