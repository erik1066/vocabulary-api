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
        [Range(0, Int32.MaxValue)]
        [FromQuery(Name = "pageNumber")]
        public int PageNumber { get; set; } = 1;

        [Range(0, 100)]
        [FromQuery(Name = "pageSize")]
        public int PageSize { get; set; } = 10;

        [FromQuery(Name = "searchQuery")]
        public string SearchQuery { get; set; } = string.Empty;
    }
}