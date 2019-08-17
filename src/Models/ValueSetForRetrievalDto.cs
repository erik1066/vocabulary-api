using System;

namespace Cdc.Vocabulary.WebApi.Models
{
    public sealed class ValueSetForRetrievalDto
    {
        /// <summary>
        /// The GUID identifier for this ValueSet object.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The OID that uniquely identifies this ValueSet object.
        /// </summary>
        public string Oid { get; set; }

        /// <summary>
        /// The name of the ValueSet.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The code that uniquely identifies this ValueSet object.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Current state of this value set.  Valid values are [under development, active, retired].
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The date that the status was last modified.
        /// </summary>
        public DateTimeOffset StatusDate { get; set; }

        /// <summary>
        /// Definition of the specific value set [NOTE: Value Set Definition is set at the Value Set level and is universal to all versions of that value set; differential descriptions are maintained at the Value Set Version level].
        /// </summary>
        public string Definition { get; set; }

        /// <summary>
        /// A note which defines or clarifies the purpose of the value set as it is intended to be used in PHIN information exchange and data governance validations.
        /// </summary>
        public string ScopeNote { get; set; }

        /// <summary>
        /// The GUID identifier for the AssigningAuthority domain object that is associated with this ValueSet.
        /// </summary>
        public Guid AssigningAuthorityId { get; set; }

        /// <summary>
        /// The date that this ValueSet was created.
        /// </summary>
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// The date that this ValueSet was last modified.
        /// </summary>
        public DateTimeOffset LastRevisionDate { get; set; }
    }
}