using System;
using System.ComponentModel.DataAnnotations;

namespace Cdc.Vocabulary.WebApi.Models
{
    public sealed class ValueSetForInsertionDto
    {
        /// <summary>
        /// The OID that uniquely identifies this ValueSet object.
        /// </summary>
        [RegularExpression(@"^[a-zA-Z0-9\.]*$")]
        public string Oid { get; set; } = string.Empty;

        /// <summary>
        /// The name of the ValueSet.
        /// </summary>
        [Required]
        [StringLength(256)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The code that uniquely identifies this ValueSet object.
        /// </summary>
        [Required]
        [StringLength(64)]
        [RegularExpression(@"^[a-zA-Z0-9_\.\-]*$")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Current state of this value set.  Valid values are [under development, active, retired].
        /// </summary>
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Definition of the specific value set [NOTE: Value Set Definition is set at the Value Set level and is universal to all versions of that value set; differential descriptions are maintained at the Value Set Version level].
        /// </summary>
        [Required]
        [StringLength(1024)]
        public string Definition { get; set; } = string.Empty;

        /// <summary>
        /// A note which defines or clarifies the purpose of the value set as it is intended to be used in PHIN information exchange and data governance validations.
        /// </summary>
        [StringLength(4096)]
        public string ScopeNote { get; set; } = string.Empty;

        /// <summary>
        /// The GUID identifier for the AssigningAuthority domain object that is associated with this ValueSet.
        /// </summary>
        public Guid AssigningAuthorityId { get; set; } = default(Guid);
    }
}