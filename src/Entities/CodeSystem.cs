using System;

namespace Cdc.Vocabulary.Entities
{
    public sealed class CodeSystem
    {
        public string CodeSystemOID { get; set; } = string.Empty;

        public string HL70396Identifier { get; set; } = string.Empty;

        public Guid CodeSystemID { get; set; }

        public string CodeSystemCode { get; set; } = string.Empty;

        public string CodeSystemName { get; set; } = string.Empty;

        public string CodeSystemDefinitionText { get; set; } = string.Empty;

        public string StatusCode { get; set; } = string.Empty;

        public DateTime StatusDateTime { get; set; }

        public string CodeSystemVersion { get; set; } = string.Empty;

        public string VersionDescriptionText { get; set; } = string.Empty;
        public DateTime AcquiredDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Guid AuthorityID { get; set; }
        public string AssigningAuthorityVersionName { get; set; } = string.Empty;
        public DateTime AssigningAuthorityReleaseDate { get; set; }
        public Guid DistributionSourceID { get; set; }
        public DateTime DistributionSourceReleaseDate { get; set; }
        public string DistributionSourceVersionName { get; set; } = string.Empty;
        public DateTime SDOCodeSystemCreateDate { get; set; }
        public DateTime SDOCodeSystemRevisionDate { get; set; }
        public string CodeSystemSourceURL { get; set; } = string.Empty;
        public string LegacyFlag { get; set; } = string.Empty;
    }
}