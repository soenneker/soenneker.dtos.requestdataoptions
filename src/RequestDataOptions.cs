using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Dtos.RequestDataOptions;

/// <summary>
/// A flexible request options object for paging, sorting, and filtering queryable data, similar to OData-style parameters.
/// </summary>
public sealed class RequestDataOptions
{
    /// <summary>
    /// The zero-based index of the first item to return.
    /// </summary>
    [JsonPropertyName("skip")]
    [JsonProperty("skip")]
    public int? Skip { get; set; }

    /// <summary>
    /// The number of items to return.
    /// </summary>
    [JsonPropertyName("take")]
    [JsonProperty("take")]
    public int? Take { get; set; }

    /// <summary>
    /// The sort expression, e.g., "Name asc" or "CreatedAt desc".
    /// </summary>
    [JsonPropertyName("orderBy")]
    [JsonProperty("orderBy")]
    public string? OrderBy { get; set; }

    /// <summary>
    /// Whether to include the total count in the response (for pagination).
    /// </summary>
    [JsonPropertyName("includeCount")]
    [JsonProperty("includeCount")]
    public bool? IncludeCount { get; set; }

    /// <summary>
    /// The search term to filter results, e.g., "search term".
    /// </summary>
    [JsonPropertyName("search")]
    [JsonProperty("search")]
    public string? Search { get; set; }
}