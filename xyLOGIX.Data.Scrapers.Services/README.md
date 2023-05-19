<a name='assembly'></a>
# xyLOGIX.Data.Scrapers.Services

## Contents

- [Resources](#T-xyLOGIX-Data-Scrapers-Services-Properties-Resources 'xyLOGIX.Data.Scrapers.Services.Properties.Resources')
  - [Culture](#P-xyLOGIX-Data-Scrapers-Services-Properties-Resources-Culture 'xyLOGIX.Data.Scrapers.Services.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Data-Scrapers-Services-Properties-Resources-ResourceManager 'xyLOGIX.Data.Scrapers.Services.Properties.Resources.ResourceManager')
- [ScraperService](#T-xyLOGIX-Data-Scrapers-Services-ScraperService 'xyLOGIX.Data.Scrapers.Services.ScraperService')
  - [GetHtmlContent(url)](#M-xyLOGIX-Data-Scrapers-Services-ScraperService-GetHtmlContent-System-String- 'xyLOGIX.Data.Scrapers.Services.ScraperService.GetHtmlContent(System.String)')
  - [GetTagContent(url,xpath)](#M-xyLOGIX-Data-Scrapers-Services-ScraperService-GetTagContent-System-String,System-String- 'xyLOGIX.Data.Scrapers.Services.ScraperService.GetTagContent(System.String,System.String)')
  - [OnScraperServiceExceptionRaised(e)](#M-xyLOGIX-Data-Scrapers-Services-ScraperService-OnScraperServiceExceptionRaised-xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventArgs- 'xyLOGIX.Data.Scrapers.Services.ScraperService.OnScraperServiceExceptionRaised(xyLOGIX.Data.Scrapers.Events.ScraperServiceExceptionRaisedEventArgs)')

<a name='T-xyLOGIX-Data-Scrapers-Services-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Data.Scrapers.Services.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Data-Scrapers-Services-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Data-Scrapers-Services-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Data-Scrapers-Services-ScraperService'></a>
## ScraperService `type`

##### Namespace

xyLOGIX.Data.Scrapers.Services

##### Summary

Scrapes content from the Web and provides parsing helper methods.

<a name='M-xyLOGIX-Data-Scrapers-Services-ScraperService-GetHtmlContent-System-String-'></a>
### GetHtmlContent(url) `method`

##### Summary

Gets the HTML content of the Web resource with the specified
`url`.

##### Returns

String containing the content obtained; blank if not found or if a
problem occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the URL of the page to download and parse. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `url`, is blank. |

<a name='M-xyLOGIX-Data-Scrapers-Services-ScraperService-GetTagContent-System-String,System-String-'></a>
### GetTagContent(url,xpath) `method`

##### Summary

Obtains the HTML from the specified `url` and then
extracts the inner-text content of the element at the
`xpath`
provided.

##### Returns

String containing the inner textual content of the tag looked up by
the `xpath` query provided, or blank if the tag was
not found or a problem occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the URL of the page to download and parse. |
| xpath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the XPATH query to use in order to
find the desired element. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the two required parameters,
`url`
or `xpath`, are blank. |

<a name='M-xyLOGIX-Data-Scrapers-Services-ScraperService-OnScraperServiceExceptionRaised-xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventArgs-'></a>
### OnScraperServiceExceptionRaised(e) `method`

##### Summary

Raises the
[](#E-CoinMarketCap-Data-Scraper-Helpers-Scraper-ScraperServiceExceptionRaised 'CoinMarketCap.Data.Scraper.Helpers.Scraper.ScraperServiceExceptionRaised')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.Data.Scrapers.Events.ScraperServiceExceptionRaisedEventArgs](#T-xyLOGIX-Data-Scrapers-Events-ScraperServiceExceptionRaisedEventArgs 'xyLOGIX.Data.Scrapers.Events.ScraperServiceExceptionRaisedEventArgs') | A
[ScraperServiceExceptionRaisedEventArgs](#T-CoinMarketCap-Data-Scraper-Helpers-Events-ScraperServiceExceptionRaisedEventArgs 'CoinMarketCap.Data.Scraper.Helpers.Events.ScraperServiceExceptionRaisedEventArgs')
that contains the event data. |
