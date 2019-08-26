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
        [FromQuery(Name = "valuesetversionid")]
        public Guid? ValueSetVersionId { get; set; }

        [FromQuery(Name = "valuesetversionnumber")]
        [RegularExpression("^([0-9]*|latest)$")]
        public string? ValueSetVersionNumber { get; set; }
    }
}