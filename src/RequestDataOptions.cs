using Newtonsoft.Json;
using Soenneker.Dtos.Filters.ExactMatch;
using Soenneker.Dtos.Filters.Range;
using Soenneker.Dtos.Options.OrderBy;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Dtos.RequestDataOptions;

/// <summary>
/// Options for flexible, efficient, and explicit querying in Cosmos DB or similar repositories.
/// </summary>
public sealed class RequestDataOptions
{
    /// <summary>
    /// Maximum items to return in one page
    /// </summary>
    [JsonProperty("pageSize")]
    [JsonPropertyName("pageSize")]
    public int PageSize { get; set; }

    /// <summary>
    /// Opaque Cosmos DB continuation token.  
    /// ‑ <see langword="null"/> on the **first** request.  
    /// ‑ Client must echo back the <c>NextToken</c> it received from the previous page.
    /// </summary>
    [JsonProperty("continuationToken")]
    [JsonPropertyName("continuationToken")]
    public string? ContinuationToken { get; set; }

    /// <summary>
    /// List of sort instructions, in priority order.
    /// </summary>
    [JsonProperty("orderBy")]
    [JsonPropertyName("orderBy")]
    public List<OrderByOption>? OrderBy { get; set; }

    /// <summary>
    /// Whether to include the total count in the response (for pagination).
    /// </summary>
    [JsonProperty("includeCount")]
    [JsonPropertyName("includeCount")]
    public bool? IncludeCount { get; set; }

    /// <summary>
    /// The search term to filter results (applied to <see cref="SearchFields"/>).
    /// </summary>
    [JsonProperty("search")]
    [JsonPropertyName("search")]
    public string? Search { get; set; }

    /// <summary>
    /// The list of fields to apply the Search term to (must be string properties).
    /// </summary>
    [JsonProperty("searchFields")]
    [JsonPropertyName("searchFields")]
    public List<string>? SearchFields { get; set; }

    /// <summary>
    /// Key-value exact match filters (e.g., Status = Active).
    /// </summary>
    [JsonProperty("filters")]
    [JsonPropertyName("filters")]
    public List<ExactMatchFilter>? Filters { get; set; }

    /// <summary>
    /// Advanced range-based filters (e.g., Price > 50 and Price &lt;= 200).
    /// </summary>
    [JsonProperty("rangeFilters")]
    [JsonPropertyName("rangeFilters")]
    public List<RangeFilter>? RangeFilters { get; set; }
}