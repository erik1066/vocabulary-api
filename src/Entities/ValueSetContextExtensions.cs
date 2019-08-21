using System;
using System.Collections.Generic;

namespace Cdc.Vocabulary.Entities
{
    public static class ValueSetContextExtensions
    {
        public static void EnsureSeedDataForContext(this ValueSetContext context)
        {
            // first, clear the database.  This ensures we can always start 
            // fresh with each demo.  Not advised for production environments, obviously :-)

            context.ValueSets.RemoveRange(context.ValueSets);
            context.SaveChanges();

            // init seed data
            var valueSets = new List<ValueSet>()
            {
                new ValueSet()
                {
                    ValueSetID = new Guid("cf13f137-4aca-4f5e-a08e-54397914a013"),
                    ValueSetCode = "PHVS_YesNoUnknown_CDC",
                    ValueSetName = "Yes No Unknown (YNU)",
                    ValueSetOID = "2.16.840.1.114222.4.11.888",
                    DefinitionText = "Value set used to respond to any question that can be answered Yes, No, or Unknown.",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("055e8716-48e6-4e4f-bb4f-bb846312f2a9"),
                    ValueSetCode = "PHVS_RaceCategory_CDC",
                    ValueSetName = "Race Category",
                    ValueSetOID = "2.16.840.1.114222.4.11.836",
                    DefinitionText = "General race category reported by the patient - subject may have more than one",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("92bd2cb7-04c1-41aa-9455-d1b0533972fe"),
                    ValueSetCode = "PHVS_EthnicityGroup_CDC",
                    ValueSetName = "Ethnicity group ",
                    ValueSetOID = "2.16.840.1.114222.4.11.837",
                    DefinitionText = "Whether the patient is hispanic or not",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c22356d1-62dd-4382-b258-67e28c0423d3"),
                    ValueSetCode = "PHVS_Microorganism_CDC",
                    ValueSetName = "Microorganism",
                    ValueSetOID = "2.16.840.1.114222.4.11.1009",
                    DefinitionText = "Microorganisms/infectious agents",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e46842ec-1112-4f1c-8e87-ab4f5e896cb5"),
                    ValueSetCode = "PHVS_BirthCountry_CDC",
                    ValueSetName = "Birth Country",
                    ValueSetOID = "2.16.840.1.114222.4.11.3200",
                    DefinitionText = "Country of Birth value set includes current countries as well as historical countries (eg. USSR). This value set is based upon ISO 3166-1, Alpha-3 codes (current countries), ISO 3166-3 (retired countries) and FIPS 10-4 (US Territories, Countries that are not found in ISO 3166)",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2aeccf0c-baaa-4b2d-bfe8-b66916cfdb51"),
                    ValueSetCode = "PHVS_AddressType_HL7_2x",
                    ValueSetName = "Address Type (HL7) ",
                    ValueSetOID = "2.16.840.1.114222.4.11.801",
                    DefinitionText = "Address Type",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("885b7532-491b-4993-ba18-6dcd946912bc"),
                    ValueSetCode = "PHVS_Sex_MFU",
                    ValueSetName = "Sex (MFU)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1038",
                    DefinitionText = "Constrained list of sex codes in use by public health. Keyword: Administrative Sex.",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("aea41ec7-3f97-4d59-a9ac-99f2952fa9ff"),
                    ValueSetCode = "PHVS_RaceCategory_CDC_NullFlavor",
                    ValueSetName = "Race Category including Null Flavor ",
                    ValueSetOID = "2.16.840.1.114222.4.11.7205",
                    DefinitionText = "Based on CDC Race Category Value Set but includes selected Null Flavor concepts.",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("372ecbd3-2bd9-471a-897e-d4a075210407"),
                    ValueSetCode = "PHVS_EthnicityGroup_CDC_Unk",
                    ValueSetName = "Ethnicity Group including Unknown ",
                    ValueSetOID = "2.16.840.1.114222.4.11.3015",
                    DefinitionText = "Ethnicity Group including Unknown",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7c48f4e9-9fed-4c0f-b56a-364a326eefbd"),
                    ValueSetCode = "PHVS_Country_ISO_3166-1",
                    ValueSetName = "Country",
                    ValueSetOID = "2.16.840.1.114222.4.11.828",
                    DefinitionText = "Codes representing country of origin, nationality, citizenship, address country",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f9b1352c-2f7a-4c3f-bcb9-7a2c33e9a04c"),
                    ValueSetCode = "PHVS_County_FIPS_6-4",
                    ValueSetName = "County",
                    ValueSetOID = "2.16.840.1.114222.4.11.829",
                    DefinitionText = "Codes representing county of origin, address county, reporting county. ",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("97df63ad-ce45-4aa8-ab14-3d8f8835afdf"),
                    ValueSetCode = "PHVS_State_FIPS_5-2",
                    ValueSetName = "State",
                    ValueSetOID = "2.16.840.1.114222.4.11.830",
                    DefinitionText = "State codes for U.S. based on FIPS 5-2",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("381d5d30-e9be-4311-a605-3478d5311ed1"),
                    ValueSetCode = "PHVS_DurationUnit_CDC",
                    ValueSetName = "Duration Unit ",
                    ValueSetOID = "2.16.840.1.114222.4.11.7265",
                    DefinitionText = "",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1e937482-aa8d-4a4c-9569-7c8067b8591f"),
                    ValueSetCode = "PHVS_AgeUnit_UCUM",
                    ValueSetName = "Age unit",
                    ValueSetOID = "2.16.840.1.114222.4.11.878",
                    DefinitionText = "Units of measure for age",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b59cb62a-c22c-4fda-93fb-d9d00295d3ce"),
                    ValueSetCode = "PHVS_DiseaseAcquiredJurisdiction_NND",
                    ValueSetName = "Disease Acquired Jurisdiction ",
                    ValueSetOID = "2.16.840.1.114222.4.11.3030",
                    DefinitionText = "Codes specifying where the disease/condition was likely acquired.",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5e3dcb2f-9074-4fa7-9be3-2f88e4cb1689"),
                    ValueSetCode = "PHVS_City_USGS_GNIS",
                    ValueSetName = "City",
                    ValueSetOID = "2.16.840.1.114222.4.11.973",
                    DefinitionText = "US Geological Survey Geographic Names Information System - location codes.",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("86965cb9-e67e-42bb-885f-262de6fd6ed1"),
                    ValueSetCode = "PHVS_StateProvinceOfExposure_CDC",
                    ValueSetName = "State or Province of Exposure",
                    ValueSetOID = "2.16.840.1.114222.4.11.7158",
                    DefinitionText = "Indicates the state in which the disease was potentially acquired.",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4a332fce-8337-440f-8079-72c4ba424a29"),
                    ValueSetCode = "PHVS_CaseTransmissionMode_NND",
                    ValueSetName = "Case Transmission Mode",
                    ValueSetOID = "2.16.840.1.114222.4.11.3027",
                    DefinitionText = "Codes specifying the mechanism by which disease or condition was acquired.",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6e8ab71d-c457-4bc2-b994-91e256112e2a"),
                    ValueSetCode = "PHVS_CaseClassStatus_NND",
                    ValueSetName = "Case Classification Status",
                    ValueSetOID = "2.16.840.1.114222.4.11.968",
                    DefinitionText = "Indicates how the Nationally Notifiable Disease case was classified at its close",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1bf86582-d1b8-4952-af6e-7a91e7f5e07d"),
                    ValueSetCode = "PHVS_ResultStatus_NND",
                    ValueSetName = "Result Status (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7231",
                    DefinitionText = "",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2a308290-2086-48a8-9eef-e8008a2b769e"),
                    ValueSetCode = "PHVS_ReportingSourceType_NND",
                    ValueSetName = "Reporting Source Type ",
                    ValueSetOID = "2.16.840.1.114222.4.11.3036",
                    DefinitionText = "Codes specifying the type of facility or provider associated with the source of information sent to Public Health.",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ca022c9e-9e80-4eb5-986b-a89cc7e38a6f"),
                    ValueSetCode = "PHVS_BinationalReportingCriteria_CDC",
                    ValueSetName = "Binational Reporting Criteria ",
                    ValueSetOID = "2.16.840.1.114222.4.11.7157",
                    DefinitionText = "For cases meeting the binational criteria, select all the criteria which are met.",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9a225212-48c3-4172-ba9f-ae7ba8afd4d7"),
                    ValueSetCode = "PHVS_NationalReportingJurisdiction_NND",
                    ValueSetName = "National Reporting Jurisdiction ",
                    ValueSetOID = "2.16.840.1.114222.4.11.3236",
                    DefinitionText = "National jurisdiction reporting the notification to CDC",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a25f597f-ed30-4078-9dc0-a286d1e6a583"),
                    ValueSetCode = "PHVS_AbnormalFlag_HL7_27",
                    ValueSetName = "Abnormal Flag (HL7 27) ",
                    ValueSetOID = "2.16.840.1.114222.4.11.3343",
                    DefinitionText = "Abnormal Flag (HL7 Version 2.7). Few concepts were added for HL7 v2.7",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6cdd6818-2c58-4ad0-afb8-126c371ba2cd"),
                    ValueSetCode = "PHVS_BodySite_CDC",
                    ValueSetName = "Body site",
                    ValueSetOID = "2.16.840.1.114222.4.11.967",
                    DefinitionText = "Body site from which specimen taken or where disease or injury occurs. This is based on the SNOMED hierarchy (Anatomical Structure - 91723000) .",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("150444cd-e049-47c0-b5cf-061b8c4cece6"),
                    ValueSetCode = "PHVS_ClinicalManifestations_STD",
                    ValueSetName = "Clinical Manifestations (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7611",
                    DefinitionText = "",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dea043bb-8876-40d1-bb80-ad50b0534b38"),
                    ValueSetCode = "PHVS_ClinicianObservedLesions_STD",
                    ValueSetName = "Clinician Observed Lesions (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7195",
                    DefinitionText = "",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b8233d0a-7f78-4aed-beb9-f0a5c5c7d35b"),
                    ValueSetCode = "PHVS_DetectionMethod_STD",
                    ValueSetName = "Detection Method (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7199",
                    DefinitionText = "",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2401032e-df6c-423d-866b-b4f70bff14fe"),
                    ValueSetCode = "PHVS_DrugsUsed_STD",
                    ValueSetName = "Drugs Used (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7194",
                    DefinitionText = "",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cbce93db-e946-4dd4-8a16-cc74630967a8"),
                    ValueSetCode = "PHVS_GenderIdentity_STD",
                    ValueSetName = "Gender Identity (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7610",
                    DefinitionText = "Patient identified gender identity (i.e., an individual’s personal sense of being a man, woman, or other gender, regardless of the sex that person was assigned at birth)",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("202d6a67-745f-4a59-8546-09626ed99585"),
                    ValueSetCode = "PHVS_HIVStatus_STD",
                    ValueSetName = "HIV Status (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7192",
                    DefinitionText = "",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("01f31e38-1a69-438f-8e4d-30117ad26259"),
                    ValueSetCode = "PHVS_LabTestName_CDC",
                    ValueSetName = "Lab Test Result Name",
                    ValueSetOID = "2.16.840.1.114222.4.11.1002",
                    DefinitionText = "Laboratory Resulted Test identifiers and names - LOINC is the starter set",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8107321d-7fe7-48b5-970b-bf10490fbe95"),
                    ValueSetCode = "PHVS_LabTestResultQualitative_CDC",
                    ValueSetName = "Lab Test Result Qualitative ",
                    ValueSetOID = "2.16.840.1.114222.4.11.3049",
                    DefinitionText = "Codes specifying non-microorganism qualitative lab test results including coded comments. Subset of lab test related Modifier or Qualifier concepts from SNOMED CT.",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cea0eceb-bd35-4e7f-8a45-885d530bbda5"),
                    ValueSetCode = "PHVS_LabTestResultQualitative_NND",
                    ValueSetName = "Lab Test Result Qualitative (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7206",
                    DefinitionText = "",
                    ScopeNoteText = "N/A",
                    ValueSetCreatedDate = new DateTime(2007, 03, 20),
                    ValueSetLastRevisionDate = new DateTime(2007, 03, 20),
                    StatusDate = new DateTime(2007, 03, 20)
                },
            };

            context.ValueSets.AddRange(valueSets);
            context.SaveChanges();
        }
    }
}
