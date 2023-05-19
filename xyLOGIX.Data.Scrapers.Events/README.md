<a name='assembly'></a>
# xyLOGIX.Data.Scrapers.Events

## Contents

- [Resources](#T-xyLOGIX-Data-Scrapers-Events-Properties-Resources 'xyLOGIX.Data.Scrapers.Events.Properties.Resources')
  - [Culture](#P-xyLOGIX-Data-Scrapers-Events-Properties-Resources-Culture 'xyLOGIX.Data.Scrapers.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Data-Scrapers-Events-Properties-Resources-ResourceManager 'xyLOGIX.Data.Scrapers.Events.Properties.Resources.ResourceManager')
- [ScraperServiceExceptionRaisedEventArgs](#T-xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventArgs 'xyLOGIX.Data.Scrapers.Events.ScraperServiceExceptionRaisedEventArgs')
  - [#ctor(url,exception)](#M-xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventArgs-#ctor-System-String,System-Exception- 'xyLOGIX.Data.Scrapers.Events.ScraperServiceExceptionRaisedEventArgs.#ctor(System.String,System.Exception)')
  - [Exception](#P-xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventArgs-Exception 'xyLOGIX.Data.Scrapers.Events.ScraperServiceExceptionRaisedEventArgs.Exception')
  - [Url](#P-xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventArgs-Url 'xyLOGIX.Data.Scrapers.Events.ScraperServiceExceptionRaisedEventArgs.Url')
- [ScraperServiceExceptionRaisedEventHandler](#T-xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventHandler 'xyLOGIX.Data.Scrapers.Events.ScraperServiceExceptionRaisedEventHandler')
- [ScrapingStartedEventArgs](#T-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventArgs 'xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventArgs')
  - [#ctor(url)](#M-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventArgs-#ctor-System-String- 'xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventArgs.#ctor(System.String)')
  - [Url](#P-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventArgs-Url 'xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventArgs.Url')
- [ScrapingStartedEventHandler](#T-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventHandler 'xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventHandler')

<a name='T-xyLOGIX-Data-Scrapers-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Data.Scrapers.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Data-Scrapers-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Data-Scrapers-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventArgs'></a>
## ScraperServiceExceptionRaisedEventArgs `type`

##### Namespace

xyLOGIX.Data.Scrapers.Events

##### Summary

Defines the data that is passed by all `ScraperServiceExceptionRaised`
events.

<a name='M-xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventArgs-#ctor-System-String,System-Exception-'></a>
### #ctor(url,exception) `constructor`

##### Summary

Creates a new instance of
[ExceptionRaisedEventArgs](#T-CoinMarketCap-Data-Scraper-Helpers-Events-ExceptionRaisedEventArgs 'CoinMarketCap.Data.Scraper.Helpers.Events.ExceptionRaisedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the URL of the content currently being parsed. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) A [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that describes the error. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `url`, is blank. |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `exception` is
`null`. |

<a name='P-xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that describes the error.

<a name='P-xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventArgs-Url'></a>
### Url `property`

##### Summary

Gets a string containing the URL of the web content currently being parsed.

<a name='T-xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventHandler'></a>
## ScraperServiceExceptionRaisedEventHandler `type`

##### Namespace

xyLOGIX.Data.Scrapers.Events

##### Summary

Defines the method signature for the handlers of a `ScraperServiceExceptionRaised` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:xyLOGIX.Data.Scrapers.Events.ScraperServiceExceptionRaisedEventHandler](#T-T-xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventHandler 'T:xyLOGIX.Data.Scrapers.Events.ScraperServiceExceptionRaisedEventHandler') | Reference to the instance of the object that raised the event. |

<a name='T-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventArgs'></a>
## ScrapingStartedEventArgs `type`

##### Namespace

xyLOGIX.Data.Scrapers.Events

##### Summary

Defines the data that is passed by all events of type [ScrapingStartedEventHandler](#T-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventHandler 'xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventHandler').

<a name='M-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventArgs-#ctor-System-String-'></a>
### #ctor(url) `constructor`

##### Summary

Constructs a new instance of [ScrapingStartedEventArgs](#T-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventArgs 'xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the URL of the web page that is about to
be scraped. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the `url` parameter is blank. |

<a name='P-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventArgs-Url'></a>
### Url `property`

##### Summary

Gets the URL of the web page that is about to be scraped.

<a name='T-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventHandler'></a>
## ScrapingStartedEventHandler `type`

##### Namespace

xyLOGIX.Data.Scrapers.Events

##### Summary

Defines the method signature for the handlers of the [](#E-CoinMarketCap-Data-Scraper-CoinMarketCapScraper-ScrapingStarted 'CoinMarketCap.Data.Scraper.CoinMarketCapScraper.ScrapingStarted') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventHandler](#T-T-xyLOGIX-Data-Scrapers-Events-ScrapingStartedEventHandler 'T:xyLOGIX.Data.Scrapers.Events.ScrapingStartedEventHandler') | Reference to the instance of the object that raised the event. |
