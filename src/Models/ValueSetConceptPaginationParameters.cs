using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Cdc.Vocabulary.WebApi.Models
{
    /// <summary>
    /// Represents value set concept pagination parameters
    /// </summary>
    public class ValueSetConceptPaginationParameters : ValueSetVersionPaginationParameters
    {
        /// <summary>
        /// The value set version ID to filter on.
        /// </summary>
        [FromQuery(Name = "valuesetversionid")]
        public Guid? ValueSetVersionId { get; set; }

        /// <summary>
        /// The value set version number to filter on. Using the special value 'latest' will automatically filter on the latest version number.
        /// </summary>
        [FromQuery(Name = "valuesetversionnumber")]
        [RegularExpression("^([0-9]*|latest)$")]
        public string? ValueSetVersionNumber { get; set; }

        /// <summary>
        /// The concept code to filter on.
        /// </summary>
        [FromQuery(Name = "conceptcode")]
        public string? ConceptCode { get; set; }
    }
}