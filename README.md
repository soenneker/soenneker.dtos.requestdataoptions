[![](https://img.shields.io/nuget/v/soenneker.dtos.requestdataoptions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.requestdataoptions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.requestdataoptions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.requestdataoptions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.requestdataoptions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.requestdataoptions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.requestdataoptions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.requestdataoptions/actions/workflows/codeql.yml)

# Soenneker.Dtos.RequestDataOptions

A shared request DTO for cursor pagination, multi-field sorting, free-text search, exact-match filters, and range filters. It defines the wire shape; the receiving API decides which fields and limits are valid.

## Install

```bash
dotnet add package Soenneker.Dtos.RequestDataOptions
```

## Build a query request

```csharp
using Soenneker.Dtos.Filters.ExactMatch;
using Soenneker.Dtos.Filters.Range;
using Soenneker.Dtos.Options.OrderBy;
using Soenneker.Dtos.RequestDataOptions;
using Soenneker.Enums.SortDirections;

var options = new RequestDataOptions
{
    PageSize = 50,
    IncludeCount = true,
    Search = "paid",
    SearchFields = ["description", "reference"],
    OrderBy =
    [
        new OrderByOption { Field = "createdAt", Direction = SortDirection.Desc },
        new OrderByOption { Field = "id", Direction = SortDirection.Asc }
    ],
    Filters =
    [
        new ExactMatchFilter { Field = "status", Value = "active" }
    ],
    RangeFilters =
    [
        new RangeFilter { Field = "total", GreaterThanOrEqual = 25m, LessThan = 500m }
    ]
};
```

`OrderBy` entries are sent in list order, allowing the server to treat the first as the primary sort. Range filters expose exclusive (`GreaterThan`, `LessThan`) and inclusive (`GreaterThanOrEqual`, `LessThanOrEqual`) bounds.

For the next page, copy the continuation token returned by the API without parsing or changing it:

```csharp
options.ContinuationToken = continuationTokenFromResponse;
```

## Server-side responsibilities

This type does not enforce a positive or maximum `PageSize`, interpret filters, escape search syntax, or verify field names. A server consuming it should allow-list sortable, searchable, and filterable fields; parameterize values; cap page size; and reject unsupported combinations. `IncludeCount` may make a query materially more expensive, so the server remains free to ignore or restrict it.

Nullable members are serialized or omitted according to the configured `System.Text.Json` or Newtonsoft.Json options.
