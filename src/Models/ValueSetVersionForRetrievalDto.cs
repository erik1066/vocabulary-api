using System;

namespace Cdc.Vocabulary.WebApi.Models
{
    public sealed class ValueSetVersionForRetrievalDto
    {
        /// <summary>
        /// The GUID identifier for this ValueSetVersion object.
        /// </summary>
        public Guid Id { get; set; } = default(Guid);

        /// <summary>
        /// The OID that identifies the ValueSet domain object with which this object is associated.
        /// </summary>
        public string Oid { get; set; } = string.Empty;

        /// <summary>
        /// The version number of this ValueSetVersion.
        /// </summary>
        public int Version { get; set; } = 0;

        /// <summary>
        /// The name of the ValueSet.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The code that uniquely identifies this ValueSet object.
        /// </summary>
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Definition of the specific value set [NOTE: Value Set Definition is set at the Value Set level and is universal to all versions of that value set; differential descriptions are maintained at the Value Set Version level].
        /// </summary>
        public string Definition { get; set; } = string.Empty;

        /// <summary>
        /// The text that describes this ValueSetVersion.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// A code value which specifies the current state of this value set version object.  Valid values are [Un-Published, Published, Retired].
        /// </summary>
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// The date that the status was last modified.
        /// </summary>
        public DateTimeOffset? StatusDate { get; set; }

        /// <summary>
        /// Used to label a version of the value set.  Defines the requirement to create a new version of the value set.
        /// </summary>
        public string AssigningAuthorityText { get; set; } = string.Empty;

        /// <summary>
        /// The date the value set is released by the assigning authority.
        /// </summary>
        public DateTimeOffset? AssigningAuthorityReleaseDate { get; set; }

        /// <summary>
        /// Used to document information of interest.  This metadata property can be used to document information on how the value set is created such as if the value set is an enumeration of a coding system, and the root concept for the enumeration.  
        /// </summary>
        public string NoteText { get; set; } = string.Empty;

        /// <summary>
        /// The date that this ValueSetVersion is effective.
        /// </summary>
        public DateTimeOffset? EffectiveDate { get; set; }

        /// <summary>
        /// The date that this ValueSetVersion is set to expire.
        /// </summary>
        public DateTimeOffset? ExpiryDate { get; set; }
    }
}