<a name='assembly'></a>
# xyLOGIX.Data.Scrapers.Interfaces

## Contents

- [IScraper](#T-xyLOGIX-Data-Scrapers-Interfaces-IScraper 'xyLOGIX.Data.Scrapers.Interfaces.IScraper')
  - [Website](#P-xyLOGIX-Data-Scrapers-Interfaces-IScraper-Website 'xyLOGIX.Data.Scrapers.Interfaces.IScraper.Website')
  - [CanScrape(url)](#M-xyLOGIX-Data-Scrapers-Interfaces-IScraper-CanScrape-System-String- 'xyLOGIX.Data.Scrapers.Interfaces.IScraper.CanScrape(System.String)')
  - [HasMore()](#M-xyLOGIX-Data-Scrapers-Interfaces-IScraper-HasMore 'xyLOGIX.Data.Scrapers.Interfaces.IScraper.HasMore')
  - [Rewind()](#M-xyLOGIX-Data-Scrapers-Interfaces-IScraper-Rewind 'xyLOGIX.Data.Scrapers.Interfaces.IScraper.Rewind')
- [IScraperService](#T-xyLOGIX-Data-Scrapers-Interfaces-IScraperService 'xyLOGIX.Data.Scrapers.Interfaces.IScraperService')
  - [GetHtmlContent(url)](#M-xyLOGIX-Data-Scrapers-Interfaces-IScraperService-GetHtmlContent-System-String- 'xyLOGIX.Data.Scrapers.Interfaces.IScraperService.GetHtmlContent(System.String)')
  - [GetTagContent(url,xpath)](#M-xyLOGIX-Data-Scrapers-Interfaces-IScraperService-GetTagContent-System-String,System-String- 'xyLOGIX.Data.Scrapers.Interfaces.IScraperService.GetTagContent(System.String,System.String)')
- [Resources](#T-xyLOGIX-Data-Scrapers-Interfaces-Properties-Resources 'xyLOGIX.Data.Scrapers.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Data-Scrapers-Interfaces-Properties-Resources-Culture 'xyLOGIX.Data.Scrapers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Data-Scrapers-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Data.Scrapers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Data-Scrapers-Interfaces-IScraper'></a>
## IScraper `type`

##### Namespace

xyLOGIX.Data.Scrapers.Interfaces

##### Summary

Defines the methods and properties that all scraper objects have in common.

<a name='P-xyLOGIX-Data-Scrapers-Interfaces-IScraper-Website'></a>
### Website `property`

##### Summary

Gets the [WebsitesToScrape](#T-xyLOGIX-Data-Scrapers-Constants-WebsitesToScrape 'xyLOGIX.Data.Scrapers.Constants.WebsitesToScrape') value
that indicates which website this scraper is being used to pull data from.

<a name='M-xyLOGIX-Data-Scrapers-Interfaces-IScraper-CanScrape-System-String-'></a>
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

<a name='M-xyLOGIX-Data-Scrapers-Interfaces-IScraper-HasMore'></a>
### HasMore() `method`

##### Summary

Gets a value indicating whether we're at the end of the data.

##### Returns

`true` if there are more data to follow; `false` otherwise.

##### Parameters

This method has no parameters.

##### Remarks

Think of the data to be scraped as being akin to a stream.

<a name='M-xyLOGIX-Data-Scrapers-Interfaces-IScraper-Rewind'></a>
### Rewind() `method`

##### Summary

Rewinds the scraper back to the beginning of the data.

##### Parameters

This method has no parameters.

##### Remarks

Think of the data to be scraped being akin to a stream.

<a name='T-xyLOGIX-Data-Scrapers-Interfaces-IScraperService'></a>
## IScraperService `type`

##### Namespace

xyLOGIX.Data.Scrapers.Interfaces

##### Summary

Defines the public-exposed methods and properties of a scraper object.

<a name='M-xyLOGIX-Data-Scrapers-Interfaces-IScraperService-GetHtmlContent-System-String-'></a>
### GetHtmlContent(url) `method`

##### Summary

Gets the HTML content of the Web resource with the specified `url`.

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

<a name='M-xyLOGIX-Data-Scrapers-Interfaces-IScraperService-GetTagContent-System-String,System-String-'></a>
### GetTagContent(url,xpath) `method`

##### Summary

Obtains the HTML from the specified `url` and then
extracts the inner-text content of the element at the `xpath` provided.

##### Returns

String containing the inner textual content of the tag looked up by
the `xpath` query provided, or blank if the tag was
not found or a problem occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the URL of the page to download and parse. |
| xpath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the XPATH query to use in order to find
the desired element. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the two required parameters, `url` or `xpath`, are blank. |

<a name='T-xyLOGIX-Data-Scrapers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Data.Scrapers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Data-Scrapers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Data-Scrapers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
