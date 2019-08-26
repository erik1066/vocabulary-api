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
        /// The ID of the value set to filter on
        /// </summary>
        [Required]
        [FromRoute(Name = "id")]
        public Guid Id { get; set; } = default(Guid);
    }
}