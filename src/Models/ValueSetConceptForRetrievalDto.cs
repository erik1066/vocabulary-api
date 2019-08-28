using System;

namespace Cdc.Vocabulary.WebApi.Models
{
    public sealed class ValueSetConceptForRetrievalDto
    {
        /// <summary>
        /// The GUID identifier for this ValueSetConcept object.
        /// </summary>
        public Guid Id { get; set; } = default(Guid);

        /// <summary>
        /// The GUID that identifies the ValueSetVersion with which this ValueSetConcept is associated.
        /// </summary>
        public string ValueSetVersionId { get; set; } = string.Empty;

        /// <summary>
        /// The version number of the value set to which this concept belongs
        /// </summary>
        public int? ValueSetVersionNumber { get; set; }

        /// <summary>
        /// The code of the value set to which this concept belongs
        /// </summary>
        public string ValueSetCode { get; set; } = string.Empty;

        /// <summary>
        /// The OID of the value set to which this concept belongs
        /// </summary>
        public string ValueSetOid { get; set; } = string.Empty;

        /// <summary>
        /// The conceptCode text that uniquely identifies this ValueSetConcept within a ValueSetVersion or a CodeSystem.
        /// </summary>
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// The "preferred term", the designation the CDC believes is most desired for use when representing the concept.
        /// </summary>
        public string CdcPreferredDesignation { get; set; } = string.Empty;

        /// <summary>
        /// The Name of the CodeSystemConcept which was used as the source for this ValueSetConcept.
        /// </summary>
        public string CodeSystemConceptName { get; set; } = string.Empty;

        /// <summary>
        /// TODO: Fill this in
        /// </summary>
        public string Hl70396Identifier { get; set; } = string.Empty;

        /// <summary>
        /// The text that describes the scope of this ValueSetConcept
        /// </summary>
        public string ScopeNote { get; set; } = string.Empty;

        /// <summary>
        /// A code value which specifies the current state of a vocabulary object.  Valid values are [Un-Published, Published, Retired].
        /// </summary>
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// The date that the status was last modified.
        /// </summary>
        public DateTimeOffset StatusDate { get; set; }

        /// <summary>
        /// Actual description or synonym name or text provided by SDO for this Concept where the Alternate Designation is defined as a Code and is the PHIN Preferred Term for this Concept.
        /// </summary>
        public string PreferredAlternateCode { get; set; } = string.Empty;

        /// <summary>
        /// The description or extra information describing this ValueSetConcept object
        /// </summary>
        public string Definition { get; set; } = string.Empty;

        /// <summary>
        /// The OID that identifies the CodeSystem with which this ValueSetConcept is associated.
        /// </summary>
        public string CodeSystemOid { get; set; } = string.Empty;

        /// <summary>
        /// A number that indicates the preferred positioning of this concept when the concept is displayed on a client system
        /// </summary>
        public int? Sequence { get; set; }
    }
}