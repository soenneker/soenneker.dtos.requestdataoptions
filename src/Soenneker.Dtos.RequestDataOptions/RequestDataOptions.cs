using Newtonsoft.Json;
using Soenneker.Dtos.Filters.ExactMatch;
using Soenneker.Dtos.Filters.Range;
using Soenneker.Dtos.Options.OrderBy;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.RequestDataOptions;

/// <summary>
/// Defines cursor pagination, sorting, search, exact-match filters, and range filters for a structured API query.
/// </summary>
[PublicOpenApiObject]
public sealed class RequestDataOptions
{
    /// <summary>
    /// Maximum number of items requested for one page; the server may enforce a lower maximum or apply a default.
    /// </summary>
    [JsonProperty("pageSize")]
    [JsonPropertyName("pageSize")]
    public int PageSize { get; set; }

    /// <summary>
    /// Opaque cursor returned by the previous paged response; omit it when requesting the first page and do not parse or modify it.
    /// </summary>
    [JsonProperty("continuationToken")]
    [JsonPropertyName("continuationToken")]
    public string? ContinuationToken { get; set; }

    /// <summary>
    /// Sort instructions applied in priority order, with the first entry acting as the primary sort.
    /// </summary>
    [JsonProperty("orderBy")]
    [JsonPropertyName("orderBy")]
    public List<OrderByOption>? OrderBy { get; set; }

    /// <summary>
    /// Whether the response should include the total number of matching records; counting may increase query cost or latency.
    /// </summary>
    [JsonProperty("includeCount")]
    [JsonPropertyName("includeCount")]
    public bool? IncludeCount { get; set; }

    /// <summary>
    /// Free-text search term applied to the configured <see cref="SearchFields"/>.
    /// </summary>
    [JsonProperty("search")]
    [JsonPropertyName("search")]
    public string? Search { get; set; }

    /// <summary>
    /// Serializable string field names searched for <see cref="Search"/>; supported names are determined by the queried resource.
    /// </summary>
    [JsonProperty("searchFields")]
    [JsonPropertyName("searchFields")]
    public List<string>? SearchFields { get; set; }

    /// <summary>
    /// Exact-match conditions that require each named field to equal its supplied value.
    /// </summary>
    [JsonProperty("filters")]
    [JsonPropertyName("filters")]
    public List<ExactMatchFilter>? Filters { get; set; }

    /// <summary>
    /// Range conditions that constrain comparable fields with inclusive or exclusive lower and upper bounds.
    /// </summary>
    [JsonProperty("rangeFilters")]
    [JsonPropertyName("rangeFilters")]
    public List<RangeFilter>? RangeFilters { get; set; }
}
