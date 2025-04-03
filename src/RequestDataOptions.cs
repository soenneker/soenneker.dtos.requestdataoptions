namespace Soenneker.Dtos.RequestDataOptions;

/// <summary>
/// A flexible request options object for paging, sorting, and filtering queryable data, similar to OData-style parameters.
/// </summary>
public class RequestDataOptions
{
    /// <summary>
    /// The zero-based index of the first item to return.
    /// </summary>
    public int? Skip { get; set; }

    /// <summary>
    /// The number of items to return.
    /// </summary>
    public int? Take { get; set; }

    /// <summary>
    /// The sort expression, e.g., "Name asc" or "CreatedAt desc".
    /// </summary>
    public string? OrderBy { get; set; }

    /// <summary>
    /// Whether to include the total count in the response (for pagination).
    /// </summary>
    public bool? IncludeCount { get; set; }
}