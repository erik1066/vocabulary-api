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
        /// <summary>
        /// The OID of the value set to filter on. Ex: 2.16.840.1.114222.4.11.888
        /// </summary>
        [FromQuery(Name = "valuesetoid")]
        public string ValueSetOid { get; set; } = string.Empty;

        /// <summary>
        /// The Code of the value set to filter on. Ex: PHVS_YesNoUnknown_CDC
        /// </summary>
        [FromQuery(Name = "valuesetcode")]
        public string ValueSetCode { get; set; } = string.Empty;
    }
}