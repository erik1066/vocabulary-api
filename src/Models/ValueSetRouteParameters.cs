using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Cdc.Vocabulary.WebApi.Models
{
    /// <summary>
    /// Represents the route parameters for locating value sets
    /// </summary>
    public class ValueSetRouteParameters : DomainRouteParameters
    {
        /// <summary>
        /// The ID of the value set.
        /// </summary>
        [Required]
        [StringLength(128)]
        [FromRoute(Name = "id")]
        public string Id { get; set; } = string.Empty;
    }
}