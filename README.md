[![](https://img.shields.io/nuget/v/soenneker.dtos.requestdataoptions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.requestdataoptions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.requestdataoptions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.requestdataoptions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.requestdataoptions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.requestdataoptions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.requestdataoptions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.requestdataoptions/actions/workflows/codeql.yml)

# Soenneker.Dtos.RequestDataOptions

Defines cursor pagination, sorting, search, exact-match filters, and range filters for a structured API query.

## Install

```bash
dotnet add package Soenneker.Dtos.RequestDataOptions
```

## What you get

- `RequestDataOptions` — Defines cursor pagination, sorting, search, exact-match filters, and range filters for a structured API query.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `RequestDataOptions.PageSize` | Maximum number of items requested for one page; the server may enforce a lower maximum or apply a default. | Maximum number of items requested for one page; the server may enforce a lower maximum or apply a default. |
| `RequestDataOptions.ContinuationToken` | Opaque cursor returned by the previous paged response; omit it when requesting the first page and do not parse or modify it. | Opaque cursor returned by the previous paged response; omit it when requesting the first page and do not parse or modify it. |
| `RequestDataOptions.OrderBy` | Sort instructions applied in priority order, with the first entry acting as the primary sort. | Sort instructions applied in priority order, with the first entry acting as the primary sort. |
| `RequestDataOptions.IncludeCount` | Whether the response should include the total number of matching records; counting may increase query cost or latency. | Whether the response should include the total number of matching records; counting may increase query cost or latency. |
| `RequestDataOptions.Search` | Free-text search term applied to the configured `SearchFields`. | Free-text search term applied to the configured `SearchFields`. |
| `RequestDataOptions.SearchFields` | Serializable string field names searched for `Search`; supported names are determined by the queried resource. | Serializable string field names searched for `Search`; supported names are determined by the queried resource. |
| `RequestDataOptions.Filters` | Exact-match conditions that require each named field to equal its supplied value. | Exact-match conditions that require each named field to equal its supplied value. |
| `RequestDataOptions.RangeFilters` | Range conditions that constrain comparable fields with inclusive or exclusive lower and upper bounds. | Range conditions that constrain comparable fields with inclusive or exclusive lower and upper bounds. |
