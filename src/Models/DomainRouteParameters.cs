using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Cdc.Vocabulary.WebApi.Models
{
    /// <summary>
    /// Represents the route parameters for a vocabulary domain
    /// </summary>
    public class DomainRouteParameters
    {
        /// <summary>
        /// The domain (aka namespace) to which the value set belongs. This could be an organization,
        /// a problem domain such as public health or clinical care, or anything else that can be
        /// used to logically relate value sets to one another.
        /// </summary>
        /// <example>
        /// CDC
        /// </example>
        [Required]
        [StringLength(64)]
        [FromRoute(Name = "domain")]
        public string Domain { get; set; } = string.Empty;
    }
}