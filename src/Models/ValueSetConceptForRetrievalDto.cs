using System;

namespace Cdc.Vocabulary.WebApi.Models
{
    public sealed class ValueSetConceptForRetrievalDto
    {
        /// <summary>
        /// The GUID identifier for this ValueSetConcept object.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The OID that identifies the CodeSystem with which this ValueSetConcept is associated.
        /// </summary>
        public string CodeSystemOid { get; set; }

        /// <summary>
        /// The GUID that identifies the ValueSetVersion with which this ValueSetConcept is associated.
        /// </summary>
        public string ValueSetVersionId { get; set; }

        /// <summary>
        /// The conceptCode text that uniquely identifies this ValueSetConcept within a ValueSetVersion or a CodeSystem.
        /// </summary>
        public string ConceptCode { get; set; }

        /// <summary>
        /// The text that describes the scope of this ValueSetConcept
        /// </summary>
        public string ScopeNote { get; set; }

        /// <summary>
        /// A code value which specifies the current state of a vocabulary object.  Valid values are [Un-Published, Published, Retired].
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The date that the status was last modified.
        /// </summary>
        public DateTimeOffset StatusDate { get; set; }

        /// <summary>
        /// The "preferred term", the designation the CDC believes is most desired for use when representing the concept.
        /// </summary>
        public string CdcPreferredDesignation { get; set; }

        /// <summary>
        /// Actual description or synonym name or text provided by SDO for this Concept where the Alternate Designation is defined as a Code and is the PHIN Preferred Term for this Concept.
        /// </summary>
        public string PreferredAlternateCode { get; set; }

        /// <summary>
        /// The description or extra information describing this ValueSetConcept object
        /// </summary>
        public string Definition { get; set; }

        /// <summary>
        /// The Name of the CodeSystemConcept which was used as the source for this ValueSetConcept.
        /// </summary>
        public string CodeSystemConceptName { get; set; }
    }
}