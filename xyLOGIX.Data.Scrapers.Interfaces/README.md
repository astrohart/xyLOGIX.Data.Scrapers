<a name='assembly'></a>
# xyLOGIX.Data.Scrapers.Interfaces

## Contents

- [IScraperService](#T-xyLOGIX-Data-Scrapers-Interfaces-IScraperService 'xyLOGIX.Data.Scrapers.Interfaces.IScraperService')
  - [GetHtmlContent(url)](#M-xyLOGIX-Data-Scrapers-Interfaces-IScraperService-GetHtmlContent-System-String- 'xyLOGIX.Data.Scrapers.Interfaces.IScraperService.GetHtmlContent(System.String)')
  - [GetTagContent(url,xpath)](#M-xyLOGIX-Data-Scrapers-Interfaces-IScraperService-GetTagContent-System-String,System-String- 'xyLOGIX.Data.Scrapers.Interfaces.IScraperService.GetTagContent(System.String,System.String)')
- [IWebsiteDataScraper\`1](#T-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1 'xyLOGIX.Data.Scrapers.Interfaces.IWebsiteDataScraper`1')
  - [Website](#P-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1-Website 'xyLOGIX.Data.Scrapers.Interfaces.IWebsiteDataScraper`1.Website')
  - [CanScrape(url)](#M-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1-CanScrape-System-String- 'xyLOGIX.Data.Scrapers.Interfaces.IWebsiteDataScraper`1.CanScrape(System.String)')
  - [HasMore()](#M-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1-HasMore 'xyLOGIX.Data.Scrapers.Interfaces.IWebsiteDataScraper`1.HasMore')
  - [Rewind()](#M-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1-Rewind 'xyLOGIX.Data.Scrapers.Interfaces.IWebsiteDataScraper`1.Rewind')
  - [ScrapeAll()](#M-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1-ScrapeAll 'xyLOGIX.Data.Scrapers.Interfaces.IWebsiteDataScraper`1.ScrapeAll')
  - [ScrapeCurrentPage()](#M-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1-ScrapeCurrentPage 'xyLOGIX.Data.Scrapers.Interfaces.IWebsiteDataScraper`1.ScrapeCurrentPage')
  - [ScrapeRange(first,last)](#M-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1-ScrapeRange-System-Int32,System-Int32- 'xyLOGIX.Data.Scrapers.Interfaces.IWebsiteDataScraper`1.ScrapeRange(System.Int32,System.Int32)')
- [Resources](#T-xyLOGIX-Data-Scrapers-Interfaces-Properties-Resources 'xyLOGIX.Data.Scrapers.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Data-Scrapers-Interfaces-Properties-Resources-Culture 'xyLOGIX.Data.Scrapers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Data-Scrapers-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Data.Scrapers.Interfaces.Properties.Resources.ResourceManager')

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

<a name='T-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1'></a>
## IWebsiteDataScraper\`1 `type`

##### Namespace

xyLOGIX.Data.Scrapers.Interfaces

##### Summary

Defines the methods and properties that all scraper objects have in common.

<a name='P-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1-Website'></a>
### Website `property`

##### Summary

Gets the
[WebsitesToScrape](#T-xyLOGIX-Data-Scrapers-Constants-WebsitesToScrape 'xyLOGIX.Data.Scrapers.Constants.WebsitesToScrape')
value
that indicates which website this scraper is being used to pull data from.

<a name='M-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1-CanScrape-System-String-'></a>
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

<a name='M-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1-HasMore'></a>
### HasMore() `method`

##### Summary

Gets a value indicating whether we're at the end of the data.

##### Returns

`true` if there are more data to follow;
`false`
otherwise.

##### Parameters

This method has no parameters.

##### Remarks

Think of the data to be scraped as being akin to a stream.

<a name='M-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1-Rewind'></a>
### Rewind() `method`

##### Summary

Rewinds the scraper back to the beginning of the data.

##### Parameters

This method has no parameters.

##### Remarks

Think of the data to be scraped being akin to a stream.

<a name='M-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1-ScrapeAll'></a>
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

<a name='M-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1-ScrapeCurrentPage'></a>
### ScrapeCurrentPage() `method`

##### Summary

Scrapes the data from the current page, and returns it serialized into an
instance of the `TModel`.

##### Returns

Reference to an instance of `TModel` that
contains the data from the current page.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Scrapers-Interfaces-IWebsiteDataScraper`1-ScrapeRange-System-Int32,System-Int32-'></a>
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
