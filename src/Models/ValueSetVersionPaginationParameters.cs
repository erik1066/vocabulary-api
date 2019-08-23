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
        [FromQuery(Name = "oid")]
        public string Oid { get; set; } = string.Empty;

        [FromQuery(Name = "code")]
        public string Code { get; set; } = string.Empty;
    }
}