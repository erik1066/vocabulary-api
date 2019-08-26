using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Cdc.Vocabulary.WebApi.Models
{
    /// <summary>
    /// Represents value set version pagination parameters
    /// </summary>
    public class ValueSetVersionPaginationParameters : PaginationParameters
    {
        [FromQuery(Name = "valuesetoid")]
        public string ValueSetOid { get; set; } = string.Empty;

        [FromQuery(Name = "valuesetcode")]
        public string ValueSetCode { get; set; } = string.Empty;
    }
}