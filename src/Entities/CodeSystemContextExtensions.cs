
using System;
using System.Collections.Generic;

namespace Cdc.Vocabulary.Entities
{
    public static class CodeSystemContextExtensions
    {
        public static void EnsureSeedDataForContext(this CodeSystemContext context)
        {
            // first, clear the database.  This ensures we can always start 
            // fresh with each demo.  Not advised for production environments, obviously :-)

            context.CodeSystems.RemoveRange(context.CodeSystems);
            context.SaveChanges();

            // init seed data
            var codeSystems = new List<CodeSystem>()
            {
                new CodeSystem()
                {
                    CodeSystemID = new Guid("e30b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("93590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("1cd3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "1.0.3166.1",
                    HL70396Identifier = "ISO3166_1",
                    CodeSystemCode = "PH_Country_ISO_3166-1",
                    CodeSystemName = "Country (ISO 3166-1)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://www.iso.org/iso/country_codes/iso_3166_code_lists.htm",
                    StatusDateTime = new DateTime(2016, 3, 17)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("e40b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("93590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("1cd3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "1.0.3166.2",
                    HL70396Identifier = "ISO3166_2",
                    CodeSystemCode = "PH_CountrySubdivision_ISO_3166-2",
                    CodeSystemName = "ISO 3166-2 Country Subdivision",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://www.iso.org/iso/country_codes/background_on_iso_3166/iso_3166-2.htm",
                    StatusDateTime = new DateTime(2016, 6, 13)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("23e70e3b-eb8e-dd11-b2c6-00188b398520"),
                    AuthorityID = new Guid("93590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("1cd3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "1.0.3166.3",
                    HL70396Identifier = "ISO3166_3",
                    CodeSystemCode = "PH_Country_ISO_3166-3",
                    CodeSystemName = "Obsolete Country Codes (ISO 3166-3)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "ISO 3166-3 Newsletter I-5",
                    VersionDescriptionText = "ISO 3166-3 Newsletter I-5",
                    CodeSystemSourceURL = "http://www.iso.org/iso/country_codes/background_on_iso_3166/iso_3166-3.htm#updates",
                    StatusDateTime = new DateTime(2008, 9, 30)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("91b83c6e-95b1-e611-95ee-0017a477041a"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.10.14.90",
                    HL70396Identifier = "BDDC",
                    CodeSystemCode = "PH_BirthDefectsDiagnosticConfirmation_HL7",
                    CodeSystemName = "Birth Defects Diagnostic Confirmation (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2016, 11, 23)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("e1d1595a-96b1-e611-95ee-0017a477041a"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.10.14.92",
                    HL70396Identifier = "BDLD",
                    CodeSystemCode = "PH_BirthDefectsLateralityAtDiagnosis_HL7",
                    CodeSystemName = "Birth Defects Laterality at Diagnosis (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2016, 11, 23)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("930b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.1",
                    HL70396Identifier = "HL70001",
                    CodeSystemCode = "PH_AdministrativeSex_HL7_2x",
                    CodeSystemName = "Administrative sex (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("b00b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.103",
                    HL70396Identifier = "HL70103",
                    CodeSystemCode = "PH_ProcessingID_HL7_2x",
                    CodeSystemName = "Processing ID (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("bfd5161c-50a7-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.104",
                    HL70396Identifier = "HL70104",
                    CodeSystemCode = "PH_VersionID_HL7_2x",
                    CodeSystemName = "Version ID (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 Version v2.8.1",
                    VersionDescriptionText = "HL7 Version v2.8.1",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2018, 6, 22)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("f50b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.105",
                    HL70396Identifier = "HL70105",
                    CodeSystemCode = "PH_SourceOfComment_HL7_2x",
                    CodeSystemName = "Source of Comment (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("9f0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.112",
                    HL70396Identifier = "HL70112",
                    CodeSystemCode = "PH_DischargeDisposition_HL7_2x",
                    CodeSystemName = "Discharge Disposition (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2015, 8, 27)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("a90b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.119",
                    HL70396Identifier = "HL70119",
                    CodeSystemCode = "PH_OrderControlCodes_HL7_2x",
                    CodeSystemName = "Order control codes (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/fhir/v2/0119/index.html",
                    StatusDateTime = new DateTime(2018, 6, 22)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("aa0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.121",
                    HL70396Identifier = "HL70121",
                    CodeSystemCode = "PH_ResponseFlag_HL7_2x",
                    CodeSystemName = "Response flag (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("b80b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.123",
                    HL70396Identifier = "HL70123",
                    CodeSystemCode = "PH_ResultStatus_HL7_2x",
                    CodeSystemName = "Result status (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("c50b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.125",
                    HL70396Identifier = "HL70125",
                    CodeSystemCode = "PH_ValueType_HL7_2x",
                    CodeSystemName = "Value type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 v2.8.2",
                    VersionDescriptionText = "HL7 v2.8.2",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2018, 6, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("c802ce87-98ba-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.126",
                    HL70396Identifier = "HL70126",
                    CodeSystemCode = "PH_QuantityLimitedRequest_HL7_2x",
                    CodeSystemName = "Quantity Limited Request (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 version 2.5.1",
                    VersionDescriptionText = "HL7 version 2.5.1",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 9, 7)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("970b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.127",
                    HL70396Identifier = "HL70127",
                    CodeSystemCode = "PH_AllergenType_HL7_2x",
                    CodeSystemName = "Allergen type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("980b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.128",
                    HL70396Identifier = "HL70128",
                    CodeSystemCode = "PH_AllergySeverity_HL7_2x",
                    CodeSystemName = "Allergy severity (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("d30b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.131",
                    HL70396Identifier = "HL70131",
                    CodeSystemCode = "PH_ContactRole_HL7_2x",
                    CodeSystemName = "Contact Role (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("c60b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.136",
                    HL70396Identifier = "HL70136",
                    CodeSystemCode = "PH_YesNo_HL7_2x",
                    CodeSystemName = "Yes/No Indicator (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2011, 3, 25)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("bf30b164-59a7-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.155",
                    HL70396Identifier = "HL70155",
                    CodeSystemCode = "PH_AcceptApplicationAcknowledgmentConditions_HL7_2x",
                    CodeSystemName = "Accept/application acknowledgment conditions",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 Version 2.5",
                    VersionDescriptionText = "HL7 Version 2.5",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 8, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("ba0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.162",
                    HL70396Identifier = "HL70162",
                    CodeSystemCode = "PH_RouteOfAdministration_HL7_2x",
                    CodeSystemName = "Route of administration (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("990b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.163",
                    HL70396Identifier = "HL70163",
                    CodeSystemCode = "PH_BodySite_HL7_2x",
                    CodeSystemName = "Body Site (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "calendar update",
                    VersionDescriptionText = "calendar update",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2018, 12, 7)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("910b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.164",
                    HL70396Identifier = "HL70164",
                    CodeSystemCode = "PH_AdministrationDevice_HL7_2x",
                    CodeSystemName = "Administration device (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("920b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.165",
                    HL70396Identifier = "HL70165",
                    CodeSystemCode = "PH_AdministrationMethod_HL7_2x",
                    CodeSystemName = "Administration method (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("9a0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.177",
                    HL70396Identifier = "HL70177",
                    CodeSystemCode = "PH_ConfidentialityCode_HL7_2x",
                    CodeSystemName = "Confidentiality code (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("b90b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.185",
                    HL70396Identifier = "HL70185",
                    CodeSystemCode = "PH_PreferredMethodOfContact_HL7_2x",
                    CodeSystemName = "Preferred method of contact (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("2b7e5800-6bf8-e111-b875-001a4be7fa90"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.189",
                    HL70396Identifier = "HL70189",
                    CodeSystemCode = "PH_EthnicGroup_HL7_2x",
                    CodeSystemName = "Ethnic Group (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2012, 9, 6)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("d00b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.190",
                    HL70396Identifier = "HL70190",
                    CodeSystemCode = "PH_AddressType_HL7_2x",
                    CodeSystemName = "Address Type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "Updated based on HL7  v2.8.2",
                    VersionDescriptionText = "Updated based on HL7  v2.8.2",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2018, 6, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("7ff64685-88a7-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.191",
                    HL70396Identifier = "HL70191",
                    CodeSystemCode = "PH_TypeOfReferencedData_HL7_2x",
                    CodeSystemName = "Type of referenced data (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 Version 2.5",
                    VersionDescriptionText = "HL7 Version 2.5",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 8, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("a40b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.2",
                    HL70396Identifier = "HL70002",
                    CodeSystemCode = "PH_MaritalStatus_HL7_2x",
                    CodeSystemName = "Marital status (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("a60b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.200",
                    HL70396Identifier = "HL70200",
                    CodeSystemCode = "PH_NameType_HL7_2x",
                    CodeSystemName = "Name type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2018, 6, 22)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("c20b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.201",
                    HL70396Identifier = "HL70201",
                    CodeSystemCode = "PH_TelecommunicationUseCode_HL7_2x",
                    CodeSystemName = "Telecommunication use code (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "Added PRS which was added v2.6",
                    VersionDescriptionText = "Added PRS which was added v2.6",
                    CodeSystemSourceURL = "https://www.hl7.org/fhir/v2/0201/index.html",
                    StatusDateTime = new DateTime(2018, 6, 22)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("c10b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.202",
                    HL70396Identifier = "HL70202",
                    CodeSystemCode = "PH_TelecommunicationEquipmentType_HL7_2x",
                    CodeSystemName = "Telecommunication equipment type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "Added SAT which was added v2.6",
                    VersionDescriptionText = "Added SAT which was added v2.6",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2018, 6, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("c80b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.203",
                    HL70396Identifier = "HL70203",
                    CodeSystemCode = "PH_IdentifierType_HL7_2x",
                    CodeSystemName = "Identifier Type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2018, 1, 3)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("bf151f81-8ba7-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.204",
                    HL70396Identifier = "HL70204",
                    CodeSystemCode = "PH_OrganizationalNameType_HL7_2x",
                    CodeSystemName = "Organizational name type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7v2.5",
                    VersionDescriptionText = "HL7v2.5",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 8, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("58f7b672-fe65-e811-98fd-0017a477041a"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.206",
                    HL70396Identifier = "HL70206",
                    CodeSystemCode = "PH_SegmentActionCode_HL7_2x",
                    CodeSystemName = "Segment Action Code (HL7_2x)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "Includes codes from version 2.5 to v.2.8.2",
                    VersionDescriptionText = "Includes codes from version 2.5 to v.2.8.2",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2018, 6, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("b10b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.207",
                    HL70396Identifier = "HL70207",
                    CodeSystemCode = "PH_ProcessingMode_HL7_2x",
                    CodeSystemName = "Processing mode (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("8844cd15-24b8-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.208",
                    HL70396Identifier = "HL70208",
                    CodeSystemCode = "PH_QueryResponseStatus_HL7_2x",
                    CodeSystemName = "Query Response Status (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "Added PD to support IIS",
                    VersionDescriptionText = "Added PD to support IIS",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2018, 6, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("7f405751-8ea7-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.211",
                    HL70396Identifier = "HL70211",
                    CodeSystemCode = "PH_AlternateCharacterSets_HL7_2x",
                    CodeSystemName = "Alternate character sets (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 Version v2.7",
                    VersionDescriptionText = "HL7 Version v2.7",
                    CodeSystemSourceURL = "https://www.hl7.org/fhir/v2/0211/index.html",
                    StatusDateTime = new DateTime(2018, 6, 22)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("d904c01d-9cba-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("14d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.215",
                    HL70396Identifier = "HL70215",
                    CodeSystemCode = "PH_PublicityCode_HL7_2x",
                    CodeSystemName = "Publicity Code (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 version 2.5.1",
                    VersionDescriptionText = "HL7 version 2.5.1",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 9, 7)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("fa0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("28f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("14d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.227",
                    HL70396Identifier = "MVX",
                    CodeSystemCode = "PH_ManufacturersOfVaccinesMVX_CDC_NIP",
                    CodeSystemName = "Manufacturers of vaccines (MVX)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "March 13, 2018",
                    VersionDescriptionText = "March 13, 2018",
                    CodeSystemSourceURL = "https://www2a.cdc.gov/vaccines/iis/iisstandards/vaccines.asp?rpt=mvx",
                    StatusDateTime = new DateTime(2018, 3, 13)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("960b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.23",
                    HL70396Identifier = "HL70023",
                    CodeSystemCode = "PH_AdmitSource_HL7_2x",
                    CodeSystemName = "Admit source (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("d10b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.236",
                    HL70396Identifier = "HL70236",
                    CodeSystemCode = "PH_EventReportedTo_HL7_2x",
                    CodeSystemName = "Event Reported to (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("cf0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.240",
                    HL70396Identifier = "HL70240",
                    CodeSystemCode = "PH_EventConsequence_HL7_2x",
                    CodeSystemName = "Event Consequence (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("bb0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.265",
                    HL70396Identifier = "HL70265",
                    CodeSystemCode = "PH_SpecialtyType_HL7_2x",
                    CodeSystemName = "Specialty type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("c70b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.273",
                    HL70396Identifier = "HL70273",
                    CodeSystemCode = "PH_DocumentAvailabilityStatus_HL7_2x",
                    CodeSystemName = "Document availability status (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("b40b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.280",
                    HL70396Identifier = "HL70280",
                    CodeSystemCode = "PH_ReferralPriority_HL7_2x",
                    CodeSystemName = "Referral priority (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("b30b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.282",
                    HL70396Identifier = "HL70282",
                    CodeSystemCode = "PH_ReferralDisposition_HL7_2x",
                    CodeSystemName = "Referral disposition (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("f6c650d4-0dd4-e011-a127-0050568d00f8"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.287",
                    HL70396Identifier = "HL70287",
                    CodeSystemCode = "PH_ProblemGoalActionCode_HL7_2x",
                    CodeSystemName = "Problem Goal Action Code (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 Version 2.7",
                    VersionDescriptionText = "HL7 Version 2.7",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2011, 8, 31)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("f90b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("28f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("14d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.292",
                    HL70396Identifier = "CVX",
                    CodeSystemCode = "PH_VaccinesAdministeredCVX_CDC_NIP",
                    CodeSystemName = "Vaccines administered (CVX)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "20180222",
                    VersionDescriptionText = "20180222",
                    CodeSystemSourceURL = "https://www2a.cdc.gov/vaccines/iis/iisstandards/vaccines.asp?rpt=cvx",
                    StatusDateTime = new DateTime(2018, 2, 27)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("a00b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.299",
                    HL70396Identifier = "HL70299",
                    CodeSystemCode = "PH_Encoding_HL7_2x",
                    CodeSystemName = "Encoding (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("c75fa1e8-17a3-df11-bef5-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.3",
                    HL70396Identifier = "HL70003",
                    CodeSystemCode = "PH_EventType_HL7_2x",
                    CodeSystemName = "Event Type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "Updated based on HL7  v2.8.2",
                    VersionDescriptionText = "Updated based on HL7  v2.8.2",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2018, 6, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("c40b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.301",
                    HL70396Identifier = "HL70301",
                    CodeSystemCode = "PH_UniversalIdType_HL7_2x",
                    CodeSystemName = "Universal ID type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("c30b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.322",
                    HL70396Identifier = "HL70322",
                    CodeSystemCode = "PH_CompletionStatusForValidValues_HL7_2x",
                    CodeSystemName = "Completion Status for Valid Values (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("dad79f17-d6b8-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.323",
                    HL70396Identifier = "HL70323",
                    CodeSystemCode = "PH_ActionCode_HL7_2x",
                    CodeSystemName = "Action Code (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 version 2.5.1",
                    VersionDescriptionText = "HL7 version 2.5.1",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 9, 5)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("bfa00812-bea7-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.326",
                    HL70396Identifier = "HL70326",
                    CodeSystemCode = "PH_VisitIndicator_HL7_2x",
                    CodeSystemName = "Visit Indicator (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 version 2.5",
                    VersionDescriptionText = "HL7 version 2.5",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2011, 7, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("b50b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.336",
                    HL70396Identifier = "HL70336",
                    CodeSystemCode = "PH_ReferralReason_HL7_2x",
                    CodeSystemName = "Referral reason (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("7f907453-c3a7-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.354",
                    HL70396Identifier = "HL70354",
                    CodeSystemCode = "PH_MessageStructure_HL7_2x",
                    CodeSystemName = "Message Structure (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "Updated based on HL7  v2.8.2",
                    VersionDescriptionText = "Updated based on HL7  v2.8.2",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2017, 5, 4)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("7f4c436c-c9a7-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.356",
                    HL70396Identifier = "HL70356",
                    CodeSystemCode = "PH_AlternateCharacterSetHandlingScheme_HL7_2x",
                    CodeSystemName = "Alternate character set handling scheme (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 version 2.5",
                    VersionDescriptionText = "HL7 version 2.5",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 8, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("a50b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.357",
                    HL70396Identifier = "HL70357",
                    CodeSystemCode = "PH_MessageErrorConditionCodes_HL7_2x",
                    CodeSystemName = "Message error condition codes (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 v2.8.2",
                    VersionDescriptionText = "HL7 v2.8.2",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2018, 6, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("9c0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.359",
                    HL70396Identifier = "HL70359",
                    CodeSystemCode = "PH_DiagnosisPriority_HL7_2x",
                    CodeSystemName = "Diagnosis priority (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/fhir/v2/0359/index.html",
                    StatusDateTime = new DateTime(2018, 6, 22)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("9b0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.360",
                    HL70396Identifier = "HL70360",
                    CodeSystemCode = "PH_DegreeLicenseCertificate_HL7_2x",
                    CodeSystemName = "Degree (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/fhir/v2/0360/2.7/index.html",
                    StatusDateTime = new DateTime(2018, 6, 22)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("cc0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.364",
                    HL70396Identifier = "HL70364",
                    CodeSystemCode = "PH_CommentType_HL7_2x",
                    CodeSystemName = "Comment type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("ca0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.369",
                    HL70396Identifier = "HL70369",
                    CodeSystemCode = "PH_SpecimenRole_HL7_2x",
                    CodeSystemName = "Specimen Role (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("900b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.371",
                    HL70396Identifier = "HL70371",
                    CodeSystemCode = "PH_AdditiveOrPreservative_HL7_2x",
                    CodeSystemName = "Additive (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("d40b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.373",
                    HL70396Identifier = "HL70373",
                    CodeSystemCode = "PH_Treatment_HL7_2x",
                    CodeSystemName = "Treatment (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("ac0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.38",
                    HL70396Identifier = "HL70038",
                    CodeSystemCode = "PH_OrderStatus_HL7_2x",
                    CodeSystemName = "Order status (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("87f23b1a-cea2-df11-bef5-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.396",
                    HL70396Identifier = "HL70396",
                    CodeSystemCode = "PH_CodingSystem_HL7_2x",
                    CodeSystemName = "Coding System (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "2018-03-26",
                    VersionDescriptionText = "2018-03-26",
                    CodeSystemSourceURL = "http://www.hl7.org/Special/committees/vocab/table_0396/index.cfm",
                    StatusDateTime = new DateTime(2018, 5, 31)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("ae0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.4",
                    HL70396Identifier = "HL70004",
                    CodeSystemCode = "PH_PatientClass_HL7_2x",
                    CodeSystemName = "Patient class (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("ad0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.406",
                    HL70396Identifier = "HL70406",
                    CodeSystemCode = "PH_OrganizationUnitType_HL7_2x",
                    CodeSystemName = "Organization Unit Type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("b20b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.429",
                    HL70396Identifier = "HL70429",
                    CodeSystemCode = "PH_ProductionClass_HL7_2x",
                    CodeSystemName = "Production class Code (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("940b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.432",
                    HL70396Identifier = "HL70432",
                    CodeSystemCode = "PH_AdmissionLevelOfCareCode_HL7_2x",
                    CodeSystemName = "Admission level of care code (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("b6589efa-d9b8-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.441",
                    HL70396Identifier = "HL70441",
                    CodeSystemCode = "PH_ImmunizationRegistryStatus_HL7_2x",
                    CodeSystemName = "Immunization Registry Status (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 version 2.5.1",
                    VersionDescriptionText = "HL7 version 2.5.1",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 9, 5)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("94eceedb-5976-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.443",
                    HL70396Identifier = "HL70443",
                    CodeSystemCode = "PH_ProviderRole",
                    CodeSystemName = "Provider Role (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 Version 2.5.1",
                    VersionDescriptionText = "HL7 Version 2.5.1",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2009, 7, 21)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("ffc3db12-cca7-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.444",
                    HL70396Identifier = "HL70444",
                    CodeSystemCode = "PH_NameAssemblyOrder_HL7_2x",
                    CodeSystemName = "Name Assembly Order (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 Version 2.5",
                    VersionDescriptionText = "HL7 Version 2.5",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 8, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("a30b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.445",
                    HL70396Identifier = "HL70445",
                    CodeSystemCode = "PH_IdentityReliabilityCode_HL7_2x",
                    CodeSystemName = "Identity Reliability Code (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("ac279922-cea7-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.465",
                    HL70396Identifier = "HL70465",
                    CodeSystemCode = "PH_NameAddressRepresentation_HL7_2x",
                    CodeSystemName = "Name Address Representation (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 v2.5",
                    VersionDescriptionText = "HL7 v2.5",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 8, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("74360ba5-ddb8-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("14d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.471",
                    HL70396Identifier = "HL70471",
                    CodeSystemCode = "PH_QueryName_HL7_2x",
                    CodeSystemName = "Query Name (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 Version 2.5.1 - User defined table added by NCIRD",
                    VersionDescriptionText = "HL7 Version 2.5.1 - User defined table added by NCIRD",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 9, 5)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("7f070319-d0a7-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.472",
                    HL70396Identifier = "HL70472",
                    CodeSystemCode = "PH_TQConjunctionID_HL7_2x",
                    CodeSystemName = "TQ Conjunction ID (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 8, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("af0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.480",
                    HL70396Identifier = "HL70480",
                    CodeSystemCode = "PH_PharmacyOrderType_HL7_2x",
                    CodeSystemName = "Pharmacy Order Types (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("dfc1b875-d1a7-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.482",
                    HL70396Identifier = "HL70482",
                    CodeSystemCode = "PH_OrderType_HL7_2x",
                    CodeSystemName = "Order Type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 8, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("9f3a0006-d3a7-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.483",
                    HL70396Identifier = "HL70483",
                    CodeSystemCode = "PH_AuthorizationMode_HL7_2x",
                    CodeSystemName = "Authorization Mode (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 8, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("ab0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.485",
                    HL70396Identifier = "HL70485",
                    CodeSystemCode = "PH_ExtendedPriorityCodes_HL7_2x",
                    CodeSystemName = "Extended Priority Codes (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("cc57c49e-f4d4-e111-ac0b-0050568d00f8"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.487",
                    HL70396Identifier = "HL70487",
                    CodeSystemCode = "PH_SpecimenType_HL7_2x",
                    CodeSystemName = "Specimen Type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2012, 7, 23)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("be0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.488",
                    HL70396Identifier = "HL70488",
                    CodeSystemCode = "PH_SpecimenCollectionMethod_HL7_2x",
                    CodeSystemName = "Specimen Collection Method (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("c90b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.489",
                    HL70396Identifier = "HL70489",
                    CodeSystemCode = "PH_RiskCodes_HL7_2x",
                    CodeSystemName = "Risk Codes (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("c00b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.490",
                    HL70396Identifier = "HL70490",
                    CodeSystemCode = "PH_SpecimenRejectReason_HL7_2x",
                    CodeSystemName = "Specimen Reject Reason (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("bf0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.491",
                    HL70396Identifier = "HL70491",
                    CodeSystemCode = "PH_SpecimenQuality_HL7_2x",
                    CodeSystemName = "Specimen quality (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("bc0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.492",
                    HL70396Identifier = "HL70492",
                    CodeSystemCode = "PH_SpecimenAppropriateness_HL7_2x",
                    CodeSystemName = "Specimen Appropriateness (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("ce0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.493",
                    HL70396Identifier = "HL70493",
                    CodeSystemCode = "PH_SpecimenCondition_HL7_2x",
                    CodeSystemName = "Specimen Condition (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/fhir/v2/0493/index.html",
                    StatusDateTime = new DateTime(2018, 6, 22)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("bd0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.494",
                    HL70396Identifier = "HL70494",
                    CodeSystemCode = "PH_SpecimenChildRole_HL7_2x",
                    CodeSystemName = "Specimen Child Role (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("81ee7c02-6cf8-e111-b875-001a4be7fa90"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.5",
                    HL70396Identifier = "HL70005",
                    CodeSystemCode = "PH_Race_HL7_2x",
                    CodeSystemName = "Race (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2012, 9, 6)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("df5b2c58-daa7-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.507",
                    HL70396Identifier = "HL70507",
                    CodeSystemCode = "PH_ObservationResultHandling_HL7_2x",
                    CodeSystemName = "Observation Result Handling (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 8, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("a10b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.516",
                    HL70396Identifier = "HL70516",
                    CodeSystemCode = "PH_ErrorSeverity_HL7_2x",
                    CodeSystemName = "Error Severity (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "Added Fatal error concept from added v2.6",
                    VersionDescriptionText = "Added Fatal error concept from added v2.6",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2018, 6, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("9d0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.52",
                    HL70396Identifier = "HL70052",
                    CodeSystemCode = "PH_DiagnosisType_HL7_2x",
                    CodeSystemName = "Diagnosis type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("a20b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.532",
                    HL70396Identifier = "HL70532",
                    CodeSystemCode = "PH_ExpandedYesNo_HL7_2x",
                    CodeSystemName = "Expanded Yes No Indicator (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("83b0054d-3b3d-e611-9785-0017a477041a"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.533",
                    HL70396Identifier = "HL70533",
                    CodeSystemCode = "PH_ApplicationErrorCode_HL7_2x",
                    CodeSystemName = "Application Error Code (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 v2.5.1",
                    VersionDescriptionText = "HL7 v2.5.1",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2016, 6, 28)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("b70b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.6",
                    HL70396Identifier = "HL70006",
                    CodeSystemCode = "PH_Religion_HL7_2x",
                    CodeSystemName = "Religion (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("07c63f6a-60a3-df11-bef5-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.61",
                    HL70396Identifier = "HL70061",
                    CodeSystemCode = "PH_CheckDigitScheme_HL7_2x",
                    CodeSystemName = "Check Digit Scheme (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 8, 8)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("cd0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.62",
                    HL70396Identifier = "HL70062",
                    CodeSystemCode = "PH_EventReason_HL7_2x",
                    CodeSystemName = "Event Reason (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("b60b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.63",
                    HL70396Identifier = "HL70063",
                    CodeSystemCode = "PH_Relationship_HL7_2x",
                    CodeSystemName = "Relationship (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "20170801",
                    VersionDescriptionText = "20170801",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2017, 8, 1)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("93eceedb-5976-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.64",
                    HL70396Identifier = "HL70064",
                    CodeSystemCode = "PH_FinancialClass_HL7_2x",
                    CodeSystemName = "Financial Class (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 Version 2.5.1",
                    VersionDescriptionText = "HL7 Version 2.5.1",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2016, 9, 16)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("47709840-a5a3-df11-bef5-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.65",
                    HL70396Identifier = "HL70065",
                    CodeSystemCode = "PH_SpecimenActionCode_HL7_2x",
                    CodeSystemName = "Specimen Action Code (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 2.5 Table",
                    VersionDescriptionText = "HL7 2.5 Table",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 8, 9)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("950b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.7",
                    HL70396Identifier = "HL70007",
                    CodeSystemCode = "PH_AdmissionType_HL7_2x",
                    CodeSystemName = "Admission type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("f60b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.70",
                    HL70396Identifier = "HL70070",
                    CodeSystemCode = "PH_SpecimenSource_HL7_2x",
                    CodeSystemName = "Specimen Source (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("9e0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.74",
                    HL70396Identifier = "HL70074",
                    CodeSystemCode = "PH_DiagnosticServiceSectionID_HL7_2x",
                    CodeSystemName = "Diagnostic service section ID (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("e72a5af1-aea3-df11-bef5-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.76",
                    HL70396Identifier = "HL70076",
                    CodeSystemCode = "PH_MessageType_HL7_2x",
                    CodeSystemName = "Message Type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 v2.5",
                    VersionDescriptionText = "HL7 v2.5",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 8, 9)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("8e0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.78",
                    HL70396Identifier = "HL70078",
                    CodeSystemCode = "PH_AbnormalFlag_HL7_2x",
                    CodeSystemName = "Abnormal flags (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "v2.8.2",
                    VersionDescriptionText = "v2.8.2",
                    CodeSystemSourceURL = "https://www.hl7.org/fhir/v2/0078/index.html",
                    StatusDateTime = new DateTime(2018, 3, 30)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("8f0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.8",
                    HL70396Identifier = "HL70008",
                    CodeSystemCode = "PH_AcknowledgmentCode_HL7_2x",
                    CodeSystemName = "Acknowledgment code (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("a70b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.80",
                    HL70396Identifier = "HL70080",
                    CodeSystemCode = "PH_NatureOfAbnormalTesting_HL7_2x",
                    CodeSystemName = "Nature of abnormal testing (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("a80b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.85",
                    HL70396Identifier = "HL70085",
                    CodeSystemCode = "PH_ObservationResultStatus_HL7_2x",
                    CodeSystemName = "Observation result status (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "https://www.hl7.org/library/standards_non1.htm#HL7 Version 2.5",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("6327d3fd-96ba-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.12.91",
                    HL70396Identifier = "HL70091",
                    CodeSystemCode = "PH_QueryPriority_HL7_2x",
                    CodeSystemName = "Query Priority (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HL7 Version 2.5.1",
                    VersionDescriptionText = "HL7 Version 2.5.1",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 9, 7)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("675fd42d-4cd5-e311-8f3c-0017a477041a"),
                    AuthorityID = new Guid("35f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("0c3a84e5-679c-dd11-8a3f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.13.250",
                    HL70396Identifier = "gec-country",
                    CodeSystemCode = "PH_Country_GEC",
                    CodeSystemName = "GEC Country Codes",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "December 2016",
                    VersionDescriptionText = "December 2016",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2017, 11, 9)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("6c880a2a-9a3b-e511-99a5-0017a477041a"),
                    AuthorityID = new Guid("f0db8d7c-6cfe-df11-9273-00188b39829b"),
                    DistributionSourceID = new Guid("e8b0189f-6cfe-df11-9273-00188b39829b"),
                    CodeSystemOID = "2.16.840.1.113883.15.6",
                    HL70396Identifier = "NAACCRTNM",
                    CodeSystemCode = "PH_TNM7.Edition_NAACCR",
                    CodeSystemName = "TNM 7. Edition",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2015, 8, 5)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("446270ba-d6d5-e111-ac0b-0050568d00f8"),
                    AuthorityID = new Guid("5c585282-7008-e011-9273-00188b39829b"),
                    DistributionSourceID = new Guid("30664898-7008-e011-9273-00188b39829b"),
                    CodeSystemOID = "2.16.840.1.113883.3.221.5",
                    HL70396Identifier = "PHDSCPT",
                    CodeSystemCode = "PH_SourceOfPaymentTypology_PHDSC",
                    CodeSystemName = "Source of Payment Typology (PHDSC)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "1/18/18",
                    VersionDescriptionText = "1/18/18",
                    CodeSystemSourceURL = "http://www.phdsc.org/standards/pdfs/SourceofPaymentTypologyVersion6FINALSeptember2015.pdf",
                    StatusDateTime = new DateTime(2018, 1, 18)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("0f970703-616a-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("50659f98-606a-de11-9b52-0015173d1785"),
                    DistributionSourceID = new Guid("3a9be0cd-606a-de11-9b52-0015173d1785"),
                    CodeSystemOID = "2.16.840.1.113883.3.26.1.1",
                    HL70396Identifier = "NCIT",
                    CodeSystemCode = "PH_NCIThesaurus",
                    CodeSystemName = "NCI Thesaurus",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://ncit.nci.nih.gov/",
                    StatusDateTime = new DateTime(2014, 9, 8)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("f00b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("9a590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("22d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.3.26.1.5",
                    HL70396Identifier = "NDFRT",
                    CodeSystemCode = "PH_NDF-RT",
                    CodeSystemName = "NDF-RT (Drug Classification)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "Added four concepts for supporting Case Notification in March 2010. This release reflects content in the new namespace, \"NDF-RT2 [Public Edition]\", which is intended to be the \"next generation\" of NDF-RT, comprising a multi-namespace approach that will restore focus on orderable clinical drugs, ingredients, and descriptive classifications. It will also support clinical decision support, quality of care research, and FDA SPL drug labeling initiatives. See the release notes at -http://evs.nci.nih.gov/ftp1/FDA/ndfrt/NDF-RT%20Public%20Edition%20Release%20Notes.txt.",
                    VersionDescriptionText = "Added four concepts for supporting Case Notification in March 2010. This release reflects content in the new namespace, \"NDF-RT2 [Public Edition]\", which is intended to be the \"next generation\" of NDF-RT, comprising a multi-namespace approach that will restore focus on orderable clinical drugs, ingredients, and descriptive classifications. It will also support clinical decision support, quality of care research, and FDA SPL drug labeling initiatives. See the release notes at -http://evs.nci.nih.gov/ftp1/FDA/ndfrt/NDF-RT%20Public%20Edition%20Release%20Notes.txt.",
                    CodeSystemSourceURL = "http://evs.nci.nih.gov/ftp1/FDA/ndfrt/",
                    StatusDateTime = new DateTime(2008, 10, 16)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("7a2dcdb0-e8fe-df11-9273-00188b39829b"),
                    AuthorityID = new Guid("8e31d992-4d07-e011-9273-00188b39829b"),
                    DistributionSourceID = new Guid("baacef38-4d07-e011-9273-00188b39829b"),
                    CodeSystemOID = "2.16.840.1.113883.3.5.14.3",
                    HL70396Identifier = "USDASD",
                    CodeSystemCode = "PH_SubjectDescriptor_USDA",
                    CodeSystemName = "USDA Subject Descriptor",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://www.aphis.usda.gov/animal_health/nahln/NAHLN_IT.shtml",
                    StatusDateTime = new DateTime(2010, 12, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("509f6aa5-2000-e011-9273-00188b39829b"),
                    AuthorityID = new Guid("8e31d992-4d07-e011-9273-00188b39829b"),
                    DistributionSourceID = new Guid("baacef38-4d07-e011-9273-00188b39829b"),
                    CodeSystemOID = "2.16.840.1.113883.3.5.14.4",
                    HL70396Identifier = "USDASF",
                    CodeSystemCode = "PH_SubjectFunction_USDA",
                    CodeSystemName = "USDA Subject Function",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2010, 12, 15)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("2ceff653-de04-e011-9273-00188b39829b"),
                    AuthorityID = new Guid("f0db8d7c-6cfe-df11-9273-00188b39829b"),
                    DistributionSourceID = new Guid("e8b0189f-6cfe-df11-9273-00188b39829b"),
                    CodeSystemOID = "2.16.840.1.113883.3.50.3.1",
                    HL70396Identifier = "NAACCRLAD",
                    CodeSystemCode = "PH_LateralityAtDiagnosis_NAACCR",
                    CodeSystemName = "NAACCR Laterality at Diagnosis",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://www.naaccr.org/",
                    StatusDateTime = new DateTime(2012, 12, 18)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("403a86fc-2f06-e011-9273-00188b39829b"),
                    AuthorityID = new Guid("f0db8d7c-6cfe-df11-9273-00188b39829b"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.3.520.3.10",
                    HL70396Identifier = "NAACCRTCSD",
                    CodeSystemCode = "PH_TNMClinicalStageDescriptor_NAACCR",
                    CodeSystemName = "NAACCR TNM Clinical Stage Descriptor",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2010, 12, 12)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("56807743-d704-e011-9273-00188b39829b"),
                    AuthorityID = new Guid("f0db8d7c-6cfe-df11-9273-00188b39829b"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.3.520.3.11",
                    HL70396Identifier = "NAACCRCS",
                    CodeSystemCode = "PH_CancerStatus_NAACCR",
                    CodeSystemName = "NAACCR Cancer Status",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2010, 12, 12)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("5e576e6e-e104-e011-9273-00188b39829b"),
                    AuthorityID = new Guid("f0db8d7c-6cfe-df11-9273-00188b39829b"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.3.520.3.12",
                    HL70396Identifier = "NAACCRQOS",
                    CodeSystemCode = "PH_QualityOfSurvival_NAACCR",
                    CodeSystemName = "NAACCR Quality of Survival",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "Http://www.naaccr.org",
                    StatusDateTime = new DateTime(2010, 12, 16)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("7c393aae-e204-e011-9273-00188b39829b"),
                    AuthorityID = new Guid("f0db8d7c-6cfe-df11-9273-00188b39829b"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.3.520.3.13",
                    HL70396Identifier = "NAACCRSR",
                    CodeSystemCode = "PH_ScreeningResult_NAACCR",
                    CodeSystemName = "NAACCR Screening Result",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2010, 12, 12)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("485f2953-d504-e011-9273-00188b39829b"),
                    AuthorityID = new Guid("f0db8d7c-6cfe-df11-9273-00188b39829b"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.3.520.3.14",
                    HL70396Identifier = "NAACCRBC",
                    CodeSystemCode = "PH_BehaviorCode_NAACCR",
                    CodeSystemName = "NAACCR Behavior Code",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2012, 12, 18)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("80155566-dc04-e011-9273-00188b39829b"),
                    AuthorityID = new Guid("f0db8d7c-6cfe-df11-9273-00188b39829b"),
                    DistributionSourceID = new Guid("e8b0189f-6cfe-df11-9273-00188b39829b"),
                    CodeSystemOID = "2.16.840.1.113883.3.520.3.15",
                    HL70396Identifier = "NAACCRG",
                    CodeSystemCode = "PH_Grade_NAACCR",
                    CodeSystemName = "NAACCR Grade",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2012, 12, 18)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("0f695e0e-963b-e511-99a5-0017a477041a"),
                    AuthorityID = new Guid("f0db8d7c-6cfe-df11-9273-00188b39829b"),
                    DistributionSourceID = new Guid("e8b0189f-6cfe-df11-9273-00188b39829b"),
                    CodeSystemOID = "2.16.840.1.113883.3.520.3.17",
                    HL70396Identifier = "NAACCRTNMPSB",
                    CodeSystemCode = "PH_TNMPathologicalStagedBy_NAACCR",
                    CodeSystemName = "NAACCR TNM Pathologic Staged By",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2015, 8, 5)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("06f14d1e-d904-e011-9273-00188b39829b"),
                    AuthorityID = new Guid("f0db8d7c-6cfe-df11-9273-00188b39829b"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.3.520.3.3",
                    HL70396Identifier = "NAACCRDC",
                    CodeSystemCode = "PH_DiagnosticConfirmation_NAACCR",
                    CodeSystemName = "NAACCR Diagnostic Confirmation",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2012, 12, 18)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("a0dec5da-e304-e011-9273-00188b39829b"),
                    AuthorityID = new Guid("f0db8d7c-6cfe-df11-9273-00188b39829b"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.3.520.3.4",
                    HL70396Identifier = "NAACCRTNMCSB",
                    CodeSystemCode = "PH_TNMClinicalStagedBy_NAACCR",
                    CodeSystemName = "NAACCR TNM Clinical Staged By",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2012, 12, 18)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("cc104328-2e06-e011-9273-00188b39829b"),
                    AuthorityID = new Guid("f0db8d7c-6cfe-df11-9273-00188b39829b"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.3.520.3.5",
                    HL70396Identifier = "NAACCRTEN",
                    CodeSystemCode = "PH_TNMEditionNumber_NAACCR",
                    CodeSystemName = "NAACCR TNM Edition Number",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2010, 12, 12)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("fb0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("8b590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("16d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.4.291",
                    HL70396Identifier = "LANGUAL",
                    CodeSystemCode = "PH_Langual",
                    CodeSystemName = "LanguaL",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "Langual 2017",
                    VersionDescriptionText = "Langual 2017",
                    CodeSystemSourceURL = "http://www.langual.org/",
                    StatusDateTime = new DateTime(2018, 6, 29)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("f30b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("2ff87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("19d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.4.9",
                    HL70396Identifier = "FDAUNII",
                    CodeSystemCode = "PH_UNII_FDA_SRS",
                    CodeSystemName = "Unique Ingredient Identifier (UNII)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "20100122",
                    VersionDescriptionText = "20100122",
                    CodeSystemSourceURL = "http://www.fda.gov/ForIndustry/DataStandards/SubstanceRegistrationSystem-UniqueIngredientIdentifierUNII/default.htm",
                    StatusDateTime = new DateTime(2008, 10, 15)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("8bbe6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.1",
                    HL70396Identifier = "HITSP-CS-1",
                    CodeSystemCode = "PH_AdministrativeGender_HL7_V3",
                    CodeSystemName = "AdministrativeGender",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "hl7_rimrepos-2.26.2",
                    VersionDescriptionText = "hl7_rimrepos-2.26.2",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2009, 7, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("64c129ca-f8d3-e411-8970-0017a477041a"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.1001",
                    HL70396Identifier = "ActMood",
                    CodeSystemCode = "PH_ActMood_HL7_V3",
                    CodeSystemName = "ActMood (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2015, 3, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("82be6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.1008",
                    HL70396Identifier = "NULLFL",
                    CodeSystemCode = "PH_NullFlavor_HL7_V3",
                    CodeSystemName = "NullFlavor",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "hl7_rimrepos-2.26.2",
                    VersionDescriptionText = "hl7_rimrepos-2.26.2",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2009, 7, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("93be6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.1060",
                    HL70396Identifier = "HITSP-CS-1060",
                    CodeSystemCode = "PH_EntityCode_HL7_V3",
                    CodeSystemName = "EntityCode",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "hl7_rimrepos-2.26.2",
                    VersionDescriptionText = "hl7_rimrepos-2.26.2",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2009, 7, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("83be6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.1064",
                    HL70396Identifier = "PRTCPTNMODE",
                    CodeSystemCode = "PH_ParticipationMode_HL7_V3",
                    CodeSystemName = "ParticipationMode",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "hl7_rimrepos-2.26.2",
                    VersionDescriptionText = "hl7_rimrepos-2.26.2",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2009, 7, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("91be6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.1076",
                    HL70396Identifier = "HITSP-CS-1076",
                    CodeSystemCode = "PH_ReligiousAffiliation_HL7_V3",
                    CodeSystemName = "ReligiousAffiliation",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "hl7_rimrepos-2.26.2",
                    VersionDescriptionText = "hl7_rimrepos-2.26.2",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2009, 7, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("84be6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.1077",
                    HL70396Identifier = "EDLEVEL",
                    CodeSystemCode = "PH_EducationLevel_HL7_V3",
                    CodeSystemName = "EducationLevel",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "hl7_rimrepos-2.26.2",
                    VersionDescriptionText = "hl7_rimrepos-2.26.2",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2009, 7, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("92be6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.110",
                    HL70396Identifier = "HITSP-CS-110",
                    CodeSystemCode = "PH_RoleClass_HL7_V3",
                    CodeSystemName = "RoleClass",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "hl7_rimrepos-2.26.2",
                    VersionDescriptionText = "hl7_rimrepos-2.26.2",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2009, 7, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("85be6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.111",
                    HL70396Identifier = "ROLECODE",
                    CodeSystemCode = "PH_RoleCode_HL7_V3",
                    CodeSystemName = "RoleCode",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2014, 9, 8)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("837f7b32-b2d4-e411-8970-0017a477041a"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.1119",
                    HL70396Identifier = "AddressUse",
                    CodeSystemCode = "PH_AddressUse_HL7_V3",
                    CodeSystemName = "Address Use (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2015, 3, 27)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("8abe6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.112",
                    HL70396Identifier = "HITSP-CS-112",
                    CodeSystemCode = "PH_RouteOfAdministration_HL7_V3",
                    CodeSystemName = "RouteOfAdministration",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "hl7_rimrepos-2.26.2",
                    VersionDescriptionText = "hl7_rimrepos-2.26.2",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2009, 7, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("8dbe6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.14",
                    HL70396Identifier = "HITSP-CS-14",
                    CodeSystemCode = "PH_ActStatus_HL7_V3",
                    CodeSystemName = "ActStatus",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "hl7_rimrepos-2.26.2",
                    VersionDescriptionText = "hl7_rimrepos-2.26.2",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2009, 7, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("8fbe6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.2",
                    HL70396Identifier = "HITSP-CS-2",
                    CodeSystemCode = "PH_MaritalStatus_HL7_V3",
                    CodeSystemName = "MaritalStatus",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "hl7_rimrepos-2.26.2",
                    VersionDescriptionText = "hl7_rimrepos-2.26.2",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2009, 7, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("24cb4a35-f8d3-e411-8970-0017a477041a"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.25",
                    HL70396Identifier = "ConfidentialityCode",
                    CodeSystemCode = "PH_ConfidentialityCode_HL7_V3",
                    CodeSystemName = "ConfidentialityCode (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2015, 3, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("86be6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.4",
                    HL70396Identifier = "ACTCODE",
                    CodeSystemCode = "PH_ActCode_HL7_V3",
                    CodeSystemName = "ActCode",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "hl7_rimrepos-2.26.2",
                    VersionDescriptionText = "hl7_rimrepos-2.26.2",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2009, 7, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("87be6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.42",
                    HL70396Identifier = "ENTITYHDLG",
                    CodeSystemCode = "PH_EntityHandling_HL7_V3",
                    CodeSystemName = "EntityHandling",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "hl7_rimrepos-2.26.2",
                    VersionDescriptionText = "hl7_rimrepos-2.26.2",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2009, 7, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("245ca1bd-f6d3-e411-8970-0017a477041a"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.43",
                    HL70396Identifier = "EntityNamePartQual",
                    CodeSystemCode = "PH_EntityNamePartQualifier_HL7_V3",
                    CodeSystemName = "EntityNamePartQualifier (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2015, 3, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("14fc1f23-f6d3-e411-8970-0017a477041a"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.45",
                    HL70396Identifier = "EntityNameUse",
                    CodeSystemCode = "PH_EntityNameUse_HL7_V3",
                    CodeSystemName = "EntityNameUse (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2015, 3, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("e20b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("7c99f4be-039e-dd11-8a3f-00188b398520"),
                    DistributionSourceID = new Guid("12d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.53",
                    HL70396Identifier = "HCPT",
                    CodeSystemCode = "PH_HealthcareProviderTaxonomy_HIPAA",
                    CodeSystemName = "Healthcare Provider Taxonomy (HIPAA)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "HealthcareProviderTaxonomyHIPAAOriginally created prior to the completion and publication of the NUCC Provider Taxonomy codes.  This code system has been retired, and replaced by the NUCC Provider codes, which are now used for all HIPAA compliant transactions.",
                    VersionDescriptionText = "HealthcareProviderTaxonomyHIPAAOriginally created prior to the completion and publication of the NUCC Provider Taxonomy codes.  This code system has been retired, and replaced by the NUCC Provider codes, which are now used for all HIPAA compliant transactions.",
                    CodeSystemSourceURL = "http://www.wpc-edi.com/custom_html/tax_more.htm",
                    StatusDateTime = new DateTime(2010, 9, 8)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("8ebe6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.60",
                    HL70396Identifier = "HITSP-CS-60",
                    CodeSystemCode = "PH_LanguageAbilityMode_HL7_V3",
                    CodeSystemName = "LanguageAbilityMode",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "hl7_rimrepos-2.26.2",
                    VersionDescriptionText = "hl7_rimrepos-2.26.2",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2009, 7, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("ba2d0da9-5dd2-e411-8970-0017a477041a"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.61",
                    HL70396Identifier = "LanguageAbilityProf",
                    CodeSystemCode = "PH_LanguageAbilityProficiency_HL7_V3",
                    CodeSystemName = "LanguageAbilityProficiency (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2015, 3, 24)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("2c812ef8-59d2-e411-8970-0017a477041a"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.7",
                    HL70396Identifier = "ActPriority",
                    CodeSystemCode = "PH_ActPriority_HL7_V3",
                    CodeSystemName = "Act Priority (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2015, 3, 24)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("8cbe6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.8",
                    HL70396Identifier = "HITSP-CS-8",
                    CodeSystemCode = "PH_ActReason_HL7_V3",
                    CodeSystemName = "ActReason",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "hl7_rimrepos-2.26.2",
                    VersionDescriptionText = "hl7_rimrepos-2.26.2",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2009, 7, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("90be6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.83",
                    HL70396Identifier = "HITSP-CS-83",
                    CodeSystemCode = "PH_ObservationInterpretation_HL7_V3",
                    CodeSystemName = "ObservationInterpretation",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "v3 Code System ObservationInterpretation",
                    VersionDescriptionText = "v3 Code System ObservationInterpretation",
                    CodeSystemSourceURL = "http://hl7.org/fhir/v3/ObservationInterpretation",
                    StatusDateTime = new DateTime(2016, 8, 25)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("88be6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.84",
                    HL70396Identifier = "OBSMETHOD",
                    CodeSystemCode = "PH_ObservationMethod_HL7_V3",
                    CodeSystemName = "ObservationMethod",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "hl7_rimrepos-2.26.2",
                    VersionDescriptionText = "hl7_rimrepos-2.26.2",
                    CodeSystemSourceURL = "http://hl7projects.hl7.nscee.edu/frs/download.php/622/hl7_rimrepos-2.26.2.zip",
                    StatusDateTime = new DateTime(2009, 7, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("6455ffc7-fad3-e411-8970-0017a477041a"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.88",
                    HL70396Identifier = "participationFunc",
                    CodeSystemCode = "PH_ParticipationFunction_HL7_V3",
                    CodeSystemName = "Participation Function (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2015, 3, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("203035cb-b2d4-e411-8970-0017a477041a"),
                    AuthorityID = new Guid("31f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("8a1a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.5.90",
                    HL70396Identifier = "ParticipationType",
                    CodeSystemCode = "PH_ParticipationType_HL7_V3",
                    CodeSystemName = "Participation Type (HL7)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2015, 3, 27)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("d80b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("96590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("20d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.1",
                    HL70396Identifier = "LN",
                    CodeSystemCode = "PH_LOINC",
                    CodeSystemName = "LOINC",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "2.65",
                    VersionDescriptionText = "2.65",
                    CodeSystemSourceURL = "http://www.regenstrief.org/medinformatics/loinc/downloads",
                    StatusDateTime = new DateTime(2018, 12, 18)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("cb0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("90590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("1bd3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.10",
                    HL70396Identifier = "MEDIATYPE",
                    CodeSystemCode = "PH_MIME_MediaType_IANA",
                    CodeSystemName = "MIME Media Type IANA",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://www.iana.org/assignments/media-types/",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("e00b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("93590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("f203ece2-5db0-dd11-8b18-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.100",
                    HL70396Identifier = "ISO6392",
                    CodeSystemCode = "PH_Language_ISO_639-2_Alpha3",
                    CodeSystemName = "ISO 639-2 Language",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "March 2014",
                    VersionDescriptionText = "March 2014",
                    CodeSystemSourceURL = "http://www.loc.gov/standards/iso639-2/",
                    StatusDateTime = new DateTime(2017, 11, 9)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("f6091ce8-74bb-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("7c99f4be-039e-dd11-8a3f-00188b398520"),
                    DistributionSourceID = new Guid("f9890b43-4faf-dd11-a7f5-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.101",
                    HL70396Identifier = "HCPTNUCC",
                    CodeSystemCode = "PH_ProviderCodes_NUCC",
                    CodeSystemName = "NUCC Provider Codes",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "12.1",
                    VersionDescriptionText = "12.1",
                    CodeSystemSourceURL = "http://www.nucc.org/index.php?option=com_content&task=view&id=14&Itemid=40",
                    StatusDateTime = new DateTime(2012, 10, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("de0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("35f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("5e616888-61b0-dd11-8b18-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.103",
                    HL70396Identifier = "I9CDX",
                    CodeSystemCode = "PH_DiseaseClassification_ICD-9CM",
                    CodeSystemName = "ICD-9-CM, Volume 1&2",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "FY 2015 - Effective October 1,2014",
                    VersionDescriptionText = "FY 2015 - Effective October 1,2014",
                    CodeSystemSourceURL = "http://www.cms.hhs.gov/ICD9ProviderDiagnosticCodes/06_codes.asp#TopOfPage",
                    StatusDateTime = new DateTime(2018, 2, 9)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("df0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("35f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("5e616888-61b0-dd11-8b18-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.104",
                    HL70396Identifier = "I9CP",
                    CodeSystemCode = "PH_ProcedureClassification_ICD-9CM",
                    CodeSystemName = "ICD-9 CM, Volume 3",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "FY 2015 - Effective October 1,2014",
                    VersionDescriptionText = "FY 2015 - Effective October 1,2014",
                    CodeSystemSourceURL = "http://www.cms.gov/ICD9ProviderDiagnosticCodes/06_codes.asp#TopOfPage",
                    StatusDateTime = new DateTime(2018, 2, 9)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("e50b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("89590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("fa890b43-4faf-dd11-a7f5-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.232",
                    HL70396Identifier = "SIC",
                    CodeSystemCode = "PH_Industry_SIC_1987",
                    CodeSystemName = "Industry (SIC)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://www.osha.gov/pls/imis/sic_manual.html",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("dd0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("35f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.238",
                    HL70396Identifier = "CDCREC",
                    CodeSystemCode = "PH_RaceAndEthnicity_CDC",
                    CodeSystemName = "Race & Ethnicity - CDC",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://www.cdc.gov/phin/resources/vocabulary/index.html",
                    StatusDateTime = new DateTime(2018, 10, 17)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("2df7aefc-7218-e211-989d-001a4be7fa90"),
                    AuthorityID = new Guid("98590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("fb890b43-4faf-dd11-a7f5-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.240",
                    HL70396Identifier = "US_COC",
                    CodeSystemCode = "PH_Occupation_Census",
                    CodeSystemName = "U.S. Census Occupation Code (2010)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "2010",
                    VersionDescriptionText = "2010",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2013, 5, 13)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("e60b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("2cf87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("f5890b43-4faf-dd11-a7f5-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.243",
                    HL70396Identifier = "SOC",
                    CodeSystemCode = "PH_Occupation_SOC_2000",
                    CodeSystemName = "Occupation (SOC 2000)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://www.bls.gov/soc/home.htm",
                    StatusDateTime = new DateTime(2008, 9, 30)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("db0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("3af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("24d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.245",
                    HL70396Identifier = "USGSGNIS",
                    CodeSystemCode = "PH_USGS_GNIS",
                    CodeSystemName = "U.S. Board on Geographic Names (USGS - GNIS)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://geonames.usgs.gov/index.html",
                    StatusDateTime = new DateTime(2017, 6, 30)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("89be6f37-6967-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("7cde6339-c7c4-de11-913d-0015173d1785"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.259",
                    HL70396Identifier = "HSLOC",
                    CodeSystemCode = "PH_HealthcareServiceLoc_NHSN",
                    CodeSystemName = "NHSN Healthcare Facility Patient Care Location",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "December 2017 Update",
                    VersionDescriptionText = "December 2017 Update",
                    CodeSystemSourceURL = "http://www.cdc.gov/nhsn",
                    StatusDateTime = new DateTime(2018, 2, 13)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("fd0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("8a590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("18d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.275",
                    HL70396Identifier = "EPASRS",
                    CodeSystemCode = "PH_EPA_SRS",
                    CodeSystemName = "EPA SRS",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://www.epa.gov/srs/",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("f039b339-699c-dd11-8a3f-00188b398520"),
                    AuthorityID = new Guid("142577bb-689c-dd11-8a3f-00188b398520"),
                    DistributionSourceID = new Guid("0c3a84e5-679c-dd11-8a3f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.3",
                    HL70396Identifier = "I10",
                    CodeSystemCode = "PH_DiseaseClassification_ICD-10_WHO",
                    CodeSystemName = "International Classification of Diseases revision 10 (ICD 10 - WHO)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "2011",
                    VersionDescriptionText = "2011",
                    CodeSystemSourceURL = "ftp://ftp.cdc.gov/pub/Health_Statistics/NCHS/Publications/ICD10/",
                    StatusDateTime = new DateTime(2016, 12, 15)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("199bef5e-cf17-e211-989d-001a4be7fa90"),
                    AuthorityID = new Guid("98590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("fb890b43-4faf-dd11-a7f5-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.310",
                    HL70396Identifier = "uscic",
                    CodeSystemCode = "PH_Industry_Census",
                    CodeSystemName = "U.S. Census Industry Code (2007)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "2007",
                    VersionDescriptionText = "2007",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2013, 5, 13)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("0c66d4f0-ab31-e611-bd10-0017a477041a"),
                    AuthorityID = new Guid("35f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("24d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.317",
                    HL70396Identifier = "GNIS",
                    CodeSystemCode = "PH_PopulatedPlaces_NCHS",
                    CodeSystemName = "Populated Places (NCHS)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2016, 6, 14)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("b9a95a02-f6c0-e411-8193-0017a477041a"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("5e616888-61b0-dd11-8b18-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.4",
                    HL70396Identifier = "I10P",
                    CodeSystemCode = "PH_ProcedureClassification_ICD-10PCS",
                    CodeSystemName = "ICD-10-PCS Procedure",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "2018",
                    VersionDescriptionText = "2018",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2017, 9, 11)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("dc0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("2ff87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("19d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.69",
                    HL70396Identifier = "NDC",
                    CodeSystemCode = "PH_FDA_DRLS",
                    CodeSystemName = "NDC-FDA Drug Registration and Listing System",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "20080902",
                    VersionDescriptionText = "20080902",
                    CodeSystemSourceURL = "http://www.accessdata.fda.gov/scripts/cder/drugsatfda/index.cfm",
                    StatusDateTime = new DateTime(2008, 10, 21)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("d50b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("96590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("20d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.8",
                    HL70396Identifier = "UCUM",
                    CodeSystemCode = "PH_UnitsOfMeasure_UCUM",
                    CodeSystemName = "UCUM - Unified Code for Units of Measure",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "November 2017",
                    VersionDescriptionText = "November 2017",
                    CodeSystemSourceURL = "http://aurora.rg.iupui.edu/~schadow/units/UCUM/ucum.html#section-Alphabetic-Index-By-Kind-Of-Quantity",
                    StatusDateTime = new DateTime(2017, 11, 30)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("f10b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("98590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("fb890b43-4faf-dd11-a7f5-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.85",
                    HL70396Identifier = "NAICS",
                    CodeSystemCode = "PH_Industry_NAICS",
                    CodeSystemName = "Industry (NAICS)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "NAICS 2007",
                    VersionDescriptionText = "NAICS 2007",
                    CodeSystemSourceURL = "http://www.census.gov/naics/2007/index.html",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("ef0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("94590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("22d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.86",
                    HL70396Identifier = "UML",
                    CodeSystemCode = "PH_UMLS",
                    CodeSystemName = "UMLS",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "CDA PHCR Concepts from UMLS",
                    VersionDescriptionText = "CDA PHCR Concepts from UMLS",
                    CodeSystemSourceURL = "http://www.nlm.nih.gov/",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("e10b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("94590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("22d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.88",
                    HL70396Identifier = "RXNORM",
                    CodeSystemCode = "PH_RxNorm",
                    CodeSystemName = "RxNorm",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "Added new concepts from the following term type subsets: Brand Name, Semantic Clinical Drug, Brand Name Pack, and Generic Pack",
                    VersionDescriptionText = "Added new concepts from the following term type subsets: Brand Name, Semantic Clinical Drug, Brand Name Pack, and Generic Pack",
                    CodeSystemSourceURL = "http://www.nlm.nih.gov/",
                    StatusDateTime = new DateTime(2018, 4, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("20344f36-1204-e011-9273-00188b39829b"),
                    AuthorityID = new Guid("35f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("5e616888-61b0-dd11-8b18-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.90",
                    HL70396Identifier = "I10C",
                    CodeSystemCode = "PH_DiseaseClassification_ICD-10CM",
                    CodeSystemName = "ICD-10-CM Diagnosis",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "2018",
                    VersionDescriptionText = "2018",
                    CodeSystemSourceURL = "http://www.cdc.gov/nchs/icd/icd10cm.htm",
                    StatusDateTime = new DateTime(2017, 9, 11)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("d70b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("98590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("24d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.92",
                    HL70396Identifier = "FIPS5_2",
                    CodeSystemCode = "PH_State_FIPS_5-2",
                    CodeSystemName = "FIPS 5-2 (State)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "September 2015",
                    VersionDescriptionText = "September 2015",
                    CodeSystemSourceURL = "http://www.itl.nist.gov/fipspubs/fip5-2.htm#FORE_SEC",
                    StatusDateTime = new DateTime(2017, 11, 9)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("d60b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("98590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("24d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.113883.6.93",
                    HL70396Identifier = "FIPS6_4",
                    CodeSystemCode = "PH_County_FIPS_6-4",
                    CodeSystemName = "FIPS 6-4 (County)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "April 2018",
                    VersionDescriptionText = "April 2018",
                    CodeSystemSourceURL = "http://geonames.usgs.gov/domestic/download_data.htm",
                    StatusDateTime = new DateTime(2018, 6, 1)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("da0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("104a6df5-68be-de11-913d-0015173d1785"),
                    DistributionSourceID = new Guid("4b7ab926-f36a-de11-9b52-0015173d1785"),
                    CodeSystemOID = "2.16.840.1.113883.6.96",
                    HL70396Identifier = "SCT",
                    CodeSystemCode = "PH_SNOMED-CT",
                    CodeSystemName = "SNOMED-CT",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "20180301",
                    VersionDescriptionText = "20180301",
                    CodeSystemSourceURL = "http://www.ihtsdo.org/",
                    StatusDateTime = new DateTime(2018, 3, 1)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("d9e90447-ebf4-e811-8177-005056ab3bbb"),
                    AuthorityID = new Guid("006ad8d0-e9f4-e811-8177-005056ab3bbb"),
                    DistributionSourceID = new Guid("047432d7-e9f4-e811-8177-005056ab3bbb"),
                    CodeSystemOID = "2.16.840.1.114222.4.11.8888.1235",
                    HL70396Identifier = "Importing",
                    CodeSystemCode = "PH_ImportingCodeSystem_DEV11",
                    CodeSystemName = "Importing Code System (DEV 11)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2018, 11, 30)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("60478065-c054-e911-8181-005056ab3bbb"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.11.8888.1237",
                    HL70396Identifier = "DEV11-1",
                    CodeSystemCode = "PHCSSearchTest_DEV11",
                    CodeSystemName = "CS Search Test (DEV11)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2019, 4, 1)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("a327ad02-5655-e911-8181-005056ab3bbb"),
                    AuthorityID = new Guid("2bf87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("16d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.11.8888.1238",
                    HL70396Identifier = "DEV11-2",
                    CodeSystemCode = "PH_TestDescription_DEV11",
                    CodeSystemName = "Test Description (DEV11)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2019, 4, 2)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("7087de18-87c6-e811-8174-005056ab3bbb"),
                    AuthorityID = new Guid("6b2dd9c1-84c6-e811-8174-005056ab3bbb"),
                    DistributionSourceID = new Guid("9a505dd1-84c6-e811-8174-005056ab3bbb"),
                    CodeSystemOID = "2.16.840.1.114222.4.11.8888.124",
                    HL70396Identifier = "Dev11",
                    CodeSystemCode = "PH_CodeSystemA_DEV",
                    CodeSystemName = "Code system A (DEV)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2018, 10, 4)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("a5a8a352-86d1-e811-8174-005056ab3bbb"),
                    AuthorityID = new Guid("c3f4964e-6ed1-e811-8174-005056ab3bbb"),
                    DistributionSourceID = new Guid("87b5ac76-6ed1-e811-8174-005056ab3bbb"),
                    CodeSystemOID = "2.16.840.1.114222.4.11.8888.1256",
                    HL70396Identifier = "HL700002c",
                    CodeSystemCode = "PH_CodeSystemC_DEV12",
                    CodeSystemName = "Code system C (Dev 12 test)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "test 1 test 2 test 3 test 4 test 5 test 6 test 7 test 8 test 9 test 10 test 11 test 12 test 13 test 14 test 15 test 16 test 17 test 18 test 19 test 20",
                    VersionDescriptionText = "test 1 test 2 test 3 test 4 test 5 test 6 test 7 test 8 test 9 test 10 test 11 test 12 test 13 test 14 test 15 test 16 test 17 test 18 test 19 test 20",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2018, 12, 10)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("1ee4ed3e-b2e9-e811-8177-005056ab3bbb"),
                    AuthorityID = new Guid("6b2dd9c1-84c6-e811-8174-005056ab3bbb"),
                    DistributionSourceID = new Guid("13d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.11.9999.1257",
                    HL70396Identifier = "strut test",
                    CodeSystemCode = "PH_StrutTest_Dev11",
                    CodeSystemName = "Strut test 11",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "11/16/2018",
                    VersionDescriptionText = "11/16/2018",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2018, 11, 16)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("fc0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.232",
                    HL70396Identifier = "PHINQUESTION",
                    CodeSystemCode = "PH_PHINQuestions_CDC",
                    CodeSystemName = "PHIN Questions",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "20180701",
                    VersionDescriptionText = "20180701",
                    CodeSystemSourceURL = "http://phinvads.cdc.gov",
                    StatusDateTime = new DateTime(2018, 7, 10)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("f40b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.250",
                    HL70396Identifier = "CDCEDACUITY",
                    CodeSystemCode = "PH_EmergencyDepartmentAcuity_CDC",
                    CodeSystemName = "Emergency Department Acuity - CDC",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("f20b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.261",
                    HL70396Identifier = "CDCOBS",
                    CodeSystemCode = "PH_BioSenseRTObservations_CDC",
                    CodeSystemName = "BioSense RT observations (Census) - CDC",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2008, 9, 26)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("ee0b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.274",
                    HL70396Identifier = "CDCPHINVS",
                    CodeSystemCode = "PH_PHINVS_CDC",
                    CodeSystemName = "PHIN VS (CDC Local Coding System)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "20180701",
                    VersionDescriptionText = "20180701",
                    CodeSystemSourceURL = "http://phinvads.cdc.gov",
                    StatusDateTime = new DateTime(2018, 7, 10)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("d90b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("84590f3b-417f-dd11-b38d-00188b398520"),
                    DistributionSourceID = new Guid("13d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.277",
                    HL70396Identifier = "NND",
                    CodeSystemCode = "PH_NotifiableEvent_Disease_Condition_CDC_NNDSS",
                    CodeSystemName = "Notifiable Event (Disease/Condition) Code List",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "December 7, 2017",
                    VersionDescriptionText = "December 7, 2017",
                    CodeSystemSourceURL = "http://wwwn.cdc.gov/nndss/message-mapping-guides.html",
                    StatusDateTime = new DateTime(2017, 12, 7)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("f70b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("25f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.288",
                    HL70396Identifier = "PLT",
                    CodeSystemCode = "PH_LabTest_PHLIP",
                    CodeSystemName = "Lab Test (PHLIP)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2018, 1, 10)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("f80b7876-437f-dd11-b38d-00188b398520"),
                    AuthorityID = new Guid("25f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.289",
                    HL70396Identifier = "PLR",
                    CodeSystemCode = "PH_LabResult_PHLIP",
                    CodeSystemName = "Lab Result (PHLIP)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "1.27",
                    VersionDescriptionText = "1.27",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2018, 6, 28)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("2d33c106-5a76-de11-9b52-0015173d1785"),
                    AuthorityID = new Guid("28f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("14d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.293",
                    HL70396Identifier = "NIP001",
                    CodeSystemCode = "PH_ImmunizationInformationSource_NIP",
                    CodeSystemName = "Immunization Information Source",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "Immunization Guide -  HL7 2.5.1 IG Release 1.1",
                    VersionDescriptionText = "Immunization Guide -  HL7 2.5.1 IG Release 1.1",
                    CodeSystemSourceURL = "http://www.cdc.gov/vaccines/programs/iis/technical-guidance/hl7.html",
                    StatusDateTime = new DateTime(2016, 1, 25)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("4f5f1b97-eeb8-df11-9bdd-0015173d1785"),
                    AuthorityID = new Guid("28f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("14d3e0aa-407f-dd11-b38d-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.294",
                    HL70396Identifier = "NIP002",
                    CodeSystemCode = "PH_SubstanceRefusalReason_NIP",
                    CodeSystemName = "Substance Refusal Reason (NIP)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "Immunization 2.5.1 IG release 1.1",
                    VersionDescriptionText = "Immunization 2.5.1 IG release 1.1",
                    CodeSystemSourceURL = "http://www.hl7.org",
                    StatusDateTime = new DateTime(2010, 9, 5)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("de17a047-b68f-dd11-b2c6-00188b398520"),
                    AuthorityID = new Guid("c038e97d-5cb0-dd11-8b18-00188b398520"),
                    DistributionSourceID = new Guid("98619cfe-5db0-dd11-8b18-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.300",
                    HL70396Identifier = "FIPS10_4",
                    CodeSystemCode = "PH_Country_FIPS_10-4",
                    CodeSystemName = "Country (FIPS 10-4)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "FIPS PUB 10-4",
                    VersionDescriptionText = "FIPS PUB 10-4",
                    CodeSystemSourceURL = "http://www.itl.nist.gov/fipspubs/fip10-4.htm",
                    StatusDateTime = new DateTime(2008, 10, 1)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("44d9e567-c404-e011-9273-00188b39829b"),
                    AuthorityID = new Guid("35f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("0c3a84e5-679c-dd11-8a3f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.303",
                    HL70396Identifier = "CDCRECDCM",
                    CodeSystemCode = "PH_MethodOfRaceAndEthnicityDataCollection_CDC",
                    CodeSystemName = "Method of Race and Ethnicity Data Collection",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://www.cdc.gov/phin/activities/standards/vocabulary/index.html",
                    StatusDateTime = new DateTime(2010, 12, 11)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("ce099f51-eb7b-e011-a0ea-00188b39829b"),
                    AuthorityID = new Guid("25f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.304",
                    HL70396Identifier = "99Rol",
                    CodeSystemCode = "PH_Role_PHLIP",
                    CodeSystemName = "Role (PHLIP)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2011, 5, 11)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("6e33a9d2-eb7b-e011-a0ea-00188b39829b"),
                    AuthorityID = new Guid("25f87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.305",
                    HL70396Identifier = "99Org",
                    CodeSystemCode = "PH_OrganizationUnit_PHLIP",
                    CodeSystemName = "Organization unit (PHLIP)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2011, 5, 11)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("7766614d-4df2-e111-b875-001a4be7fa90"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.307",
                    HL70396Identifier = "cdcgs1vis",
                    CodeSystemCode = "PH_CDCGS1_VIS",
                    CodeSystemName = "CDC GS1 VIS BarCodes",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "20180313",
                    VersionDescriptionText = "20180313",
                    CodeSystemSourceURL = "http://www.cdc.gov/vaccines/pubs/vis/vis-barcodes.htm",
                    StatusDateTime = new DateTime(2018, 3, 22)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("905dfe81-e847-e311-8cc9-0017a477041a"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.308",
                    HL70396Identifier = "MHJBIDS",
                    CodeSystemCode = "PH_MexicanHealthJurisdictions_BIDS",
                    CodeSystemName = "Mexican Health Jurisdictions (BIDS)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2013, 11, 7)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("d92fd278-100c-e311-81f2-0017a477041a"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.312",
                    HL70396Identifier = "VADS003",
                    CodeSystemCode = "PH_Occupation_CDC_Census2002",
                    CodeSystemName = "Occupation CDC Census 2002",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2013, 8, 23)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("4651aef3-f00b-e311-81f2-0017a477041a"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.313",
                    HL70396Identifier = "VADS001",
                    CodeSystemCode = "PH_Industry_CDC_Census2002",
                    CodeSystemName = "Industry CDC Census 2002",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2013, 8, 23)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("42f85608-120c-e311-81f2-0017a477041a"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.314",
                    HL70396Identifier = "CDCOCCUPATION2010",
                    CodeSystemCode = "PH_Occupation_CDC_Census2010",
                    CodeSystemName = "Occupation CDC Census 2010",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "2010",
                    VersionDescriptionText = "2010",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2017, 7, 6)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("f4b8a38b-190c-e311-81f2-0017a477041a"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.315",
                    HL70396Identifier = "CDCINDUSTRY2010",
                    CodeSystemCode = "PH_Industry_CDC_Census2010",
                    CodeSystemName = "Industry CDC Census 2010",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "2010",
                    VersionDescriptionText = "2010",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2017, 7, 6)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("2246129c-8f45-e311-8cc9-0017a477041a"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.317",
                    HL70396Identifier = "georegcdc",
                    CodeSystemCode = "PH_GeographicRegions_CDC",
                    CodeSystemName = "Geographic Regions (CDC)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://unstats.un.org/unsd/methods/m49/m49.htm",
                    StatusDateTime = new DateTime(2013, 11, 4)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("4144748a-248a-e511-b6c0-0017a477041a"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.320",
                    HL70396Identifier = "I10PO",
                    CodeSystemCode = "PH_PlaceOfOccurrence_ICD-10_WHO",
                    CodeSystemName = "ICD-10 Place of Occurrence",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "http://apps.who.int/classifications/icd10/browse/2016/en#/XX",
                    StatusDateTime = new DateTime(2015, 11, 13)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("e562a6b8-5612-e811-88f9-0017a477041a"),
                    AuthorityID = new Guid("2af87b81-0cac-dd11-bb1f-00188b398520"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.323",
                    HL70396Identifier = "PHEP",
                    CodeSystemCode = "PH_PHEmergencyPreparedness_CDC",
                    CodeSystemName = "PH Emergency Preparedness",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "v2",
                    VersionDescriptionText = "v2",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2018, 3, 16)
                },
                new CodeSystem()
                {
                    CodeSystemID = new Guid("395ad308-cc06-e811-88f9-0017a477041a"),
                    AuthorityID = new Guid("80da8521-cc06-e811-88f9-0017a477041a"),
                    DistributionSourceID = new Guid("911a50da-0cac-dd11-bb1f-00188b398520"),
                    CodeSystemOID = "2.16.840.1.114222.4.5.327",
                    HL70396Identifier = "CDCODH",
                    CodeSystemCode = "PH_OccupationalDataForHealth_ODH",
                    CodeSystemName = "Occupational Data for Health (ODH)",
                    CodeSystemDefinitionText = "2",
                    CodeSystemVersion = "",
                    VersionDescriptionText = "",
                    CodeSystemSourceURL = "",
                    StatusDateTime = new DateTime(2018, 3, 15)
                },
            };

            context.CodeSystems.AddRange(codeSystems);
            context.SaveChanges();
        }
    }
}