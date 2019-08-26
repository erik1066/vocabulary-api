using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Cdc.Vocabulary.WebApi.Models
{
    /// <summary>
    /// Represents pagination parameters
    /// </summary>
    public class PaginationParameters
    {
        /// <summary>
        /// The page number to return
        /// </summary>
        [Range(1, Int32.MaxValue)]
        [FromQuery(Name = "pageNumber")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// The maximum size of the result set that is returned
        /// </summary>
        [Range(0, 100)]
        [FromQuery(Name = "pageSize")]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// A free-text search string that will be used for querying the resources
        /// </summary>
        [FromQuery(Name = "searchQuery")]
        public string SearchQuery { get; set; } = string.Empty;

        /// <summary>
        /// Whether the search should use a 'contains' or 'startsWith' matching algorithm
        /// </summary>
        [FromQuery(Name = "searchType")]
        public MatchType SearchType { get; set; } = MatchType.Contains;
    }

    public enum MatchType
    {
        Contains,
        StartsWith
    }
}