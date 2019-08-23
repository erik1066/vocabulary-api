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
                    ValueSetID = new Guid("f9504f32-bf11-df11-80e4-0015173d1785"),
                    ValueSetCode = "PHVS_CountrySubdivision_ISO_3166-2",
                    ValueSetName = "Country Subdivision (ISO 3166-2)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3286",
                    DefinitionText = "ISO 3166-2:Codes for the representation of names of countries and their subdivisions - Part 2: Country subdivision code which gives codes for the names of the principal subdivisions (e.g provinces or states) of all countries coded in ISO 3166-1. This code is based on the two-letter code element from ISO 3166-1 followed by a separator and a further string of up to three alphanumeric characters. Keywords: IS0 3166-2 Part 2, Country subdivision, Country Subdivisions, Provinces",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("84bf6ec0-9ac4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_TimeFrameDailyWeekly_CDC",
                    ValueSetName = "Time Frame (Daily Weekly)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3256",
                    DefinitionText = "Interval of grouped subjects being reported inside of a repeating group. Keyword: Count Group Interval",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("85bf6ec0-9ac4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_SurveillanceMethod_Flu",
                    ValueSetName = "Surveillance Method (Novel Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3257",
                    DefinitionText = "Methods used for Novel Influenza Surveillance",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("86bf6ec0-9ac4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_ChangePattern_CDC",
                    ValueSetName = "Change Pattern",
                    ValueSetOID = "2.16.840.1.114222.4.11.3258",
                    DefinitionText = "Trend Indicator or Change Pattern (e.g. Increasing, Decreasing, Stable)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("87bf6ec0-9ac4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_AgeGroup_Flu",
                    ValueSetName = "Age Group (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3259",
                    DefinitionText = "Age of subjects being reported inside of a repeating group. Keyword: Age Group",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("88bf6ec0-9ac4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_CountGroupType_Flu",
                    ValueSetName = "Count Group Type (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3260",
                    DefinitionText = "Type of grouped subjects being reported inside of a repeating group. Keyword: Count Group Type",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5803cc58-a2c4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_VaccinesAdministered_Flu",
                    ValueSetName = "Vaccines Administered (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3250",
                    DefinitionText = "Influenza vaccine received before illness onset.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5903cc58-a2c4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_ObesitySeverity_Flu",
                    ValueSetName = "Obesity Severity (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3253",
                    DefinitionText = "Degree or Severity of obesity",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5a03cc58-a2c4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_LabTestProcedure_Flu",
                    ValueSetName = "Lab Test Procedure (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3251",
                    DefinitionText = "Epidemiologic interpretation of the type of test(s) performed for Influenza Case.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b03cc58-a2c4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_LabTestInterpretation_Flu",
                    ValueSetName = "Lab Test Interpretation (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3252",
                    DefinitionText = "Epidemiologic interpretation of the results of the tests performed for Influenza Case.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5c03cc58-a2c4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_EmploymentStatus_Flu",
                    ValueSetName = "Employment Status  (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3254",
                    DefinitionText = "Type of work at the time of hospitalization within 7 days prior to illness onset",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5d03cc58-a2c4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_Relationship_Flu",
                    ValueSetName = "Relationship (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3275",
                    DefinitionText = "Relationship of contact, i.e., a contact is anyone who stayed overnight in the household, with the subject, 7 days before to 7 days after the subject's illness onset date.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5e03cc58-a2c4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_CaseContactSignsSymptoms_Flu",
                    ValueSetName = "Case Contact Signs and Symptoms (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3255",
                    DefinitionText = "Flu signs and symptoms of contact, i.e., a contact is anyone who stayed overnight in the household, with the subject, 7 days before to 7 days after the subject's illness onset date.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1448693c-bdc4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_DeathLocation_Flu",
                    ValueSetName = "Death Location (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3261",
                    DefinitionText = "Death Location. Where did the subject die?",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1548693c-bdc4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_LabTestProcedure_PediatricFlu",
                    ValueSetName = "Lab Test Procedure (Pediatric Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3262",
                    DefinitionText = "Epidemiologic interpretation of the type of test(s) performed for this case.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1648693c-bdc4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_LabTestInterpretation_PediatricFlu",
                    ValueSetName = "Lab Test Interpretation (Pediatric Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3263",
                    DefinitionText = "Epidemiologic interpretation of the results of the tests performed for this case.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1748693c-bdc4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_SterileSpecimen_PediatricFlu",
                    ValueSetName = "Sterile Specimen (Pediatric Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3264",
                    DefinitionText = "Indicates the type of specimen used in testing the resulted test.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1848693c-bdc4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_PosNegUnk_CDC",
                    ValueSetName = "Positive Negative Unknown",
                    ValueSetOID = "2.16.840.1.114222.4.11.3265",
                    DefinitionText = "Qualitative interpretation of  testing performed on the specimen identified by Specimen Type (LAB203)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1948693c-bdc4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_Microorganism_PediatricFlu",
                    ValueSetName = "Microorganism (Pediatric Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3266",
                    DefinitionText = "Organism cultured from specimen",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1a48693c-bdc4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_NonSterileSpecimen_PediatricFlu",
                    ValueSetName = "Non-Sterile Specimen (Pediatric Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3267",
                    DefinitionText = "Indicates the type of specimen used in testing the resulted test (LAB101).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b48693c-bdc4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_AcuteIllnessComplications_PediatricFlu",
                    ValueSetName = "Acute Illness Complications (Pediatric Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3268",
                    DefinitionText = "Listing of complications as related to the condition/illness",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1c48693c-bdc4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_UnderlyingConditions_PediatricFlu",
                    ValueSetName = "Underlying Conditions (Pediatric Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3269",
                    DefinitionText = "Listing of pre-existing conditions as related to the condition/illness",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1d48693c-bdc4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_Therapy7DaysPriorOrAfterIllnessOnset_PediatricFlu",
                    ValueSetName = "Therapy 7 Days Prior or After  Illness Onset (Pediatric Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3270",
                    DefinitionText = "List therapies received in the 7 days prior to illness onset or after illness onset",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1e48693c-bdc4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_TherapyPriorIllnessOnset_PediatricFlu",
                    ValueSetName = "Therapy Prior Illness Onset (Pediatric Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3271",
                    DefinitionText = "Therapy received prior to illness onset",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1f48693c-bdc4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_TherapyAfterIllnessOnset_PediatricFlu",
                    ValueSetName = "Therapy After Illness Onset (Pediatric Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3272",
                    DefinitionText = "Therapy received after illnes onset",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2048693c-bdc4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_VaccinesAdministered_PediatricFlu",
                    ValueSetName = "Vaccines Administered (Pediatric Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3273",
                    DefinitionText = "Influenza vaccine received before illness onset.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2148693c-bdc4-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_TimingPriorToIllnessOnset_CDC",
                    ValueSetName = "Timing Prior To Illness Onset",
                    ValueSetOID = "2.16.840.1.114222.4.11.3274",
                    DefinitionText = "The timing of when the vaccine was given in reference to the illness onset.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("306cb873-62c5-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_PHINQuestions_Flu_Summary",
                    ValueSetName = "PHIN Questions (Flu Summary)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3276",
                    DefinitionText = "PHIN Questions value set for Flu Summary Case Notification",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("316cb873-62c5-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_PHINQuestions_Flu",
                    ValueSetName = "PHIN Questions (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3277",
                    DefinitionText = "PHIN Questions value set for Flu (Individual Case Notification)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("326cb873-62c5-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_PHINQuestions_PediatricFlu",
                    ValueSetName = "PHIN Questions (Pediatric Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3278",
                    DefinitionText = "PHIN Questions value set for Pediatric Flu Case Notification",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 10, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6258e47c-5acd-de11-913d-0015173d1785"),
                    ValueSetCode = "VaccineManufacturerH1N1Code",
                    ValueSetName = "H1N1 Vaccine Manufacturer",
                    ValueSetOID = "2.16.840.1.114222.4.11.3279",
                    DefinitionText = "National Healthcare Safety Network's value set for manufacturers of the 2009 H1N1 vaccine.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 11, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1ce52dd1-becd-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_SpecimenCollectionMethod_CDC",
                    ValueSetName = "Specimen Collection Method",
                    ValueSetOID = "2.16.840.1.114222.4.11.3282",
                    DefinitionText = "Specimen Collection Method is an intrinsic value set from SNOMED based on SNOMED procedure domain concepts derived from the domain specimen collection (17636008) and its children",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("643354b0-46ce-de11-913d-0015173d1785"),
                    ValueSetCode = "PHVS_AnatomicalEntity_CDC",
                    ValueSetName = "Anatomical Entity (Body Site)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3285",
                    DefinitionText = "Anatomical Entity is an intrinsic value set from SNOMED based on SNOMED anatomical concepts derived from the domain Physical Anatomical Entity  (91722005) and its children",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 11, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("77c61ed4-d764-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_PHINQuestions_Mumps",
                    ValueSetName = "PHIN Questions (Mumps)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3237",
                    DefinitionText = "PHIN Questions value set for Mumps",
                    ScopeNoteText = "Subset of VPD Questions",
                    StatusDate = new DateTime(2009, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("78c61ed4-d764-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_PHINQuestions_Measles",
                    ValueSetName = "PHIN Questions (Measles)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3238",
                    DefinitionText = "PHIN Questions value set for Measles",
                    ScopeNoteText = "Subset of VPD Questions",
                    StatusDate = new DateTime(2009, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("79c61ed4-d764-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_PHINQuestions_Summary",
                    ValueSetName = "PHIN Questions (Summary)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3239",
                    DefinitionText = "PHIN Questions value set for Summary",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7ac61ed4-d764-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_NationalReportingJurisdiction_NND",
                    ValueSetName = "National Reporting Jurisdiction",
                    ValueSetOID = "2.16.840.1.114222.4.11.3236",
                    DefinitionText = "National jurisdiction reporting the notification to CDC",
                    ScopeNoteText = "This value set is similar to National Reporting Jurisdiction TB, but managed by DISSS which allows them to add value set concepts in future that could be applied for all the concepts.",
                    StatusDate = new DateTime(2009, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6196fca9-8567-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_SignsSymptoms_Flu",
                    ValueSetName = "Flu Signs and Symptoms",
                    ValueSetOID = "2.16.840.1.114222.4.11.3240",
                    DefinitionText = "Signs and Symptoms of  Flu",
                    ScopeNoteText = "This value set was created generally for Flu and not specifically for H1N1.",
                    StatusDate = new DateTime(2009, 7, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6296fca9-8567-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_NotifiableEventCondition_Flu",
                    ValueSetName = "Notifiable Event Condition (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3241",
                    DefinitionText = "List of CDC Notifiable Event Conditions related to Flu",
                    ScopeNoteText = "This value set was created generally for Flu and not specifically for H1N1.",
                    StatusDate = new DateTime(2009, 7, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6396fca9-8567-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_RiskFactor_Flu",
                    ValueSetName = "Risk Factor (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3242",
                    DefinitionText = "List of conditions that are considered as risk factors for Flu",
                    ScopeNoteText = "This value set was created generally for Flu and not specifically for H1N1.",
                    StatusDate = new DateTime(2009, 7, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6496fca9-8567-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_LabTestFinding_Flu",
                    ValueSetName = "Lab Test Finding (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3243",
                    DefinitionText = "General lab diagnostic findings related to Flu",
                    ScopeNoteText = "This value set was created generally for Flu and not specifically for H1N1.",
                    StatusDate = new DateTime(2009, 7, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6596fca9-8567-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationTreatment_Flu",
                    ValueSetName = "Medication Treatment (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3244",
                    DefinitionText = "List of Medications related to Flu",
                    ScopeNoteText = "This value set was created generally for Flu and not specifically for H1N1.",
                    StatusDate = new DateTime(2009, 7, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6696fca9-8567-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_RadiologyLabTest_Flu",
                    ValueSetName = "Radiology Lab Test (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3245",
                    DefinitionText = "List of radiology lab tests related to Flu",
                    ScopeNoteText = "This value set was created generally for Flu and not specifically for H1N1.",
                    StatusDate = new DateTime(2009, 7, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("025e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_AdministrativeGender_HL7_V3",
                    ValueSetName = "Administrative Gender (HL7 V3)",
                    ValueSetOID = "2.16.840.1.113883.1.11.1",
                    DefinitionText = "Administrative Gender based upon HL7 V3 vocabulary. This value set contains only male, female and undifferentiated concepts.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("035e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_BirthCountry_CDC",
                    ValueSetName = "Birth Country",
                    ValueSetOID = "2.16.840.1.114222.4.11.3200",
                    DefinitionText = "Country of Birth value set includes current countries as well as historical countries (eg. USSR). This value set is based upon ISO 3166-1, Alpha-3 codes (current countries), ISO 3166-3 (retired countries) and FIPS 10-4 (US Territories, Countries that are not found in ISO 3166)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("045e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_BloodOrBodyFluidExposureEvent_CDC",
                    ValueSetName = "Blood or body fluid exposure event",
                    ValueSetOID = "2.16.840.1.114222.4.11.3224",
                    DefinitionText = "Blood or Body Fluid Exposure Event value set has data elements or questions that captures the risk for transmission of disease based on Blood or Body Fluid exposure. This value set is based upon Clinical LOINC. Most of these data elements are occupational risk factors.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("055e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_BloodOrBodyFluidExposureFrequency_CDC",
                    ValueSetName = "Blood or body fluid exposure frequency",
                    ValueSetOID = "2.16.840.1.114222.4.11.3225",
                    DefinitionText = "Blood or body fluid exposure frequency value set has qualitative concepts that expresses the frequency such as frequent and infrequent. This value set is based upon SNOMED CT Qualifier domain (Frequencies - subdomain)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("065e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_BloodorBodyFluidExposureRelatedProcedure_CDC",
                    ValueSetName = "Blood or body fluid exposure related procedure",
                    ValueSetOID = "2.16.840.1.114222.4.11.3226",
                    DefinitionText = "Procedures involving blood or body fluid exposure. These procedures are considered as risk factors especially for bloodborne infectious diseases such as HIV, Hepatitis B and C. This value set is based upon SNOMED CT Procedure domain.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("075e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_BodySite_HITSP",
                    ValueSetName = "Body Site Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.3221.8.9",
                    DefinitionText = "Contains values descending from the SNOMED CT® Anatomical Structure (91723000) hierarchy or Acquired body structure (body structure) (280115004) or Anatomical site notations for tumor staging (body structure) (258331007) or Body structure, altered from its original anatomical structure (morphologic abnormality) (118956008) or Physical anatomical entity (body structure) (91722005) This indicates the anatomical site.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 1, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("085e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_ContactType_HepatitisB",
                    ValueSetName = "Contact Type (Hepatitis B)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3210",
                    DefinitionText = "Types of contact that have been identified by public health departments as associated with higher risk of coming into contact with the hepatitis B virus.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("095e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_Race_HL7_V3",
                    ValueSetName = "Race Value Set",
                    ValueSetOID = "2.16.840.1.113883.1.11.14914",
                    DefinitionText = "Concepts in the race value set include the OMB minimum categories, 5 races, along with a sixth race category, Other race, and a more detailed set of race categories used by the Bureau of Census.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0a5e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_DiseaseType_AcuteHepatitisB",
                    ValueSetName = "Disease Type (Acute Hepatitis B)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3221",
                    DefinitionText = "Acute hepatitis B disease type value set has problems or disease related to Acute Hepatitis B. This value set is based upon SNOMED CT",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0b5e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_DiseaseType_Anthrax",
                    ValueSetName = "Disease Type (Anthrax)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3220",
                    DefinitionText = "Anthrax disease type value set has problems or disease related to Anthrax. This value set is based upon SNOMED CT",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0c5e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_DiseaseType_Hepatitis",
                    ValueSetName = "Disease Type (Hepatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3230",
                    DefinitionText = "Hepatitis disease type value set has problems or disease related to hepatitis. This value set is based upon SNOMED CT.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0d5e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_DiseaseType_STD",
                    ValueSetName = "Disease Type (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3231",
                    DefinitionText = "Sexually Transmitted Disease type value set has problems or disease related to STD. This value set is based upon SNOMED CT.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0e5e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_DiseaseType_TB",
                    ValueSetName = "Disease Type (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3222",
                    DefinitionText = "Tuberculosis disease type value set has problems or disease related to Tuberculosis. This value set is based upon SNOMED CT.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0f5e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_DiseaseType_Tularemia",
                    ValueSetName = "Disease Type (Tularemia)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3223",
                    DefinitionText = "Tularemia disease type value set has problems or disease related to Tularemia. This value set is based upon SNOMED CT.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("105e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_ExposureLocation_CDC",
                    ValueSetName = "Exposure Location",
                    ValueSetOID = "2.16.840.1.114222.4.11.3209",
                    DefinitionText = "Locations that have been identified by public health departments as locations that have been associated with higher risk of coming into contact with infectious diseases such as tuberculosis and Hepatitis B",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("115e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_GeographicLocationHistory_CDC",
                    ValueSetName = "Geographical location history",
                    ValueSetOID = "2.16.840.1.114222.4.11.3201",
                    DefinitionText = "Locations out of US (Birth Country) and jurisdictions within US (states) that are potentially relevent to current condition. This value set is based upon ISO 3166 (Countries) as well as FIPS 5-2 (States).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("125e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_HIVStatus_CDC",
                    ValueSetName = "HIV Status (PHCR)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3232",
                    DefinitionText = "HIV Status value set has concepts that expresses the status of HIV such as HIV negative or HIV positive. This value set is based upon SNOMED CT finding domain.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("135e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_LabTestResultName_AcuteHepatitisB",
                    ValueSetName = "Lab Test Result Name (Acute Hepatitis B)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3206",
                    DefinitionText = "Acute Hepatitis B lab test result name value set  is based upon the Lab LOINC concepts that are defined in the CSTE standardized reporting definition for Acute Hepatitis B.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("145e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_LabTestResultName_Anthrax",
                    ValueSetName = "Lab Test Result Name (Anthrax)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3207",
                    DefinitionText = "Anthrax lab test result name value set is based upon the Lab LOINC concepts that are defined in the CSTE standardized reporting definition for Anthrax.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("155e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_LabTestResultName_TB",
                    ValueSetName = "Lab Test Result Name (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3205",
                    DefinitionText = "Tuberculosis lab test result name value set is based upon the Lab LOINC concepts that are defined in the CSTE standardized reporting definition for Tuberculosis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("165e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_LabTestResultName_Tularemia",
                    ValueSetName = "Lab Test Result Name (Tularemia)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3208",
                    DefinitionText = "Tularemia lab test result name value set is based upon the Lab LOINC concepts that are defined in the CSTE standardized reporting definition for Tularemia.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("175e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_LocationPerformingBBFExposureProcedure_CDC",
                    ValueSetName = "Location performing blood or body fluid exposure procedure",
                    ValueSetOID = "2.16.840.1.114222.4.11.3227",
                    DefinitionText = "Service delivery locations that may perform the procedure on human body involving blood or body fluid. This value set is based upon the HL7 V3 vocabulary.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("185e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_MaterialExposureType_CDC",
                    ValueSetName = "Material exposure type",
                    ValueSetOID = "2.16.840.1.114222.4.11.3211",
                    DefinitionText = "Types of exposure related to material such as suspicious mail and powder including animal material. This value set is primarily based upon SNOMED CT Material (260769002) hierarchy.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("195e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationTreatment_Anthrax",
                    ValueSetName = "Medication Treatment (Anthrax)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3216",
                    DefinitionText = "Anthrax treatment value set has medication concepts used to treat anthrax.  This is based upon the FDA Unique Ingredient Identifier (UNII).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1a5e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationTreatment_TB",
                    ValueSetName = "Medication Treatment (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3218",
                    DefinitionText = "Tuberculosis treatment value set has medication concepts used to treat tuberculosis.  This is based upon the FDA Unique Ingredient Identifier (UNII).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b5e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationTreatment_Tularemia",
                    ValueSetName = "Medication Treatment (Tularemia)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3217",
                    DefinitionText = "Tularemia treatment value set has medication concepts used to treat tularemia. This is based upon the FDA Unique Ingredient Identifier (UNII).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1c5e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_NonLabInterventionProcedure_CDC",
                    ValueSetName = "Non-Laboratory Intervention and Procedure",
                    ValueSetOID = "2.16.840.1.114222.4.11.3204",
                    DefinitionText = "This value set includes medical and surgical procedures performed on human body. This is based upon the concepts descending from the SNOMED CT Procedures (71388002) hierarchy. This value set does not include administrative billing procedure or laboratory procedure.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1d5e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_ObservationInterpretation_HL7_V3",
                    ValueSetName = "Observation Interpretation (HL7)",
                    ValueSetOID = "2.16.840.1.113883.1.11.78",
                    DefinitionText = "Observation interpretation concepts that are based upon HL7 V3 vocabulary.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1e5e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationRoute_FDA",
                    ValueSetName = "Medication Route FDA Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.3221.8.7",
                    DefinitionText = "Route of Administration value set is based upon FDA Drug Registration and Listing Database (FDA Orange Book) which are used in FDA structured product and labelling (SPL).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1f5e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_SignsSymptoms_AcuteHepatitisB",
                    ValueSetName = "Signs and Symptoms (Acute Hepatitis B)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3213",
                    DefinitionText = "Acute Hepatitis B Signs and Symptoms value set  is primarily based upon the SNOMED concepts that are defined in the CSTE standardized reporting definition for Acute Hepatitis B.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("205e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_SignsSymptoms_Anthrax",
                    ValueSetName = "Signs and Symptoms (Anthrax)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3212",
                    DefinitionText = "Anthrax Signs and Symptoms value set  is primarily based upon the SNOMED concepts that are defined in the CSTE standardized reporting definition for Anthrax.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("215e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_SignsSymptoms_TB",
                    ValueSetName = "Signs and Symptoms (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3214",
                    DefinitionText = "Tuberculosis Signs and Symptoms value set  is primarily based upon the SNOMED concepts that are defined in the CSTE standardized reporting definition for Tuberculosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("225e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_SignsSymptoms_Tularemia",
                    ValueSetName = "Signs and Symptoms (Tularemia)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3215",
                    DefinitionText = "Tularemia Signs and Symptoms value set  is primarily based upon the SNOMED concepts that are defined in the CSTE standardized reporting definition for Anthrax",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("235e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_SocioBehavioralRiskFactor_CDC",
                    ValueSetName = "Sociobehavioral risk factor",
                    ValueSetOID = "2.16.840.1.114222.4.11.3228",
                    DefinitionText = "Socio-behavioral risk factor related to infectious disease.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("245e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_TreatmentStatus_CDC",
                    ValueSetName = "Treatment status",
                    ValueSetOID = "2.16.840.1.114222.4.11.3203",
                    DefinitionText = "Treatment (medication) status value set includes concepts such as active and on hold",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("255e48ca-166b-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_VaccineAdministered_HepatitisB",
                    ValueSetName = "Vaccine Administered (Hepatitis B)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3219",
                    DefinitionText = "Hepatitis B vaccine value set has Hepatitis B vaccines. This is based upon the Clinical Vaccines Administered (CVX) vocabulary maintained by CDC.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("15af5a46-b570-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_Specimen_Flu",
                    ValueSetName = "Specimen (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3246",
                    DefinitionText = "List of specimen sources related to Flu.",
                    ScopeNoteText = "This value set was created generally for Flu and not specifically for H1N1.",
                    StatusDate = new DateTime(2009, 7, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("832140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_MaritalStatus_HL7_V3",
                    ValueSetName = "Marital Status Value Set",
                    ValueSetOID = "2.16.840.1.113883.1.11.12212",
                    DefinitionText = "Marital Status is the domestic partnership status of a person.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("842140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_PersonalRelationshipRoleType_HL7_V3",
                    ValueSetName = "Personal Relationship Role Type Value Set",
                    ValueSetOID = "2.16.840.1.113883.1.11.19563",
                    DefinitionText = "A Personal Relationship records the role of a person in relation to another person. This value set is to be used when recording the relationships between different people who are not necessarily related by family ties, but also includes family relationships",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("852140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_FamilyMember_HL7_V3",
                    ValueSetName = "Family Member Value Set",
                    ValueSetOID = "2.16.840.1.113883.1.11.19579",
                    DefinitionText = "Family Relationships record the familial relationship of a person to another person. This value set is to be used when it is necessary to record family relationships (e.g., next of kin, or blood relations). This is a subset of the value set used for personal relationships",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("862140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_ContactType_HL7_V3",
                    ValueSetName = "Contact Type Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.3221.3.2",
                    DefinitionText = "The HL7 Version 3 Role Class Vocabulary has been limited by HITSP to the value set and represents the type of individual support provided, such as immediate emergency contacts, next of kin, family relations, guardians, agents, et cetera",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("872140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_ReligiousAffiliation_HL7_V3",
                    ValueSetName = "Religious Affiliation Value Set",
                    ValueSetOID = "2.16.840.1.113883.1.11.19185",
                    DefinitionText = "This reflects the spiritual faith affiliation",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("882140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_LanguageAbilityMode_HL7_V3",
                    ValueSetName = "LanguageAbilityMode Value Set",
                    ValueSetOID = "2.16.840.1.113883.1.11.12249",
                    DefinitionText = "This identifies the language ability of the individual. A value representing the method of expression of the language.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("892140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_CoverageRoleType_HL7_V3",
                    ValueSetName = "Coverage Role Type Value Set",
                    ValueSetOID = "2.16.840.1.113883.1.11.18877",
                    DefinitionText = "This specifies if the patient is the subscriber or dependent within the context of the specified health plan",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8a2140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_FinanciallyResponsibleParty_HL7_V3",
                    ValueSetName = "Financially Responsible Party Type Value Set",
                    ValueSetOID = "2.16.840.1.113883.1.11.10416",
                    DefinitionText = "A relationship between two entities that is formally recognized, frequently by a contract or similar agreement. This identifies the party that has responsibility for all or a portion of the patient’s healthcare.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8b2140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_SocialHistoryType_HITSP",
                    ValueSetName = "Social History Type Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.80.60",
                    DefinitionText = "This indicates the type of social history observation",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8c2140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_ProblemList_HITSP",
                    ValueSetName = "Problem Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.3221.7.4",
                    DefinitionText = "This describes the problem. Diagnosis/Problem List is broadly defined as a series of brief statements that catalog a patient’s medical, nursing, dental, social, preventative and psychiatric events and issues that are relevant to that patient’s healthcare (e.g., signs, symptoms, and defined conditions). Contains descendants of SNOMED CT codes 404684003 (Signs and Symptoms) and 243796009 (Situation with explicit context).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 1, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8d2140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_ProblemType_HITSP",
                    ValueSetName = "Problem Type Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.3221.7.2",
                    DefinitionText = "The SNOMED CT® has been limited by HITSP to the value set reproduced below in Table 2-60 Problem Type Value Set Definition. This indicates the level of medical judgment used to determine the existence of a problem",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8e2140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_ProblemSeverity_HITSP",
                    ValueSetName = "Problem Severity",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.3221.6.8",
                    DefinitionText = "This is a description of the level of the severity of the problem.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 12, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8f2140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationFillStatus_HITSP",
                    ValueSetName = "Medication Fill Status Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.80.64",
                    DefinitionText = "The HL7 ActStatus has been limited by HITSP. This identifies whether the medication has been fulfilled, such as completed and aborted",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("902140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationProductForm_HITSP",
                    ValueSetName = "Medication Product Form Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.3221.8.11",
                    DefinitionText = "This is the physical form of the product as presented to the individual. For example: tablet, capsule, liquid or ointment. NCI concept code for pharmaceutical dosage form: C42636",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("912140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationType_HITSP",
                    ValueSetName = "Medication Type Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.3221.8.19",
                    DefinitionText = "This is a classification based on how the medication is marketed (e.g., prescription, over the counter drug)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("922140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationClinicalDrugName_HITSP",
                    ValueSetName = "Medication Clinical Drug Name Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.80.17",
                    DefinitionText = "Shall contain RxNorm normal forms for concepts type of “Ingredient Name” or Generic Packs. The ingredient name concepts can be found in the RxNORM file RXCONSO.RRF selecting all terms where SAB=RXNORM (selecting the normal forms), and TTY=SCD (selecting the ingredient names) or TTY=GPCK (selecting the generic packs)",
                    ScopeNoteText = "Updated the definition and intrinsic logic based on HITSP V2.0.1 specification (Jan 31st 2010)",
                    StatusDate = new DateTime(2018, 5, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("932140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationDrugClass_HITSP",
                    ValueSetName = "Medication Drug Class Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.80.18",
                    DefinitionText = "This identifies the pharmacological drug class, such as Cephalosporins. Shall contain a value descending from the NDF-RT concept types of “Mechanism of Action - N0000000223”, “Physiologic Effect - N0000009802” or “Chemical Structure - N0000000002”`. NUI will be used as the concept code.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("942140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationBrandName_HITSP",
                    ValueSetName = "Medication Brand Name Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.80.16",
                    DefinitionText = "This identifies the product brand name of drugs, such as Tylenol, Claritin, etc. Shall contain RxNorm normal forms for concepts type of “Brand Name” or Brand Name Packs.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("952140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationVehicle_HITSP",
                    ValueSetName = "Medication Vehicle Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.80.21",
                    DefinitionText = "This indicates non-active ingredient(s), or substances not of therapeutic interest, in which the active ingredients are dispersed. Most often applied to liquid products where the major fluid Component is considered the vehicle",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("962140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_AllergyOrAdverseEventType_HITSP",
                    ValueSetName = "Allergy/Adverse Event Type Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.3221.6.2",
                    DefinitionText = "This describes the type of product and intolerance suffered by the patient",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("972140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_ActNoImmunizationReason_HL7_V3",
                    ValueSetName = "No Immunization Reason Value Set",
                    ValueSetOID = "2.16.840.1.113883.1.11.19717",
                    DefinitionText = "This identifies the reason why the immunization did not occur",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("982140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_ImmunizationInformationSource_HITSP",
                    ValueSetName = "Immunization Information Source",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.80.39",
                    DefinitionText = "This identifies the source of information for this immunization record or, more generically, whether the immunization being reported has just been administered (new) or came from other records (historical)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("992140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_ImmunizationServiceFundingEligibility_HL7_2x",
                    ValueSetName = "Immunization Service Funding Eligibility Value Set",
                    ValueSetOID = "2.16.840.1.114222.4.5.301",
                    DefinitionText = "Identifies the Immunization Service Funding Eligibility assigned to the patient for the purpose of identifying sources of reimbursement. See User Defined Table 0064 Financial Class in Appendix 1 in CDC Implementation Guide for Immunization Data Transactions.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9a2140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_ResultStatus_HITSP_HL7_V3",
                    ValueSetName = "V3 Result Status Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.80.65",
                    DefinitionText = "This identifies the status for the results (observation)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9b2140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_VitalSignResult_HITSP",
                    ValueSetName = "Vital Sign Result Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.80.62",
                    DefinitionText = "This identifies the vital sign result type",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9c2140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_ProviderRole_HITSP",
                    ValueSetName = "Provider Role Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.3221.4.2",
                    DefinitionText = "This classifies providers according to the role they play in the healthcare of the individual. See HL7 Table 0443 in Appendix A of HL7 2.5.1 Specification.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9d2140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_PatientClass_HITSP_HL7_V3",
                    ValueSetName = "Patient Class Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.80.66",
                    DefinitionText = "This is used to categorize patients by site where encounter occurred",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9e2140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_AdvanceDirectiveType_HL7_CCD",
                    ValueSetName = "Advance Directive Type Value Set",
                    ValueSetOID = "2.16.840.1.113883.1.11.20.2",
                    DefinitionText = "This identifies the type of the Advance Directive. Uses the AdvanceDirectiveTypeCode vocabulary defined by CCD.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9f2140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_DocumentClass_HITSP",
                    ValueSetName = "Document Class Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.80.46",
                    DefinitionText = "This is the code specifying the particular kind of document (e.g., Prescription, Discharge Summary, Report, etc.). It is suggested that the XDS Affinity Domain draws these values from a coding scheme providing a coarse level of granularity (about 10 to 100 entries)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a02140e7-a177-de11-9b52-0015173d1785"),
                    ValueSetCode = "PHVS_DocumentType_HITSP",
                    ValueSetName = "Document Type Value Set",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.80.47",
                    DefinitionText = "This is the code specifying the precise type of document (e.g., Pulmonary History and Physical, Discharge Summary, Ultrasound Report, etc.). It is suggested that the XDS Affinity Domain draw these values from a coding scheme providing a fine level of granularity",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2009, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bf278036-53a7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_VersionID_HL7_2x",
                    ValueSetName = "Version ID (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3342",
                    DefinitionText = "Version ID (HL7) based on HL7 2.x table 0104",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 10, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dfdb0027-57a7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_AbnormalFlag_HL7_27",
                    ValueSetName = "Abnormal Flag (HL7 27)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3343",
                    DefinitionText = "Abnormal Flag (HL7 Version 2.7). Few concepts were added for HL7 v2.7",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1fa2ce72-5ba7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_AcceptApplicationAcknowledgmentConditions_HL7",
                    ValueSetName = "Accept Application Acknowledgment Conditions (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3344",
                    DefinitionText = "Accept Application Acknowledgment Conditions (HL7) based on HL7 2.5 table 0155.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2019, 4, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dfb75d3c-8aa7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_TypeOfReferencedData_HL7_2x",
                    ValueSetName = "Type of Referenced Data (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3345",
                    DefinitionText = "HL7 version 2.x Type of referenced data used in chapter(s) 2; HL7 table 0191",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5fde6ea9-8ca7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_TypeOfOrganizationalNameType_HL7_2x",
                    ValueSetName = "Organizational Name Type (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3346",
                    DefinitionText = "HL7 version 2.x Organizational name type used in chapter(s) 2; HL7 table 0204",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7feedc29-8fa7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_AlternateCharacterSets_HL7_2x",
                    ValueSetName = "Alternate Character Sets (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3347",
                    DefinitionText = "HL7 version 2.x Alternate character sets used in chapter(s) 2; HL7 table 0211",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dfbab9c9-bea7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_VisitIndicator_HL7_2x",
                    ValueSetName = "Visit Indicator (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3348",
                    DefinitionText = "HL7 version 2.x Visit indicator used in chapter(s) 3; HL7 table 0326. User defined table",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5fe687f5-c7a7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_MessageStructure_HL7_2x",
                    ValueSetName = "Message Structure (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3349",
                    DefinitionText = "HL7 version 2.x Message structure used in chapter(s) 2; HL7 table 0354",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bfed410b-cba7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_AlternateCharacterSetHandlingScheme_HL7_2x",
                    ValueSetName = "Alternate Character Set Handling Scheme (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3350",
                    DefinitionText = "HL7 version 2.x Alternate character set handling scheme used in chapter(s) 2; HL7 table 0356",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e24ad914-cda7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_NameAssemblyOrder_HL7_2x",
                    ValueSetName = "Name Assembly Order (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3351",
                    DefinitionText = "HL7 version 2.x Name assembly order used in chapter(s) 2; HL7 table 0444",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cf3f0c11-cfa7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_NameAddressRepresentation_HL7_2x",
                    ValueSetName = "Name Address Representation (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3352",
                    DefinitionText = "HL7 version 2.x Name/address representation used in chapter(s) 2; HL7 table 0465",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("df7abdc0-d0a7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_TQConjunctionID_HL7_2x",
                    ValueSetName = "TQ Conjunction ID (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3353",
                    DefinitionText = "HL7 version 2.x TQ Conjunction ID used in chapter(s) 4; HL7 table 0472",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dffe6ff0-d1a7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_OrderType_HL7_2x",
                    ValueSetName = "Order Type (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3354",
                    DefinitionText = "HL7 version 2.x Order Type used in chapter(s) 4; HL7 table 0482",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bf89b88f-d3a7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_AuthorizationMode_HL7_2x",
                    ValueSetName = "Authorization Mode (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3355",
                    DefinitionText = "HL7 version 2.x Authorization Mode used in chapter(s) 4; HL7 table 0483",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7f95f383-d8a7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_RiskCodes_HL7_2x",
                    ValueSetName = "Risk Codes (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3356",
                    DefinitionText = "HL7 version 2.x Risk Codes used in chapter(s) 7; HL7 table 0489",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bff0b86a-15a8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_ObservationResultHandling_HL7_2x",
                    ValueSetName = "Observation Result Handling (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3357",
                    DefinitionText = "Observation Result Handling (HL7)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9fb7f050-88a8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_LabTestName_NND",
                    ValueSetName = "Lab Test Name (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3358",
                    DefinitionText = "Lab Test Name Identifiers associated with the notifiable conditions. This value set has been created  based on all the lab LOINC codes present in CSTE Technical Implementation Guide (TIG). These codes would come in OBX-3 and could be used for ELR 2.5.1 IG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7fa82177-8ea8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_EvaluationFinding_CDC",
                    ValueSetName = "Evaluation Finding",
                    ValueSetOID = "2.16.840.1.114222.4.11.3359",
                    DefinitionText = "Evaluation finding concepts could be used in OBX-5 as lab test result finding. This has been created based upon SNOMED domain (Evaluation Finding - 441742003). Keyword: Lab Test Result.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d8b644dc-0fb7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_EventType_IIS",
                    ValueSetName = "Event Type (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3362",
                    DefinitionText = "HL7-defined Table 0003 - Event type [only selected values listed] (use in MSH-9, second component). This code indicates the trigger event. Refer to Chapter 3, Version 2.5.1 for further information on HL7 event triggers.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7bb60f21-14b7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_PatientClass_IIS",
                    ValueSetName = "Patient Class (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3363",
                    DefinitionText = "User-defined Table 0004 - Patient class [values suggested by HL7] (use in PV1-2)This code categorizes the patient in the current event. The only value supported is R for recurring patient.  For a current list of HL7 values please reference the HL7 version 2.5.1 documents.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9b2a4fec-7bb7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_MessageType_IIS",
                    ValueSetName = "Message Type (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3364",
                    DefinitionText = "HL7-defined Table 0076 - Message type [only selected values listed] (use in MSH-9, first component)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6638a265-83b7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_Relationship_IIS",
                    ValueSetName = "Relationship (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3365",
                    DefinitionText = "User-defined Table 0063 - Relationship [as defined in HL7’s Version 2.4] (use in NK1-3, IN1-17)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cb299f6c-c9b7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_FinancialClass_IIS",
                    ValueSetName = "Financial Class (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3366",
                    DefinitionText = "User-defined Table 0064 - Financial class [NIP suggested values] (use in PV1-20)Financial class references a clients eligibility status at a point in time.  The values in this table relate to eligibility for the Vaccine for Children (VFC) program.  Local implementations may define and document local codes.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("aa3b0516-d4b7-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_VersionID_IIS",
                    ValueSetName = "Version ID (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3367",
                    DefinitionText = "HL7-defined Table 0104 - Version ID (use in MSH-12)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a4c82953-10b8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_OrderControlCode_IIS",
                    ValueSetName = "Order Control Code (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3368",
                    DefinitionText = "HL7-defined Table 0119 - Order Control Codes  (use in ORC-1)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b042b59-15b8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_RouteOfAdministration_IIS",
                    ValueSetName = "Route Of Administration (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3369",
                    DefinitionText = "HITSP has specified the use of the FDA route of administration. Implementation guide has mapping to the Table 0162 Route of Administration",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("95257779-17b8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_AdministrativeSite_IIS",
                    ValueSetName = "Administrative Site (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3370",
                    DefinitionText = "HL7-defined Table 0163 - Administrative site  [only selected values listed] (use in RXR-2)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6fba1149-19b8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_NameType_IIS",
                    ValueSetName = "Name Type (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3371",
                    DefinitionText = "HL7-defined Table 0200 - Name type (use in all XCN, XPN data types; including PID-5, 6, 9)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d6de8c91-1db8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_IdentifierType_IIS",
                    ValueSetName = "Identifier Type (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3372",
                    DefinitionText = "User-defined Table 0203 - Identifier type [values suggested by HL7; with NIP-suggested additions] (use in all CX, XCN type codes; including PID-2,3,4,18,21 and RXA-10)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c7aae7f9-22b8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_OrganizationalNameType_IIS",
                    ValueSetName = "Organizational Name Type (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3373",
                    DefinitionText = "User-defined Table 0204 - Organizational name type [values suggested by HL7] (use in all XON data types)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c9005c0a-25b8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_QueryResponseStatus_IIS",
                    ValueSetName = "Query Response Status (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3374",
                    DefinitionText = "User-defined Table 0208 - Query response status [values suggested by HL7] (use in QAK-2)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ecbd5716-d7b8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_ActionCode_IIS",
                    ValueSetName = "Action Code (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3375",
                    DefinitionText = "HL7-defined Table 0323 - Action code (use in RXA-21)       text",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2019, 2, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7dc6e8f2-d7b8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_MessageStructure_IIS",
                    ValueSetName = "Message Structure (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3376",
                    DefinitionText = "HL7-defined Table 0354 - Message structure [only selected values listed] (use in MSH-9, third component)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("205863a2-dab8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_ImmunizationRegistryStatus_HL7_2x",
                    ValueSetName = "Immunization Registry Status (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3377",
                    DefinitionText = "User-defined Table 0441 - Immunization registry status (use in PD1-16) [HL7 assigned table number 0441 in Version 2.4]",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4069e565-dcb8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PH_ImmunizationRegistryStatus_IIS",
                    ValueSetName = "Immunization Registry Status (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3378",
                    DefinitionText = "User-defined Table 0441 - Immunization registry status (use in PD1-16) [HL7 assigned table number 0441 in Version 2.4]",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e4be9efb-ddb8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_QueryName_IIS",
                    ValueSetName = "Query Name (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3379",
                    DefinitionText = "User-defined Table 0471 Query Name",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("893a2600-f1b8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_SubstanceRefusalReason_IIS",
                    ValueSetName = "Substance Refusal Reason (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3380",
                    DefinitionText = "NIP-defined NIP002 - Substance refusal reason (use in RXA-18)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8d4bef26-feb8-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_ObservationIdentifier_IIS",
                    ValueSetName = "Observation Identifier (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3381",
                    DefinitionText = "NIP-defined NIP003 - Observation identifiers (use in OBX-3)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2ad050cd-9ab9-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_ImmunizationFundingSource_IIS",
                    ValueSetName = "Immunization Funding Source (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3287",
                    DefinitionText = "Immunization Funding Source  (Used in OBX- 5) - Indicates funding source for an immunization.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 9, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d7edfbd4-9bb9-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_VaccinationContraindication_IIS",
                    ValueSetName = "Vaccination Contraindication (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3288",
                    DefinitionText = "Indicates a contraindication to vaccination.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ca050ae1-a9b9-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_VaccinationReaction_IIS",
                    ValueSetName = "Vaccination Reaction and Adverse Event (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3289",
                    DefinitionText = "indicates a reaction or adverse event associated in time with an immunization.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 11, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("318ce13c-abb9-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_VaccinationSpecialIndication_IIS",
                    ValueSetName = "Vaccination Special Indication (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3290",
                    DefinitionText = "Describes a factor about the client which may impact forecasting of next dose of vaccine needed.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("833719d2-abb9-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_ImmunizationProfileIdentifier_IIS",
                    ValueSetName = "Immunization Profile Identifier (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3291",
                    DefinitionText = "Identifies the profile used by the message",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e6f83060-acb9-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_ImmunizationScheduleIdentifier_IIS",
                    ValueSetName = "Immunization Schedule Identifier (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3292",
                    DefinitionText = "Identifies the schedule used for immunization evaluation and forecast.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fbe9e077-adb9-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_EvidenceOfImmunity_IIS",
                    ValueSetName = "Evidence Of Immunity (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3293",
                    DefinitionText = "Evidence of immunity indicates that a person has plausible evidence that they have already developed immunity to a particular disease.  The definition of plausible evidence is a local decision, but best practice would suggest that serological evidence of immunity is the strongest indicator of immunity.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2ab610d2-97ba-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_QueryPriority_IIS",
                    ValueSetName = "Query Priority (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3382",
                    DefinitionText = "Fields using this code set are expected to be I or null, which indicates Immediate processing is expected.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("51e8daea-99ba-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_QuantityLimitedRequest_IIS",
                    ValueSetName = "Quantity Limited Request (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3383",
                    DefinitionText = "HL7-defined Table 0126 - Quantity limited request (use in RCP-2). Fields using this code set are expected to be set to RD for records.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("73af1c0b-9eba-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_PublicityCode_IIS",
                    ValueSetName = "Publicity Code (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3384",
                    DefinitionText = "User-defined Table 0215 - Publicity code [values suggested by NIP] (use in PD1-11)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 9, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("304693de-0ec0-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_FacilityLocationNICU_NCHS",
                    ValueSetName = "Facility Location NICU (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.1",
                    DefinitionText = "To Reflect that the newborn was treated in the NICU reflecting an abnormal condition of the newborn.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("72859c1f-12c0-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_FacilityLocationICU_NCHS",
                    ValueSetName = "Facility Location ICU (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.2",
                    DefinitionText = "To Reflect that the patient (mother)  was treated in the ICU reflecting an maternal morbidity.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("249eda4c-1cc0-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_FacilityLocationOR_NCHS",
                    ValueSetName = "Facility Location OR (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.104",
                    DefinitionText = "To Reflect that the patient (mother)  was treated in the OR reflecting unplanned operation.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7f843d33-1ec0-df11-9bdd-0015173d1785"),
                    ValueSetCode = "PHVS_Antibiotics_NCHS",
                    ValueSetName = "Antibiotics (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.3",
                    DefinitionText = "To Reflect that antibiotics were administered.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("eb3411eb-a5c0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationAdministrationRouteIV_NCHS",
                    ValueSetName = "IV Medication Administration Route (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.4",
                    DefinitionText = "To Reflect that IV Medication Administration Route was used to administer a medication.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5e77647f-a7c0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationAdministrationRouteIM_NCHS",
                    ValueSetName = "IM Medication Administration Route (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.5",
                    DefinitionText = "To Reflect that Intramuscular Medication Administration Route was used to administer a medication.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fa92e31a-a9c0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_NeonatalSepsis_NCHS",
                    ValueSetName = "Neonatal Sepsis (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.6",
                    DefinitionText = "To Reflect that the newborn was provided assisted ventilation immediately following delivery reflecting an abnormal condition of the newborn.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0e631544-aac0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_SignificantBirthInjury_NCHS",
                    ValueSetName = "Significant Birth Injury (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.9",
                    DefinitionText = "To Reflect that the newborn suffered a Significant Birth Injury (skeletal fracture(s), peripheral nerve injury, and/ or soft tissue/solid organ hemorrhage which requires intervention) reflecting an abnormal condition of the newborn.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0e54b5c8-abc0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_SeizureOrSeriousNeurologicDysfunction_NCHS",
                    ValueSetName = "Seizure or Serious Neurologic Dysfunction (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.10",
                    DefinitionText = "To Reflect that the newborn suffered a Seizure or Serious Neurologic Dysfunction reflecting an abnormal condition of the newborn.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2452848f-aec0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_NeonatalDeath_NCHS",
                    ValueSetName = "Neonatal Death (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.149",
                    DefinitionText = "To Reflect that the newborn died",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("da751e47-afc0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_ApgarScore5Min_NCHS",
                    ValueSetName = "5 Min Apgar Score (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.12",
                    DefinitionText = "To Reflect the question as to the 5 Min Apgar Score",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("751e84a3-afc0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_ApgarScore10Min_NCHS",
                    ValueSetName = "10 Min Apgar Score (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.13",
                    DefinitionText = "To Reflect the question as to the 10 Min Apgar Score",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fbf97535-b0c0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_Delivery_NCHS",
                    ValueSetName = "Delivery (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.14",
                    DefinitionText = "To Reflect the Delivery Procedure",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ba69bce4-b3c0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_Physician_NCHS",
                    ValueSetName = "Physician (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.15",
                    DefinitionText = "To Reflect the Title of the Attendant responsible for the delivery Procedure as a Physician",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d8a4f7c8-b4c0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_DoctorOfOsteopathicMedicine_NCHS",
                    ValueSetName = "Doctor of Osteopathic Medicine (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.16",
                    DefinitionText = "To Reflect the Title of the Attendant responsible for the delivery Procedure as a Doctor of Osteopathic Medicine",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4d27fc26-b5c0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_CertifiedMidwife_NCHS",
                    ValueSetName = "Certified Midwife (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.17",
                    DefinitionText = "To Reflect the Title of the Attendant responsible for the delivery Procedure as a Certified Midwife",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("930bd1ee-c2c0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_Midwife_NCHS",
                    ValueSetName = "Midwife (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.18",
                    DefinitionText = "To Reflect the Title of the Attendant responsible for the delivery Procedure as a Midwife excluding registered midwife which is reflected in the certified midwife value set.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("43639750-c4c0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_USTerritories_NCHS",
                    ValueSetName = "U.S. Territories (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.19",
                    DefinitionText = "To Reflect the U.S. Territories",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c11feff8-c5c0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_BirthWeight_NCHS",
                    ValueSetName = "Birth Weight (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.20",
                    DefinitionText = "To Reflect the question as to the Birth Weight",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1044c646-c6c0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_MeasuredHeight_NCHS",
                    ValueSetName = "Measured Height (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.117",
                    DefinitionText = "To Reflect the mother's height",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4409e17d-c8c0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_PrePregnancyWeight_NCHS",
                    ValueSetName = "Pre-Pregnancy Weight (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.118",
                    DefinitionText = "To Reflect the question as to the mothers Pre-Pregnancy Weight",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ff9dfd6e-c9c0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_MothersDeliveryWeight_NCHS",
                    ValueSetName = "Mothers Delivery Weight (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.120",
                    DefinitionText = "To Reflect the question as to the Mother's Delivery Weight",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7a1edf42-32c3-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_AntibioticAdministrationProcedure_NCHS",
                    ValueSetName = "Antibiotic Administration Procedure (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.178",
                    DefinitionText = "To Reflect Antibiotic Administration Procedure during labor and delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ada52c41-34c3-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_FetusWeight_NCHS",
                    ValueSetName = "Fetus Weight (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.151",
                    DefinitionText = "To Reflect the weight of the fetus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0402619e-3bc3-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_GestationalHypertension_NCHS",
                    ValueSetName = "Gestational Hypertension (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.139",
                    DefinitionText = "To Reflect Risk Factors of Gestational Hypertension",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e552ea86-91c3-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_PrepregnancyHypertension_NCHS",
                    ValueSetName = "Prepregnancy Hypertension (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.138",
                    DefinitionText = "To Reflect Risk Factors of Prepregnancy Hypertension",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("90870326-98c3-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_PrepregnancyDiabetes_NCHS",
                    ValueSetName = "Prepregnancy Diabetes (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.136",
                    DefinitionText = "To Reflect Risk Factors of Prepregnancy Diabetes",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ef721ef7-69c4-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_Toxoplasmosis_NCHS",
                    ValueSetName = "Toxoplasmosis (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.169",
                    DefinitionText = "To Reflect infection with Parvovirus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6122e4fd-6cc4-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_Parvovirus_NCHS",
                    ValueSetName = "Parvovirus (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.168",
                    DefinitionText = "To Reflect infection with Parvovirus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("37e9ed28-13c5-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_Cytomegalovirus_NCHS",
                    ValueSetName = "Cytomegalovirus (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.167",
                    DefinitionText = "To Reflect infection with Cytomegalovirus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("42f62ca4-14c5-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_StreptococcusGroupB_NCHS",
                    ValueSetName = "Group B Streptococcus (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.166",
                    DefinitionText = "To Reflect Infection with Group B Streptococcus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6fd22678-18c5-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_HysterotomyHysterectomy_NCHS",
                    ValueSetName = "Hysterotomy Hysterectomy (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.150",
                    DefinitionText = "To reflect hysterotomy/histerectomy as the method of delivery in fetal death",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7de0df33-1bc5-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_FetalAutopsy_NCHS",
                    ValueSetName = "Fetal Autopsy (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.153",
                    DefinitionText = "To Reflect Fetal Autopsy  was performed",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e74d61fa-26c5-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_KaryotypeDetermination_NCHS",
                    ValueSetName = "Karyotype Determination (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.154",
                    DefinitionText = "To Reflect Fetal Autopsy  was performed",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("43cb2c90-27c5-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_NumberOfFetalDeathsThisDelivery_NCHS",
                    ValueSetName = "Number of Fetal Deaths This Delivery (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.164",
                    DefinitionText = "To Reflect the question as to the Number of Fetal Deaths This Delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("baf5a1c6-2dc5-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_ProlongedLabor_NCHS",
                    ValueSetName = "Prolonged Labor (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.131",
                    DefinitionText = "To Reflect Onset of labor with Prolonged Labor",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8d65ce6e-2fc5-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_Eclampsia_NCHS",
                    ValueSetName = "Eclampsia (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.140",
                    DefinitionText = "To Reflect Risk Factors of Eclampsia",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("451d7f12-30c5-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_PoorPregnancyOutcomeHistory_NCHS",
                    ValueSetName = "Poor Pregnancy Outcome History (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.142",
                    DefinitionText = "To Reflect Risk Factors of Pregnancy Outcome of Perinatal Death - History",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9e72edca-30c5-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_InfertilityTreatment_NCHS",
                    ValueSetName = "Infertility Treatment (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.143",
                    DefinitionText = "To Reflect Risk Factors of Pregnancy Infertility Treatment",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bd3c8656-31c5-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_ArtificialOrIntrauterineInsemination_NCHS",
                    ValueSetName = "Artificial or Intrauterine Insemination (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.145",
                    DefinitionText = "To Reflect the Artificial or Intrauterine Insemination  as a Risk Factor in Pregnancy",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e28d8167-32c5-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_AssistiveReproductiveTechnology_NCHS",
                    ValueSetName = "Assistive Reproductive Technology (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.146",
                    DefinitionText = "To Reflect the Assistive Reproductive Technology as a Risk Factor in Pregnancy",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e1d4aa94-80c5-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_StatedHeight_NCHS",
                    ValueSetName = "Stated Height (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.179",
                    DefinitionText = "To Reflect the mothers height (stated)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9cc31f3b-b7c6-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_AttemptedForceps_NCHS",
                    ValueSetName = "Attempted Forceps Procedure (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.106",
                    DefinitionText = "To Reflect the Attempted Forceps method of delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("042722d6-b7c6-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_AttemptedVacuum_NCHS",
                    ValueSetName = "Attempted Vacuum Procedure (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.107",
                    DefinitionText = "To Reflect the Attempted Vacuum method of delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("52528781-bac6-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_FetalPresentationAtBirthCephalic_NCHS",
                    ValueSetName = "Fetal Presentation at Birth- Cephalic (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.109",
                    DefinitionText = "To Reflect the Fetal Presentation at Birth- Cephalic method of delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 11, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d2570059-bcc6-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_RouteMethodOfDeliverySpontaneous_NCHS",
                    ValueSetName = "Route and Method of Delivery - Spontaneous (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.111",
                    DefinitionText = "To Reflect the Route and Method of Delivery as Spontaneous Delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bea041fb-bcc6-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_RouteMethodOfDeliveryForceps_NCHS",
                    ValueSetName = "Route and Method of Delivery - Forceps (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.112",
                    DefinitionText = "To Reflect the Route and Method of Delivery as Forceps Delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 10, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3e5fcc7d-c1c6-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_RouteMethodOfDeliveryVacuum_NCHS",
                    ValueSetName = "Route and Method of Delivery - Vacuum (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.113",
                    DefinitionText = "To Reflect the Route and Method of Delivery as Vacuum Delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("32ca3145-c2c6-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_RouteMethodOfDeliveryCesarean_NCHS",
                    ValueSetName = "Route and Method of Delivery - Cesarean (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.114",
                    DefinitionText = "To Reflect the Route and Method of Delivery as Cesarean Delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("66df3853-c3c6-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_RouteMethodOfDeliveryTrialOfLabor_NCHS",
                    ValueSetName = "Route Method of Delivery - Trial of Labor (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.115",
                    DefinitionText = "To Reflect the Route and Method of Delivery as Trial of Labor",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1c372fae-c3c6-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_RouteMethodOfDeliveryScheduledCesarean_NCHS",
                    ValueSetName = "Route and Method of Delivery - Scheduled C (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.116",
                    DefinitionText = "To Reflect the Route and Method of Delivery as Scheduled Cesarean",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e88ed11e-c4c6-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_CervicalCerclage_NCHS",
                    ValueSetName = "Cervical Cerclage (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.125",
                    DefinitionText = "To Reflect Obstetric Procedures as Cervical Cerclage",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("00c550a1-c4c6-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_Tocolysis_NCHS",
                    ValueSetName = "Tocolysis (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.128",
                    DefinitionText = "To Reflect Obstetric Procedures as Tocolysis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 7, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("56d72707-c5c6-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_PrematureRupture_NCHS",
                    ValueSetName = "Premature Rupture (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.129",
                    DefinitionText = "To Reflect Onset of labor with Premature Rupture",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5270a1a2-c5c6-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_PrecipitousLabor_NCHS",
                    ValueSetName = "Precipitous Labor (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.130",
                    DefinitionText = "To Reflect Onset of labor with Precipitous Labor",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("76d4e318-c6c6-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_PretermBirth_NCHS",
                    ValueSetName = "Preterm Birth (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.141",
                    DefinitionText = "To Reflect Risk Factors of Preterm Birth (history)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1648c666-03c8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_AnencephalyOfTheNewborn_NCHS",
                    ValueSetName = "Anencephaly of the Newborn (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.53",
                    DefinitionText = "To Reflect Anencephaly of the Newborn as an anomality of the newborn",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0e058e20-04c8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_CyanoticCongenitalHeartDisease_NCHS",
                    ValueSetName = "Cyanotic Congenital Heart Disease (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.54",
                    DefinitionText = "To Reflect Cyanotic Congenital Heart Disease as an anomality of the newborn",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("784eba7c-04c8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_CongenitalDiaphragmaticHernia_NCHS",
                    ValueSetName = "Congenital Diaphragmatic Hernia (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.55",
                    DefinitionText = "To Reflect Congenital Diaphragmatic Hernia  as an anomality of the newborn",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("925980cd-04c8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_KaryotypeConfirmed_NCHS",
                    ValueSetName = "Karyotype Confirmed (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.56",
                    DefinitionText = "To Reflect Karyotype Confirmed in an abnomality of the newborn",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6e8e6612-05c8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_SuspectedChromosomalDisorder_NCHS",
                    ValueSetName = "Suspected Chromosomal Disorder (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.57",
                    DefinitionText = "To Reflect Suspected Chromosomal Disorder as an anomality of the newborn",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("00329e7c-05c8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_CleftLipWithOrWithoutCleftPalate_NCHS",
                    ValueSetName = "Cleft Lip with or without Cleft Palate (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.58",
                    DefinitionText = "To Reflect Cleft Lip with/without Cleft Palate as an anomality of the newborn",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("88adf872-06c8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_CleftLipWithoutCleftPalate_NCHS",
                    ValueSetName = "Cleft Lip without Cleft Palate (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.60",
                    DefinitionText = "To Reflect Cleft Lip without Cleft Palate as an anomality of the newborn",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b492b454-07c8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_DownSyndrome_NCHS",
                    ValueSetName = "Down Syndrome (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.61",
                    DefinitionText = "To reflect Down Syndrome as an anomaly of the newborn",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7cd608c7-07c8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_Gastroschisis_NCHS",
                    ValueSetName = "Gastroschisis of the Newborn (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.62",
                    DefinitionText = "To reflect Gastroschisis of the Newborn  as an anomality of the newborn",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2e77cf11-08c8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_Hypospadias_NCHS",
                    ValueSetName = "Hypospadias (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.63",
                    DefinitionText = "To reflect Hypospadias as an anomality of the newborn",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7e3e0079-08c8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_LimbReduction_NCHS",
                    ValueSetName = "Limb Reduction Defect (NCHS)",
                    ValueSetOID = "6.1.4.1.19376.1.7.3.1.1.13.8.64",
                    DefinitionText = "To reflect Limb Reduction Defect as an anomality of the newborn",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ec5e18a4-09c8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_OmphaloceleOfTheNewborn_NCHS",
                    ValueSetName = "Omphalocele of the Newborn (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.66",
                    DefinitionText = "To reflect Omphalocele of the Newborn as an anomality of the newborn",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("025b833a-0ac8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_HepatitisB_NCHS",
                    ValueSetName = "Hepatitis B (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.96",
                    DefinitionText = "To reflect Hepatitis B as Infections present and treated during this pregnancy",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c4448513-0bc8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_HepatitisC_NCHS",
                    ValueSetName = "Hepatitis C (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.97",
                    DefinitionText = "To reflect Hepatitis C as Infections present and treated during this pregnancy",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2ea74392-0bc8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_Pregnant_NCHS",
                    ValueSetName = "Pregnant (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.95",
                    DefinitionText = "To reflect the pregnancy and associated dates with finding",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("18a84941-0cc8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_ConceptionDate_NCHS",
                    ValueSetName = "Conception Date (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.180",
                    DefinitionText = "To Reflect Conception Date",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("78cdd9a8-0cc8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_TransfusionWholeBloodOrPackedRBC_NCHS",
                    ValueSetName = "Transfusion Whole Blood or Packed Red Bld (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.99",
                    DefinitionText = "To reflect Transfusion Whole Blood or Packed Red Blood as a maternal morbidity",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("043ffd36-0dc8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_ThirdDegreePerinealLaceration_NCHS",
                    ValueSetName = "Third Degree Perineal Laceration (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.100",
                    DefinitionText = "To reflect Third Degree Perineal Laceration as a maternal morbidity",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7ac157a2-0dc8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_FourthDegreePerinealLaceration_NCHS",
                    ValueSetName = "Fourth Degree Perineal Laceration (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.101",
                    DefinitionText = "To reflect Fourth Degree Perineal Laceration as a maternal morbidity",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("863ad1fd-0dc8-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_RupturedUterus_NCHS",
                    ValueSetName = "Ruptured Uterus (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.102",
                    DefinitionText = "To reflect Ruptured Uterus as a maternal morbidity",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db58e60d-81cd-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_Syphilis_NCHS",
                    ValueSetName = "Syphilis (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.98",
                    DefinitionText = "To reflect Syphilis as Infections present and treated during this pregnancy",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9ace9cdc-93ce-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_FurtherFetalAssessment_NCHS",
                    ValueSetName = "Further Fetal Assessment (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.32",
                    DefinitionText = "To Reflect that there was a Fetal Intolerance of Labor Further Fetal Assessment including scalp pH, scalp stimulation, acoustic stimulation",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6ba73578-94ce-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_InductionOfLabor_NCHS",
                    ValueSetName = "Induction of Labor (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.34",
                    DefinitionText = "To Reflect that there was an Induction of Labor",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("481ed75f-95ce-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_SpontaneousOnsetOfLabor_NCHS",
                    ValueSetName = "Spontaneous Onset of Labor (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.35",
                    DefinitionText = "To Reflect that there was a Spontaneous Onset of Labor",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e8c0adc3-95ce-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_MeconiumStaining_NCHS",
                    ValueSetName = "Meconium Staining (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.36",
                    DefinitionText = "To Reflect that there was moderate or heavy Meconium staining",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cbd7e33f-96ce-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_NonVertexPresentationActivePhaseLabor_NCHS",
                    ValueSetName = "Non-vertex presentation in active phase of (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.37",
                    DefinitionText = "To Reflect that there was Non-vertex presentation in active phase of labor and delivery including breech, shoulder, brow, face presentations, and transverse lie",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ef9981a9-97ce-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_ImmatureFetus_NCHS",
                    ValueSetName = "Immature Fetus (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.39",
                    DefinitionText = "To Reflect an indication of Fetal Lung Maturation",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dc9f9864-2ed0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_MeningomyeloceleSpinaBifidaNewborn_NCHS",
                    ValueSetName = "Meningomyelocele/Spina Bifida - Newborn (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.65",
                    DefinitionText = "To reflect Meningomyelocele/Spina Bifida of the Newborn as an anomality of the newborn",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dff2bab1-31d0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_OperativeDelivery_NCHS",
                    ValueSetName = "Operative Delivery (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.33",
                    DefinitionText = "To Reflect that there was an Operative Delivery including operative intervention to shorten time to delivery of the fetus such as forceps, vacuum, or cesarean delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4d2a7906-35d0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_InUteroResuscitation_NCHS",
                    ValueSetName = "In-utero Resuscitation (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.31",
                    DefinitionText = "To Reflect that there was a Fetal Intolerance of Labor requiring In-utero Resuscitation measures including maternal position change, oxygen administration to the mother, intravenous fluid administered to the mother, amnioinfusion, support of maternal blood pressure, and administration of uterine relaxing agents",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6aa8ca77-36d0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_EpiduralAnesthesia_NCHS",
                    ValueSetName = "Epidural Anesthesia - Procedure (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.27",
                    DefinitionText = "To Reflect an Epidural Anesthesia Procedure",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("77cd2563-37d0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_ChorioamnionitisDuringLabor_NCHS",
                    ValueSetName = "Chorioamnionitis During Labor (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.24",
                    DefinitionText = "To Reflect a Chorioamnionitis During Labor",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6f772cd4-37d0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_AugmentationOfLaborProcedure_NCHS",
                    ValueSetName = "Augmentation of Labor - Procedure (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.22",
                    DefinitionText = "To Reflect a procedure of Augmentation of Labor",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b400869e-38d0-df11-ab08-0015173d1785"),
                    ValueSetCode = "PHVS_NoOfPreviousLiveBirthsNowLiving_NCHS",
                    ValueSetName = "Number of Previous Live Births Now Living (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.123",
                    DefinitionText = "To Reflect the question as to the number of previous live births now living",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("001dea0d-cc2a-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_PHINQuestions_CRS",
                    ValueSetName = "PHIN Questions (CRS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3294",
                    DefinitionText = "PHIN Questions (data elements) for Congenital Rubella Syndrome",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("011dea0d-cc2a-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_PHINQuestions_Malaria",
                    ValueSetName = "PHIN Questions (Malaria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3295",
                    DefinitionText = "PHIN Questions (data elements) for Malaria",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("041dea0d-cc2a-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_PHINQuestions_Rubella",
                    ValueSetName = "PHIN Questions (Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3298",
                    DefinitionText = "PHIN Questions (data elements) for Rubella",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("051dea0d-cc2a-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_PHINQuestions_StrepPneumo",
                    ValueSetName = "PHIN Questions (Strep Pneumo)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3299",
                    DefinitionText = "PHIN Questions (data elements) for Streptococcus Pneumonia",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a0a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_LabTestProcedure_Rubella",
                    ValueSetName = "Lab Test Procedure (Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3300",
                    DefinitionText = "Interpretative lab test types associated with Rubella",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a1a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_LabTestInterpretation_VPD",
                    ValueSetName = "Lab Test Interpretation (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3301",
                    DefinitionText = "Epidemiologic interpretation of the results of the tests performed for Vaccine Preventable Disease (VPD).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a2a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_BirthOutcome_Rubella",
                    ValueSetName = "Birth Outcome (Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3323",
                    DefinitionText = "Birth Outcome (i.e. Outcome of current pregnancy)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a3a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_LabTestProcedure_Measles",
                    ValueSetName = "Lab Test Procedure (Measles)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3302",
                    DefinitionText = "Epidemiologic interpretation of the type of test(s) performed for Measles.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a4a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_ParotitisLaterality_Mumps",
                    ValueSetName = "Parotitis Laterality (Mumps)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3304",
                    DefinitionText = "Indicates if the parotitis is unilateral or bilateral.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a5a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_DeafnessType_Mumps",
                    ValueSetName = "Type of Deafness (Mumps)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3305",
                    DefinitionText = "Type of Deafness (permanent or temporary)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a6a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_LabTestProcedure_Mumps",
                    ValueSetName = "Lab Test Procedure (Mumps)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3306",
                    DefinitionText = "Epidemiologic interpretation of the type of test(s) performed for Mumps.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a7a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_SpecimenSource_Mumps",
                    ValueSetName = "Specimen Source (Mumps)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3307",
                    DefinitionText = "The medium from which the specimen originated.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a8a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_Complications_Malaria",
                    ValueSetName = "Complications (Malaria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3308",
                    DefinitionText = "Listing of complications as related to Malaria.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 5, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a9a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_LabTestProcedure_Malaria",
                    ValueSetName = "Lab Test Procedure (Malaria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3309",
                    DefinitionText = "Epidemiologic interpretation of the type of test(s) performed for Malaria",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("aaa0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationMissedReason_Malaria",
                    ValueSetName = "Medication Missed (Malaria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3310",
                    DefinitionText = "Reason for missing the doses of malaria medication",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("aba0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationProphylaxis_Malaria",
                    ValueSetName = "Medication Prophylaxis (Malaria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3311",
                    DefinitionText = "Listing of preventative medications taken by the subject for malaria (Medication Prophylaxis for Malaria).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("aca0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_MedicationTreatment_Malaria",
                    ValueSetName = "Medication Treatment (Malaria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3312",
                    DefinitionText = "Listing of treatment medication the subject received for Malaria.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ada0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_Species_Malaria",
                    ValueSetName = "Species (Malaria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3313",
                    DefinitionText = "Species of Malaria identified through testing.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("aea0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_SpecimenType_Malaria",
                    ValueSetName = "Specimen Type (Malaria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3314",
                    DefinitionText = "Type(s) of specimen sent to CDC to test or confirm for Malaria.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 5, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("afa0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_TravelReason_Malaria",
                    ValueSetName = "Travel Reason (Malaria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3315",
                    DefinitionText = "Prinicipal reason for travel outside U.S.A. in the context of Malaria case notification.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 5, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b0a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_AntimicrobialAgent_IPD",
                    ValueSetName = "Antimicrobial Agent (IPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3316",
                    DefinitionText = "Anti-microbial agents for Invasive Pneumococcal Disease (IPD).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b1a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_AntimicrobialSuceptiblilityTestMethod_IPD",
                    ValueSetName = "Antimicrobial Susceptibility Test Method (IPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3317",
                    DefinitionText = "Anti-microbial Susceptibility Test Methods for Invasive Pneumococcal Disease (IPD).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b2a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_BacterialInfectionSyndrome_IPD",
                    ValueSetName = "Bacterial Infection Syndrome (IPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3318",
                    DefinitionText = "Bacterial Infection Syndrome for invasive pneumococcal disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b3a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_OxacillinInterpretation_IPD",
                    ValueSetName = "Oxacillin Interpretation (IPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3319",
                    DefinitionText = "Oxacillin Interpretation for invasive pneumococcal disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b4a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_SerotypeMethod_IPD",
                    ValueSetName = "Serotype Method (IPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3320",
                    DefinitionText = "Serotype Method for invasive pneumococcal disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b5a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_SterileSpecimen_IPD",
                    ValueSetName = "Sterile Specimen (IPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3321",
                    DefinitionText = "Sterile Specimen for invasive pneumococcal disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b6a0ddfe-202b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_UnderlyingConditions_IPD",
                    ValueSetName = "Underlying Conditions (IPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3322",
                    DefinitionText = "Underlying Conditions for invasive pneumococcal disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e05efd80-892b-df11-b334-0015173d1785"),
                    ValueSetCode = "PHVS_SpecimenSource_Measles",
                    ValueSetName = "Specimen Source (Measles)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3303",
                    DefinitionText = "The medium from which the specimen originated - Measles",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("671ad904-17a3-df11-bef5-0015173d1785"),
                    ValueSetCode = "PHVS_EventType_HL7_2x",
                    ValueSetName = "Event Type (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3337",
                    DefinitionText = "HL7 version 2.x Event type used in chapter(s) 2,12; HL7 table 03.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("07e9bcc6-62a3-df11-bef5-0015173d1785"),
                    ValueSetCode = "PHVS_CheckDigitScheme_HL7_2x",
                    ValueSetName = "Check Digit Scheme (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3339",
                    DefinitionText = "HL7 version 2.x Check digit scheme used in chapter(s) 2; HL7 table 061",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("47c3459b-a5a3-df11-bef5-0015173d1785"),
                    ValueSetCode = "PHVS_SpecimenActionCode_HL7_2x",
                    ValueSetName = "Specimen Action Code (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3340",
                    DefinitionText = "HL7 version 2.x Specimen action code used in chapter(s) 4; HL7 table 065",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("87446483-b0a3-df11-bef5-0015173d1785"),
                    ValueSetCode = "PHVS_MessageType_HL7_2x",
                    ValueSetName = "Message Type (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3341",
                    DefinitionText = "HL7 version 2.x Message type used in chapter(s) 2; HL7 table 076",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b11631b8-67a4-df11-bef5-0015173d1785"),
                    ValueSetCode = "PHVS_CodingSystem_HL7_2x_Table0396",
                    ValueSetName = "Coding System HL7 2x Table 0396",
                    ValueSetOID = "2.16.840.1.114222.4.11.3338",
                    DefinitionText = "List of all the code systems identifier from HL7 Table 0396.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("61940042-3ab9-e411-8193-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestResultInterpretation_NND",
                    ValueSetName = "Lab Test Result Interpretation (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7270",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ebd29a79-3bb9-e411-8193-0017a477041a"),
                    ValueSetCode = "PHVS_ReasonForMissingTest_NND",
                    ValueSetName = "Reason for Missing Test (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7269",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c7c6fd3c-7dbb-e411-8193-0017a477041a"),
                    ValueSetCode = "PHVS_CaseNotificationSpecificationVersion_NND",
                    ValueSetName = "Case Notification Specification Version (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7271",
                    DefinitionText = "Case Notification Specification version that would be sent in MSH-21",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b6570057-7ebb-e411-8193-0017a477041a"),
                    ValueSetCode = "PHVS_CaseNotificationMMGVersion_NND",
                    ValueSetName = "Case Notification MMG Version (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7272",
                    DefinitionText = "Case Notification Message Mapping Guide version that would be sent in MSH-21",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b004ffb-efc0-e411-8193-0017a477041a"),
                    ValueSetCode = "PHVS_DeathCertification_NCHS",
                    ValueSetName = "Death Certification (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.23.8.6",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c3671c82-f1c0-e411-8193-0017a477041a"),
                    ValueSetCode = "PHVS_DischargeDeath_NCHS",
                    ValueSetName = "Discharge Death (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.23.8.4",
                    DefinitionText = "To reflect information on the discharge disposition for the decedent",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("030df0ed-eec7-e411-8193-0017a477041a"),
                    ValueSetCode = "PHVS_DeathPronouncementFinding_NCHS",
                    ValueSetName = "Death Pronouncement Finding (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7273",
                    DefinitionText = "To reflect whether the pronouncer reports the pronounced date and time in the problem list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("edd5a6c9-130c-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_Industry_CDC_Census2002",
                    ValueSetName = "Industry CDC Census 2002",
                    ValueSetOID = "2.16.840.1.114222.4.11.7185",
                    DefinitionText = "2002 Industry coding system used by CDC (NIOSH & NCHS) for coding industry text.  Industry describes an economic/business sector comprised of businesses/ enterprises concerned with the output of a specified category of products or services (e.g., the construction industry or the agriculture industry).  This industry code system includes  2002 U.S. Census Bureau industry codes and  three additional codes developed by CDC for unpaid workers. The 2002 Census industry categories  are based on the 2002 North American Industry Classification System (NAICS).  The PH_Occupation_CDC_Census2002  code system should be used in conjunction with this industry code system when coding both industry and occupation.  For more information and instructions on using this coding system, see the instruction manual for Census  I&O coding at:  http://www.cdc.gov/niosh/topics/coding/",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 8, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("29eeabeb-140c-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_Occupation_CDC_Census2002",
                    ValueSetName = "Occupation CDC Census 2002",
                    ValueSetOID = "2.16.840.1.114222.4.11.7184",
                    DefinitionText = "2002 Occupation coding system used by CDC (NIOSH & NCHS) for coding occupation text.  Occupation describes a set of activities or tasks that individuals are paid to perform or, if unpaid, define a person’s contribution to a household/family business/community.  This occupation code system includes  2002 U.S. Census Bureau occupation codes with modifications made by CDC for unpaid workers and military occupations.  The 2002 Census occupation categories  are based on the 2000 BLS Standard Occupational Classification (SOC) system.  The PH_Industry_CDC_Census2002  code system should be used in conjunction with this occupation code system when coding both industry and occupation.  For more information and instructions on using this coding system, see the instruction manual for Census I&O coding at:  http://www.cdc.gov/niosh/topics/coding/",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 8, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cd1f3e72-160c-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_Occupation_CDC_Census2010",
                    ValueSetName = "Occupation CDC Census 2010",
                    ValueSetOID = "2.16.840.1.114222.4.11.7186",
                    DefinitionText = "2010 Occupation coding system used by CDC (NIOSH & NCHS) for coding occupation text.  Occupation describes a set of activities or tasks that individuals are paid to perform or, if unpaid, define a person’s contribution to a household/family business/community.  This code system includes  2010 U.S. Census Bureau occupation codes with modifications made by CDC for unpaid workers and military occupations.  The 2010 Census occupation categories  are based on the 2010 BLS Standard Occupational Classification (SOC) system.  The PH_Industry_CDC_Census2010  code system should be used in conjunction with this occupation code system when coding both industry and occupation.  For more information and instructions on using this coding system, see the instruction manual for CDC-Census I&O coding at:  http://www.cdc.gov/niosh/topics/coding/",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 8, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("981f6e94-1a0c-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_Industry_CDC_Census2010",
                    ValueSetName = "Industry CDC Census 2010",
                    ValueSetOID = "2.16.840.1.114222.4.11.7187",
                    DefinitionText = "2010 Industry coding system used by CDC (NIOSH & NCHS) for coding industry text.  Industry describes an economic/business sector comprised of businesses/ enterprises concerned with the output of a specified category of products or services (e.g., the construction industry or the agriculture industry).  This industry code system includes  2007 U.S. Census Bureau industry codes  and  three additional codes developed by CDC for unpaid workers.  The 2010 Census industry categories  are based on the 2007 North American Industry Classification System (NAICS).  The PH_Occupation_CDC_Census2010  code system should be used in conjunction with this industry code system when coding both industry and occupation.  For more information and instructions on using this coding system, see the instruction manual for CDC-Census I&O coding at:  http://www.cdc.gov/niosh/topics/coding/",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 8, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("34c71142-400f-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_TravelReason_HepatitisA",
                    ValueSetName = "Travel Reason (Hepatitis A)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7188",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 8, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8f6bc02b-5416-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_EmploymentStatus_ODH",
                    ValueSetName = "Employment Status (ODH)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7129",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 9, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("87334751-5416-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_WorkSchedule_ODH",
                    ValueSetName = "Work Schedule (ODH)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7130",
                    DefinitionText = "Describes an individual's typical arrangement of working hours for a job.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("844e6171-5c1a-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_YNRD_CDC",
                    ValueSetName = "YNRD (CDC)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7193",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 10, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8025f678-5d1a-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_SyphilisNeurologicInvolvement_STD",
                    ValueSetName = "Syphilis Neurologic Involvement (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7191",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 2, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("67aa1539-161b-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_HIVStatus_STD",
                    ValueSetName = "HIV Status (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7192",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 10, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dfcd483b-171b-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_DrugsUsed_STD",
                    ValueSetName = "Drugs Used (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7194",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 7, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("17ecbf72-181b-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_NonTreponemalSerologicTest_STD",
                    ValueSetName = "Non Treponemal Serologic Test (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7196",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 9, 11)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b891d988-eb1b-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenSource_STD",
                    ValueSetName = "Specimen Source (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7189",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 9, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("18127fa8-eb1b-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_ClinicianObservedLesions_STD",
                    ValueSetName = "Clinician Observed Lesions (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7195",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 9, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("38eac0c3-eb1b-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_TreponemalSerologicTest_STD",
                    ValueSetName = "Treponemal Serologic Test (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7197",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("32c4fddf-eb1b-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_TransmissionCategory_STD",
                    ValueSetName = "Transmission Category (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7198",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 9, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e817706d-ec1b-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_DetectionMethod_STD",
                    ValueSetName = "Detection Method (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7199",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("68a79f97-ec1b-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_LabResults_STD",
                    ValueSetName = "Lab Results (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7200",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 9, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("384c93bb-ec1b-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_LabTests_STD",
                    ValueSetName = "Lab Tests (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7201",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 9, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b8b974ec-ec1b-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_QuantitativeSyphilisTestResult_STD",
                    ValueSetName = "Quantitative Syphilis Test Result (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7203",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 9, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9e6cf98f-a01c-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_CurrentSex_NND",
                    ValueSetName = "Current Sex (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7190",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 9, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("da45b047-a21c-e311-81f2-0017a477041a"),
                    ValueSetCode = "PHVS_CountryImportedFrom_NND",
                    ValueSetName = "Country Imported From (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7202",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 9, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("391ec4a3-5b5d-e511-81f8-0017a477041a"),
                    ValueSetCode = "PHVS_DeathPronouncementProcedure_NCHS",
                    ValueSetName = "Death Pronouncement Procedure (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7274",
                    DefinitionText = "When an authorized person views the body and declares that death has occurred",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1953e16e-8984-e411-8338-0017a477041a"),
                    ValueSetCode = "PHVS_Listeria_NCHS",
                    ValueSetName = "Listeria (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.147",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 12, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bf759a9c-4785-e411-8338-0017a477041a"),
                    ValueSetCode = "PHVS_DurationUnit_CDC",
                    ValueSetName = "Duration Unit",
                    ValueSetOID = "2.16.840.1.114222.4.11.7265",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 1, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b511e38-7657-e711-8563-0017a477041a"),
                    ValueSetCode = "PHVS_JobEmploymentType_ODH",
                    ValueSetName = "Job Employment Type (ODH)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7597",
                    DefinitionText = "A Patient's employment type as defined by compensation and sector",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("22f72cf9-32d7-e511-8702-0017a477041a"),
                    ValueSetCode = "PHVS_SignsSymptoms_Dengue_ICD10CM",
                    ValueSetName = "Signs Symptoms Dengue ICD-10 CM",
                    ValueSetOID = "2.16.840.1.114222.4.11.7483",
                    DefinitionText = "Zika virus disease associated vocabulary for EHR and ELR",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f2213586-34d7-e511-8702-0017a477041a"),
                    ValueSetCode = "PHVS_SignsSymptoms_Chikungunya_ICD10CM",
                    ValueSetName = "Signs Symptoms Chikungunya ICD-10 CM",
                    ValueSetOID = "2.16.840.1.114222.4.11.7484",
                    DefinitionText = "Zika virus disease associated vocabulary for EHR and ELR",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f71df0d1-36d7-e511-8702-0017a477041a"),
                    ValueSetCode = "PHVS_SignsSymptoms_Zika_ICD10CM",
                    ValueSetName = "Signs Symptoms Zika ICD-10 CM",
                    ValueSetOID = "2.16.840.1.114222.4.11.7485",
                    DefinitionText = "Zika virus disease associated vocabulary for EHR and ELR",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f4382ff8-6cda-e511-8702-0017a477041a"),
                    ValueSetCode = "PHVS_DecedentEducationLevel_NCHS",
                    ValueSetName = "Decedent Education Level (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7385",
                    DefinitionText = "To reflect the possible highest level of education received by the decedent.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cb0b2628-0be6-e511-8702-0017a477041a"),
                    ValueSetCode = "PHVS_ReasonForHospitalization_VZ",
                    ValueSetName = "Reason for Hospitalization (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7487",
                    DefinitionText = "If the subject was hospitalized because of this event, indicate the reason(s)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 3, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("de7cbd27-9c7b-e211-87a9-0017a477041a"),
                    ValueSetCode = "PHVS_BirthAttendantTitles_NCHS",
                    ValueSetName = "Birth Attendant Titles (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7111",
                    DefinitionText = "The value set contains the list of titles used by persons (attendant) responsible for delivering a child/fetus. The attendant at birth/delivery is defined as the individual physically present at the delivery who is responsible for the delivery.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0969b533-dbae-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_Chlamydia_NCHS",
                    ValueSetName = "Chlamydia (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.93",
                    DefinitionText = "To reflect Chlamydia as Infections present and treated during this pregnancy.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8b74a8d2-77af-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_BirthPlaceHomeUnknownIntention_NCHS",
                    ValueSetName = "Birth Place Home Unknown Intention (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.195",
                    DefinitionText = "To reflect that the home was the place where the birth occurred",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f2854e13-89b1-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_BirthPlaceHospital_NCHS",
                    ValueSetName = "Birth Place Hospital (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.192",
                    DefinitionText = "To reflect that the hospital was the place where the birth occurred.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f8279cbe-8bb1-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_BirthPlaceClinicOffice_NCHS",
                    ValueSetName = "Birth Place Clinic Office (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.197",
                    DefinitionText = "To reflect that the clinic or doctor's office was the place where the birth occurred",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("925ac1b4-8cb1-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_BirthPlaceFreestandingBirthingCenter_NCHS",
                    ValueSetName = "Birth Place Freestanding Birthing Center  (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.196",
                    DefinitionText = "To reflect that the freestanding birthing center was the place where the birth occurred",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fdd8f390-c4b1-e311-8837-0017a477041a"),
                    ValueSetCode = "Fetal Intolerance of Labor (NCHS)",
                    ValueSetName = "Fetal Intolerance of Labor (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.30",
                    DefinitionText = "To Reflect that there was a Fetal Intolerance of Labor Further Fetal Assessment including in-utero resuscitation, further fetal assessment,  and operative delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9d526071-c7b1-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_ContributoryTobaccoUse_NCHS",
                    ValueSetName = "Contributory Tobacco Use (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6004",
                    DefinitionText = "To reflect the extent to which tobacco use contributed to the person's death.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cd9182cf-c8b1-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_PlaceOfDeath_NCHS",
                    ValueSetName = "Place of Death (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7216",
                    DefinitionText = "To reflect the death location of the decedent",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("62376171-ccb1-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_TransportationRelationships_NCHS",
                    ValueSetName = "Transportation Relationships (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6005",
                    DefinitionText = "To reflect the specific role played by the decedent, e.g. driver, passenger in a death related to transportation",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a486b310-cfb1-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_MannerOfDeath_NCHS",
                    ValueSetName = "Manner of Death (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6002",
                    DefinitionText = "To reflect the manner that a person died",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f48e96d2-94b2-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_PreviousCesarean_NCHS",
                    ValueSetName = "Previous Cesarean (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7165",
                    DefinitionText = "Mother had a previous cesarean delivery. Previous delivery by extracting the fetus, placenta, and membranes through an incision in the mother’s abdominal and uterine walls.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c3285ef7-98b2-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_NonVertexPresentation_NCHS",
                    ValueSetName = "Non-Vertex Presentation (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7142",
                    DefinitionText = "Nonvertex is presentation of other than the upper and back part of the infant’s head. Nonvertex presentation includes any nonvertex fetal presentation such as Breech, Shoulder, Brow, Face, Compound, and Transverse lie in the active phase of labor and delivery other than vertex.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("632dd89b-99b2-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_SteroidsForFetalLungMaturation_NCHS",
                    ValueSetName = "Steroids For Fetal Lung Maturation (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7143",
                    DefinitionText = "To Reflect a Steroids For Fetal Lung Maturation  During Labor",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3f2cff91-9cb2-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_EpiduralAnesthesiaMedication_NCHS",
                    ValueSetName = "Epidural Anesthesia - Medication (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.26",
                    DefinitionText = "To Reflect an Epidural Anesthesia Medication",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ca9eb5c0-50b3-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_FetalPresentationAtBirth- Other (NCHS)",
                    ValueSetName = "Fetal Presentation at Birth- Other (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.110",
                    DefinitionText = "To Reflect the Fetal Presentation at Birth excluding cephalic and breech presentations",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("affc86a0-5bb3-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_UnplannedHysterectomy_NCHS",
                    ValueSetName = "Unplanned Hysterectomy (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.103",
                    DefinitionText = "To reflect that the patient had an unplanned hysterectomy reflecting a maternal morbidity",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a8055d52-5cb3-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_ICUCare_NCHS",
                    ValueSetName = "ICU Care (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.188",
                    DefinitionText = "To reflect that the patient was in ICU care reflecting a maternal morbidity",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("aabe09df-5db3-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_UnplannedOperation_NCHS",
                    ValueSetName = "Unplanned Operation (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.105",
                    DefinitionText = "To reflect that the patient had an unplanned operation reflecting a maternal morbidity",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d106461e-61b3-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_NICUCare_NCHS",
                    ValueSetName = "NICU Care (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.198",
                    DefinitionText = "To Reflect that the newborn was provided NICU care reflecting an abnormal condition of the newborn.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("07f3cef3-62b3-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_CleftPalateAlone_NCHS",
                    ValueSetName = "Cleft Palate Alone (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.189",
                    DefinitionText = "To reflect Cleft Palate Alone as an anomality of the newborn",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a0a1b5ec-63b3-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_TransferToFacility_NCHS",
                    ValueSetName = "Transfer to Facility (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.190",
                    DefinitionText = "To refect that a patient was transferred to another facility",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a165c9bb-d6b4-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_EstimatedTimeOfDeathNoLaborOngoing_NCHS",
                    ValueSetName = "Estimated Time of Death No Labor Ongoing (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7153",
                    DefinitionText = "The estimated time of fetal death Indicating that dead at time of first assessment and no labor ongoing",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("11c6a409-d8b4-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_MaternalVitalSigns_NCHS",
                    ValueSetName = "Maternal Vital Signs (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7209",
                    DefinitionText = "The value set contains the list of vital sign items captured for a mother. Note, LOINC is being used as the primary source for codes within the value set.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("31362f6a-dab4-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_NewbornVitalSigns_NCHS",
                    ValueSetName = "Newborn Vital Signs (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7208",
                    DefinitionText = "The value set contains the list of vital sign information captured for a newborn or delivered fetus.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 5, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("215bcb26-c8b9-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_PregnancyStatus_NCHS",
                    ValueSetName = "Pregnancy Status (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6003",
                    DefinitionText = "To reflect whether the decedent was pregnant at or around the time of death",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 4, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0b8630dc-1ebc-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestReactivity_NND",
                    ValueSetName = "Lab Test Reactivity (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7217",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 4, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f5b2a58f-2fbf-e311-8837-0017a477041a"),
                    ValueSetCode = "PHVS_ResultStatus_NND",
                    ValueSetName = "Result Status (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7231",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 4, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("073a5e51-9dfc-e711-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestType_Measles",
                    ValueSetName = "Lab Test Type (Measles)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7661",
                    DefinitionText = "Interpretative lab test types associated with Measles.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("30cebc8d-9dfc-e711-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_Complications_Measles",
                    ValueSetName = "Type of Complication (Measles)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7660",
                    DefinitionText = "Complications associated with the illness being reported.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("63f75176-8a00-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_SignsSymptoms_Measles_NND",
                    ValueSetName = "Signs and Symptoms (Measles)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7662",
                    DefinitionText = "Signs & Symptoms value set for Measles. This value set is used to populate OBX-3 Observation Identifier in the message.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4b9d5469-cd06-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_JobSupervisoryLevelorPayGrade_ODH",
                    ValueSetName = "Job Supervisory Level or Pay Grade (ODH)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7613",
                    DefinitionText = "Reflects the amount of supervisory or management responsibilities for an individual’s job. In the military, this is the person’s pay grade, which serves as a proxy for supervisory level and can be interpreted across branches.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8a899e48-a107-e811-88f9-0017a477041a"),
                    ValueSetCode = "NHSNHealthcareServiceLocationCode",
                    ValueSetName = "Healthcare Service Location (NHSN)",
                    ValueSetOID = "2.16.840.1.113883.13.19",
                    DefinitionText = "NHSN's value set for healthcare service location. NOTE: This value set is no longer maintained by NHSN. Due to this, there will be no more updates made on this value set.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 2, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2f55be0a-5e08-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_NND_Malaria",
                    ValueSetName = "Data Elements (NND Malaria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7663",
                    DefinitionText = "This value set includes the data elements (DE) listed in the message mapping guide (MMG) for Malaria",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 2, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db2ee992-7508-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_NND_Varicella",
                    ValueSetName = "Data Elements (NND Varicella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7665",
                    DefinitionText = "This value set includes the data elements (DE) listed in the message mapping guide (MMG) for Varicella",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 2, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a7b6a40e-7608-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_NND_Babesiosis",
                    ValueSetName = "Data Elements (NND Babesiosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7664",
                    DefinitionText = "This value set includes the data elements (DE) listed in the message mapping guide (MMG) for Babesiosis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8380959b-0c0d-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_SignsSymptoms_Trich",
                    ValueSetName = "Signs and Symptoms (Trich)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7666",
                    DefinitionText = "Signs and symptoms of trichinellosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 2, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("797cefd9-0c0d-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_EosinophilUnits_CDC",
                    ValueSetName = "Eosinophil Units",
                    ValueSetOID = "2.16.840.1.114222.4.11.7667",
                    DefinitionText = "Units for eosinophil value",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 2, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("497bbc56-0d0d-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_MeatConsumedType_Trich",
                    ValueSetName = "Meat Consumed Type (Trich)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7668",
                    DefinitionText = "Specify type of suspect meat consumed [i.e., meat item(s) suspected of making the person ill]",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 2, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6f22038f-0d0d-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_MeatPurchaseInfo_Trich",
                    ValueSetName = "Meat Purchase Info (Trich)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7670",
                    DefinitionText = "Where was the suspected meat obtained?",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 2, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bfefc9b9-0d0d-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_FoodCookingMethod_Trich",
                    ValueSetName = "Food Cooking Method (Trich)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7671",
                    DefinitionText = "Method of cooking",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 2, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f045f3f3-0d0d-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_PerformingLaboratoryType_Trich",
                    ValueSetName = "Performing Lab Type (Trich)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7672",
                    DefinitionText = "Performing laboratory type",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 2, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4e97c6a9-0e0d-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_FoodProcessingMethod_Trich",
                    ValueSetName = "Food Processing Method (Trich)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7669",
                    DefinitionText = "Meat preparation after purchase (further food processing)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 2, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a2d7904b-160d-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestInterpretation_Trich",
                    ValueSetName = "Lab Test Interpretation (Trich)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7674",
                    DefinitionText = "Epidemiologic interpretation of the results of the test(s) performed for this case. This is a qualitative test result.  (e.g, positive, detected, negative)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 2, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d03ebebe-170d-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestType_Trich",
                    ValueSetName = "Lab Test Type (Trich)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7673",
                    DefinitionText = "Epidemiologic interpretation of the type of test(s) performed for this case.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 2, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("300c4213-190d-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenType_Trich",
                    ValueSetName = "Specimen type (Trich)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7675",
                    DefinitionText = "This indicates the type of specimen tested.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 2, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("43f6056f-1a0d-e811-88f9-0017a477041a"),
                    ValueSetCode = "PHVS_StrainType_Trich",
                    ValueSetName = "Strain Type (Trich)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7676",
                    DefinitionText = "If the specimen was sent for strain identification, indicate the strain.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("332950bf-c5c8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_BirthPlaceHomeIntended_NCHS",
                    ValueSetName = "Birth Place Home Intended (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.193",
                    DefinitionText = "To reflect that the home was the place where the birth occurred and that the birth was planned to be delivered in the home.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b378dd41-c6c8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_BirthPlaceHomeUnintended_NCHS",
                    ValueSetName = "Birth Place Home Unintended (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.194",
                    DefinitionText = "To reflect that the home was the place where the birth occurred and that the birth was not planned to be delivered in the home.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("53cdeb36-cec8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_SpinalAnesthesiaProcedure_NCHS",
                    ValueSetName = "Spinal Anesthesia - Procedure (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.29",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bf0388d1-16cc-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_FetalDeathCauseOrCondition_NCHS",
                    ValueSetName = "Fetal Death Cause or Condition (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7422",
                    DefinitionText = "The value sets contains the list of values used to report initiating cause or condition or other significant causes or conditions contributing to fetal death.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c87e8ff9-7dcd-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_NationallyNotifiableEventCode_Hepatitis",
                    ValueSetName = "Nationally Notifiable Event Code (Hepatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7275",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 18)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d538eb1b-63ce-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_NationallyNotifiableEventCode_STD",
                    ValueSetName = "Nationally Notifiable Event Code (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7276",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dc77141a-5bd2-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_ActPriority_HL7_V3",
                    ValueSetName = "Act Priority (HL7)",
                    ValueSetOID = "2.16.840.1.113883.1.11.16866",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a2e00839-5cd2-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_Act_Status_HL7_V3",
                    ValueSetName = "Procedure Act Status Code (HL7)",
                    ValueSetOID = "2.16.840.1.113883.11.20.9.22",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6e9bd15a-5fd2-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_LanguageAbilityProficiency_HL7_V3",
                    ValueSetName = "Language Ability Proficiency (HL7)",
                    ValueSetOID = "2.16.840.1.113883.1.11.12199",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("41aa3f3d-28d3-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_PriorityLevel_NCHS",
                    ValueSetName = "Priority Level (NCHS)",
                    ValueSetOID = "2.16.840.1.113883.11.20.9.60",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d1922039-2dd3-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_ProviderED_NCHS",
                    ValueSetName = "Provider ED (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7419",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b40229a0-fbd3-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_EntityNameUse_HL7_V3",
                    ValueSetName = "Entity Name Use (HL7)",
                    ValueSetOID = "2.16.840.1.113883.1.11.15913",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("046c5a41-fcd3-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_EntityPersonNamePartQualifier_HL7_V3",
                    ValueSetName = "Entity Person Name Part Qualifier (HL7)",
                    ValueSetOID = "2.16.840.1.113883.11.20.9.26",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b4de3ceb-fcd3-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_BasicConfidentialityKind_HL7_V3",
                    ValueSetName = "Basic Confidentiality Kind (HL7)",
                    ValueSetOID = "2.16.840.1.113883.1.11.16926",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("94d24450-fdd3-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_RoleClassCodes_HL7_V3",
                    ValueSetName = "Role Class Codes (HL7)",
                    ValueSetOID = "2.16.840.1.113883.11.20.9.33",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("142816ae-fdd3-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_MoodCodeEvnInt_HL7_V3",
                    ValueSetName = "MoodCodeEvnInt (HL7)",
                    ValueSetOID = "2.16.840.1.113883.11.20.9.18",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("34796790-fed3-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_ParticipationFunction_HL7_V3",
                    ValueSetName = "Participation Function (HL7)",
                    ValueSetOID = "2.16.840.1.113883.1.11.10267",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("844e0b1c-ffd3-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_PlannedMoodCodeActEncounterProcedure_HL7_V3",
                    ValueSetName = "Planned moodCode - Act/Encounter/Procedure (HL7)",
                    ValueSetOID = "2.16.840.1.113883.11.20.9.23",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("345c5ef1-ffd3-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_PlannedMoodCodeSubstanceAdminSupply_HL7_V3",
                    ValueSetName = "Planned moodCode - SubstanceAdministration/Supply",
                    ValueSetOID = "2.16.840.1.113883.11.20.9.24",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e84ad9d8-b0d4-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_TransportModeToHospital_NCHS",
                    ValueSetName = "Transport Mode to Hospital (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7277",
                    DefinitionText = "The mode of transport (e.g., ground ambulance, walk-in, police) delivering the patient to a hospital.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d667a757-b3d4-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_PostalAddressUse_HL7_V3",
                    ValueSetName = "Postal Address Use (HL7)",
                    ValueSetOID = "2.16.840.1.113883.1.11.10637",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fcfb6bbb-b3d4-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_ServiceEventPerformer_HL7_V3",
                    ValueSetName = "x_ServiceEventPerformer (HL7)",
                    ValueSetOID = "2.16.840.1.113883.1.11.19601",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d286e14d-a7d8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_SubstanceOtherThanClinicalDrug_NCHS",
                    ValueSetName = "Substance Other Than Clinical Drug (NCHS)",
                    ValueSetOID = "2.16.840.1.113762.1.4.1010.9",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("15a84dd8-a7d8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_DispositionED_NCHS",
                    ValueSetName = "Disposition ED (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7437",
                    DefinitionText = "The final arrangement or transfer of care made when a patient completes and emergency department encounter",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("78651c51-a9d8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_EpisodeofCare_NCHS",
                    ValueSetName = "Episode of Care (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7439",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5f337c21-aad8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_HospitalDischargeStatus_NCHS",
                    ValueSetName = "Hospital Discharge Status (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7440",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("726cae64-abd8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_PatientEducation",
                    ValueSetName = "Patient Education",
                    ValueSetOID = "2.16.840.1.113883.11.20.9.34",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f11d70fe-abd8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_PatientResidence_NCHS",
                    ValueSetName = "Patient Residence (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7402",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ee218b18-aed8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_PersonalLegalRelationshipRoleType_HL7_V3",
                    ValueSetName = "Personal And Legal Relationship Role Type (HL7)",
                    ValueSetOID = "2.16.840.1.113883.11.20.12.1",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7d323e89-b0d8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_PlannedMoodCodeObservation_HL7_V3",
                    ValueSetName = "Planned moodCode - Observation (HL7)",
                    ValueSetOID = "2.16.840.1.113883.11.20.9.25",
                    DefinitionText = "This value set is used to restrict the moodCode to future moods.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("34daa519-b1d8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_ProblemStatus",
                    ValueSetName = "Problem Status",
                    ValueSetOID = "2.16.840.1.113883.3.88.12.80.68",
                    DefinitionText = "A value set of SNOMED-CT codes reflecting state of existence.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4af550ef-b2d8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_ResidenceAccommodationType",
                    ValueSetName = "Residence and Accommodation Type",
                    ValueSetOID = "2.16.840.1.113883.11.20.9.49",
                    DefinitionText = "A value set of SNOMED-CT codes descending from 365508006  Residence and accommodation circumstances - finding reflecting type of residence, status of accommodations, living situation and environment.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("443330fa-b4d8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_TelecomUse_HL7_V3",
                    ValueSetName = "Telecom Use - US Realm Header (HL7)",
                    ValueSetOID = "2.16.840.1.113883.11.20.9.20",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6e9f7396-b6d8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_TobaccoUse",
                    ValueSetName = "Tobacco Use",
                    ValueSetOID = "2.16.840.1.113883.11.20.9.41",
                    DefinitionText = "Contains values descending from the SNOMED CT® Finding of tobacco use and exposure (finding) (365980008) hierarchy.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("53d1fb70-b8d8-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_TriageSystem_NCHS",
                    ValueSetName = "Triage System (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7401",
                    DefinitionText = "These values describe different types of triage systems.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("01daf709-94d9-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestPerformedModifier_CS",
                    ValueSetName = "Lab Test Performed Modifier (CS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7278",
                    DefinitionText = "Lab Test Performed Modifier includes concepts that can be used as a modifier for the lab test that can specify the timing or subject or event of performing a lab test (e.g. Mother's First Treponemal Lab Test Finding).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 12, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("57a389e7-42dd-e411-8970-0017a477041a"),
                    ValueSetCode = "PHVS_NonTreponemalTestResult_STD",
                    ValueSetName = "Non-Treponemal Test Result (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7279",
                    DefinitionText = "Non-Treponemal Test Result that includes coded quantitative titer concepts. Same value set would be used for STD and Congenital Syphilis case notification Non-Treponemal Test Results.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 1, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("90ea9030-3c92-e211-89a9-0017a477041a"),
                    ValueSetCode = "PHVS_AntituberculosisDrugs_TB",
                    ValueSetName = "Antituberculosis Drugs (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7055",
                    DefinitionText = "Drugs used to treat tuberculosis and latent tuberculosis infection (LTBI)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 3, 21)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d5fc6eba-3596-e211-89a9-0017a477041a"),
                    ValueSetCode = "PHVS_PregnancyRiskFactors_NCHS",
                    ValueSetName = "Pregnancy Risk Factors (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7126",
                    DefinitionText = "The value set contains the list of values used to indicate selected medical risk factors of the mother during this pregnancy.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4aac027a-fd96-e211-89a9-0017a477041a"),
                    ValueSetCode = "PHVS_OnsetLabor_NCHS",
                    ValueSetName = "Onset Labor (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7123",
                    DefinitionText = "The value set contains the list of values used to indicate serious complications experienced by the mother associated with labor and delivery.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("16e4382d-2ba1-e211-89a9-0017a477041a"),
                    ValueSetCode = "PHVS_FetalPresentations_NCHS",
                    ValueSetName = "Fetal Presentations (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7113",
                    DefinitionText = "The value set contains the list of the different presentations (orientations within the mother's womb) that a fetus may be in prior to delivery.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f06504b6-f7a1-e211-89a9-0017a477041a"),
                    ValueSetCode = "PHVS_DeliveryRoutes_NCHS",
                    ValueSetName = "Delivery Routes (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7118",
                    DefinitionText = "The value set contains the list of the possible routes by which the infant or fetus may be delivered.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9152fac7-f9a1-e211-89a9-0017a477041a"),
                    ValueSetCode = "PHVS_KaryotypeDownSyndrome_NCHS",
                    ValueSetName = "Karyotype Down Syndrome (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7116",
                    DefinitionText = "The value set contains the list of values that indicate whether the newborn/fetus is confirmed or pending if there is a diagnosis of Down syndrome, Trisomy 21.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5ab83877-cf40-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestResultQualitative_NND",
                    ValueSetName = "Lab Test Result Qualitative (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7206",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a6165d40-9245-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_InfluenzaTransmissionZones_PHLIP",
                    ValueSetName = "Influenza Transmission Zones (PHLIP)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7211",
                    DefinitionText = "Derived from the WHO Influenza Transmission Zones are geographical groups of countries, areas or territories with similar influenza transmission patterns.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("649f9359-2247-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_PHINQuestions_Hepatitis",
                    ValueSetName = "PHIN Questions (Hepatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3022",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("53422b33-ea47-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_MexicanHealthJurisdictions_BIDS",
                    ValueSetName = "Mexican Health Jurisdictions (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7159",
                    DefinitionText = "Defines Mexican Health Jurisdictions",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("13dd9f94-7248-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_BinationalReportingCriteria_BIDS",
                    ValueSetName = "Binational Reporting Criteria (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7166",
                    DefinitionText = "Defines criteria for Binational Reporting",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5337c1ba-7248-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_CaseTransmissionMode_BIDS",
                    ValueSetName = "Case Transmission Mode (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7167",
                    DefinitionText = "Defines if there is an Outbreak, how was it transmitted",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("93c76edd-7248-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_NotifiableEventDiseaseCondition_BIDS",
                    ValueSetName = "Notifiable Event Disease Condition (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7168",
                    DefinitionText = "Defines the Notifiable Event Disease Condition for this investigation",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b3253502-7348-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_USMexicoStates_BIDS",
                    ValueSetName = "US Mexico States (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7169",
                    DefinitionText = "Defines US Mexico States",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("63ed9b28-7348-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenSite_BIDS",
                    ValueSetName = "Specimen Site (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7170",
                    DefinitionText = "Defines a limited set of Specimen Sites",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("571b4246-7348-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_SalmonellaSerogroup_BIDS",
                    ValueSetName = "Salmonella Serogroup (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7171",
                    DefinitionText = "Defines Salmonella Serogroups of interest",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("532b086b-7348-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_ShigellaSerogroup_BIDS",
                    ValueSetName = "Shigella Serogroup (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7172",
                    DefinitionText = "Defines Shigella Serogroups of interest",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c3566e91-7348-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_CampylobacterSpecies_BIDS",
                    ValueSetName = "Campylobacter Species (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7173",
                    DefinitionText = "Defines Campylobacter Culture Isolation Species of interest",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1379cbc1-7348-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_CampylobacterNoncultureTestType_BIDS",
                    ValueSetName = "Campylobacter Nonculture Test Type (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7174",
                    DefinitionText = "Defines Campylobacter Nonculture Test Types of interest",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a34cbb22-7448-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_EcoliCultureIsolateIdSerotype_BIDS",
                    ValueSetName = "E. coli Culture Isolate Id Serotype (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7175",
                    DefinitionText = "Defines E. coli Culture Isolate Serotypes of interest",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("683f5747-7448-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_STECNoncultureTestType_BIDS",
                    ValueSetName = "STEC Nonculture Test Type (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7176",
                    DefinitionText = "Defines STEC Nonculture Test Types of interest",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1302276e-7448-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_EcoliShigaToxinTestType_BIDS",
                    ValueSetName = "E. coli Shiga Toxin Test Type (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7177",
                    DefinitionText = "Defines E. coli Shiga Toxin Test Types of interest",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("73ea918d-7448-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_EcoliShigaToxin_BIDS",
                    ValueSetName = "E. coli Shiga Toxin (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7178",
                    DefinitionText = "Defines E. coli Shiga Toxins of interest",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("833e62b3-7448-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_VibrioCultureSpecies_BIDS",
                    ValueSetName = "Vibrio Culture Species (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7179",
                    DefinitionText = "Defines Vibrio Culture Species of interest",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b3c091d1-7448-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_VibrioSerotype_BIDS",
                    ValueSetName = "Vibrio Serotype (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7180",
                    DefinitionText = "Defines Vibrio Serotypes of interest",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b30837f3-7448-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_VibrioBiotype_BIDS",
                    ValueSetName = "Vibrio Biotype (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7181",
                    DefinitionText = "Defines Vibrio Biotypes of interest",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("53084414-7548-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_VibrioCholeraToxinTestType_BIDS",
                    ValueSetName = "Vibrio Cholera Toxin Test Type (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7182",
                    DefinitionText = "Defines Vibrio Cholera Toxin Test Types of interest",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("63f8653d-7548-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_ListeriaCultureSpecies_BIDS",
                    ValueSetName = "Listeria Culture Species (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7183",
                    DefinitionText = "Defines Listeria Culture Species of interest",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5d07f96f-d34b-e311-8cc9-0017a477041a"),
                    ValueSetCode = "PHVS_PHINQuestions_BIDS",
                    ValueSetName = "PHIN Questions (BIDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7213",
                    DefinitionText = "Data elements associated with the Binational Infectious Disease Surveillance (BIDS) Enteric Message Mapping Guide",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 12, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e10f1412-a1a5-e311-8d07-0017a477041a"),
                    ValueSetCode = "PHVS_DietaryBehavior_HW",
                    ValueSetName = "Dietary Behavior (HW)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.23.8.8",
                    DefinitionText = "To reflect Healthy Weight influencing factors of Dietary Behavior",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4f3c794a-a1a5-e311-8d07-0017a477041a"),
                    ValueSetCode = "PHVS_PhysicalActivityBehavior_HW",
                    ValueSetName = "Physical Activity Behavior (HW)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.23.8.9",
                    DefinitionText = "To reflect Physical Activity Behavior",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b2ddb57c-a1a5-e311-8d07-0017a477041a"),
                    ValueSetCode = "PHVS_Interventions_HW",
                    ValueSetName = "Interventions (HW)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.23.8.7",
                    DefinitionText = "This value set reflects  interventions that will support improved healthy weight",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e026e5ad-a1a5-e311-8d07-0017a477041a"),
                    ValueSetCode = "PHVS_FamilyHistory_HW",
                    ValueSetName = "Family History (HW)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.23.8.13",
                    DefinitionText = "To reflect Family History that impact Healthy Weight",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5453b10c-a2a5-e311-8d07-0017a477041a"),
                    ValueSetCode = "PHVS_LaboratoryTests_HW",
                    ValueSetName = "Laboratory Tests (HW)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.23.8.17",
                    DefinitionText = "To identify laboratory tests that are relevant to improved healthy weight",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a5e20e43-a2a5-e311-8d07-0017a477041a"),
                    ValueSetCode = "PHVS_MotherBreastfeeding_HW",
                    ValueSetName = "Mother Breastfeeding (HW)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.23.8.14",
                    DefinitionText = "To reflect that the mother is breastfeeding her child",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bbe8f2c0-252f-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestName_Ebolavirus",
                    ValueSetName = "Lab Test Name (Ebolavirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7243",
                    DefinitionText = "lab tests (LOINC) associated with Ebola virus. Ebola 2014 outbreak Zaire strain LOINC code (75411-9: EZ1 RNA PlasBld Ql PCR )",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("80bdd27a-5d37-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_ApgarAssessments_NCHS",
                    ValueSetName = "Apgar Assessments (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7210",
                    DefinitionText = "The value set contains systematic measures as to the question for evaluating the physical condition of the infant at specific intervals following birth.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 5, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0b4f19bc-5f37-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_AutopsyExamination_NCHS",
                    ValueSetName = "Autopsy Examination (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7137",
                    DefinitionText = "The value set contains the list of values used to indicate whether or not an autopsy was performed.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a1b865c2-6037-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_FetalDeathTimePoints_NCHS",
                    ValueSetName = "Fetal Death Time Points (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7112",
                    DefinitionText = "The value set contains a list of items to indicate when the fetus died with respect to labor and assessment.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5bab5341-f738-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_QLRInconc_ReportableConditions",
                    ValueSetName = "Qual Lab Result Inconc (Reportable Conditions)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7236",
                    DefinitionText = "Coded values for inconclusive test results in the OBX-5 field, such as Equivocal, Indeterminate, Inconclusive, etc.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("037007e4-ca3c-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_QLRNeg_ReportableConditions",
                    ValueSetName = "Qual Lab Result Negative (Reportable Conditions)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7235",
                    DefinitionText = "Coded values for negative test results in the OBX-5 field, such as Not detected, No growth, Non-reactive, etc.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e70b0ed9-cb3c-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_QLRPos_ReportableConditions",
                    ValueSetName = "Qual Lab Result Positive (Reportable Conditions)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7234",
                    DefinitionText = "Coded values for positive test results in the OBX-5 field, such as Detected, Positive, Reactive, etc.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("845c6dbb-e03c-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_BirthStatus_NND",
                    ValueSetName = "Birth Status (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7223",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ae19827d-e13c-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_CSFWBCProteinResult_NND",
                    ValueSetName = "CSF WBC  Protein Result (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7228",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1e111d66-e23c-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_DarkFieldDFAResult_CS",
                    ValueSetName = "Darkfield DFA Result (CS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7224",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6d3cf247-e33c-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_PregnancyTreatmentStage_NND",
                    ValueSetName = "Pregnancy Treatment Stage (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7220",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("840f9007-e43c-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_SerologicResponse_CS",
                    ValueSetName = "Serologic Response (CS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7222",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fc9bbedc-e43c-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_SignsSymptoms_CS",
                    ValueSetName = "Signs Symptoms (CS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7225",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ffb945d0-e53c-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_SyphilisClinicalStage_CS",
                    ValueSetName = "Syphilis Clinical Stage (CS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7218",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c080ebce-e63c-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_SyphilisSurveillanceStage_CS",
                    ValueSetName = "Syphilis Surveillance Stage (CS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7219",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5ffe1ec2-e73c-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_SyphilisTreatmentInfant_CS",
                    ValueSetName = "Syphilis Treatment Infant (CS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7229",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("76f95f9b-e83c-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_SyphilisTreatmentMother_CS",
                    ValueSetName = "Syphilis Treatment Mother (CS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7221",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ede6f963-e93c-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_VDRLTestResult_NND",
                    ValueSetName = "VDRL Test Result (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7227",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ba29826b-ea3c-e411-8d91-0017a477041a"),
                    ValueSetCode = "PHVS_XRayResult_CS",
                    ValueSetName = "X-Ray Result (CS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7226",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b79893b2-6ecc-e611-8e51-0017a477041a"),
                    ValueSetCode = "PHVS_RouteofAdministration_CDC",
                    ValueSetName = "Route of Administration",
                    ValueSetOID = "2.16.840.1.113762.1.4.1018.98",
                    DefinitionText = "This set of values contain the current set of terms related to the location of administration for clinical therapeutics.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 12, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3ad58570-05ce-e611-8e51-0017a477041a"),
                    ValueSetCode = "PHVS_TestType_Syphilis",
                    ValueSetName = "Test Type (Syphilis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7549",
                    DefinitionText = "Interpretative lab tests associated with Syphilis and includes both treponemal and non-treponemal tests.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 12, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5740cb63-49d5-e311-8f3c-0017a477041a"),
                    ValueSetCode = "PHVS_CertifierTypes_NCHS",
                    ValueSetName = "Certifier Types (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6001",
                    DefinitionText = "To reflect the type of certifier for the death certificate.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 12, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("872d11d5-4cd5-e311-8f3c-0017a477041a"),
                    ValueSetCode = "PHVS_Country_GEC",
                    ValueSetName = "Country (GEC)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7162",
                    DefinitionText = "Country value set includes current countries as well as historical countries based on Geopolitical Entities and Codes (GEC).  This list will be used for coding of birth, fetal death, and death certificates from 2014 onwards. A few codes appear more than once in the list alphabetized under commonly use variants of the official name. Note that codes are not available for countries that ceased to exist prior to June 15, 1970.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 5, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("860169d0-64a6-e411-8f69-0017a477041a"),
                    ValueSetCode = "PHVS_Diarrhea_CDS_EHR",
                    ValueSetName = "Diarrhea (CDS - EHR)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7264",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 1, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("00c71cf6-d8ab-e411-9365-0017a477041a"),
                    ValueSetCode = "PHVS_AbdominalPain_CDS_EHR",
                    ValueSetName = "Abdominal Pain (CDS - EHR)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7257",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1ca39c4c-d9ab-e411-9365-0017a477041a"),
                    ValueSetCode = "PHVS_Weakness_CDS_EHR",
                    ValueSetName = "Weakness (CDS - EHR)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7258",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fcd6b89e-d9ab-e411-9365-0017a477041a"),
                    ValueSetCode = "PHVS_Fever_CDS_EHR",
                    ValueSetName = "Fever (CDS - EHR)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7259",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bc4c34f2-d9ab-e411-9365-0017a477041a"),
                    ValueSetCode = "PHVS_Headache_CDS_EHR",
                    ValueSetName = "Headache (CDS - EHR)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7260",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bc2254d3-daab-e411-9365-0017a477041a"),
                    ValueSetCode = "PHVS_Hemorrhage_CDS_EHR",
                    ValueSetName = "Hemorrhage (CDS - EHR)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7261",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6fa7254a-dbab-e411-9365-0017a477041a"),
                    ValueSetCode = "PHVS_MusclePain_CDS_EHR",
                    ValueSetName = "Muscle Pain (CDS - EHR)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7262",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("69d5faf2-dbab-e411-9365-0017a477041a"),
                    ValueSetCode = "PHVS_Vomiting_CDS_EHR",
                    ValueSetName = "Vomiting (CDS - EHR)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7263",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1e190752-75b1-e411-9365-0017a477041a"),
                    ValueSetCode = "PHVS_FertilityEnhancingDrugs_NCHS",
                    ValueSetName = "Fertility Enhancing Drugs (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.144",
                    DefinitionText = "To Reflect Fertility Enhancing Medications",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3a375449-6cec-e511-9555-0017a477041a"),
                    ValueSetCode = "PHVS_TransmissionMode_Arbovirus",
                    ValueSetName = "Transmission Mode (Arbovirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7489",
                    DefinitionText = "Other Arboviral unusual and rare disease transmission modes. This variable is used to differentiate the In Utero (Transplacental) vs Perinatal. This variable also can be used to capture more than one transmission mode. Other valid values such as blood donation, blood transfusion, lab acquired, organ transplant are not included in this value set as they exists as variables in the current guide as risk factors.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 4, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("74137efd-6cec-e511-9555-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenType_Arbovirus",
                    ValueSetName = "Specimen Type (Arbovirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7488",
                    DefinitionText = "List of specimens associated with Arbovirus laboratory tests",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 3, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("72452ba1-6eec-e511-9555-0017a477041a"),
                    ValueSetCode = "PHVS_ClinicalSyndromeSecondary_Arbovirus",
                    ValueSetName = "Clinical Syndrome - Secondary (Arbovirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7490",
                    DefinitionText = "Secondary clinical syndrome is the type of clinical presentation the case had.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 4, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("641fbf13-6fec-e511-9555-0017a477041a"),
                    ValueSetCode = "PHVS_PregnancyComplications_Arbovirus",
                    ValueSetName = "Pregnancy Complications (Arbovirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7491",
                    DefinitionText = "This data element won't be used for congenital infection newborn cases.Complications of pregnancy such as Microcephaly, Intracranial Calcification, Fetal growth abnormality and Fetus with Central Nervous System (CNS) abnormalities.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 4, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e1c35370-6fec-e511-9555-0017a477041a"),
                    ValueSetCode = "PHVS_NewbornComplications_Arbovirus",
                    ValueSetName = "Newborn Complications (Arbovirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7492",
                    DefinitionText = "This data element would be used only for Congenital / Neonatal cases",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 4, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b3a09ff9-6fec-e511-9555-0017a477041a"),
                    ValueSetCode = "PHVS_PregnancyOutcome_CDC",
                    ValueSetName = "Pregnancy Outcome",
                    ValueSetOID = "2.16.840.1.114222.4.11.7494",
                    DefinitionText = "This maternal data element captures the pregnancy outcomes such as livebirth, , premature birth, still birth, fetal loss, perinatal death and therapeutic abortion.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 4, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c9697652-71ec-e511-9555-0017a477041a"),
                    ValueSetCode = "PHVS_PerformingLabType_Arbovirus",
                    ValueSetName = "Performing Lab Type (Arbovirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7493",
                    DefinitionText = "Type of labs that were used to test for Arboviral lab tests - CDC Lab, State Public Health Lab, Commercial Lab.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 4, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8700daad-71ec-e511-9555-0017a477041a"),
                    ValueSetCode = "PHVS_Serotype_Arbovirus",
                    ValueSetName = "Serotype (Arbovirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7495",
                    DefinitionText = "If there are serotypes for any of the Arbovirus, use the Serotype to specify the sub-type.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 4, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dd280dd0-4cfb-e511-9555-0017a477041a"),
                    ValueSetCode = "PHVS_DeathReportingValueType_NCHS",
                    ValueSetName = "Death Reporting Value Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7497",
                    DefinitionText = "To reflect the list of possible data types that can appear as the data type for observations used within the Death Reporting Implementation Guide.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 4, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f314b4fb-4ffb-e511-9555-0017a477041a"),
                    ValueSetCode = "PHVS_YesNoNotApplicable_NCHS",
                    ValueSetName = "Yes No Not Applicable (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7486",
                    DefinitionText = "Value set used to respond to any question that can be answered Yes, No, or Not Applicable.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("255e8e6d-50fb-e511-9555-0017a477041a"),
                    ValueSetCode = "PHVS_MethodsOfDisposition_NCHS",
                    ValueSetName = "Methods of Disposition (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7379",
                    DefinitionText = "To reflect the method by which the decedent's body was disposed.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 4, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9c484473-b0fd-e511-9555-0017a477041a"),
                    ValueSetCode = "PHVS_DeathReportingObservationResultStatus_NCHS",
                    ValueSetName = "Death Reporting Observation Result Status (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7496",
                    DefinitionText = "To reflect the status of the observation.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 4, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("019fe45a-91b1-e611-95ee-0017a477041a"),
                    ValueSetCode = "PHVS_OutdoorActivities_CDC",
                    ValueSetName = "Outdoor Activities",
                    ValueSetOID = "2.16.840.1.114222.4.11.7544",
                    DefinitionText = "Which outdoor activities did the subject engage in?",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 11, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("717b81bc-91b1-e611-95ee-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestType_Babesiosis",
                    ValueSetName = "Lab Test Type (Babesiosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7545",
                    DefinitionText = "Epidemiologic interpretation of the type of test(s) performed for this case",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("41fb6d92-98b1-e611-95ee-0017a477041a"),
                    ValueSetCode = "PHVS_BirthDefectDiagnosis_CDC",
                    ValueSetName = "Birth Defect Diagnosis",
                    ValueSetOID = "2.16.840.1.113883.13.277",
                    DefinitionText = "Collection of SNOMED codes of the diagnoses that are considered to be birth defects. The Birth Defect Diagnosis values were created for the CDA Implementation Guide for Ambulatory Healthcare Provider Reporting to Birth Defect Registries.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 11, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("51fcde19-99b1-e611-95ee-0017a477041a"),
                    ValueSetCode = "PHVS_BirthDefectsDiagnosticConfirmation_HL7",
                    ValueSetName = "Birth Defects Diagnostic Confirmation (HL7)",
                    ValueSetOID = "2.16.840.1.113883.10.14.91",
                    DefinitionText = "Code for the best method used to confirm the presence of the Birth Defect(s) being reported.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 11, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("91bd205e-99b1-e611-95ee-0017a477041a"),
                    ValueSetCode = "PHVS_BirthDefectsLateralityatDiagnosis_HL7",
                    ValueSetName = "Birth Defects Laterality at Diagnosis (HL7)",
                    ValueSetOID = "2.16.840.1.113883.10.14.93",
                    DefinitionText = "Code for the side of a paired organ, or the side of the body on which the reportable Birth Defect(s) is present.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 11, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ab315a0c-fcc6-e611-95ee-0017a477041a"),
                    ValueSetCode = "PHVS_NATTests_Zika",
                    ValueSetName = "NAT Tests (Zika)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7546",
                    DefinitionText = "Zika virus NAT tests in LOINC. This value set includes PCR, plus other non-PCR nucleic acid tests.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 12, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1bf2fb66-fcc6-e611-95ee-0017a477041a"),
                    ValueSetCode = "PHVS_IgMAbTests_Zika",
                    ValueSetName = "IgM Ab Tests (Zika)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7547",
                    DefinitionText = "Zika virus IgM antibody tests in LOINC",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 12, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dbd23158-fdc6-e611-95ee-0017a477041a"),
                    ValueSetCode = "PHVS_NeutralizingAbTests_Zika",
                    ValueSetName = "Neutralizing Ab Tests (Zika)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7548",
                    DefinitionText = "Zika virus neutralizing antibody tests in LOINC",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 12, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a0ff5a9e-4359-e411-9618-0017a477041a"),
                    ValueSetCode = "PHVS_Symptoms_EVD_Triage",
                    ValueSetName = "Symptoms (EVD Triage)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7247",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 21)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7ffce50a-4559-e411-9618-0017a477041a"),
                    ValueSetCode = "PHVS_CountriesWidespreadTransmission_EVD",
                    ValueSetName = "Countries Widespread Transmission (EVD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7248",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 21)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2b2cdade-4559-e411-9618-0017a477041a"),
                    ValueSetCode = "PHVS_ObservationIdentifiers_EVD_Triage",
                    ValueSetName = "Observation Identifiers (EVD Triage)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7250",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 21)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("25e2a878-3c3d-e611-9785-0017a477041a"),
                    ValueSetCode = "PHVS_ApplicationErrorCode_NCHS",
                    ValueSetName = "Application Error Code (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7438",
                    DefinitionText = "A list of the possible error types that may be recorded during processing of a received message and returned to the message sender in a response.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("54e764ae-7d60-e811-98fd-0017a477041a"),
                    ValueSetCode = "PHVS_GenotypicTestName_CP-CRE",
                    ValueSetName = "Genotypic Test Name (CP-CRE)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7825",
                    DefinitionText = "Molecular methods for carbapenemase resistance mechanism.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b861a3e2-7e60-e811-98fd-0017a477041a"),
                    ValueSetCode = "PHVS_PhenotypicTestMethod_CP-CRE",
                    ValueSetName = "Phenotypic Test Method (CP-CRE)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7824",
                    DefinitionText = "Methods showing evidence of carbapenemase production",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9fe448eb-2f68-e811-98fd-0017a477041a"),
                    ValueSetCode = "PHVS_SegmentActionCode_HL7_2x",
                    ValueSetName = "Segment Action Code (HL7_2x)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7827",
                    DefinitionText = "Health Level 7 (HL7) version 2.x Specimen action code used in chapter(s) 4",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2781f898-3d70-e811-98fd-0017a477041a"),
                    ValueSetCode = "PHVS_ImmunizationProfileID_IIS",
                    ValueSetName = "Immunization Profile ID (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7828",
                    DefinitionText = "Identifiers the profile used in the message for Implementation Guide V2.8.2.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2881f898-3d70-e811-98fd-0017a477041a"),
                    ValueSetCode = "PHVS_SeriesStatus_IIS",
                    ValueSetName = "Series Status (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7829",
                    DefinitionText = "Status of a patient within an immunization series",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1279ad52-a171-e811-98fd-0017a477041a"),
                    ValueSetCode = "PHVS_ObservationIdentifier_V2_IIS",
                    ValueSetName = "Observation Identifier V2 (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7830",
                    DefinitionText = "The observation identifiers are used for patient level observations, observations about immunization events and observations about evaluated events and forecasts",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b32540e1-4c31-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_NoPrenatalCareVisit_NCHS",
                    ValueSetName = "No Prenatal Care Visit (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7352",
                    DefinitionText = "To reflect the question as to whether there were no prenatal care visits",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("79269363-9034-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_TransferredForMaternalMedicalOrFetalIndicatio",
                    ValueSetName = "Transferred for Maternal Medical or Fetal Indicat",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.176",
                    DefinitionText = "The value set contains the list of values used to indicate whether the mother was transferred for  maternal medical or fetal indications for delivery from another facility. Transfers include hospital to hospital, birth facility to hospital,  but do not include home to hospital transfers.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 7, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5917f3a9-9134-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_SurfactantReplacementTherapy_NCHS",
                    ValueSetName = "Surfactant Replacement Therapy (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7431",
                    DefinitionText = "To reflect surfactant replacement therapy as a newborn abnormal condition",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 7, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("495a2661-9234-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_PregnancyResulting FromFertilityEnhancingDrug",
                    ValueSetName = "Pregnancy Resulting From Fertility Enhancing Drugs",
                    ValueSetOID = "2.16.840.1.114222.4.11.7423",
                    DefinitionText = "The value set contains a list of items to indicate  whether a pregnancy resulted from fertility enhancing drugs",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 7, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("de1a07ff-f335-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_Laterality_NAACCR",
                    ValueSetName = "Laterality (NAACCR)",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.22",
                    DefinitionText = "Code for the side of a paired organ, or the side of the body on which the reportable tumor originated.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 7, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("df3da17b-fc35-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_CurrentSmokingStatus_NAACCR",
                    ValueSetName = "Current Smoking Status (NAACCR)",
                    ValueSetOID = "2.16.840.1.113883.11.20.9.38",
                    DefinitionText = "This value set indicates the current smoking status of a patient.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 7, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("95c052c9-0036-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_RadRxICD10PCS_NAACCR",
                    ValueSetName = "Radiation Rx and Boost Radiation ICD10-PCS (NAACCR",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.25",
                    DefinitionText = "Records the dominant modality of radiation therapy used to deliver the clinically most significant regional dose to the primary volume of interest during the first course of treatment.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 7, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("32e58d04-1d36-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_RadRxSNOMED_NAACCR",
                    ValueSetName = "Radiation Rx and Boost Radiation SNOMEDCT (NAACCR)",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.26",
                    DefinitionText = "Records the dominant modality of radiation therapy used to deliver the clinically most significant regional dose to the primary volume of interest during the first course of treatment.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 7, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a5620df4-983b-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_TNMPathologicStagedBy_NAACCR",
                    ValueSetName = "NAACCR TNM Pathologic Staged By (NAACCR)",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.27",
                    DefinitionText = "Identifies the person who recorded the pathologic AJCC staging elements and the stage group in the patient's medical record.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ba680d9f-9d3b-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_TNMPathologicStageDescriptor_NAACCR",
                    ValueSetName = "TNM Pathologic Stage Descriptor (NAACCR)",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.21",
                    DefinitionText = "Code for the the AJCC pathologic stage (prefix/suffix) descriptor as defined by AJCC. Identify special cases that need separate data analysis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c57dcecf-4b3c-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_InstitutionReferredTo_NCHS",
                    ValueSetName = "Institution Referred To (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.191",
                    DefinitionText = "To reflect the question as to the facility the infant was transferred to",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0e56aefd-823f-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_PartLineNumber_NCHS",
                    ValueSetName = "Part/line Number",
                    ValueSetOID = "2.16.840.1.114222.4.11.7354",
                    DefinitionText = "To indicate where in the death report structure an individual item of death cause information appeared.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2de1e1b0-c541-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_Relationship_NND",
                    ValueSetName = "Relationship (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7366",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4bf34685-ce41-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_ExposureTimeFrame_NND",
                    ValueSetName = "Exposure Time Frame (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7367",
                    DefinitionText = "Used for MVPS data provisioning",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f10b389d-eb44-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_EstimatedTimeOfFetalDeath_NCHS",
                    ValueSetName = "Estimated Time Of Fetal Death (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7426",
                    DefinitionText = "To reflect the question as to the estimated time of fetal death",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e718a4a5-f244-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_HistologicalPlacentalExamPerformed_NCHS",
                    ValueSetName = "Histological Placental Exam Performed (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7430",
                    DefinitionText = "To reflect the question as to whether a histological placental examination was performed.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bd4760f7-f444-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_Hysterectomy_NCHS",
                    ValueSetName = "Hysterectomy (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7357",
                    DefinitionText = "To reflect hysterectomy as the method of delivery in fetal death",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4fcc017a-1345-e511-99a5-0017a477041a"),
                    ValueSetCode = "PHVS_Hysterotomy_NCHS",
                    ValueSetName = "Hysterotomy (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7358",
                    DefinitionText = "To reflect hysterotomy as the method of delivery in fetal death",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1e59e0eb-bf18-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_HAntigen_FDD",
                    ValueSetName = "H Antigens (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7741",
                    DefinitionText = "H antigens for E. coli serotyping.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 2, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("052d1646-fa18-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_OAntigen_FDD",
                    ValueSetName = "O Antigen (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7742",
                    DefinitionText = "O antigens for E. coli serotyping",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 2, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e066819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestType_TB",
                    ValueSetName = "Lab Test Type (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7743",
                    DefinitionText = "Epidemiologic interpretation of the type of test(s) performed for this case. Please provide a response for each of the main test types (culture, smear, pathology/cytology, NAA, TST, IGRA, HIV, diabetes) If test was not done please indicate so.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e166819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestInterpretation_TB",
                    ValueSetName = "Lab Test Interpretation (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7744",
                    DefinitionText = "Epidemiologic interpretation of the results of the test(s) performed for this case. This is a qualitative test result.  (e.g, positive, detected, negative)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e266819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_TypeofRadiologyStudy_CDC",
                    ValueSetName = "Type of Radiology Study",
                    ValueSetOID = "2.16.840.1.114222.4.11.7745",
                    DefinitionText = "Type of chest radiology test completed.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e366819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_ResultofRadiologyStudy_TB",
                    ValueSetName = "Result of Radiology Study (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7746",
                    DefinitionText = "Result of chest diagnostic testing",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e466819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_DiabetesStatus_CDC",
                    ValueSetName = "Diabetes Status",
                    ValueSetOID = "2.16.840.1.114222.4.11.7747",
                    DefinitionText = "Diabetes Status",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e566819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_EpidemiologicalRiskFactors_TB",
                    ValueSetName = "Epidemiological Risk Factors (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7748",
                    DefinitionText = "Type of risk factor patient was exposed to",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e666819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SmokingStatus_CDC",
                    ValueSetName = "Smoking Status",
                    ValueSetOID = "2.16.840.1.114222.4.11.7749",
                    DefinitionText = "What is the patient's current smoking status?",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e766819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_DiagnosisType_TB",
                    ValueSetName = "Diagnosis type (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7750",
                    DefinitionText = "Previous TB or LTBI Diagnosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e866819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_TypeofLink_TB",
                    ValueSetName = "Type of Link (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7751",
                    DefinitionText = "Indicate if link is a contact, location, or other",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e966819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_StrengthofLink_TB",
                    ValueSetName = "Strength of Link (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7752",
                    DefinitionText = "Strength of Link",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ea66819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_DirectionalityofLink_TB",
                    ValueSetName = "Directionality of Link (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7753",
                    DefinitionText = "Directionality of Link",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("eb66819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_TreatmentAdministrationType_TB",
                    ValueSetName = "Treatment Administration Type (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7754",
                    DefinitionText = "Treatment Administration Type",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ec66819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_LTBIDrugRegimen_TB",
                    ValueSetName = "LTBI Drug Regimen (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7755",
                    DefinitionText = "LTBI Drug Regimen",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ed66819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_ReasonLTBINotStarted_TB",
                    ValueSetName = "Reason LTBI Not Started (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7756",
                    DefinitionText = "Reason LTBI Not Started",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ee66819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_ReasonLTBITreatmentStopped_TB",
                    ValueSetName = "Reason LTBI Treatment Stopped (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7757",
                    DefinitionText = "Reason LTBI Treatment Stopped",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ef66819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_AdverseEventSeverity_TB",
                    ValueSetName = "Adverse Event Severity (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7758",
                    DefinitionText = "Adverse Event Severity",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f066819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_Medications_TB",
                    ValueSetName = "Medication (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7759",
                    DefinitionText = "Medication",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f166819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SusceptibilityTestType_TB",
                    ValueSetName = "Susceptibility Test Type (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7760",
                    DefinitionText = "Susceptibility Test Type",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f266819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SusceptibilityTestResultQuantitative_TB",
                    ValueSetName = "Susceptibility Test Interpretation (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7761",
                    DefinitionText = "Susceptibility Test Interpretation",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f366819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SusceptibilityTestMethod_TB",
                    ValueSetName = "Susceptibility Test Method (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7762",
                    DefinitionText = "Susceptibility Test Method",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f466819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_GeneName_TB",
                    ValueSetName = "Gene Name (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7763",
                    DefinitionText = "Gene Name",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f566819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_MolecularTestResults_TB",
                    ValueSetName = "Molecular Test Results (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7764",
                    DefinitionText = "Molecular Test Results",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f666819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_MolecularIndel_TB",
                    ValueSetName = "Molecular Indel (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7765",
                    DefinitionText = "Molecular Indel",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f766819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_MolecularTestMethods_TB",
                    ValueSetName = "Molecular Test Methods (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7766",
                    DefinitionText = "Molecular Test Methods",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f866819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_ReasonNotTreatedwithRIPE_TB",
                    ValueSetName = "Reason Not Treated with RIPE (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7767",
                    DefinitionText = "Reason Not Treated with RIPE",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f966819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_MovedWhereDuringTherapy_TB",
                    ValueSetName = "Moved Where During Therapy (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7768",
                    DefinitionText = "Moved Where During Therapy",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fa66819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_FinalTreatmentOutcome_TB",
                    ValueSetName = "Final Treatment Outcome (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7769",
                    DefinitionText = "Final Treatment Outcome",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb66819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_LengthofTimeDrugTaken_TB",
                    ValueSetName = "Length of Time Drug Taken (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7770",
                    DefinitionText = "Length of Time Drug Taken",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fc66819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SideEffectTimetoOnset_TB",
                    ValueSetName = "Side Effect Time to Onset (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7771",
                    DefinitionText = "Side Effect Time to Onset",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fd66819f-941d-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SideEffectofTreatment_TB",
                    ValueSetName = "Side Effect of Treatment (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7772",
                    DefinitionText = "Side Effect of Treatment.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3716a47a-e320-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_FormStatus_RIBD",
                    ValueSetName = "Form Status (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7677",
                    DefinitionText = "Form Status",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4d2cd6a9-e320-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_EmergencySeverityIndexAcuity_CDC",
                    ValueSetName = "Emergency Severity Index - Acuity",
                    ValueSetOID = "2.16.840.1.114222.4.11.7776",
                    DefinitionText = "The Emergency Severity Index (ESI) is a tool for use in emergency department (ED) triage. The ESI triage algorithm yields rapid, reproducible, and clinically relevant stratification of patients into five groups, from level 1 (most urgent) to level 5 (least urgent). The ESI provides a method for categorizing ED patients by both acuity and resource needs. (https://www.ahrq.gov/professionals/systems/hospital/esi/index.html )  Based upon AHRQ 2012 Edition on the Implementation Handbook - version 4.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("616a86da-e320-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_ResidenceLocation_RIBD",
                    ValueSetName = "Residence Location (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7730",
                    DefinitionText = "Residence location at the time of initial culture.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3bd66d1e-e420-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_DischargeLocation_RIBD",
                    ValueSetName = "Discharge Location (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7678",
                    DefinitionText = "Patient's discharge location.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4f324b0b-e520-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_PregnacyStatus_RIBD",
                    ValueSetName = "Pregnancy Status (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7679",
                    DefinitionText = "Whether patient was pregnant, postpartum, or neither at the time of first positive culture.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb5fe5f6-e520-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_FetalOutcome_RIBD",
                    ValueSetName = "Fetal Outcome (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7680",
                    DefinitionText = "Outcome of the fetus.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8bc59c17-e620-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_InfectionType_RIBD",
                    ValueSetName = "Infection Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7732",
                    DefinitionText = "Types of infection or clinical syndromes caused by the organism.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cb709038-e620-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_UnderlyingConditions_RIBD",
                    ValueSetName = "Underlying Condition (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7681",
                    DefinitionText = "Underlying causes or prior illnesses.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4beed45f-e620-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SmokingStatus_RIBD",
                    ValueSetName = "Smoking Status (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7682",
                    DefinitionText = "Current smoking status.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5bcfde82-e620-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SubstanceAbuse_RIBD",
                    ValueSetName = "Substance Abuse (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7683",
                    DefinitionText = "Type of substance abused.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db41cf9f-e620-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_ModeofDelivery_RIBD",
                    ValueSetName = "Mode of Delivery (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7684",
                    DefinitionText = "Mode of substance delivery.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7ba00acf-e620-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestMethod_RIBD",
                    ValueSetName = "Lab Test Method (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7733",
                    DefinitionText = "Lab test method.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("57a233f8-e620-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestType_RIBD",
                    ValueSetName = "Lab Test Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7775",
                    DefinitionText = "Epidemiologic interpretation of the type of test(s) performed for this case.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("61eafdf2-e720-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_GBSTimePeriod_RIBD",
                    ValueSetName = "GBS Time Period (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7685",
                    DefinitionText = "GBS time period (before admission of after admission).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("32343f53-e820-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_Microorganism_RIBD",
                    ValueSetName = "Microorganism (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7686",
                    DefinitionText = "Bacterial species isolated.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f004abfe-e920-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_InsuranceType_RIBD",
                    ValueSetName = "Insurance Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7731",
                    DefinitionText = "Patient's primary insurance type",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cddc5415-f420-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestInterpretation_RIBD",
                    ValueSetName = "Lab Test Interpretation (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7734",
                    DefinitionText = "Epidemiologic interpretation of the results of the test(s) performed for this case. This is a qualitative test result. (e.g, positive, detected, negative)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1140ad49-f420-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SerotypeMethod_RIBD",
                    ValueSetName = "Serotype Method (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7736",
                    DefinitionText = "Serotype Method",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("62972381-5921-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_HealthcareServiceLocation_Syndromic",
                    ValueSetName = "Healthcare Service Location (Syndromic)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7777",
                    DefinitionText = "Value set for healthcare service location used by the Implementation Guide for Syndromic Surveillance.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e6818d2b-5b21-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_EstablishmentType_RIBD",
                    ValueSetName = "Establishment Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7729",
                    DefinitionText = "Type of Establishment where the exposure occurred.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c22a6b5a-5b21-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_BirdType_RIBD",
                    ValueSetName = "Bird Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7728",
                    DefinitionText = "Type of bird patient had contact with.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0d473987-5b21-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_TiterTestMethod_RIBD",
                    ValueSetName = "Titer Test Method (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7727",
                    DefinitionText = "Method of titer test.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c99eb0a2-5b21-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_GloveMaterial_RIBD",
                    ValueSetName = "Glove Material (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7726",
                    DefinitionText = "Glove material used.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9fd60fbc-6821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_RespiratoryProtectiveEquipment_RIBD",
                    ValueSetName = "Respiratory Protective Equipment (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7725",
                    DefinitionText = "Respiratory protective equipment used at the time of exposure.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4fe988da-6821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_PersonalProtectiveEquipment_RIBD",
                    ValueSetName = "Personal Protective Equipment (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7724",
                    DefinitionText = "Personal protective equipment (PPE) was used at the time of exposure.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ac65eeec-6821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SignsSymptoms_RIBD",
                    ValueSetName = "Signs and Symptoms (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7723",
                    DefinitionText = "Signs and symptoms associated with the illness being reported.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5adec89b-6921-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_CruiseLine_RIBD",
                    ValueSetName = "Cruise Line (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7721",
                    DefinitionText = "Name of cruiseline patient sailed with.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c81a8eaf-6921-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_WaterSource_RIBD",
                    ValueSetName = "Water Source (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7720",
                    DefinitionText = "Respiratory therapy equipment water source.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a0b360c2-6921-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_HealthcareExposureType_RIBD",
                    ValueSetName = "Healthcare Exposure Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7718",
                    DefinitionText = "Type of exposure to healthcare setting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ead261ce-6921-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_LegionellaExposureSetting_RIBD",
                    ValueSetName = "Legionella Exposure Setting (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7717",
                    DefinitionText = "Setting of Legionnella exposure",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a44ba4df-6921-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_DefinitelyPossiblyNo_RIBD",
                    ValueSetName = "Definitely Possibly No (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7716",
                    DefinitionText = "Definitely Possibly No",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2a779af0-6921-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_LegionellaExposure_RIBD",
                    ValueSetName = "Legionella Exposure (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7715",
                    DefinitionText = "Legionella exposure in 10 days prior to onset of Legionella.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("43fdad0d-6a21-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_LegionellaDiagnosis_RIBD",
                    ValueSetName = "Legionella Diagnosis (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7714",
                    DefinitionText = "Legionella Diagnosis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ae4d111b-6a21-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_CollegeLivingSituation_RIBD",
                    ValueSetName = "College Living Situation (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7713",
                    DefinitionText = "Patient's current college/university living situation",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fec8133a-6c21-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_FacilityType_RIBD",
                    ValueSetName = "Facility Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7719",
                    DefinitionText = "Type of assisted/senior living facility visited/lived in by patient during the exposure period.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5164e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_PerformingLabType_RIBD",
                    ValueSetName = "Performing Lab Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7687",
                    DefinitionText = "Performing Lab Type.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5264e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_VaccineType_RIBD",
                    ValueSetName = "Vaccine Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7688",
                    DefinitionText = "Type of vaccine administered for the condition being reported.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5364e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_VaccinationInformationSource_RIBD",
                    ValueSetName = "Vaccination Information Source (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7689",
                    DefinitionText = "Vaccination history information source.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5464e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_GASRiskFactor_RIBD",
                    ValueSetName = "GAS Risk Factor (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7690",
                    DefinitionText = "GAS specific risk factors.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5564e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_GASRiskFactorInterval_RIBD",
                    ValueSetName = "GAS Risk Factor Interval (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7691",
                    DefinitionText = "Gas Risk Factor Interval.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5664e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_RehabType_RIBD",
                    ValueSetName = "Rehab Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7692",
                    DefinitionText = "Type of rehabilitation",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5764e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_AntibioticRecevied_RIBD",
                    ValueSetName = "Antibiotic Received (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7693",
                    DefinitionText = "Antibiotic patient received.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5864e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_AdministrationRoute_RIBD",
                    ValueSetName = "Administration Route (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7694",
                    DefinitionText = "Route of antibiotic administration.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5964e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_AntibioticReason_RIBD",
                    ValueSetName = "Antibiotic Reason (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7695",
                    DefinitionText = "Reason for antibiotics.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5a64e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_DetectionMethod_RIBD",
                    ValueSetName = "Detection Method (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7696",
                    DefinitionText = "Method of case detection.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b64e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_BirthLocation_RIBD",
                    ValueSetName = "Birth Location (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7697",
                    DefinitionText = "Specifies infant's (case) birth place location.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5c64e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_GestationalAgeDetermination_RIBD",
                    ValueSetName = "Gestational Age Determination (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7698",
                    DefinitionText = "Method by which gestational age was determined",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5d64e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SusceptibilityDataNA_RIBD",
                    ValueSetName = "Susceptibility Data NA (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7699",
                    DefinitionText = "Reason susceptibility data not available.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5e64e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_ARAgent_RIBD",
                    ValueSetName = "AR Agent (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7700",
                    DefinitionText = "Antimicrobial agent.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5f64e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_ARTestMethod_RIBD",
                    ValueSetName = "AR Test Method (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7701",
                    DefinitionText = "Antimicrobial Susceptibility Test Method",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6064e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_ATIMethod_RIBD",
                    ValueSetName = "ATI Method (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7702",
                    DefinitionText = "ATI Method.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6164e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_MICOperator_RIBD",
                    ValueSetName = "MIC Operator (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7703",
                    DefinitionText = "Recorded MIC sign",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6264e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SusceptibilityInterpretation_RIBD",
                    ValueSetName = "Susceptibility Interpretation (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7704",
                    DefinitionText = "Antimicrobial Susceptibility Test Interpretation.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6364e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_ICDCodes_RIBD",
                    ValueSetName = "ICD Codes (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7705",
                    DefinitionText = "ICD 9/ICD 10 code(s) reported in the discharge diagnosis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6464e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_Sequelae_RIBD",
                    ValueSetName = "Sequelae (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7706",
                    DefinitionText = "Sequelae",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6564e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_BloodType_RIBD",
                    ValueSetName = "Blood Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7707",
                    DefinitionText = "Blood type",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6664e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_RuptureType_RIBD",
                    ValueSetName = "Rupture Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7708",
                    DefinitionText = "Type of rupture.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6764e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_DeliveryType_RIBD",
                    ValueSetName = "Delivery Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7709",
                    DefinitionText = "Type of delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6864e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_MedicationPreTreatment_RIBD",
                    ValueSetName = "Medication Pre-Treatment (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7710",
                    DefinitionText = "Medications the patient was taking at the time of disease onset.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6964e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_ContactType_RIBD",
                    ValueSetName = "Contact Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7711",
                    DefinitionText = "Type of contact with case",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6a64e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SchoolYear_RIBD",
                    ValueSetName = "School Year (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7712",
                    DefinitionText = "School year.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6b64e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_TiterTestType_RIBD",
                    ValueSetName = "Titer Test Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7722",
                    DefinitionText = "Titer test type (initial/acute or convalescent)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6c64e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_IsolateNotAvailable_RIBD",
                    ValueSetName = "Isolate Not Available (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7738",
                    DefinitionText = "Reason isolate not available",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6d64e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_GASLabTestType_RIBD",
                    ValueSetName = "GAS Lab Test Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7739",
                    DefinitionText = "GAS test(s) performed for this case.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6e64e321-7821-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SerogroupMethod_RIBD",
                    ValueSetName = "Serogroup Method (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7773",
                    DefinitionText = "Serogroup Method",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("628130fe-8621-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_LegionellosisSerogroup_RIBD",
                    ValueSetName = "Legionellosis Serogroup (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7737",
                    DefinitionText = "Legionellosis Serogroup",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("51d08a4b-8921-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenType_RIBD",
                    ValueSetName = "Specimen Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7774",
                    DefinitionText = "Specimen type from which organism was isolated.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("56ba80d8-8921-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_ColonyCountMagnitude_CDC",
                    ValueSetName = "Colony Count Magnitude",
                    ValueSetOID = "2.16.840.1.114222.4.11.7740",
                    DefinitionText = "Order of magnitude of the GBS colony count.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("162de4b1-8e21-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_SPNIPDSerotype_RIBD",
                    ValueSetName = "SPN/IPD Serotype (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7735",
                    DefinitionText = "SPN/IPD Serotype",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("36f99254-1a23-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_ConditionStatus_FDD",
                    ValueSetName = "Condition Status (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7779",
                    DefinitionText = "Patient's outcome following illness",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6cd18afd-e823-e811-99b0-0017a477041a"),
                    ValueSetCode = "PHVS_Specimen Site_FDD",
                    ValueSetName = "Specimen Site (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7778",
                    DefinitionText = "Site of specimen collection answer list for FDD MMG.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c30191ba-ee9c-e411-9c04-0017a477041a"),
                    ValueSetCode = "PHVS_DeathReportObservationIdentifier_NCHS",
                    ValueSetName = "Death Report Observation Identifier (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7267",
                    DefinitionText = "The value sets contains the list of values used to report observations on the Death Certificate",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 6, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ce40667e-f99c-e411-9c04-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_NND_GenV2",
                    ValueSetName = "Data Elements (NND Gen V2)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7268",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 1, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ef6457fa-42c1-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_QualLabResult_RCMT",
                    ValueSetName = "Qualitative Lab Result (RCMT)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7449",
                    DefinitionText = "This value set is a union of the following RCMT value sets: PHVS_QLRPos_ReportableConditions, PHVS_QLRNeg_ReportableConditions, PHVS_QLRInconc_ReportableConditions",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("21fcb721-9fc3-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_VaccineEventInformationSource_NND",
                    ValueSetName = "Vaccine Event Information Source (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7450",
                    DefinitionText = "Identifies the source of information for this immunization record or, more generically, whether the immunization being reported has just been administered (new) or came from other records (historical)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 21)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("295cc67c-afc7-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_ZikaAffectedAreas_CDC",
                    ValueSetName = "Zika-affected areas",
                    ValueSetOID = "2.16.840.1.114222.4.11.7457",
                    DefinitionText = "Zika-affected areas value set has been created based upon August 31, 2016 travel notice from CDC Zika virus disease website.  For more information, please visit http://www.cdc.gov/zika/geo/index.html",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b9359b46-bbc7-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_TransmissionMode_Zika",
                    ValueSetName = "Transmission Mode (Zika)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7458",
                    DefinitionText = "Transmission mode for Zika virus disease value set includes few transmission modes which are still being investigated. For more information, please visit CDC website http://www.cdc.gov/zika/transmission/index.html",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("49bf933a-c4c7-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_SignsSymptoms_Zika",
                    ValueSetName = "Signs Symptoms (Zika)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7459",
                    DefinitionText = "Signs and Symptoms of Zika virus disease. For more information, please visit CDC Zika virus website at http://www.cdc.gov/zika/hc-providers/clinicalevaluation.html",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("49ad667d-cfc7-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_SignsSymptoms_Arbovirus",
                    ValueSetName = "Signs Symptoms (Arbovirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7460",
                    DefinitionText = "Signs and Symptoms of Arboviral diseases. This value set would be used for public health case notification and includes signs and symptoms of Dengue, Chikungunya and Zika.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7572833b-67c8-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_PrenatalDiagnosticProcedures_CDC",
                    ValueSetName = "Prenatal Diagnostic Procedures",
                    ValueSetOID = "2.16.840.1.114222.4.11.7462",
                    DefinitionText = "List of non-laboratory prenatal diagnostic procedures such as Ultrasound, Amniocentesis, etc.…",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fd90ff33-6ac8-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenType_Zika",
                    ValueSetName = "Specimen Type (Zika)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7463",
                    DefinitionText = "List of specimens associated with Zika laboratory tests. This includes specimen from mother as well as fetus, infant as well as acute, convalescent specimens.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6034acda-75c8-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_InsectRepellant_CDC",
                    ValueSetName = "Insect Repellant",
                    ValueSetOID = "2.16.840.1.114222.4.11.7464",
                    DefinitionText = "List of insect repellants which includes mosquito repellants too.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("60c21fb0-76c8-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_Vector_Zika",
                    ValueSetName = "Vector (Zika)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7465",
                    DefinitionText = "Vectors / Mosquito species associated with the vector-borne transmission of Zika virus disease.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d0968d1a-78c8-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_Complications_Zika",
                    ValueSetName = "Complications (Zika)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7466",
                    DefinitionText = "Complications associated with Zika virus disease. This list represents potential complications and some of them are not confirmed. Complications related to Dengue and Chikungunya are also present in this value set.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b016f40e-7cc8-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_DrugDiseaseInteraction_Dengue",
                    ValueSetName = "Drug Disease Interaction (Dengue)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7467",
                    DefinitionText = "Drug disease interaction association with Dengue includes the drugs (Asprin, NSAID) that should be avoided in Dengue virus infection / illness.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("20607838-7ec8-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_LengthOfGestationInWeeks_CDC",
                    ValueSetName = "Length of Gestation in Weeks",
                    ValueSetOID = "2.16.840.1.114222.4.11.7468",
                    DefinitionText = "Length of gestation finding values in weeks and trimester.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("104257d6-89c8-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_MicrocephalyCauses_CDC",
                    ValueSetName = "Microcephaly Causes",
                    ValueSetOID = "2.16.840.1.114222.4.11.7469",
                    DefinitionText = "Causes of Microcephaly. There is a possible association of  Microcephaly with Zika virus infection during pregnancy.For more information, please see http://www.cdc.gov/ncbddd/birthdefects/microcephaly.html/",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("00a6584e-94c8-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_HeadCircumferenceFindings_CDC",
                    ValueSetName = "Head Circumference Findings",
                    ValueSetOID = "2.16.840.1.114222.4.11.7470",
                    DefinitionText = "Head Circumference findings",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8076198f-97c8-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestType_Arbovirus",
                    ValueSetName = "Lab Test Type (Arbovirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7472",
                    DefinitionText = "Lab test type associated with Arboviral disease. This value set is used for Arboviral Case Notification MMG v2.0. This would be used by public health epidemiologist to interpret the lab tests.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 3, 18)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c07826fe-9cc8-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_DiagnosticLabTestFindings_NND",
                    ValueSetName = "Diagnostic Lab Test Findings (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7473",
                    DefinitionText = "Diagnostic lab test findings contains interpretation lab test results used by Epidemiologists.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f340d46d-fbc8-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_TypeOfTestingAtCDC_VZ",
                    ValueSetName = "Type of Testing at CDC (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7451",
                    DefinitionText = "Update based on new MMG guide",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0829b3d2-00c9-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_Complications_VZ",
                    ValueSetName = "Type of Complication (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7474",
                    DefinitionText = "Update based on new MMG guide",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 5, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("060191d8-14c9-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestType_VZ",
                    ValueSetName = "Lab Test Type (Varicella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7456",
                    DefinitionText = "Update based on new MMG guide.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("68299469-15c9-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_AgeUnit_NND",
                    ValueSetName = "Age Unit (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7452",
                    DefinitionText = "Update based on new MMG guide",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("64d585ac-16c9-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_BodyRegionOfRash_VZ",
                    ValueSetName = "Body Region(s) of Rash",
                    ValueSetOID = "2.16.840.1.114222.4.11.7453",
                    DefinitionText = "Update based on new MMG guide",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 21)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0bdb14ea-16c9-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestInterpretation_VZ",
                    ValueSetName = "Lab Test Interpretation (Varicella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7455",
                    DefinitionText = "Update based on new MMG guide",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("aa800d08-19c9-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_CharacterofLesions_VZ",
                    ValueSetName = "Character of Lesions",
                    ValueSetOID = "2.16.840.1.114222.4.11.7454",
                    DefinitionText = "Update based on new MMG guide",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0edd0031-79cf-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_EpiduralSpinalAnesthesiaMedication_NCHS",
                    ValueSetName = "Epidural/Spinal Anesthesia - Medication (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7475",
                    DefinitionText = "To Reflect an Epidural and Spinal Anesthesia Medication",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f0c671b4-1dd0-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_PosNegEquivNotDone_CDC",
                    ValueSetName = "Positive Negative Equivocal Not Done",
                    ValueSetOID = "2.16.840.1.114222.4.11.7476",
                    DefinitionText = "Interpretation of test results associated with the lab tests such as positive, negative, equivocal, test not done.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 4, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ece16f47-1ed0-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_PosNeg4FoldRiseNotDone_CDC",
                    ValueSetName = "Positive Negative 4 Fold Rise Not Done",
                    ValueSetOID = "2.16.840.1.114222.4.11.7477",
                    DefinitionText = "Serum paired antibody result. This is an interpretation based upon the lab values paired sera testing of specimen 1 (Acute) and Specimen 2 (Convalescent). For Arboviral lab tests, these tests are usually PRNT.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 4, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6fa5a8f8-1ed0-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_Serotype_Dengue",
                    ValueSetName = "Serotype (Dengue)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7478",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("029877d5-a3d1-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_LabResult_ZikaVirus",
                    ValueSetName = "Lab Result (Zika virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7479",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4e58aaa0-a4d1-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestName_ZikaVirus",
                    ValueSetName = "Lab Test Name (Zika virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7480",
                    DefinitionText = "lab tests associated with Zika virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("58d38b70-e8d4-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_SignsSymptoms_Dengue",
                    ValueSetName = "Signs Symptoms (Dengue)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7481",
                    DefinitionText = "Signs and Symptoms of Dengue virus disease. For more information, please visit CDC Dengue virus website at http://www.cdc.gov/Dengue/symptoms/index.html",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("66779b98-ebd4-e511-9d24-0017a477041a"),
                    ValueSetCode = "PHVS_SignsSymptoms_Chikungunya",
                    ValueSetName = "Signs Symptoms (Chikungunya)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7482",
                    DefinitionText = "Signs and Symptoms of Chikungunya virus disease. For more information, please visit CDC Chikungunya virus website at http://www.cdc.gov/chikungunya/symptoms/index.html",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6b49500b-c68f-e511-9d58-0017a477041a"),
                    ValueSetCode = "PHVS_DeathReportingIdentifierType_HL70203_NCHS",
                    ValueSetName = "Death Reporting Identifier Type (HL70203) (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7382",
                    DefinitionText = "The value indicates the type for the identifierCodes added to Identifier Type (HL7) Code system for HL7 v2.9: [ DC , Death Certificate Id ] , [ DCFN , Death Certificate File Number ]",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ea934e97-573f-e811-9e26-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestName_CrimeanCongoHemorrhagicFever",
                    ValueSetName = "Lab Test Name (Crimean-Congo hemorrhagic fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7780",
                    DefinitionText = "lab tests associated with Crimean-Congo hemorrhagic fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("653d5298-3644-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_AssistedLivingExposureType_RIBD",
                    ValueSetName = "Assisted Living Exposure Type (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7806",
                    DefinitionText = "Type of exposure to assisted/senior living facility.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("663d5298-3644-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_BirdExposureSetting_RIBD",
                    ValueSetName = "Bird Exposure Setting (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7807",
                    DefinitionText = "Setting of bird exposure",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("673d5298-3644-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_N.meningitidisSerogroup_RIBD",
                    ValueSetName = "N. meningitidis Serogroup (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7808",
                    DefinitionText = "N. meningitidis Serogroup",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("683d5298-3644-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_H.influenzae_Serotype_RIBD",
                    ValueSetName = "H. influenzae Serotype (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7809",
                    DefinitionText = "H. influenzae Serotype",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("693d5298-3644-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_ProviderInformationSource_RIBD",
                    ValueSetName = "Provider Information Source (RIBD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7810",
                    DefinitionText = "Provider Information Source",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("20a06300-c648-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_CaseType_CP-CRE",
                    ValueSetName = "Case Type (CP-CRE)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7812",
                    DefinitionText = "Stratification identification based on cultures",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9b671e27-c648-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenSource_CP-CRE",
                    ValueSetName = "Specimen Source (CP-CRE)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7813",
                    DefinitionText = "Specimen source or source of culture",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("400ca658-c648-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_GenotypicTestResult_CP-CRE",
                    ValueSetName = "Genotypic Test Result (CP-CRE)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7814",
                    DefinitionText = "Result of test to identify carbapenemase",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d65a91c0-c648-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_PhenotypicTestResult_CP-CRE",
                    ValueSetName = "Phenotypic Test Result (CP-CRE)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7815",
                    DefinitionText = "Result of Phenotypic test",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3f38212c-c748-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_Rubella",
                    ValueSetName = "Data Elements (Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7816",
                    DefinitionText = "This value set includes the data elements (DE) listed in the message mapping guide (MMG) for Rubella.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("690dd862-c748-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_CRS",
                    ValueSetName = "Data Elements (CRS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7811",
                    DefinitionText = "This value set includes the data elements (DE) listed in the message mapping guide (MMG) for CRS.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b8540575-0053-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_GeneralConditionStatus_TB",
                    ValueSetName = "General Condition Status (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7818",
                    DefinitionText = "Was the patient alive or dead at the time of diagnostic evaluation?",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("eff8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_AnimalContactType_Listeria",
                    ValueSetName = "Animal Contact Type (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7781",
                    DefinitionText = "Type of animal contact",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f0f8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_DeliMeats_Listeria",
                    ValueSetName = "Deli Meats (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7782",
                    DefinitionText = "Listeria deli meat answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f1f8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_DeliSalads_Listeria",
                    ValueSetName = "Deli Salads (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7783",
                    DefinitionText = "Listeria deli salad answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f2f8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_DietType_Listeria",
                    ValueSetName = "Diet Type (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7784",
                    DefinitionText = "List of vegetarian diets",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f3f8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_ExtendedRaceGroup_Listeria",
                    ValueSetName = "Extended Race Group (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7785",
                    DefinitionText = "Listeria race groups answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f4f8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_Food_Listeria",
                    ValueSetName = "Food (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7786",
                    DefinitionText = "Listeria meats, fish and produce answer list.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f5f8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_FoodAllergy_Listeria",
                    ValueSetName = "Food Allergy (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7787",
                    DefinitionText = "Food sensitivity",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f6f8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_FoodFreshness_Listeria",
                    ValueSetName = "Food Freshness (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7788",
                    DefinitionText = "Describes the state of freshness of fruit or produce",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f7f8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_Fruit_Listeria",
                    ValueSetName = "Fruit (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7789",
                    DefinitionText = "Listeria fruit answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f8f8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_HeatedFood_Listeria",
                    ValueSetName = "Heated Food (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7790",
                    DefinitionText = "Temperature at which food was served",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f9f8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_HispanicEthnicGroup_Listeria",
                    ValueSetName = "Hispanic Ethnic Group (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7791",
                    DefinitionText = "Reflect Hispanic Ethnicity",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("faf8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_Illness_Listeria",
                    ValueSetName = "Illness (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7792",
                    DefinitionText = "Listeria illness answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fbf8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_LikelyContact_Listeria",
                    ValueSetName = "Likely Contact (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7793",
                    DefinitionText = "Animal contact indicator",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fcf8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_LikelyAte_Listeria",
                    ValueSetName = "LikelyAte (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7794",
                    DefinitionText = "food eaten indicator",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fdf8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_MedicalHistory_Listeria",
                    ValueSetName = "Medical History (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7795",
                    DefinitionText = "Medical history answer list for Listeria MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fef8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_PatientType_Listeria",
                    ValueSetName = "Patient Type (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7796",
                    DefinitionText = "Listeria patient type answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fff8a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_BirthLocation_Listeria",
                    ValueSetName = "Birth Location (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7797",
                    DefinitionText = "Location of infant delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("00f9a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_PregnancyOutcome_Listeria",
                    ValueSetName = "Pregnancy Outcome (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7798",
                    DefinitionText = "Outcome of pregnancy answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("01f9a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_ReasonNotInterviewed_Listeria",
                    ValueSetName = "Reason Not Interviewed (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7799",
                    DefinitionText = "Reasons patient was not interviewed",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("02f9a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_Respondent_Listeria",
                    ValueSetName = "Respondent (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7800",
                    DefinitionText = "Source of survey responses",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("03f9a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_SignsSymptoms_Listeria",
                    ValueSetName = "Signs and Symptoms (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7801",
                    DefinitionText = "Listeria MMG Signs and Symptoms",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("04f9a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenType_Listeria",
                    ValueSetName = "Specimen Type (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7802",
                    DefinitionText = "Specimen collection source answer list for Listeria MMG.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("05f9a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_YesNoUnknownRefused_Listeria",
                    ValueSetName = "Yes No Unknown Refused (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7803",
                    DefinitionText = "Yes, No, Unknown, Refused to Answer",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("06f9a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_PatientOutcome_Listeria",
                    ValueSetName = "Patient Outcome (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7804",
                    DefinitionText = "Patient's outcome following illness",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("07f9a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_YesNoNone_Listeria",
                    ValueSetName = "Yes No None (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7805",
                    DefinitionText = "Listeria shopper's card release answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("08f9a1cc-0353-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_TypeofDairyProduct_Listeria",
                    ValueSetName = "Type of Dairy Product (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7817",
                    DefinitionText = "Listeria cheese and diary product answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1ff8b81e-d453-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_UnitofMeasure_TB",
                    ValueSetName = "Unit of Measure (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7819",
                    DefinitionText = "Units of measure for the Quantitative Test Result Value",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5d9ba5df-7458-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_BornInTheUnitedStates_Listeria",
                    ValueSetName = "Born in the United States (Listeria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7820",
                    DefinitionText = "Whether case was born in the United States",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("afca4e2e-4459-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestType_Psittacosis",
                    ValueSetName = "Lab Test Type (Psittacosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7821",
                    DefinitionText = "Interpretative Lab tests associated with Psittacosis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("45c58152-4459-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestType_Legionellosis",
                    ValueSetName = "Lab Test Type (Legionellosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7822",
                    DefinitionText = "Interpretative Lab tests associated with Legionellosis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5c9a5898-4459-e811-9e69-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestInterpretation_Legionellosis",
                    ValueSetName = "Lab Test Interpretation (Legionellosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7823",
                    DefinitionText = "Epidemiologic interpretation of the results of the tests performed for Legionellosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("69e37511-7c1a-e511-9eef-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestName_Chikungunya",
                    ValueSetName = "Lab Test Name (Chikungunya virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7339",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("496914d0-7c1a-e511-9eef-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestName_JuninHemorrhagicFever",
                    ValueSetName = "Lab Test Name (Junin Hemorrhagic fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7340",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 11, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e9a8124c-7d1a-e511-9eef-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestName_Lassafever",
                    ValueSetName = "Lab Test Name (Lassa fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7341",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4940df8b-7e1a-e511-9eef-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestName_Marburgvirus",
                    ValueSetName = "Lab Test Name (Marburgvirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7342",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("89893ac9-7f1a-e511-9eef-0017a477041a"),
                    ValueSetCode = "PHVS_LabResult_Chikungunya",
                    ValueSetName = "Lab Result (Chikungunya virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7343",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("59fb096c-941a-e511-9eef-0017a477041a"),
                    ValueSetCode = "PHVS_LabResult_CrimeanCongoHemorrhagicFever",
                    ValueSetName = "Lab Result (Crimean-Congo hemorrhagic fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7344",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9977b6e3-951a-e511-9eef-0017a477041a"),
                    ValueSetCode = "PHVS_LabResult_GuanaritoHemorrhagicFever",
                    ValueSetName = "Lab Result (Guanarito hemorrhagic fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7345",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f9bc1b6e-971a-e511-9eef-0017a477041a"),
                    ValueSetCode = "PHVS_LabResult_JuninHemorrhagicFever",
                    ValueSetName = "Lab Result (Junin hemorrhagic fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7346",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("597028e8-981a-e511-9eef-0017a477041a"),
                    ValueSetCode = "PHVS_LabResult_LassaFever",
                    ValueSetName = "Lab Result (Lassa fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7347",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("69cf8a61-991a-e511-9eef-0017a477041a"),
                    ValueSetCode = "PHVS_LabResult_LujoVirus",
                    ValueSetName = "Lab Result (Lujo virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7348",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e9950d0b-9a1a-e511-9eef-0017a477041a"),
                    ValueSetCode = "PHVS_LabResult_MachupoHemorrhagicFever",
                    ValueSetName = "Lab Result (Machupo hemorrhagic fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7349",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("19b3ebb4-ab1a-e511-9eef-0017a477041a"),
                    ValueSetCode = "PHVS_LabResult_SabiaVirusHemorrhagicFever",
                    ValueSetName = "Lab Result (Sabia virus hemorrhagic fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7350",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3cb5cdb6-a51f-e511-9eef-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestPerformedModfier_NND",
                    ValueSetName = "Lab Test Performed Modifier (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7351",
                    DefinitionText = "List of modifier values that could be applied for tests performed or specimens such as Acute, Convalescent",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 7, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3c2e496d-2c93-e711-a03d-0017a477041a"),
                    ValueSetCode = "PHVS_AmnioticFluidConditions_HL7",
                    ValueSetName = "Amniotic Fluid Conditions (HL7)",
                    ValueSetOID = "2.16.840.1.113883.10.14.1.1.13.1",
                    DefinitionText = "Code to indicate the conditions of amniotic fluid.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3d2e496d-2c93-e711-a03d-0017a477041a"),
                    ValueSetCode = "PHVS_TypeofTwin_CDC",
                    ValueSetName = "Type of Twin (HL7)",
                    ValueSetOID = "2.16.840.1.113883.10.14.1.1.13.10",
                    DefinitionText = "Code to identify type of twin.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3e2e496d-2c93-e711-a03d-0017a477041a"),
                    ValueSetCode = "PHVS_TwinPlacenta_HL7",
                    ValueSetName = "Twin Placenta (HL7)",
                    ValueSetOID = "2.16.840.1.113883.10.14.1.1.13.11",
                    DefinitionText = "To identify the anomaly of placental structure in multiple births pregnancy.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3f2e496d-2c93-e711-a03d-0017a477041a"),
                    ValueSetCode = "PHVS_UmbilicalCordComplication_HL7",
                    ValueSetName = "Umbilical Cord Complication (HL7)",
                    ValueSetOID = "2.16.840.1.113883.10.14.1.1.13.12",
                    DefinitionText = "Code to indicate umbilical cord complications during childbirth and/or puerperium.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("402e496d-2c93-e711-a03d-0017a477041a"),
                    ValueSetCode = "PHVS_InfantFetalComplications_HL7",
                    ValueSetName = "Infant Fetal Complications (HL7)",
                    ValueSetOID = "2.16.840.1.113883.10.14.1.1.13.13",
                    DefinitionText = "Code for problems, conditions associated with patient’s medical events and issues that affect infant/fetal health.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("412e496d-2c93-e711-a03d-0017a477041a"),
                    ValueSetCode = "PHVS_PlacentalMeasurement_HL7",
                    ValueSetName = "Placental Measurement (HL7)",
                    ValueSetOID = "2.16.840.1.113883.10.14.1.1.13.14",
                    DefinitionText = "Code to indicate measurements of placenta.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("422e496d-2c93-e711-a03d-0017a477041a"),
                    ValueSetCode = "PHVS_CordInsertionType_HL7",
                    ValueSetName = "Cord Insertion Type (HL7)",
                    ValueSetOID = "2.16.840.1.113883.10.14.1.1.13.2",
                    DefinitionText = "Code to indicate the umbilical cord insertion site on the placenta.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("432e496d-2c93-e711-a03d-0017a477041a"),
                    ValueSetCode = "PHVS_HospitalCare-Setting_HL7",
                    ValueSetName = "Hospital Care-Setting (HL7)",
                    ValueSetOID = "2.16.840.1.113883.10.14.1.1.13.3",
                    DefinitionText = "Code to identify care setting in hospitals.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("442e496d-2c93-e711-a03d-0017a477041a"),
                    ValueSetCode = "PHVS_MaternalExposures_HL7",
                    ValueSetName = "Maternal Exposures (HL7)",
                    ValueSetOID = "2.16.840.1.113883.10.14.1.1.13.4",
                    DefinitionText = "Code to identify exposures to pregnant women. Such exposurse includes: potentially harmful chemical, physical, or biological agents in the environment or to environmental factors that may include ionizing radiation, pathogenic organisms, or toxic chemicals that may cause fetal morbidity.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("452e496d-2c93-e711-a03d-0017a477041a"),
                    ValueSetCode = "PHVS_IntendedNewbornFeedingType_HL7",
                    ValueSetName = "Intended Newborn Feeding Type (HL7)",
                    ValueSetOID = "2.16.840.1.113883.10.14.1.1.13.5",
                    DefinitionText = "Code to identify feeding types intended for the newborn to consume.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("462e496d-2c93-e711-a03d-0017a477041a"),
                    ValueSetCode = "PHVS_PlacentaType_HL7",
                    ValueSetName = "Placenta Type (HL7)",
                    ValueSetOID = "2.16.840.1.113883.10.14.1.1.13.6",
                    DefinitionText = "Code to indicate the finding of completeness of the placenta at delivery.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("472e496d-2c93-e711-a03d-0017a477041a"),
                    ValueSetCode = "PHVS_PlacentalConditions_HL7",
                    ValueSetName = "Placental Conditions (HL7)",
                    ValueSetOID = "2.16.840.1.113883.10.14.1.1.13.7",
                    DefinitionText = "Findings of placental conditions/problems during pregnancy and/or at delivery.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c6739a65-1db7-e211-a070-0017a477041a"),
                    ValueSetCode = "PHVS_StateProvinceOfExposure_CDC",
                    ValueSetName = "State or Province of Exposure",
                    ValueSetOID = "2.16.840.1.114222.4.11.7158",
                    DefinitionText = "Indicates the state in which the disease was potentially acquired.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 5, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d7d630ff-1eb7-e211-a070-0017a477041a"),
                    ValueSetCode = "PHVS_BinationalReportingCriteria_CDC",
                    ValueSetName = "Binational Reporting Criteria",
                    ValueSetOID = "2.16.840.1.114222.4.11.7157",
                    DefinitionText = "For cases meeting the binational criteria, select all the criteria which are met.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 5, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("35ccd29a-015a-e411-a174-0017a477041a"),
                    ValueSetCode = "PHVS_ExposureRisk_EVD",
                    ValueSetName = "Exposure Risk (EVD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7249",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3e459f48-5c60-e411-a174-0017a477041a"),
                    ValueSetCode = "PHVS_GlucocorticoSteroids_NCHS",
                    ValueSetName = "Glucocortico Steroids (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.38",
                    DefinitionText = "Steroids (glucocorticoids) for fetal lung maturation received by the mother before delivery.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cdea074d-9363-e411-a174-0017a477041a"),
                    ValueSetCode = "PHVS_AutopsyPerformed_NCHS",
                    ValueSetName = "Autopsy Performed (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.23.8.1",
                    DefinitionText = "To reflect information on whether an autopsy was performed",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db106f86-9563-e411-a174-0017a477041a"),
                    ValueSetCode = "PHVS_AutopsyNotPerformed_NCHS",
                    ValueSetName = "Autopsy Not Performed (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.23.8.2",
                    DefinitionText = "To reflect information on whether an autopsy was not performed",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e8f57b6a-9963-e411-a174-0017a477041a"),
                    ValueSetCode = "PHVS_NewbornGivenSurfactantReplacement_NCHS",
                    ValueSetName = "Newborn Given Surfactant Replacement (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.11",
                    DefinitionText = "To Reflect that the newborn received surfactant replacement therapy",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 11, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ed75f39b-9a63-e411-a174-0017a477041a"),
                    ValueSetCode = "PHVS_BirthAndFetalDeathReportEventReason_NCHS",
                    ValueSetName = "Birth and Fetal Death Report Event Reason (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7164",
                    DefinitionText = "The value set contains the list of values used to indicate whether the report refers to a live birth or to a fetal death.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 11, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3abda20b-9c63-e411-a174-0017a477041a"),
                    ValueSetCode = "PHVS_AssistedVentilationMinutesAfterBirth_NCHS",
                    ValueSetName = "Assisted Ventilation Minutes After Birth (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7144",
                    DefinitionText = "To Reflect that the newborn was provided assisted ventilation immediately following delivery reflecting an abnormal condition of the newborn.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 11, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5a073da7-9c63-e411-a174-0017a477041a"),
                    ValueSetCode = "PHVS_AssistedVentilationMoreThanSixHours_NCHS",
                    ValueSetName = "Assisted Ventilation More Than Six Hours (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7145",
                    DefinitionText = "To Reflect that the newborn was provided assisted ventilation required for more than six hours  reflecting an abnormal condition of the newborn.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 11, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c3bab455-fd76-e711-a1d6-0017a477041a"),
                    ValueSetCode = "PHVS_Augmentation OfLaborFinding_NCHS",
                    ValueSetName = "Augmentation of Labor Finding (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7532",
                    DefinitionText = "To reflect a technique used for the Augmentation of Labor",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c4bab455-fd76-e711-a1d6-0017a477041a"),
                    ValueSetCode = "PHVS_MethodOfDeliveryCesareanFinding_NCHS",
                    ValueSetName = "Method of Delivery Cesarean Finding (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7527",
                    DefinitionText = "To reflect the physical process by which the cesarean delivery of the fetus was effected",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c5bab455-fd76-e711-a1d6-0017a477041a"),
                    ValueSetCode = "PHVS_ScheduledCesareanFinding_NCHS",
                    ValueSetName = "Scheduled Cesarean Finding (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7530",
                    DefinitionText = "To reflect the findings of a scheduled cesarean section",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c6bab455-fd76-e711-a1d6-0017a477041a"),
                    ValueSetCode = "PHVS_TobaccoUseUnitOfMeasure_NCHS",
                    ValueSetName = "Tobacco Use Unit Of Measure (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7605",
                    DefinitionText = "The collection of tobacco use unit of measure used within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c7bab455-fd76-e711-a1d6-0017a477041a"),
                    ValueSetCode = "PHVS_MethodOfDeliveryVaginalVacuumFinding_NCHS",
                    ValueSetName = "Method of Delivery Vaginal Vacuum Finding (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7529",
                    DefinitionText = "To reflect the physical process by which the vaginal vacuum delivery of the fetus was effected",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c8bab455-fd76-e711-a1d6-0017a477041a"),
                    ValueSetCode = "PHVS_FetalDeathReportingAssociatedPartyRelation_NCHS",
                    ValueSetName = "Fetal Death Reporting Associated Party Relation (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7603",
                    DefinitionText = "The collection of fetal death associated party relationship used within birth and fetal death reporting",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c9bab455-fd76-e711-a1d6-0017a477041a"),
                    ValueSetCode = "PHVS_MethodOfDeliveryVaginalForcepsFinding_NCHS",
                    ValueSetName = "Method of Delivery Vaginal Forceps Finding (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7528",
                    DefinitionText = "To reflect the findings of application of physical forceps by which the  delivery of the fetus was effected",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cabab455-fd76-e711-a1d6-0017a477041a"),
                    ValueSetCode = "PHVS_InductionOfLaborFinding_NCHS",
                    ValueSetName = "Induction of Labor Finding (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7531",
                    DefinitionText = "To reflect the findings of the initiation of uterine contractions",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cbbab455-fd76-e711-a1d6-0017a477041a"),
                    ValueSetCode = "PHVS_RouteMethodOfDeliverySpontaneousProcedure_NCHS",
                    ValueSetName = "Route Method of Delivery SpontaneousProcedure (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7604",
                    DefinitionText = "To reflect the procedures of a spontaneous method of delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ccbab455-fd76-e711-a1d6-0017a477041a"),
                    ValueSetCode = "PHVS_MethodOfDeliveryVaginalSponFinding_NCHS",
                    ValueSetName = "Method of Delivery VaginalSpon Finding (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7526",
                    DefinitionText = "To reflect the physical process by which the vaginal spontaneous delivery of the fetus was effected",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a947d274-8882-e711-a1d6-0017a477041a"),
                    ValueSetCode = "PHVS_BabyOrFetusWeightUnitOfMeasure_NCHS",
                    ValueSetName = "Baby Or Fetus Weight Unit Of Measure (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7598",
                    DefinitionText = "The collection of baby or fetus weight unit of measure used within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("aa47d274-8882-e711-a1d6-0017a477041a"),
                    ValueSetCode = "PHVS_BirthReportingMothersNameType_NCHS",
                    ValueSetName = "Birth Reporting Mother's NameType (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7599",
                    DefinitionText = "The collection of mother's name type used within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ab47d274-8882-e711-a1d6-0017a477041a"),
                    ValueSetCode = "PHVS_BirthReportingRelatedPartyAddressType_NCHS",
                    ValueSetName = "Birth Reporting Related Party Address Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7600",
                    DefinitionText = "The collection of related party address type used within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ac47d274-8882-e711-a1d6-0017a477041a"),
                    ValueSetCode = "PHVS_LiveBirthReportingAssociatedPartyRelation_NCHS",
                    ValueSetName = "Live Birth Reporting Associated Party Relation (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7606",
                    DefinitionText = "The collection of live birth reporting party relations used within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cc5331d2-aacf-e211-a27c-0017a477041a"),
                    ValueSetCode = "SpecimenRoleVPD",
                    ValueSetName = "VPD Specimen Role",
                    ValueSetOID = "2.16.840.1.114222.4.11.7107",
                    DefinitionText = "specimen role used for proficiency testing in VPD porject",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("52801056-abcf-e211-a27c-0017a477041a"),
                    ValueSetCode = "ReasonForStudyVPD",
                    ValueSetName = "VPD Reason for Study",
                    ValueSetOID = "2.16.840.1.114222.2.11.7101",
                    DefinitionText = "Use to indicate diagnostic testign or proficiency testing usage",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("671eefe5-abcf-e211-a27c-0017a477041a"),
                    ValueSetCode = "SpecimenSourceBodySiteVPD",
                    ValueSetName = "VPD Specimen Source Body Site",
                    ValueSetOID = "2.16.840.1.114222.4.11.7106",
                    DefinitionText = "body sites used in VPD project",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 11, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("69c253c5-accf-e211-a27c-0017a477041a"),
                    ValueSetCode = "SpecimenCollectionMethodVPD",
                    ValueSetName = "VPD Specimen Collection Method",
                    ValueSetOID = "2.16.840.1.114222.4.11.7105",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5aa26f85-adcf-e211-a27c-0017a477041a"),
                    ValueSetCode = "SpecimenTypeVPD",
                    ValueSetName = "VPD Specimen Type",
                    ValueSetOID = "2.16.840.1.114222.4.11.7104",
                    DefinitionText = "speicmen type terms used for VPD project",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d96a9163-afcf-e211-a27c-0017a477041a"),
                    ValueSetCode = "LaboratoryCodedObservationVPD",
                    ValueSetName = "VPD Laboratory Coded Observation",
                    ValueSetOID = "2.16.840.1.114222.4.11.7103",
                    DefinitionText = "result value set for coded bservation in VPD project",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 7, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ecc51a38-b8cf-e211-a27c-0017a477041a"),
                    ValueSetCode = "ResultedLabTestIdentifiersVPD",
                    ValueSetName = "VPD Lab Test Identifiers",
                    ValueSetOID = "2.16.840.1.114222.4.11.7102",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 7, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("453df80a-bbcf-e211-a27c-0017a477041a"),
                    ValueSetCode = "LabOrderIdentifierVPD",
                    ValueSetName = "VPD Lab Order Identifier",
                    ValueSetOID = "2.16.840.1.114222.4.11.7109",
                    DefinitionText = "Codes used to request tests for VPD project",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 7, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4df9289d-bccf-e211-a27c-0017a477041a"),
                    ValueSetCode = "SpecimenConditionVPD",
                    ValueSetName = "VPD Specimen Condition",
                    ValueSetOID = "2.16.840.1.114222.4.11.7108",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 7, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a848ce9e-cecf-e211-a27c-0017a477041a"),
                    ValueSetCode = "SpecimenRejectReasonVPD",
                    ValueSetName = "VPD Specimen Reject Reason",
                    ValueSetOID = "2.16.840.1.114222.4.11.7110",
                    DefinitionText = "to use in VPD project",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5d236ffc-a8ee-e411-a336-0017a477041a"),
                    ValueSetCode = "PHVS_SignsAndSymptoms_Mumps_NND",
                    ValueSetName = "Signs and Symptoms (Mumps)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7283",
                    DefinitionText = "Signs & Symptoms value set for Mumps.  This value set is used to populate OBX-3 Observation Identifier in the message.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("30fb3c43-acee-e411-a336-0017a477041a"),
                    ValueSetCode = "PHVS_Complications_Mumps",
                    ValueSetName = "Complications (Mumps)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7282",
                    DefinitionText = "Complications value set for Mumps. This value set is used to populate OBX-3 Observation Identifier in the message.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 10, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4f16e917-aeee-e411-a336-0017a477041a"),
                    ValueSetCode = "PHVS_SignsSymptoms_Pertussis_NND",
                    ValueSetName = "Signs and Symptoms (Pertussis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7284",
                    DefinitionText = "Signs & Symptoms value set for Pertussis. This value set is used to populate OBX-3 Observation Identifier in the message.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 5, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5e8d5061-b0ee-e411-a336-0017a477041a"),
                    ValueSetCode = "PHVS_Complications_Pertussis",
                    ValueSetName = "Complications (Pertussis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7285",
                    DefinitionText = "Complications value set for Pertussis. This value set is used to populate OBX-3 Observation Identifier in the message.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 5, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bd57a9af-bbf4-e411-a336-0017a477041a"),
                    ValueSetCode = "PHVS_ApgarScore1Min_NCHS",
                    ValueSetName = "1 Min Apgar Score (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7328",
                    DefinitionText = "To Reflect the question as to the 1 Min Apgar Score",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 5, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2970c8b3-f43b-e311-a464-0017a477041a"),
                    ValueSetCode = "PHVS_RaceCategory_CDC_Ref",
                    ValueSetName = "Race Category including Refused",
                    ValueSetOID = "2.16.840.1.114222.4.11.7204",
                    DefinitionText = "Based on CDC Race Category Value Set but includes Unknown (Null Flavor) and Refused to Answer (PHIN VS Coding System).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 10, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0da82b13-093c-e311-a464-0017a477041a"),
                    ValueSetCode = "PHVS_RaceCategory_CDC_NullFlavor",
                    ValueSetName = "Race Category including Null Flavor",
                    ValueSetOID = "2.16.840.1.114222.4.11.7205",
                    DefinitionText = "Based on CDC Race Category Value Set but includes selected Null Flavor concepts.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 10, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b2714a8e-cca2-e211-a4e6-0017a477041a"),
                    ValueSetCode = "PHVS_KaryotypeSuspectedChromosomalDisorder_NCHS",
                    ValueSetName = "Karyotype Suspected Chromosomal Disorder (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7115",
                    DefinitionText = "The value set contains the list of values that indicate whether the newborn/fetus is confirmed or pending if there is a diagnosis of suspected chromosomal disorder (may include Trisomy 21).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b357b805-fba5-e211-a4e6-0017a477041a"),
                    ValueSetCode = "PHVS_InfectionsDuringPregnancyFetalDeath_NCHS",
                    ValueSetName = "Infections During Pregnancy Fetal Death (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7135",
                    DefinitionText = "The value set contains the list of selected infections that the mother had or was treated for during the course of this pregnancy for fetal death, as required by the National US Standards. Note: Genital herpes simplex (SNOMED code 33839006) is only a Michigan state-specific requirement.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ff3604d5-73a7-e211-a4e6-0017a477041a"),
                    ValueSetCode = "PHVS_BirthDeliveryOccurred_NCHS",
                    ValueSetName = "Birth or Delivery Occurred (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7124",
                    DefinitionText = "The value set contains the list of values used to indicate the type of place where birth or delivery occurred.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ade9b981-2da8-e211-a4e6-0017a477041a"),
                    ValueSetCode = "PHVS_NewbornCongenitalAnomalies_NCHS",
                    ValueSetName = "Newborn Congenital Anomalies (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7122",
                    DefinitionText = "The value set contain the list of values use to specify malformations of the newborn diagnosed prenatally or after delivery.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7f5bde11-37a8-e211-a4e6-0017a477041a"),
                    ValueSetCode = "PHVS_HistologicalPlacentalExamination_NCHS",
                    ValueSetName = "Histological Placental Examination (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7138",
                    DefinitionText = "The value set contains the list of values used to indicate whether or not a histological placental examination was performed.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6ba67e9b-6ede-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestType_STD",
                    ValueSetName = "Lab Test Type (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7550",
                    DefinitionText = "What type of STD test was performed on specimen collected to support case patient's diagnosis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 2, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("81ea657b-70e1-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_OrganismIdentifiedAST_STD",
                    ValueSetName = "Organism Identified AST (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7552",
                    DefinitionText = "Pathogen /Organism Identified in Isolate.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 1, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e8dbe99e-70e1-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenTypeAST_STD",
                    ValueSetName = "Specimen Type AST (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7553",
                    DefinitionText = "Antimicrobial Susceptibility Specimen Type (e.g. Exudate, Blood, Serum, Urine)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 1, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8fa90fc0-70e1-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenCollectionSiteAST_STD",
                    ValueSetName = "Specimen Collection Site AST (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7554",
                    DefinitionText = "Anatomic site where the specimen was collected (e.g. Urethra, Throat, Nasopharynx)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 1, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("324b31de-70e1-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_SusceptibilityTestType_STD",
                    ValueSetName = "Susceptibility Test Type (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7555",
                    DefinitionText = "Antimicrobial Susceptibility Test Type would includes drugs, enzymes, PCR and other genetic tests to detect the resistance against specific drugs.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 1, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a6ab1714-71e1-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_SusceptibilityTestMethod_STD",
                    ValueSetName = "Susceptibility Test Method (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7556",
                    DefinitionText = "Antimicrobial Susceptibility Test Method (e.g. E-Test, MIC, Disk Diffusion)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 1, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1502592d-71e1-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_SusceptibilityTestInterpretation_STD",
                    ValueSetName = "Susceptibility Test Interpretation (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7557",
                    DefinitionText = "Antimicrobial Susceptibility Test Interpretation (e.g. Susceptible, Resistant, Intermediate, Not tested)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 1, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b589947-71e1-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_SusceptibilityTestResultUnits_STD",
                    ValueSetName = "Susceptibility Test Result Units (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7558",
                    DefinitionText = "Antimicrobial Susceptibility Test Result Numerical Value Units (e.g. microgram/ml, mm)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 1, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f3e09a62-71e1-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_SusceptibilityTestResultQuantitative_STD",
                    ValueSetName = "Susceptibility Test Result Quantitative (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7559",
                    DefinitionText = "Antimicrobial Susceptibility Test Result - Coded Quantitative. List of coded values (i.e. valid dilutions) to represent the antimicrobial susceptibility test result.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 1, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("835e91f5-84e1-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestResultQualitative_STD",
                    ValueSetName = "Test Result Coded Qualitative",
                    ValueSetOID = "2.16.840.1.114222.4.11.7551",
                    DefinitionText = "Coded Qualitative Test Result Value",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 1, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1051132d-85e1-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_GenderIdentity_CDC",
                    ValueSetName = "Gender Identity",
                    ValueSetOID = "2.16.840.1.114222.4.11.756",
                    DefinitionText = "Patient identified gender identity (i.e., an individual’s personal sense of being a man, woman, or other gender, regardless of the sex that person was assigned at birth)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 1, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3399be54-85e1-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_SexualOrientation_CDC",
                    ValueSetName = "Sexual Orientation",
                    ValueSetOID = "2.16.840.1.114222.4.11.7563",
                    DefinitionText = "Patient identified sexual orientation (i.e., an individual's physical and/or emotional attraction to another individual of the same gender, opposite gender, or both genders)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 1, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("35af577f-d3fa-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_BirthReportingAddressType_NCHS",
                    ValueSetName = "Birth Reporting Address Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7564",
                    DefinitionText = "The collection of address types used within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("19b02bd7-d5fa-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_BirthdateEditFlags_NCHS",
                    ValueSetName = "Birthdate Edit Flags (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7565",
                    DefinitionText = "To reflect the relevant edit possibilities for birthdate.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 2, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f2fba40f-dafa-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_PregnancyReportEditFlags_NCHS",
                    ValueSetName = "Pregnancy Report Edit Flags (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7566",
                    DefinitionText = "To reflect the relevant edit possibilities for pregnancy report of Education, Mother's height, Mother's pre-pregnancy weight and Prenatal care visit number.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 2, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("778d51b5-dbfa-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_EstimateOf GestationEditFlags_NCHS",
                    ValueSetName = "Estimate Of Gestation Edit Flags (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7567",
                    DefinitionText = "To reflect the relevant edit possibilities for estimate of gestation.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 2, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c2bc6d8b-ddfa-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_NumberOfPreviousCesareansEditFlags_NCHS",
                    ValueSetName = "Number Of Previous Cesareans Edit Flags (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7568",
                    DefinitionText = "To reflect the relevant edit possibilities for number of previous cesareans.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 2, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cf6679ce-fefc-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_BirthReportingEventReason_NCHS",
                    ValueSetName = "Birth Reporting Event Reason (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7570",
                    DefinitionText = "The collection of independent events which trigger data exchange within birth and death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f6dab1e4-e1fd-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_BirthReportingEventType_NCHS",
                    ValueSetName = "Birth Reporting Event Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7571",
                    DefinitionText = "The collection of event types used within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c64d2917-e4fd-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_BirthReportingMessageType_NCHS",
                    ValueSetName = "Birth Reporting Message Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7573",
                    DefinitionText = "The collection of message types used within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f6d41f3a-f8fd-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_BirthReportingValueType_NCHS",
                    ValueSetName = "Birth Reporting Value Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7574",
                    DefinitionText = "The collection of value types used within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fae41e77-fafd-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_BirthReportingAssociatedPartyRelation_NCHS",
                    ValueSetName = "Birth Reporting Associated Party Relation (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7569",
                    DefinitionText = "The collection of next of kin segment relationships that is relevant to birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 2, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("87c21bd0-fbfd-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_BirthReportingObservationResultStatus_NCHS",
                    ValueSetName = "Birth Reporting Observation Result Status (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7575",
                    DefinitionText = "The collection of observation result statuses used within birth and fetal death reporting",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 2, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f77a83a3-fcfd-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_BirthWeightEditFlags_NCHS",
                    ValueSetName = "Birth Weight Edit Flags (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7576",
                    DefinitionText = "To reflect the relevant edit possibilities for birth weight.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 2, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("37484c53-fdfd-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_PluralityEditFlags_NCHS",
                    ValueSetName = "Plurality Edit Flags (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7577",
                    DefinitionText = "To reflect the relevant edit possibilities for plurality.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 2, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1c0768ee-64ff-e611-a856-0017a477041a"),
                    ValueSetCode = "PHVS_ConsolidatedEthnicity_NCHS",
                    ValueSetName = "Consolidated Ethinicity (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7578",
                    DefinitionText = "A collection of ethnicity codes used within vital records reporting to consolidate reported ethnicity values into a single code",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 3, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f5804c71-8802-e711-a856-0017a477041a"),
                    ValueSetCode = "PHVS_WeightOfFetusEditFlag_NCHS",
                    ValueSetName = "Weight Of  Fetus Edit Flag (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7579",
                    DefinitionText = "To reflect the relevant edit possibilities for weight of fetus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ce32cf09-3a7b-e811-ac69-0017a477041a"),
                    ValueSetCode = "PHVS_EvaluationStatusReason_IIS",
                    ValueSetName = "Evaluation Status Reason (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7831",
                    DefinitionText = "Identifies the reasons why an administered dose has the assigned evaluation status (valid/invalid)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("17383e16-8084-e811-ac69-0017a477041a"),
                    ValueSetCode = "PHVS_ClinicalManifestation_TBRD",
                    ValueSetName = "Clinical Manifestation (TBRD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7832",
                    DefinitionText = "Clinical manifestation of TBRD",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("18383e16-8084-e811-ac69-0017a477041a"),
                    ValueSetCode = "PHVS_Complication_TBRD",
                    ValueSetName = "Complications (TBRD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7833",
                    DefinitionText = "If the subject experienced complications due to this episode, what was the complication?",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("19383e16-8084-e811-ac69-0017a477041a"),
                    ValueSetCode = "PHVS_MedicationReceived_TBRD",
                    ValueSetName = "Medication Received (TBRD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7834",
                    DefinitionText = "What antibiotic did the patient receive for this episode?",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1a383e16-8084-e811-ac69-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestType_TBRD",
                    ValueSetName = "Lab Test Type (TBRD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7835",
                    DefinitionText = "Epidemiologic interpretation of the type of test(s) performed for this case.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b383e16-8084-e811-ac69-0017a477041a"),
                    ValueSetCode = "PHVS_Organism_TBRD",
                    ValueSetName = "Organism (TBRD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7836",
                    DefinitionText = "Species identified",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1c383e16-8084-e811-ac69-0017a477041a"),
                    ValueSetCode = "PHVS_CoinfectionType_TBRD",
                    ValueSetName = "Coinfection Type (TBRD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7837",
                    DefinitionText = "Specify coinfection",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1d383e16-8084-e811-ac69-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenType_TBRD",
                    ValueSetName = "Specimen Type (TBRD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7838",
                    DefinitionText = "This indicates the type of specimen tested.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3f046838-1986-e811-ac69-0017a477041a"),
                    ValueSetCode = "PHVS_MedicationReceived_Lyme",
                    ValueSetName = "Medication Received (Lyme)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7839",
                    DefinitionText = "Medication received to treat Lyme disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("40046838-1986-e811-ac69-0017a477041a"),
                    ValueSetCode = "PHVS_ClinicalManifestations_Lyme",
                    ValueSetName = "Clinical Manifestations (Lyme)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7840",
                    DefinitionText = "Clinical manifestations of Lyme Disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("41046838-1986-e811-ac69-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenType_Lyme",
                    ValueSetName = "Specimen Type (Lyme)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7841",
                    DefinitionText = "List of specimens associated with Lyme disease laboratory tests",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("42046838-1986-e811-ac69-0017a477041a"),
                    ValueSetCode = "PHVS_Organism_Lyme",
                    ValueSetName = "Organism (Lyme)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7843",
                    DefinitionText = "Genus and species of the organism identified as Borrelia",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("43046838-1986-e811-ac69-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestType_Lyme",
                    ValueSetName = "Lab Test Type (Lyme)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7844",
                    DefinitionText = "Interpretative lab test types associated with Lyme Disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("399f1654-1ceb-e711-acd6-0017a477041a"),
                    ValueSetCode = "RRVS_ProcessingStatusReasonDetailType_eCR",
                    ValueSetName = "eICR Processing Status Reason Detail Type (eCR)",
                    ValueSetOID = "2.16.840.1.113883.10.20.15.2.5.10",
                    DefinitionText = "This value set contains codes that describe the type of eICR processing status detail.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f4f61567-1deb-e711-acd6-0017a477041a"),
                    ValueSetCode = "RRVS_DeterminationOfReportability_eCR",
                    ValueSetName = "Determination of Reportability (eCR)",
                    ValueSetOID = "2.16.840.1.113883.10.20.15.2.5.3",
                    DefinitionText = "This value set contains codes that specify whether a condition is reportable or not.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("630f537f-20eb-e711-acd6-0017a477041a"),
                    ValueSetCode = "RRVS_ExternalResourceType_eCR",
                    ValueSetName = "External Resource Type (eCR)",
                    ValueSetOID = "2.16.840.1.113883.10.20.15.2.5.4",
                    DefinitionText = "This value set contains codes that describe the type/category of an external resource used in a Reportability Response.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ccadc3b7-20eb-e711-acd6-0017a477041a"),
                    ValueSetCode = "RRVS_ReportabilityPriority_eCR",
                    ValueSetName = "Reportability Priority (eCR)",
                    ValueSetOID = "2.16.840.1.113883.10.20.15.2.5.5",
                    DefinitionText = "This value set contains codes that describe the reportability priority in a Reportability Response document.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("40834ff3-20eb-e711-acd6-0017a477041a"),
                    ValueSetCode = "RRVS_LocationRelevance_eCR",
                    ValueSetName = "Location Relevance (eCR)",
                    ValueSetOID = "2.16.840.1.113883.10.20.15.2.5.6",
                    DefinitionText = "This valueset contains codes to indicate the location because of which the responsible agency is relevant.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("13d2da2d-21eb-e711-acd6-0017a477041a"),
                    ValueSetCode = "RRVS_eICRProcessingStatusReason_eCR",
                    ValueSetName = "eICR Processing Status Reason (eCR)",
                    ValueSetOID = "2.16.840.1.113883.10.20.15.2.5.7",
                    DefinitionText = "This value set contains codes that describe the reason for the processing status (warning or error).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f2af4458-21eb-e711-acd6-0017a477041a"),
                    ValueSetCode = "RRVS_eICRProcessingStatus_eCR",
                    ValueSetName = "eICR Processing Status (eCR)",
                    ValueSetOID = "2.16.840.1.113883.10.20.15.2.5.8",
                    DefinitionText = "This value set contains codes that describe the status of the eICR document in terms of processing by the public health decision support system.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("83d6e82e-c5ec-e711-acd6-0017a477041a"),
                    ValueSetCode = "PHVS_JurisdictionCertificateIDType_NCHS",
                    ValueSetName = "Jurisdiction Certificate ID Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7601",
                    DefinitionText = "The collection of certificate identifier types used within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("725b589d-34b8-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_TypeOfTestingAtCDC_CRS",
                    ValueSetName = "Type of Testing at CDC",
                    ValueSetOID = "2.16.840.1.114222.4.11.7607",
                    DefinitionText = "What type of testing was done at CDC for this subject",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 10, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("08a08650-abb9-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_Complications_CRS",
                    ValueSetName = "Type Of Complication (CRS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7608",
                    DefinitionText = "Complications associated with the illness being reported",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 10, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dd004707-45bb-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_SexualOrientation_STD",
                    ValueSetName = "Sexual Orientation (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7609",
                    DefinitionText = "Patient identified sexual orientation (i.e., an individual's physical and/or emotional attraction to another individual of the same gender, opposite gender, or both genders).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 1, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ad155ea6-45bb-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_GenderIdentity_STD",
                    ValueSetName = "Gender Identity (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7610",
                    DefinitionText = "Patient identified gender identity (i.e., an individual’s personal sense of being a man, woman, or other gender, regardless of the sex that person was assigned at birth)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 10, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0d098506-48bb-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_ClinicalManifestations_STD",
                    ValueSetName = "Clinical Manifestations (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7611",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 10, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0dd9b07d-48bb-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_LateClincicalManifestation_STD",
                    ValueSetName = "Late Clinical Manifestation (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7612",
                    DefinitionText = "Late clinical manifestations of syphilis (tertiary syphilis) may include inflammatory lesions of the cardiovascular system, skin, bone, or other tissue. Certain neurologic manifestations (e.g., general paresis and tabes dorsalis) are late clinical manifestations of syphilis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 1, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bec0e8b1-fdc3-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_CaseAppraisal_CRS",
                    ValueSetName = "Case Appraisal (CRS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7614",
                    DefinitionText = "What is the clinical case appraisal as determined by the case investigator?",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("74611009-02c4-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_Pre-PregnancySerologicalTestInterp_CRS",
                    ValueSetName = "Pre-Pregnancy SerologicalTestInterp (CRS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7615",
                    DefinitionText = "Interpretation of mother's pre-pregnancy serological test",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9d25395e-03c4-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenFromMotherOrInfant_CRS",
                    ValueSetName = "Specimen From Mother Or Infant (CRS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7616",
                    DefinitionText = "Specimen from mother or infant?",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("08a0d664-9ac5-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_Complications_Rubella",
                    ValueSetName = "Type Of Complication (Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7650",
                    DefinitionText = "Complications of Rubella",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("af9a937e-9bc5-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_SignsSymptoms_Rubella",
                    ValueSetName = "Signs and Symptoms (Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7649",
                    DefinitionText = "Signs and symptoms value set for Rubella.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d488954d-a2c5-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_PreviousCaseDiagnosedBy_Rubella",
                    ValueSetName = "Previous Case Diagnosed By (Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7651",
                    DefinitionText = "Indicate who diagnosed the previous illness; if none of the choices apply choose Other",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c317bee1-90c8-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_MailingAddressIndicator_NCHS",
                    ValueSetName = "Mailing Address Indicator (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7652",
                    DefinitionText = "An indicator to show whether the mailing address for the mother is the same as the residence address",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("de2e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_Organism_FDD",
                    ValueSetName = "Organism (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7617",
                    DefinitionText = "Organism answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("df2e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_YesNoUnkRefused_NND",
                    ValueSetName = "Yes No Unknown Refused (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7618",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e02e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_Antibiotics_FDD",
                    ValueSetName = "Antibiotics (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7619",
                    DefinitionText = "Antibiotics answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e12e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_Antacids_FDD",
                    ValueSetName = "Antacids (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7620",
                    DefinitionText = "Antacids answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e22e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_SignsSymptoms_FDD",
                    ValueSetName = "Signs and Symptoms (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7621",
                    DefinitionText = "FDD MMG Signs and Symptoms",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e32e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_PosNegNotDone_NND",
                    ValueSetName = "Positive Negative Not Done",
                    ValueSetOID = "2.16.840.1.114222.4.11.7622",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e42e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_TestMethod_FDD",
                    ValueSetName = "Test Method (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7623",
                    DefinitionText = "Test method answer list.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e52e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_PerformingLabType_FDD",
                    ValueSetName = "Performing Lab Type (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7624",
                    DefinitionText = "Performing lab type answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e62e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_TestType_FDD",
                    ValueSetName = "Test Type (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7625",
                    DefinitionText = "Test type answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e72e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_TestResult_FDD",
                    ValueSetName = "Test Result (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7626",
                    DefinitionText = "Test result answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 11)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e82e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenCollectionSource_FDD",
                    ValueSetName = "Specimen Collection Source (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7627",
                    DefinitionText = "Specimen collection source answer list for FDD MMG.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e92e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_YesNoUnkMaybe_FDD",
                    ValueSetName = "Yes No Unknown Maybe (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7628",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ea2e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_YesNoDon'tKnowMaybe_FDD",
                    ValueSetName = "Yes No Don't Know Maybe (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7629",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("eb2e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_DrinkingWater_FDD",
                    ValueSetName = "Drinking Water (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7630",
                    DefinitionText = "Drinking water answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ec2e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_RecreationalH2OTreatment_FDD",
                    ValueSetName = "Recreational H2O Treatment (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7631",
                    DefinitionText = "Recreational H2O treatment for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ed2e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_RawUnpasteurizedProducts_FDD",
                    ValueSetName = "Raw Unpasteurized Products (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7632",
                    DefinitionText = "Raw unpasteurized products for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ee2e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_DayCareSetting_FDD",
                    ValueSetName = "Day Care Setting (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7633",
                    DefinitionText = "Day care setting for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ef2e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_SexualContact_FDD",
                    ValueSetName = "Sexual Contact (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7634",
                    DefinitionText = "Sexual contact answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f02e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_MedicationAdministered_FDD",
                    ValueSetName = "Medication Administered (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7635",
                    DefinitionText = "Medication administered answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f12e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_MedicalHistory_FDD",
                    ValueSetName = "Medical History (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7636",
                    DefinitionText = "Medical history answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f22e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_SeafoodPreparation_FDD",
                    ValueSetName = "Seafood Preparation (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7637",
                    DefinitionText = "Seafood preparation answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f32e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_SeafoodSource_FDD",
                    ValueSetName = "Seafood Source (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7638",
                    DefinitionText = "Seafood source answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f42e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_ShellfishDistributed_FDD",
                    ValueSetName = "Shellfish Distributed (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7639",
                    DefinitionText = "Shellfish distributed answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f52e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_ImproperHandlingStorage_FDD",
                    ValueSetName = "Improper Handling Storage (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7640",
                    DefinitionText = "Improper handling storage answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f62e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_HarvestRegion_FDD",
                    ValueSetName = "Harvest Region (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7641",
                    DefinitionText = "Harvest region answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f72e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_HarvestClassification_FDD",
                    ValueSetName = "Harvest Classification (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7642",
                    DefinitionText = "Harvest classification answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f82e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_VibrioSpecies_FDD",
                    ValueSetName = "Vibrio Species (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7643",
                    DefinitionText = "Vibrio species answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f92e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_VibrioCholeraSerotype_FDD",
                    ValueSetName = "Vibrio Cholera Serotype (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7644",
                    DefinitionText = "Vibrio cholera serotype answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fa2e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_VibrioCholeraBiotype_FDD",
                    ValueSetName = "Vibrio Cholera Biotype (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7645",
                    DefinitionText = "Vibrio cholera biotype answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb2e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_VaccineReceived_FDD",
                    ValueSetName = "Vaccine Received (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7646",
                    DefinitionText = "Vaccine received answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fc2e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_TyphoidParatyphoidSerotype_FDD",
                    ValueSetName = "Typhoid Paratyphoid Serotype (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7647",
                    DefinitionText = "Typhoid paratyphoid serotype answer list for FDD MMG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fd2e8d93-ecca-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_YesNoNotTested_NND",
                    ValueSetName = "Yes No Not Tested (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7648",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9e2ef0af-07cf-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_PCRSpecimenSource_CRS",
                    ValueSetName = "PCR Specimen Source (CRS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7655",
                    DefinitionText = "Source of PCR specimen",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 21)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7d098da4-08cf-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenType_CRS",
                    ValueSetName = "Specimen Type (CRS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7653",
                    DefinitionText = "List of specimens associated with Congenital Rubella laboratory tests",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 21)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e8efa4cb-09cf-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenSource_Rubella",
                    ValueSetName = "Specimen Source (Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7656",
                    DefinitionText = "Specimen source answer list for rubella",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("974abc10-38d1-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_SpecimenType_Rubella",
                    ValueSetName = "Specimen Type (Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7657",
                    DefinitionText = "List of specimens associated with Rubella laboratory tests",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db638888-7bd4-e711-ace2-0017a477041a"),
                    ValueSetCode = "PHVS_TypeOfTestingAtCDC_Rubella",
                    ValueSetName = "Type of Testing at CDC(Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7659",
                    DefinitionText = "What type of testing was done at CDC for this subject?",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5d0631b2-6787-e311-ae2a-0017a477041a"),
                    ValueSetCode = "PHVS_LaborandDeliveryCharacteristics_NCHS",
                    ValueSetName = "Labor and Delivery Characteristics (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7117",
                    DefinitionText = "The value set contains the list of options to indicate information about the course of labor and delivery.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ef35325e-6d87-e311-ae2a-0017a477041a"),
                    ValueSetCode = "PHVS_MaternalMorbidities_NCHS",
                    ValueSetName = "Maternal Morbidities (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7119",
                    DefinitionText = "The value set contains the list of possible maternal morbidity values when serious complications were experienced by the mother associated with labor and delivery.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3f8f5cdb-7c87-e311-ae2a-0017a477041a"),
                    ValueSetCode = "PHVS_NewbornAbnormalConditions_NCHS",
                    ValueSetName = "Newborn Abnormal Conditions (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7121",
                    DefinitionText = "The value set contains the list of values used to indicate specific disorders or significant morbidity experienced by the newborn infant.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 18)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2fb3de09-8187-e311-ae2a-0017a477041a"),
                    ValueSetCode = "PHVS_ObstetricProcedures_NCHS",
                    ValueSetName = "Obstetric Procedures (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7136",
                    DefinitionText = "The value set contains the list of values used to specify selected medical treatments or invasive / manipulative procedures performed during this pregnancy specifically for management of labor and / or delivery.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cf0cd804-8487-e311-ae2a-0017a477041a"),
                    ValueSetCode = "PHVS_BirthAndFetalDeathFinancialClass_NCHS",
                    ValueSetName = "Birth and Fetal Death Financial Class (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7163",
                    DefinitionText = "The value set contains the list of values used to indicate  the principle source of payment for the labor and delivery. Note, the Public Health Data Consortium Source of Payment Typology is being used as the primary source for codes within the value set.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 1, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cfb42cd1-8d87-e311-ae2a-0017a477041a"),
                    ValueSetCode = "PHVS_CertifierTitles_NCHS",
                    ValueSetName = "Certifier Titles (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7212",
                    DefinitionText = "To reflect the title used by death certifier to denote professional role.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 5, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e3130f86-4b8f-e311-ae2a-0017a477041a"),
                    ValueSetCode = "PHVS_InjuryOrPoisoning_NCHS",
                    ValueSetName = "Injury or Poisoning (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7403",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 2, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("150054bb-4b8f-e311-ae2a-0017a477041a"),
                    ValueSetCode = "PHVS_MajorReasonForVisit_NCHS",
                    ValueSetName = "Major reason for visit (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7404",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 2, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("69dd14db-4b8f-e311-ae2a-0017a477041a"),
                    ValueSetCode = "PHVS_Asthma_NCHS",
                    ValueSetName = "Asthma (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7432",
                    DefinitionText = "The set of Asthma Diagnoses.  All SNOMED CT concepts that are children of the SNOMED CT concept 'Asthma', including the SNOMED CT concept 'Asthma'.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 5, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f8321b00-4c8f-e311-ae2a-0017a477041a"),
                    ValueSetCode = "PHVS_ConditionControl_NCHS",
                    ValueSetName = "Condition Control (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7433",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 2, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("745d7c21-4c8f-e311-ae2a-0017a477041a"),
                    ValueSetCode = "PHVS_Disposition_NCHS",
                    ValueSetName = "Disposition (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7436",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 2, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fa4d4d44-4c8f-e311-ae2a-0017a477041a"),
                    ValueSetCode = "PHVS_ComorbidConditions_NCHS",
                    ValueSetName = "Co-morbid Conditions (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7405",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 2, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ada98487-a30f-e511-b114-0017a477041a"),
                    ValueSetCode = "PHVS_TypeOfTestingAtCDC_NND",
                    ValueSetName = "Type of Testing at CDC (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7329",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e7325736-a40f-e511-b114-0017a477041a"),
                    ValueSetCode = "PHVS_PerformingLaboratoryType_VPD",
                    ValueSetName = "Performing Laboratory Type (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7330",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("72b953c9-a70f-e511-b114-0017a477041a"),
                    ValueSetCode = "PHVS_VaccineAdministered_MMR",
                    ValueSetName = "Vaccine Administered (MMR)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7331",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9463fe26-ac0f-e511-b114-0017a477041a"),
                    ValueSetCode = "PHVS_SettingOfFurtherSpread_CDC",
                    ValueSetName = "Setting of Further Spread",
                    ValueSetOID = "2.16.840.1.114222.4.11.7332",
                    DefinitionText = "Secondary transmission setting, if the condition has spread beyond the original contact.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 10, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3a35b599-ad0f-e511-b114-0017a477041a"),
                    ValueSetCode = "PHVS_TimingOfMaternalTreatment_NND",
                    ValueSetName = "Timing of Maternal Treatment (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7333",
                    DefinitionText = "Value set for use with maternal reporting of treatment when the case subject is the infant",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 10, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c0c7da6d-af0f-e511-b114-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestInterpretation_Pertussis",
                    ValueSetName = "Lab Test Interpretation (Pertussis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7334",
                    DefinitionText = "Epidemiologic interpretation of the results of the tests performed for Pertussis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("00a927d2-af0f-e511-b114-0017a477041a"),
                    ValueSetCode = "PHVS_VaccineAdministered_Pertussis",
                    ValueSetName = "Vaccine Administered (Pertussis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7335",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bed74e1f-ac10-e511-b114-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestType_Mumps",
                    ValueSetName = "Lab Test Type (Mumps)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7336",
                    DefinitionText = "Interpretative Lab tests associated with Mumps. Updated Other and Unknown codes.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a52a91cc-ae10-e511-b114-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestType_Pertussis",
                    ValueSetName = "Lab Test Type (Pertussis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7337",
                    DefinitionText = "Interpretative lab test types associated with Pertussis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e3cc89cc-026a-e611-b21f-0017a477041a"),
                    ValueSetCode = "PHVS_HeightUnit_CDC",
                    ValueSetName = "Height Unit (CDC)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7536",
                    DefinitionText = "Subject's height units",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("338868b8-046a-e611-b21f-0017a477041a"),
                    ValueSetCode = "PHVS_DurationUnit_CDC_1",
                    ValueSetName = "Duration Unit (1)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7537",
                    DefinitionText = "Time to onset since starting treatment - units",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d176e7fc-a76f-e611-b21f-0017a477041a"),
                    ValueSetCode = "PHVS_Complications_Babesiosis",
                    ValueSetName = "Type of Complication (Babesiosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7538",
                    DefinitionText = "Complications of babesiosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c7ccc5a5-a86f-e611-b21f-0017a477041a"),
                    ValueSetCode = "PHVS_MedicationTreatment_Babesiosis",
                    ValueSetName = "Medication Treatment (Babesiosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7539",
                    DefinitionText = "Treatment drug(s) used for babesiosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dad3d2fb-a86f-e611-b21f-0017a477041a"),
                    ValueSetCode = "PHVS_BloodProduct_CDC",
                    ValueSetName = "Blood Product",
                    ValueSetOID = "2.16.840.1.114222.4.11.7540",
                    DefinitionText = "If a transfused blood product was implicated in an investigation, specify which type(s) of product.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dd21352f-ab6f-e611-b21f-0017a477041a"),
                    ValueSetCode = "PHVS_ClinicalManifestations_Babesiosis",
                    ValueSetName = "Clinical Manifestations (Babesiosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7541",
                    DefinitionText = "Clinical manifestation of babesiosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("806bd91f-ac7a-e611-b21f-0017a477041a"),
                    ValueSetCode = "PHVS_LabTestName_HantavirusInfection",
                    ValueSetName = "Lab Test Name (Hantavirus Infection)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7542",
                    DefinitionText = "lab tests associated with Hantavirus Infection",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cb361106-ad7a-e611-b21f-0017a477041a"),
                    ValueSetCode = "PHVS_LabResult_HantavirusInfection",
                    ValueSetName = "Lab Result (Hantavirus Infection)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7543",
                    DefinitionText = "lab results associated with Hantavirus Infection",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 9, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7475c35d-77df-e711-b634-0017a477041a"),
                    ValueSetCode = "PHVS_CREIObservationType_NCHS",
                    ValueSetName = "CREI Observation Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7658",
                    DefinitionText = "The collection of observation types used for reporting coded race and ethnicity information (CREI) within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e29367c0-ba87-e511-b6c0-0017a477041a"),
                    ValueSetCode = "PHVS_VaccineType_NND",
                    ValueSetName = "Vaccine Type (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7448",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 11, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b225a2ed-c287-e511-b6c0-0017a477041a"),
                    ValueSetCode = "PHVS_DeathReportingMessageType_NCHS",
                    ValueSetName = "Death Reporting Message Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7444",
                    DefinitionText = "To express, in the message header (MSH) segment, the type of message that is relevant for death reporting",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 11, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db3550fb-dd87-e511-b6c0-0017a477041a"),
                    ValueSetCode = "PHVS_StatesTerritoriesProvinces_NCHS",
                    ValueSetName = "States Territories Provinces (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7446",
                    DefinitionText = "The set of codes that represent the names of a principal subdivision (i.e., state, territory or province) within the U.S. and Canada.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 6, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("88a012e3-428d-e511-b6c0-0017a477041a"),
                    ValueSetCode = "PHVS_PlaceOfInjury_NCHS",
                    ValueSetName = "Place of Injury (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7374",
                    DefinitionText = "WHO location type extensions defined for ICD.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 11, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e7f72d20-e258-e611-b715-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_NND_HepCore",
                    ValueSetName = "Data Elements (NND Hep Core)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7515",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("34548d63-e258-e611-b715-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_NND_HepAAcute",
                    ValueSetName = "Data Elements (NND Hep A Acute)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7516",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f5b287a2-e258-e611-b715-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_NND_HepBAcute",
                    ValueSetName = "Data Elements (NND Hep B Acute)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7517",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("995ee738-e358-e611-b715-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_NND_HepBPerinatal",
                    ValueSetName = "Data Elements (NND Hep B Perinatal)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7518",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("be4ab3a3-e358-e611-b715-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_NND_HepBChronic",
                    ValueSetName = "Data Elements (NND Hep B Chronic)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7519",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fd66e6f8-e358-e611-b715-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_NND_HepCAcute",
                    ValueSetName = "Data Elements (NND Hep C Acute)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7520",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e7d80063-e458-e611-b715-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_NND_HepCChronic",
                    ValueSetName = "Data Elements (NND Hep C Chronic)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7521",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7c7d2032-e558-e611-b715-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_NND_Mumps",
                    ValueSetName = "Data Elements (NND Mumps)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7522",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("da48f46c-e558-e611-b715-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_NND_Pertussis",
                    ValueSetName = "Data Elements (NND Pertussis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7523",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c964eb96-e558-e611-b715-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_NND_STD",
                    ValueSetName = "Data Elements (NND STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7524",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 8, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("77d9bad9-e558-e611-b715-0017a477041a"),
                    ValueSetCode = "PHVS_DataElements_NND_CS",
                    ValueSetName = "Data Elements (NND CS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7525",
                    DefinitionText = "This value set includes the data elements (DE) listed in the message mapping guide (MMG) for Congenital Syphilis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("327755dd-efea-e211-b8f2-0017a477041a"),
                    ValueSetCode = "PHVS_AssociatedConditions_HW",
                    ValueSetName = "Associated Conditions (HW)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.23.8.19",
                    DefinitionText = "This value set identifies those conditions associated with healthy weight to be communicated to surveillance resources.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 11, 11)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a2df6a22-8c42-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_BirthplaceSetting_NCHS",
                    ValueSetName = "Birthplace Setting (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.184",
                    DefinitionText = "To reflect the question as to the birthplace of the newborn (setting)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("abe2489e-5d43-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_HistoryOfDiseaseAsEvidenceOfImmunity_IIS",
                    ValueSetName = "History of Disease as Evidence Of Immunity (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7244",
                    DefinitionText = "Indicates that a person has been diagnosed with  a particular disease.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8a0fe2c4-5e43-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_SerologicalEvidenceOfImmunity_IIS",
                    ValueSetName = "Serological Evidence Of Immunity (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7245",
                    DefinitionText = "Indicates that a person has immunity to that  disease.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("870e112b-0044-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_ObstetricEstimateOfGestation_NCHS",
                    ValueSetName = "Obstetric Estimate of Gestation (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.124",
                    DefinitionText = "To reflect the question as to the obstetric estimate of gestation",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("26083c3c-1744-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_DateOfLastLiveBirth_NCHS",
                    ValueSetName = "Date of Last Live Birth (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.67",
                    DefinitionText = "To reflect the question as to the date of last live birth",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e58169a0-1d44-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_DateOfLastOtherPregnancyOutcome_NCHS",
                    ValueSetName = "Date of Last Other Pregnancy Outcome (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.70",
                    DefinitionText = "To Reflect the question as to the date of last other pregnancy outcome",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("39bd34c8-1f44-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_NoOfPreviousLiveBirthsNowDead_NCHS",
                    ValueSetName = "Number of Previous Live Births Now Dead (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.122",
                    DefinitionText = "To Reflect the question as to the number of previous births now dead",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5a3f6f40-2444-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_NumberofPretermBirths_NCHS",
                    ValueSetName = "Number of Preterm Births (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.187",
                    DefinitionText = "To reflect the question as to the number of preterm births",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5cddae35-de44-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_NumberOfPreviousCesareans_NCHS",
                    ValueSetName = "Number of Previous Cesareans (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.148",
                    DefinitionText = "To reflect the question as to the number of previous cesareans",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0496aca3-df44-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_NumberPrenatalCareVisits_NCHS",
                    ValueSetName = "Number Prenatal Care Visits (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.135",
                    DefinitionText = "To reflect the question as to the number of prenatal care visits",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9496d3fe-e044-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_TimeOfDeath_NCHS",
                    ValueSetName = "Time of Death (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.185",
                    DefinitionText = "To reflect the question as to the time of death",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("eb069cbc-0748-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_FetalPresentationAtBirthUnknown_NCHS",
                    ValueSetName = "Fetal Presentation at Birth- Unknown (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7154",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3445c81c-0d48-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_AutopsyPlanned_NCHS",
                    ValueSetName = "Autopsy Planned (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7140",
                    DefinitionText = "Autopsy was planned",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("419158f4-1048-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_AssistedVentilation_NCHS",
                    ValueSetName = "Assisted Ventilation (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7156",
                    DefinitionText = "To Reflect that the newborn was provided assisted ventilation reflecting an abnormal condition of the newborn.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3a1645a6-1348-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_Height_NCHS",
                    ValueSetName = "Height (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7155",
                    DefinitionText = "To Reflect the question as to the mothers height",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4609afc7-de4e-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_VitalSigns_SyndromicSurveillance",
                    ValueSetName = "Vital Signs (Syndromic Surveillance)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7246",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("253016a0-ba4f-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_BodyWeight_NCHS",
                    ValueSetName = "Body Weight (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7421",
                    DefinitionText = "To Reflect the question as to the body weight of the patient",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f177d9e2-bb4f-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_PreviousOtherPregnancyOutcomes_NCHS",
                    ValueSetName = "Previous Other Pregnancy Outcomes (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.121",
                    DefinitionText = "To Reflect the question as to the number of other pregnancy outcomes",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bf204f71-bf4f-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_TransferIn_NCHS",
                    ValueSetName = "Transfer In (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.177",
                    DefinitionText = "The value set contains the list of values used to indicate whether the mother was admitted in the hospital",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7c5614c5-df4f-e411-bb47-0017a477041a"),
                    ValueSetCode = "PHVS_SNOMEDCTCancerReportabilityList_NAACCR",
                    ValueSetName = "NAACCR SNOMEDCT Cancer Reportability List",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.29",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("11a7831a-9440-e711-bb4b-0017a477041a"),
                    ValueSetCode = "PHVS_AdverseEventSeverity_Malaria",
                    ValueSetName = "Adverse Event Severity (Malaria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7596",
                    DefinitionText = "Adverse event outcome severity",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 5, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ad3c457b-a060-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_DeathReportingNameTypeCode_NCHS",
                    ValueSetName = "Death Reporting Name Type Code (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7378",
                    DefinitionText = "Used to differentiate between legal name and alias name of the decedent; also identifies names that are unspecified.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 6, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("39194f65-0862-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_MaritalStatus_NCHS",
                    ValueSetName = "Marital Status (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7380",
                    DefinitionText = "To reflect the possible marital statuses for the decedent",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fe32890f-1b62-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_NeurologicalManifestation_STD",
                    ValueSetName = "Neurological Manifestation (STD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7441",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 12, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("891da760-db62-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_VoidFlags_NCHS",
                    ValueSetName = "Void Flags (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7397",
                    DefinitionText = "To indicate whether or not a void record is being sent.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fbd775fd-e062-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_SourceFlags_NCHS",
                    ValueSetName = "Source Flags (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7393",
                    DefinitionText = "To reflect the form in which data has been received.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7c021b00-e362-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_EditFlags_NCHS",
                    ValueSetName = "Edit Flags (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7387",
                    DefinitionText = "To reflect whether the content of a related field has been subject to edit",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("02f24596-e562-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_MaritalStatusEditFlags_NCHS",
                    ValueSetName = "Marital Status Edit Flags (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7390",
                    DefinitionText = "To reflect the relevant edit possibilities for marital status.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d18083f9-e662-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_EducationLevelEditFlags_NCHS",
                    ValueSetName = "Education Level Edit Flags (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7388",
                    DefinitionText = "To reflect the relevant edit possibilities for education level.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f8b89bd4-e762-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_RaceCodingFlag_NCHS",
                    ValueSetName = "Race Coding Flag (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7392",
                    DefinitionText = "To reflect the relevant edit possibilities for race coding.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5e059d01-ea62-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_BridgedRace_NCHS",
                    ValueSetName = "Bridged Race (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7377",
                    DefinitionText = "The set of race codes used by NCHS for Vital Statistics reporting enhanced by “bridged race” codes.  These codes are assigned to persons who assert multiple races using an algorithm defined by NCHS.  The goal is to provide race statistics that are comparable with those used historically in order to facilitate time series analysis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a699baa2-ea62-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_IntentionalRejectEditFlags_NCHS",
                    ValueSetName = "Intentional Reject Edit Flags (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7389",
                    DefinitionText = "To reflect the relevant edit possibilities for intentional rejection.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cd873627-ec62-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_TransaxConversionFlag_NCHS",
                    ValueSetName = "Transax Conversion Flag (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7396",
                    DefinitionText = "To reflect the relevant edit possibilities for transax conversion.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f3b3f951-ed62-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_PregnancyEditFlags_NCHS",
                    ValueSetName = "Pregnancy Edit Flags (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7391",
                    DefinitionText = "To reflect the relevant edit possibilities for pregnancy status.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f5133942-ef62-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_SystemRejectCodes_NCHS",
                    ValueSetName = "System Reject Codes (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7395",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9b59770c-f962-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_Race_NCHS",
                    ValueSetName = "Race (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7373",
                    DefinitionText = "To reflect race information for the decedent.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fd8856e7-b663-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_DeathReportingProfiles_NCHS",
                    ValueSetName = "Death Reporting Profiles (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7386",
                    DefinitionText = "To indicate the use case supported by the message instance",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 6, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a3d35b2e-1b66-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_MorphologicAbnormalitiesOfNeoplasms",
                    ValueSetName = "Morphologic Abnormalities of Neoplasms",
                    ValueSetOID = "2.16.840.1.114222.4.11.7256",
                    DefinitionText = "HL7 Implementation Guide for CDA© Release 2: Reporting to Public Health Cancer Registries from Ambulatory Healthcare Providers, Release 1 (US Realm) Draft Standard for Trial Use.Contains codes descending from the following SNOMED CT® concepts: Malignant neoplasm of primary, secondary, or uncertain origin (morphologic abnormality) [367651003], Nervous system tumor morphology (morphologic abnormality) [253061008], Intratubular malignant germ cells (morphologic abnormality) [128902002], In situ melanocytic morphology (morphologic abnormality) [253035009], In situ neoplasm (morphologic abnormality) [127569003], Carcinoma in situ - category (morphologic abnormality) [399919001], Squamous intraepithelial neoplasia - category (morphologic abnormality) [399962000], In situ adenomatous neoplasm - category (morphologic abnormality) [399983006]. Also includes following SNOMED CT codes and any descendants of such codes: Chronic myeloproliferative disorder (morphologic abnormality) [115248004], Cavernous lymphangioma (morphologic abnormality) [89056007], Paraganglioma (morphologic abnormality) [803009], Craniopharyngioma (morphologic abnormality) [40009002], Craniopharyngioma, adamantinomatous (morphologic abnormality) [128781004], Craniopharyngioma, papillary (morphologic abnormality) [128782006], Pineocytoma (morphologic abnormality) [89096009], Pleomorphic adenoma (morphologic abnormality) [8360001], Intratubular malignant germ cells (morphologic abnormality) [128902002].",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 10, 21)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9207620c-aa67-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_TimeUnits_NCHS",
                    ValueSetName = "Time Units (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7372",
                    DefinitionText = "Units for measuring time for death reporting based on UCUM std.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 11, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("52d28947-ac67-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_EthnicityGroup_NCHS",
                    ValueSetName = "Ethnicity Group (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7375",
                    DefinitionText = "To reflect information regarding the Hispanic origin of the decedent.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 4, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8cdb8707-3f68-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_EthnicityDetail_NCHS",
                    ValueSetName = "Ethnicity Detail (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7376",
                    DefinitionText = "Possible Hispanic ethnic group categories defined for NCHS reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("63dc7fdd-6068-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_DeathReportingEventReason_NCHS",
                    ValueSetName = "Death Reporting Event Reason (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7383",
                    DefinitionText = "Indicates transmission of death report with valid information or a void death report.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 10, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("df66d174-ca6d-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_DeathReportingEventType_NCHS",
                    ValueSetName = "Death Reporting Event Type  (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7442",
                    DefinitionText = "Used within ADT messaging to transmit trigger event information for death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 4, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2042c656-e06d-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_DeathReportingMessageStructure_NCHS",
                    ValueSetName = "Death Reporting Message Structure (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7443",
                    DefinitionText = "To identify the segments used in messages for death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7d40388d-3077-e511-bc01-0017a477041a"),
                    ValueSetCode = "PHVS_NationallyNotifiableEventCode_Generic",
                    ValueSetName = "Nationally Notifiable Event Code (Generic)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7447",
                    DefinitionText = "List of notifiable events that can use only the Generic V2 Message Mapping Guide (MMG).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b3cf7ff7-7127-e611-bd10-0017a477041a"),
                    ValueSetCode = "PHVS_AgePQ_UCUM",
                    ValueSetName = "AgePQ_UCUM",
                    ValueSetOID = "2.16.840.1.113883.11.20.9.21",
                    DefinitionText = "A Value Set of UCUM codes for representing age value units.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 5, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("59107dcd-bf31-e611-bd10-0017a477041a"),
                    ValueSetCode = "PHVS_CityPlaces_NCHS",
                    ValueSetName = "City Places (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7512",
                    DefinitionText = "THE CONCEPT CODES DISPLAYED ARE THE GNIS FEATURE IDS. THE  FIPS 55-3 CODES ARE INCLUDED IN THE VALUE SET DOWNLOAD FILE AS PREFERRED ALTERNATE CODE . Codes for Named Populated Places, Primary County Divisions, and Other Locational Entities of the United States, Puerto Rico, and the Outlying Areas (without codes). The former FIPS 55-3 standard was superseded by ANSI standard INCITS 446-2008. Former FIPS 55 data have been incorporated into the GNIS. The GNIS Feature ID superseded the FIPS55 Place Code (now the Census Code) as the Federal and national standard geographic feature record identifier. The Census Bureau continues to assign five digit Census Codes for internal purposes. http://geonames.usgs.gov/domestic/download_data.htm",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1393ec20-4e32-e611-bd10-0017a477041a"),
                    ValueSetCode = "PHVS_MessageErrorConditionCodes_NCHS",
                    ValueSetName = "Message Error Condition Codes (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7513",
                    DefinitionText = "A list, defined by HL7, of the possible communication error types that may be returned to characterize an error response.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c5819e2f-d10b-e611-bd5a-0017a477041a"),
                    ValueSetCode = "PHVS_ActStatus",
                    ValueSetName = "Act Status",
                    ValueSetOID = "2.16.840.1.113883.1.11.159331",
                    DefinitionText = "Contains the names (codes) for each of the states in the state-machine of the RIM Act class.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2019, 4, 18)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b1c3f50c-774a-e511-bd9f-0017a477041a"),
                    ValueSetCode = "PHVS_AdministrativeDiagnosis_CDC_ICD-10CM",
                    ValueSetName = "Diagnosis (ICD-10 CM)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7356",
                    DefinitionText = "ICD-10 CM Administrative Diagnosis Codes used for billing purposes, Reason for Study, DG1 Diagnosis segments Keyword: ICD-10 CM",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b51fbabf-e04c-e511-bd9f-0017a477041a"),
                    ValueSetCode = "PHVS_AdministrativeProcedure_CDC_ICD-10PCS",
                    ValueSetName = "Procedure (ICD-10 PCS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7371",
                    DefinitionText = "ICD-10 PCS Procedure Codes used for billing purposes, Reason for Study, PR1 Diagnosis segments",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c18817ea-dc50-e511-bd9f-0017a477041a"),
                    ValueSetCode = "PHVS_TypeOfClinicLocation_NCHS",
                    ValueSetName = "Type of clinic/location (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7364",
                    DefinitionText = "The kind of place or hospital department where a procedure, treatment, or service may be performed or provided.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("023ec160-df50-e511-bd9f-0017a477041a"),
                    ValueSetCode = "PHVS_SpecialtyUnitType_NCHS",
                    ValueSetName = "Specialty Unit Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7363",
                    DefinitionText = "The kind of hospital unit having any necessary specialized equipment and/or personnel for handling critically ill or injured patients.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("83ff4842-e150-e511-bd9f-0017a477041a"),
                    ValueSetCode = "PHVS_DischargeDispositionIP_NCHS",
                    ValueSetName = "Discharge Disposition IP (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7360",
                    DefinitionText = "The final arrangement or transfer of care made when a patient is released from an inpatient admission.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3ed0a8d4-4752-e511-bd9f-0017a477041a"),
                    ValueSetCode = "PHVS_PresentOnAdmission_NCHS",
                    ValueSetName = "Present on Admission (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7369",
                    DefinitionText = "Existent at the time the patient was accepted into the hospital as an inpatient",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("10315265-0653-e511-bd9f-0017a477041a"),
                    ValueSetCode = "PHVS_PriorityTypeOfAdmissionOrVisit_NCHS",
                    ValueSetName = "Priority (Type) of Admission or Visit (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7365",
                    DefinitionText = "The kind or importance of the process which resulted in the patient’s being admitted as an inpatient.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2cb697a2-1053-e511-bd9f-0017a477041a"),
                    ValueSetCode = "PHVS_ActivityType_NCHS",
                    ValueSetName = "Activity Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7370",
                    DefinitionText = "To reflect the possible activities in which the decedent was engaged at the time of death.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("483d076b-6556-e511-bd9f-0017a477041a"),
                    ValueSetCode = "PHVS_DispositionOPD_NCHS",
                    ValueSetName = "Disposition OPD (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7361",
                    DefinitionText = "The final arrangement or transfer of care made when a patient completes an outpatient visit",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dba8d2f9-6856-e511-bd9f-0017a477041a"),
                    ValueSetCode = "PHVS_PointOfOrigin_NCHS",
                    ValueSetName = "Point of Origin (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7359",
                    DefinitionText = "Where the patient came from immediately before arriving at the healthcare facility",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("101ccb8a-fd56-e511-bd9f-0017a477041a"),
                    ValueSetCode = "PHVS_Follow-upAttemptOutcome_NCHS",
                    ValueSetName = "Follow-up Attempt Outcome (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7362",
                    DefinitionText = "The finding(s) or result(s) of contact made by healthcare staff with a patient after an outpatient surgical procedure",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0f50ad5d-1757-e511-bd9f-0017a477041a"),
                    ValueSetCode = "PHVS_NationallyNotifiableEventCode_Syphilis",
                    ValueSetName = "Nationally Notifiable Event Code (Syphilis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7398",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b530381-dc25-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_PSMLBIObservationType_NCHS",
                    ValueSetName = "PSMLBI Observation Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7594",
                    DefinitionText = "The collection of observation types used for reporting provider supplied mother's live birth information (PSMLBI) within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d8dbedc3-c929-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_BirthReportingAssociatedPartyIDType_NCHS",
                    ValueSetName = "Birth Reporting Associated Party ID Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7581",
                    DefinitionText = "The collection of identifier types used within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 1, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9de32822-dc29-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_BirthReportingObservationType_NCHS",
                    ValueSetName = "Birth Reporting Observation Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7583",
                    DefinitionText = "The collection of observation types used within birth and fetal death reporting",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 4, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3ae96c04-892a-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_CCOFDIObservationType_NCHS",
                    ValueSetName = "CCOFDI Observation Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7584",
                    DefinitionText = "The collection of observation types used for reporting coded cause of fetal death information (CCOFDI) within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9ae189ec-8a2a-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_VitalRecordsEducationLevel_NCHS",
                    ValueSetName = "Vital Records Education Level (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7582",
                    DefinitionText = "The collection of education levels used for vital records reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 4, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5a8f8ed3-902a-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_FetalRemainsDispositionMethod_NCHS",
                    ValueSetName = "Fetal Remains Disposition Method (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7585",
                    DefinitionText = "The collection of disposition methods of fetal remains used within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 4, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("aaf95682-912a-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_InformantRelationshiptoMother_NCHS",
                    ValueSetName = "Informant Relationship to Mother (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7580",
                    DefinitionText = "The collection of informant relationship to mother used within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("87329127-ac2a-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_JFDIObservationType_NCHS",
                    ValueSetName = "JFDI Observation Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7586",
                    DefinitionText = "The collection of observation types used for reporting jurisdictional facility death information (JFDI) for birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9ce4f8a6-3c2c-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_JLBIObservationType_NCHS",
                    ValueSetName = "JLBI Observation Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7587",
                    DefinitionText = "The collection of observation types used for reporting jurisdictional live birth information (JLBI) within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7c9f5657-3e2c-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_PSFFDIObservationType_NCHS",
                    ValueSetName = "PSFFDI Observation Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7589",
                    DefinitionText = "The collection of observation types used for reporting provider supplied facility fetal death information (PSFFDI) within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6c6ffcbd-3f2c-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_PSFLBIObservation Type _NCHS",
                    ValueSetName = "PSFLBI Observation Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7590",
                    DefinitionText = "The collection of observation types used for reporting provider supplied facility live birth information (PSFLBI) within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6ecc9c7d-4e2f-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_PSLBIObservationType _NCHS",
                    ValueSetName = "PSLBI Observation Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7591",
                    DefinitionText = "The collection of observation types used for reporting provider supplied live birth information (PSLBI) within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a605d3fd-4f2f-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_PSFDIObservationType_NCHS",
                    ValueSetName = "PSFDI Observation Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7588",
                    DefinitionText = "The collection of observation types used for reporting provider supplied fetal death information (PSFDI) within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("76094757-652f-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_PSMFDIObservationType_NCHS",
                    ValueSetName = "PSMFDI Observation Type (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7592",
                    DefinitionText = "The collection of observation types used for reporting provider supplied mother's fetal death information (PSMFDI) for birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("59062110-d330-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_BirthReportingMessageStructure_NCHS",
                    ValueSetName = "Birth Reporting Message Structure (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7572",
                    DefinitionText = "The collection of message structures used within birth and fetal death reporting.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8f2b35db-9b39-e711-be3f-0017a477041a"),
                    ValueSetCode = "PHVS_ConsolidatedRace_NCHS",
                    ValueSetName = "Consolidated Race (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7593",
                    DefinitionText = "A collection of consolidated race codes used within vital records reporting to consolidate reported race values into a single code",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 5, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9ef86821-0409-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_CampylobacterOrganism_CDC",
                    ValueSetName = "Campylobacter Organism",
                    ValueSetOID = "2.16.840.1.114222.4.11.3594",
                    DefinitionText = "List of Campylobacter species and subspecies which may be used with FoodNet variables (INV400 and INV405 - Campylobacter species collected at state or clinical lab).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8c6adb3b-8809-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_OutpatientEncounter_JCIH_EHDI",
                    ValueSetName = "JCIH-EHDI Outpatient Encounter",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.15.2.2",
                    DefinitionText = "Used to identify ambulatory encounters that have different quality measurement rules from inpatient.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("55ec5c40-f815-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_FacilityVisitType_SyndromicSurveillance",
                    ValueSetName = "Facility / Visit Type (Syndromic Surveillance)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3401",
                    DefinitionText = "Type of facility that the patient visited for treatment.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4d02cd54-9317-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_AgeUnit_SyndromicSurveillance",
                    ValueSetName = "Age Unit (Syndromic Surveillance)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3402",
                    DefinitionText = "Unit corresponding to numeric value of patient age (e.g. Days, Month or Years)  specific for syndromic surveillance",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6058110d-9517-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_Gender_SyndromicSurveillance",
                    ValueSetName = "Gender (Syndromic Surveillance)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3403",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2b275396-9717-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_PatientClass_SyndromicSurveillance",
                    ValueSetName = "Patient Class (Syndromic Surveillance)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3404",
                    DefinitionText = "Patient classification within facility",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 4, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4efb4c3e-3d18-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_DiseaseAcquiredJurisdiction_NETSS",
                    ValueSetName = "Disease Acquired Jurisdiction (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3406",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("678819a2-3f18-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_CaseClassStatus_NETSS",
                    ValueSetName = "Case Class Status (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3407",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f778b96b-4318-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_AgeUnit_UCUM_NETSS",
                    ValueSetName = "Age Unit (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3408",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("80db089e-c918-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_TransmissionSetting_NETSS",
                    ValueSetName = "Transmission Setting (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3409",
                    DefinitionText = "Transmission Setting (NETSS)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4d6b4871-d318-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_VaccineNotGivenReasons_NETSS",
                    ValueSetName = "Vaccine Not Given Reasons (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3410",
                    DefinitionText = "Vaccine Not Given Reasons (NETSS)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("803f5fb2-dd18-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_BodyRegion_Tetanus_NETSS",
                    ValueSetName = "Body Region Tetanus (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3411",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6b690398-df18-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_InjuryOccurredEnvironment_NETSS",
                    ValueSetName = "Injury Occurred Environment (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3412",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ce31cbfb-e118-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_InjuryType_NETSS",
                    ValueSetName = "Injury Type (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3413",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fda1ce44-9919-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_BirthAttendees_NETSS",
                    ValueSetName = "Birth Attendees (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3414",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c39f4174-a119-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_VaccinesAdministeredCVX_NETSS",
                    ValueSetName = "Vaccines Administered (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3415",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("178aa617-a519-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_ManufacturersOfVaccinesMVX_NETSS",
                    ValueSetName = "Manufacturers Of Vaccines (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3416",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2e7a9bf2-a819-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_ContactType_HepatitisA_NETSS",
                    ValueSetName = "Contact Type Hepatitis A (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3417",
                    DefinitionText = "Contact Type Hepatitis A (NETSS)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c2e597a1-c019-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_SexualPreference_NETSS",
                    ValueSetName = "Sexual Preference (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3418",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("635bc32b-c319-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestResult_Lyme_NETSS",
                    ValueSetName = "Lab Test Result Lyme (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3419",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("43c052ca-c619-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_Microorganism_NETSS",
                    ValueSetName = "Microorganism (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3420",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b5af4824-d519-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_BacterialInfectionSyndrome_NETSS",
                    ValueSetName = "Bacterial Infection Syndrome (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3421",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("98f565d0-6e1a-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_AssociatedConditions_NETSS",
                    ValueSetName = "Associated Conditions (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3422",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4ddad71c-721a-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_AntibioticTreatment_NETSS",
                    ValueSetName = "Antibiotic Treatment (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3423",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0bda92d5-751a-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_HemodialysisContactType_Hepatitis_NETSS",
                    ValueSetName = "Hemodialysis Contact Type Hepatitis (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3424",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5a72e1de-961a-e011-87a0-00188b39829b"),
                    ValueSetCode = "PHVS_GeographicRegion_NETSS",
                    ValueSetName = "Geographic Region (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3425",
                    DefinitionText = "Geographic region value set concepts have been mapped to SNOMED as it includes the relationship between the regions and the countries.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("44d30145-4eed-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_BacterialInfectiousDisease_CDC",
                    ValueSetName = "Bacterial Infectious Disease",
                    ValueSetOID = "2.16.840.1.114222.4.11.3501",
                    DefinitionText = "List of all the bacterial infectious disease. This is an intrinsic value set based upon SNOMED CT domain [87628006].",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 11, 11)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c2cc930b-50ed-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_InfectiousDisease_CDC",
                    ValueSetName = "Infectious Disease",
                    ValueSetOID = "2.16.840.1.114222.4.11.3502",
                    DefinitionText = "List of all infectious disease. This is an intrinsic value set based upon SNOMED CT domain [40733004].",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 11, 11)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b6fe8020-51ed-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_PneumoniaDisease_CDC",
                    ValueSetName = "Pneumonia Disease",
                    ValueSetOID = "2.16.840.1.114222.4.11.3503",
                    DefinitionText = "List of all the disease concepts related to Pneumonia. This is an intrinsic value set based upon SNOMED CT domain [233604007].",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 11, 11)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e85d7807-ceee-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_GestationalDiabetes_NCHS",
                    ValueSetName = "Gestational Diabetes (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.137",
                    DefinitionText = "To Reflect Risk Factors of Gestational Diabetes",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 7, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b879261c-3cef-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_SpinalAnesthesiaMedication_NCHS",
                    ValueSetName = "Spinal Anesthesia - Medication (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.28",
                    DefinitionText = "To Reflect an Spinal Anesthesia Medication",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("323f066b-3eef-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_HispanicEthnicityMexican_NCHS",
                    ValueSetName = "Hispanic Ethnicity - Mexican (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.72",
                    DefinitionText = "To Reflect Hispanic Ethnicity - Mexican/ Mexican American/ Chicana",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("767d211e-40ef-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_OtherHispanicEthnicity_NCHS",
                    ValueSetName = "Other Hispanic Ethnicity (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.75",
                    DefinitionText = "To Reflect Hispanic Ethnicity – Other Spanish/Hispanic/Latina",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("144494df-42ef-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_NotHispanicEthnicity_NCHS",
                    ValueSetName = "Not Hispanic Ethnicity (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.76",
                    DefinitionText = "To Reflect Hispanic Ethnicity - Not Spanish/Hispanic/Latina",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f894e9ad-2af1-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_HearingLossRiskFactors_JCIH_EHDI",
                    ValueSetName = "JCIH-EHDI Hearing Loss Risk Factors",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.15.2.11",
                    DefinitionText = "To Reflect the Risk Factors associated with hearing loss using SNOMED-CT Finding and Situation concepts",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 11, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7a4aaaae-2cf1-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_HearingLossRiskFactorsProcedures_JCIH_EHDI",
                    ValueSetName = "JCIH-EHDI Hearing Loss Risk Factors - Procedures",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.15.2.12",
                    DefinitionText = "To Reflect the Risk Factors Procedures associated with hearing loss using SNOMED-CT",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 11, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9856b913-2ff1-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_NICUServiceDeliveryLocation_JCIH_EHDI",
                    ValueSetName = "JCIH-EHDI NICU Service Delivery Location",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.15.2.13",
                    DefinitionText = "To Reflect that the newborn was treated in the NICU reflecting hearing loss risk",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 11, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9c8a9d22-30f1-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_NewbornHearingProcedure_JCIH_EHDI",
                    ValueSetName = "JCIH-EHDI Newborn Hearing Procedure",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.15.2.17",
                    DefinitionText = "To Reflect the type of newborn hearing procedure identified using SNOMED-CT Procedure codes (includes both screening and other tests and examinations)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 11, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8e9ec099-31f1-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_HearingScreenRight_JCIH_EHDI",
                    ValueSetName = "JCIH-EHDI Hearing Screen Right",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.15.2.9",
                    DefinitionText = "To Reflect the right ear EHDI screening using LOINC in result type",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 11, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6cfb09db-32f1-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_HearingScreenLeft_JCIH_EHDI",
                    ValueSetName = "JCIH-EHDI Hearing Screen Left",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.15.2.8",
                    DefinitionText = "To Reflect the left ear EHDI hearing screening result type using LOINC",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 11, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4a15aee6-33f1-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_NewbornHearingLossDiagnosis_JCIH_EHDI",
                    ValueSetName = "JCIH-EHDI Newborn Hearing Loss Diagnosis",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.15.2.14",
                    DefinitionText = "To Reflect EHDI hearing loss diagnosis coded with SNOMED-CT on the problem list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 11, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a659157a-35f1-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_ReasonForNoHearingLossDiagnosis_JCIH_EHDI",
                    ValueSetName = "JCIH-EHDI Reason for no Hearing Loss Diagnosis",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.15.2.15",
                    DefinitionText = "To Reflect Reason for no hearing loss diagnosis coded with SNOMED-CT",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 11, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("20efba95-3bf1-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_NewbornHearingLossReferrals_JCIH_EHDI",
                    ValueSetName = "JCIH-EHDI Newborn Hearing Loss Referrals",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.15.2.16",
                    DefinitionText = "To Reflect EHDI referals coded with SNOMED-CT and as a response to care plan recommendations (entered on a list of referals in a medical summary)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 11, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5867738a-3cf1-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_ReasonForNoFollowUpPatientReason_JCIH_EHDI",
                    ValueSetName = "JCIH-EHDI Reason for no Follow-up - Patient Reason",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.15.2.7",
                    DefinitionText = "To Reflect the reason that no follow-up is conducted in the case of hearing loss using SNOMED-CT reflected in negation of an intent to order the referral.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7cec24dd-3df1-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_JointCommissionMedicalReason_JCIH_EHDI",
                    ValueSetName = "Joint Commission Medical Reason",
                    ValueSetOID = "1.3.6.1.4.1.33895.1.3.0.75",
                    DefinitionText = "The Joint Commission value set is used to reflect medical reason why a test was not performed",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 11, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c22f79ec-3ef1-df11-9273-00188b39829b"),
                    ValueSetCode = "PHVS_ProcedureDeclined_JCIH_EHDI",
                    ValueSetName = "JCIH-EHDI Procedure Declined",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.15.2.20",
                    DefinitionText = "To Reflect that the hearing screening procedure was not performed due to the patient/parent declining the procedure",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5645e3d7-1e00-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_SubjectDescriptor_USDA",
                    ValueSetName = "USDA Subject Descriptor",
                    ValueSetOID = "2.16.840.1.113883.3.5.20.1",
                    DefinitionText = "Descriptors provide a means to rapidly describe the general appearance of the animal for purposes of visual identification (e.g. for traceback activities).  They also may be used in place of the breed if the breed is not apparent (e.g. cow is coated in mud) or unknown (e.g. Dairy Breed)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("da274fb4-9900-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_SubjectFunction_USDA",
                    ValueSetName = "USDA Subject Function",
                    ValueSetOID = "2.16.840.1.113883.3.5.20.2",
                    DefinitionText = "The function use categories are a classification applied to an animal at a given stage of its life/management cycle at the time it was observed.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("843111fe-dd00-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_FluActivityCode_CDC",
                    ValueSetName = "Flu Activity Code",
                    ValueSetOID = "2.16.840.1.114222.4.11.3587",
                    DefinitionText = "Flu activity codes used in NETSS for case counts",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 11)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("baf06bd1-f000-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_FetalPresentationAtBirthBreech_NCHS",
                    ValueSetName = "Fetal Presentation at Birth- Breech (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.108",
                    DefinitionText = "To Reflect the Fetal Presentation at Birth- Breech method of delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("226bfe72-cb04-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_MethodOfRaceAndEthnicityDataCollection_CDC",
                    ValueSetName = "Method of Race and Ethnicity Data Collection",
                    ValueSetOID = "2.16.840.1.114222.4.11.3588",
                    DefinitionText = "The Race or Ethnicity Collection code provides a method of describing how information on race or ethnicity is collected in various data gathering systems.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 11)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("28dec379-d604-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_BehaviorCode_NAACCR",
                    ValueSetName = "NAACCR Behavior Code",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.14",
                    DefinitionText = "Code for whether tissue samples are benign (0), borderline (1), in situ (2), or malignant (3).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7055b117-d804-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_CancerStatus_NAACCR",
                    ValueSetName = "NAACCR Cancer Status",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.11",
                    DefinitionText = "Code for the presence or absence of clinical evidence of the patient's malignant or non-malignant tumor.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f27c484f-da04-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_BestMethodOfDiagnosis_NAACCR",
                    ValueSetName = "NAACCR Diagnostic Confirmation",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.3",
                    DefinitionText = "Code for the best method used to confirm the presence of the cancer being reported.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 11, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ea08d650-dd04-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_Grade_NAACCR",
                    ValueSetName = "NAACCR Grade",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.15",
                    DefinitionText = "Code for the degree of differentiation of the reportable tumor.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("204cbd53-e004-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_LateralityAtDiagnosis_NAACCR",
                    ValueSetName = "NAACCR Laterality at Diagnosis",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.1",
                    DefinitionText = "Code for the side of a paired organ, or the side of the body on which the reportable tumor originated.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e416a127-e204-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_QualityOfSurvival_NAACCR",
                    ValueSetName = "NAACCR Quality of Survival",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.12",
                    DefinitionText = "Code for the patient’s ability to carry on the activities of daily living at the date of last contact.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("de63fd58-e304-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_ScreeningResult_NAACCR",
                    ValueSetName = "NAACCR Screening Result",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.13",
                    DefinitionText = "Code for the results of a screening test.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6036a7b1-e404-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_TNMClinicalStagedBy_NAACCR",
                    ValueSetName = "NAACCR TNM Clinical Staged By",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.4",
                    DefinitionText = "Code for the person who assigned the AJCC staging elements and stage group.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 11, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fe29c343-4a05-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_ObservationIdentifier_SyndromicSurveillance",
                    ValueSetName = "Observation Identifier (Syndromic Surveillance)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3589",
                    DefinitionText = "List of observation identifiers associated with syndromic surveillance that would be coming in the observation identifier field (OBX-3) in HL7 2.x messaging.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a4453adb-5505-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_PulseOximetryUnit_UCUM",
                    ValueSetName = "Pulse Oximetry Unit",
                    ValueSetOID = "2.16.840.1.114222.4.11.3590",
                    DefinitionText = "UCUM units associated with Pulse Oximetry such as percent",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 11)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("42d16f69-2f06-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_TNMEditionNumber_NAACCR",
                    ValueSetName = "NAACCR TNM Edition Number",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.5",
                    DefinitionText = "Code that indicates the edition of the AJCC manual used to stage the case.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("34448ba8-3006-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_TNMClinicalStageDescriptor_NAACCR",
                    ValueSetName = "NAACCR TNM Clinical Stage Descriptor",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.10",
                    DefinitionText = "Code for the the AJCC clinical stage (prefix/suffix) descriptor as defined by AJCC.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("96194c6a-3606-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_SourceOfPaymentTypology_PHDSC",
                    ValueSetName = "Source of Payment Typology (PHDSC)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3591",
                    DefinitionText = "The development of a standard source of payment classification system is a high priority for public health and can be used for a wide variety of public health activities such as monitoring healthcare access and documenting disparities.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 1, 18)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2ef1ade8-7808-e011-9273-00188b39829b"),
                    ValueSetCode = "PHVS_CauseOfDeath_ICD-10_CDC",
                    ValueSetName = "Cause of Death (ICD-10)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3593",
                    DefinitionText = "The list provides ICD-10 codes and associated cause-of-death titles for the most detailed listing of causes of death. This list is maintained by CDC NCHS.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 12, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b9d4371-2c98-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_AcidFastStain",
                    ValueSetName = "Lab Test Name (Acid fast stain)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4250",
                    DefinitionText = "lab tests associated with Acid fast stain",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bbd730a4-2c98-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Bacteria",
                    ValueSetName = "Lab Test Name (Bacteria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4251",
                    DefinitionText = "lab tests associated with Bacteria",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3ba89dc0-2c98-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Fungus",
                    ValueSetName = "Lab Test Name (Fungus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4252",
                    DefinitionText = "lab tests associated with Fungus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7be8cdf0-2c98-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Microorganism",
                    ValueSetName = "Lab Test Name (Microorganism)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4253",
                    DefinitionText = "lab tests associated with Microorganism",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b4c9312-2d98-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Mycobacteria",
                    ValueSetName = "Lab Test Name (Mycobacteria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4254",
                    DefinitionText = "lab tests associated with Mycobacteria",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b4a07c9-2d98-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Parasite",
                    ValueSetName = "Lab Test Name (Parasite)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4255",
                    DefinitionText = "lab tests associated with Parasite",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9b46ffe4-2d98-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Virus",
                    ValueSetName = "Lab Test Name (Virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4256",
                    DefinitionText = "lab tests associated with Virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8d901ee4-3198-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Asbestosis",
                    ValueSetName = "Lab Test Name (Asbestosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4240",
                    DefinitionText = "lab tests associated with Asbestosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ab96bd1b-3298-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Berylliosis",
                    ValueSetName = "Lab Test Name (Berylliosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4241",
                    DefinitionText = "lab tests associated with Berylliosis (Chronic Beryllium Disease)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c7b4854b-3298-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_RicinPoisoning",
                    ValueSetName = "Lab Test Name (Ricin poisoning)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4242",
                    DefinitionText = "lab tests associated with Ricin poisoning",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 12, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d446a774-3298-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_MushroomPoisoning",
                    ValueSetName = "Lab Test Name (Mushroom poisoning)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4243",
                    DefinitionText = "lab tests associated with Mushroom poisoning",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2a387bce-3298-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_CarbonMonoxidePoisoning",
                    ValueSetName = "Lab Test Name (Carbon monoxide poisoning)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4244",
                    DefinitionText = "lab tests associated with Carbon monoxide poisoning",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a982cfef-3298-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_PesticidePoisoning",
                    ValueSetName = "Lab Test Name (Pesticide poisoning)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4245",
                    DefinitionText = "lab tests associated with Pesticide poisoning",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a5d07736-3398-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_ArsenicPoisoning",
                    ValueSetName = "Lab Test Name (Arsenic poisoning)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4246",
                    DefinitionText = "lab tests associated with Arsenic poisoning",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("47defe4f-3398-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_CadmiumPoisoning",
                    ValueSetName = "Lab Test Name (Cadmium poisoning)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4247",
                    DefinitionText = "lab tests associated with Cadmium poisoning",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c33e836c-3398-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_LeadPoisoning",
                    ValueSetName = "Lab Test Name (Lead poisoning)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4248",
                    DefinitionText = "lab tests associated with Lead poisoning",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 18)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0553268c-3398-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_MercuryPoisoning",
                    ValueSetName = "Lab Test Name (Mercury poisoning)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4249",
                    DefinitionText = "lab tests associated with Mercury poisoning",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 18)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d2de771f-3498-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_DiabetesHemoglobinA1c",
                    ValueSetName = "Lab Test Name (Diabetes, hemoglobin A1c)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4239",
                    DefinitionText = "lab tests associated with Diabetes, hemoglobin A1c",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b2e6e9c-ce98-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_AntimicrobialSusceptibilityTests",
                    ValueSetName = "Lab Test Name (Antimicrobial susceptibility tests)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4257",
                    DefinitionText = "lab tests associated with Antimicrobial susceptibility testing",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb99ae51-cf98-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_TBAntimicrobialSusceptibilityTest",
                    ValueSetName = "Lab Test Name (TB Antimicrobial susceptibility test)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4258",
                    DefinitionText = "lab tests associated with Tuberculosis Antimicrobial susceptibility testing",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 18)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0f82be75-c29c-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_CancerMorphology_RCMT",
                    ValueSetName = "Lab Result (Cancer Morphology)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4275",
                    DefinitionText = "Lab result associated with Cancer - Morphology codes (M-Codes from SNOMED CT)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ef916e3a-f39d-e011-9686-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Pesticide",
                    ValueSetName = "Lab Result (Pesticide)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4276",
                    DefinitionText = "Lab results associated with pesticides.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d41238e8-d7ea-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_NumberofLiveBirths_NCHS",
                    ValueSetName = "Number of Live Births (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.68",
                    DefinitionText = "To Reflect the question as to the Number of Live Births",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7576dc15-6aec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_DateofLastMenses_NCHS",
                    ValueSetName = "Date of Last Menses (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.69",
                    DefinitionText = "To Reflect the question as to the Date of Last Menses",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7032413a-71ec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_NumberOfPriorPregnancies_NCHS",
                    ValueSetName = "Number of Prior Pregnancies (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.71",
                    DefinitionText = "To Reflect the question as to the Number of Prior Pregnancies",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("36e190f8-72ec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_Married_NCHS",
                    ValueSetName = "Married (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.170",
                    DefinitionText = "To Reflect marital status of Married",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f450ad0d-75ec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_AugmentationOfLaborMedication_NCHS",
                    ValueSetName = "Augmentation of Labor - Medication (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.23",
                    DefinitionText = "To reflect a medication used for the Augmentation of Labor",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("52a309ee-76ec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_BirthPluralityOfDelivery_NCHS",
                    ValueSetName = "Birth Plurality of Delivery (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.132",
                    DefinitionText = "To Reflect the question as to the Birth Plurality of Delivery",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fc7120c0-77ec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_FeverGreaterThan100.4_NCHS",
                    ValueSetName = "Fever Greater Than 100.4 (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.25",
                    DefinitionText = "To Reflect a Fever Greater Than 100.4  During Labor",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cce9e77f-78ec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_FirstPrenatalCareVisit_NCHS",
                    ValueSetName = "First Prenatal Care Visit (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.133",
                    DefinitionText = "To Reflect the question as to the First Prenatal Care Visit",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5f06bd79-7aec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_BreastfedInfant_NCHS",
                    ValueSetName = "Breastfed Infant (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.41",
                    DefinitionText = "To Reflect Breastfed Infant at discharge",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("79603f25-7fec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_MaleGender_NCHS",
                    ValueSetName = "Male Gender (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.42",
                    DefinitionText = "To reflect the sex of the deceased as male",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2e0df8af-7fec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_FemaleGender_NCHS",
                    ValueSetName = "Female Gender (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.43",
                    DefinitionText = "To reflect the sex of the deceased as female",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 9, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("33d28778-80ec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_ProblemStatusActive_NCHS",
                    ValueSetName = "Problem Status Active (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.119",
                    DefinitionText = "To reflect the Problem Status Active",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("249d7687-81ec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_ExternalCephalicVersion_NCHS",
                    ValueSetName = "External Cephalic Version (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.127",
                    DefinitionText = "To Reflect Obstetric Procedures as External Cephalic Version",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("481101a3-84ec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_NeverMarried_NCHS",
                    ValueSetName = "Never Married (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.171",
                    DefinitionText = "To Reflect marital status of Married",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ac49fa5d-85ec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_PreviouslyMarried_NCHS",
                    ValueSetName = "Previously Married (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.172",
                    DefinitionText = "To Reflect marital status of Married",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cc44c732-89ec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_Father_NCHS",
                    ValueSetName = "Father (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.77",
                    DefinitionText = "To Reflect the Father of the newborn or fetus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("26d0527e-8dec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_InflammationIndication_NCHS",
                    ValueSetName = "Inflammation Indication (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.40",
                    DefinitionText = "To Reflect an indication Inflammation for corticosteroied administration",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("67dc16af-90ec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_HispanicEthnicityPuertoRican_NCHS",
                    ValueSetName = "Hispanic Ethnicity - Puerto Rican (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.73",
                    DefinitionText = "To Reflect Hispanic Ethnicity - Puerto Rican",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("589bc700-92ec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_HispanicEthnicityCuban_NCHS",
                    ValueSetName = "Hispanic Ethnicity - Cuban (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.74",
                    DefinitionText = "To Reflect Hispanic Ethnicity - Cuban",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d48eee8d-92ec-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_RaceAsianIndian_NCHS",
                    ValueSetName = "Race - Asian Indian (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.81",
                    DefinitionText = "To Reflect race of Asian Indian",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f75411df-10ed-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_EducationLevel8th_NCHS",
                    ValueSetName = "Education Level 8th (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.155",
                    DefinitionText = "To Reflect the education level of 8th grade or less in social history",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0b5c8f24-2aed-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_EducationLevel9to12NoDiploma_NCHS",
                    ValueSetName = "Education Level - 9 - 12 No Diploma (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.156",
                    DefinitionText = "To Reflect the education level High School in social history",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("753906be-2aed-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_EducationLevelHighSchool_NCHS",
                    ValueSetName = "Education Level - High School (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.157",
                    DefinitionText = "To Reflect the education level - High School in social history",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("44189e42-2bed-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_EducationLevelSomeCollege_NCHS",
                    ValueSetName = "Education Level Some College (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.158",
                    DefinitionText = "To Reflect the education level of - Some College in social history",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("895872a6-2bed-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_EducationLevelAssociate_NCHS",
                    ValueSetName = "Education Level Associate (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.159",
                    DefinitionText = "To Reflect the education level of - Associate in social history",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e4f2d205-2ced-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_EducationLevelBaccalaureate_NCHS",
                    ValueSetName = "Education Level Baccalaureate (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.160",
                    DefinitionText = "To Reflect the education level of - Baccalaureate in social history",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("465f5775-2ced-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_EducationLevelGraduateDegree_NCHS",
                    ValueSetName = "Education Level Graduate Degree (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.161",
                    DefinitionText = "To Reflect the education level of - Graduate Degree in social history",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0443089c-2ded-df11-a040-00188b39829b"),
                    ValueSetCode = "PHVS_KaryotypeResult_NCHS",
                    ValueSetName = "Karyotype Result (NCHS)",
                    ValueSetOID = "1.3.6.1.4.1.19376.1.7.3.1.1.13.8.59",
                    DefinitionText = "To Reflect the question as to the Karyotyping to determine that the result is pending.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ea232f09-2b86-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_Acknowledgment Code_PHLIP",
                    ValueSetName = "Acknowledgment Code (HL7) (PHLIP)",
                    ValueSetOID = "2.16.840.1.114222.4.11.5020",
                    DefinitionText = "Constrained version of PHVS_AcknowledgementCode HL7 v2x",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9bba6eeb-b396-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Brucellosis",
                    ValueSetName = "Lab Test Name (Brucellosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4126",
                    DefinitionText = "lab tests associated with Brucellosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b7eb10f-b996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Amebiasis",
                    ValueSetName = "Lab Test Name (Amebiasis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4117",
                    DefinitionText = "lab tests associated with Amebiasis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ad69b3f5-c196-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Amebiasis",
                    ValueSetName = "Lab Result (Amebiasis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4000",
                    DefinitionText = "lab results associated with Amebiasis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("eea1202c-c296-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Anaplasma",
                    ValueSetName = "Lab Result (Anaplasma)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4001",
                    DefinitionText = "lab results associated with Anaplasma",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("72cce3a8-c296-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Anthrax",
                    ValueSetName = "Lab Result (Anthrax)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4002",
                    DefinitionText = "lab results associated with Anthrax",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7bbf462c-c496-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Arbovirus",
                    ValueSetName = "Lab Result (Arbovirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4003",
                    DefinitionText = "lab results associated with Arbovirus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dbd89dca-c496-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Arenavirus",
                    ValueSetName = "Lab Result (Arenavirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4004",
                    DefinitionText = "lab results associated with Arenavirus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb10c79c-c596-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Babesiosis",
                    ValueSetName = "Lab Result (Babesiosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4005",
                    DefinitionText = "lab results associated with Babesiosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3bee6de6-c596-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Bartonellosis",
                    ValueSetName = "Lab Result (Bartonellosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4006",
                    DefinitionText = "lab results associated with Bartonellosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9bf7a777-c696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Blastomycosis",
                    ValueSetName = "Lab Result (Blastomycosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4007",
                    DefinitionText = "lab results associated with Blastomycosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9ba5bbdd-c696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Botulism",
                    ValueSetName = "Lab Result (Botulism)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4008",
                    DefinitionText = "lab results associated with Botulism",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b31cf05-c796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Brucellosis",
                    ValueSetName = "Lab Result (Brucellosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4009",
                    DefinitionText = "lab results associated with Brucellosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db87c848-c796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_CaliforniaSerogroupVirus",
                    ValueSetName = "Lab Result (California serogroup virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4010",
                    DefinitionText = "lab results associated with California serogroup virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9b994271-c796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Campylobacteriosis",
                    ValueSetName = "Lab Result (Campylobacteriosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4011",
                    DefinitionText = "lab results associated with Campylobacteriosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db82058b-c796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Anaplasma",
                    ValueSetName = "Lab Test Name (Anaplasma)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4118",
                    DefinitionText = "lab tests associated with Anaplasma",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3be81091-c796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Chagas",
                    ValueSetName = "Lab Result (Chagas)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4012",
                    DefinitionText = "lab results associated with Chagas",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb28b9b8-c796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Chancroid",
                    ValueSetName = "Lab Result (Chancroid)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4013",
                    DefinitionText = "lab results associated with Chancroid",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3be33ac0-c796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Anthrax",
                    ValueSetName = "Lab Test Name (Anthrax)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4119",
                    DefinitionText = "lab tests associated with Anthrax",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b872547-c896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_ChlamydiaTrachomatis",
                    ValueSetName = "Lab Result (Chlamydia trachomatis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4014",
                    DefinitionText = "lab results associated with Chlamydia trachomatis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb4cc864-c896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Babesiosis",
                    ValueSetName = "Lab Test Name (Babesiosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4122",
                    DefinitionText = "lab tests associated with Babesiosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb307c74-c896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Cholera",
                    ValueSetName = "Lab Result (Cholera)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4015",
                    DefinitionText = "lab results associated with Cholera",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b73c197-c896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_ClostridiumPerfringens",
                    ValueSetName = "Lab Result (Clostridium perfringens)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4016",
                    DefinitionText = "lab results associated with Clostridium perfringens",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b58cfc0-c896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_ClostridiumPerfringensEpsilonToxin",
                    ValueSetName = "Lab Result (Clostridium perfringens Epsilon Toxin)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4017",
                    DefinitionText = "lab results associated with Clostridium perfringens Epsilon Toxin",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1bf473c9-c896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Bartonellosis",
                    ValueSetName = "Lab Test Name (Bartonellosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4123",
                    DefinitionText = "lab tests associated with Bartonellosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db6a5ffe-c896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Coccidioidomycosis",
                    ValueSetName = "Lab Result (Coccidioidomycosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4018",
                    DefinitionText = "lab results associated with Coccidioidomycosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5bdc6c1a-c996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_ColoradoTickFever",
                    ValueSetName = "Lab Result (Colorado Tick Fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4019",
                    DefinitionText = "lab results associated with Colorado Tick Fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db5c812e-c996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Blastomycosis",
                    ValueSetName = "Lab Test Name (Blastomycosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4124",
                    DefinitionText = "lab tests associated with Blastomycosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b510e47-c996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_CreutzfeldtJakobDisease",
                    ValueSetName = "Lab Result (Creutzfeldt-Jakob disease)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4020",
                    DefinitionText = "lab results associated with Creutzfeldt-Jakob disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb61945c-c996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Botulism",
                    ValueSetName = "Lab Test Name (Botulism)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4125",
                    DefinitionText = "lab tests associated with Botulism",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b4f506b-c996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Cryptococcosis",
                    ValueSetName = "Lab Result (Cryptococcosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4021",
                    DefinitionText = "lab results associated with Cryptococcosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3bb4d48a-c996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Cryptosporidiosis",
                    ValueSetName = "Lab Result (Cryptosporidiosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4022",
                    DefinitionText = "lab results associated with Cryptosporidiosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b152ba0-c996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_CaliforniaSerogroupVirus",
                    ValueSetName = "Lab Test Name (California serogroup virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4127",
                    DefinitionText = "lab tests associated with California serogroup virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9bb79db0-c996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Cyclosporiasis",
                    ValueSetName = "Lab Result (Cyclosporiasis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4023",
                    DefinitionText = "lab results associated with Cyclosporiasis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fba44ad0-c996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Cysticercosis",
                    ValueSetName = "Lab Result (Cysticercosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4024",
                    DefinitionText = "lab results associated with Cysticercosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb5153ec-c996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Campylobacteriosis",
                    ValueSetName = "Lab Test Name (Campylobacteriosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4128",
                    DefinitionText = "lab tests associated with Campylobacteriosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5beb57f7-c996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Dengue",
                    ValueSetName = "Lab Result (Dengue)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4025",
                    DefinitionText = "lab results associated with Dengue",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5be97719-ca96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Diphtheria",
                    ValueSetName = "Lab Result (Diphtheria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4026",
                    DefinitionText = "lab results associated with Diphtheria",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b60d721-ca96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Arbovirus",
                    ValueSetName = "Lab Test Name (Arbovirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4120",
                    DefinitionText = "lab tests associated with Arbovirus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb2d615e-ca96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Chagas",
                    ValueSetName = "Lab Test Name (Chagas)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4129",
                    DefinitionText = "lab tests associated with Chagas",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b433a82-ca96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Ebolavirus",
                    ValueSetName = "Lab Result (Ebolavirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4028",
                    DefinitionText = "lab results (SNOMED) associated with Ebola virus. Ebola 2014 outbreak Zaire strain SNOMED code (425092008)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dbdb70a0-ca96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Chancroid",
                    ValueSetName = "Lab Test Name (Chancroid)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4130",
                    DefinitionText = "lab tests associated with Chancroid",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7ba5a6ac-ca96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_EcoliSTEC",
                    ValueSetName = "Lab Result (E. coli STEC)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4029",
                    DefinitionText = "lab results associated with E. coli STEC",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b6fafeb-ca96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_ChlamydiaTrachomatis",
                    ValueSetName = "Lab Test Name (Chlamydia trachomatis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4131",
                    DefinitionText = "lab tests associated with Chlamydia trachomatis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b43e52d-cb96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Cholera",
                    ValueSetName = "Lab Test Name (Cholera)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4132",
                    DefinitionText = "lab tests associated with Cholera",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7bf79c51-cb96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_ClostridiumPerfringens",
                    ValueSetName = "Lab Test Name (Clostridium perfringens)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4133",
                    DefinitionText = "lab tests associated with Clostridium perfringens",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb66b77c-cb96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Coccidioidomycosis",
                    ValueSetName = "Lab Test Name (Coccidioidomycosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4134",
                    DefinitionText = "lab tests associated with Coccidioidomycosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9b1f06b3-cb96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_ColoradoTickFever",
                    ValueSetName = "Lab Test Name (Colorado Tick Fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4135",
                    DefinitionText = "lab tests associated with Colorado Tick Fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1bbb58ea-cb96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Cryptococcosis",
                    ValueSetName = "Lab Test Name (Cryptococcosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4137",
                    DefinitionText = "lab tests associated with Cryptococcosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b0ea03e-cc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Cryptosporidiosis",
                    ValueSetName = "Lab Test Name (Cryptosporidiosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4138",
                    DefinitionText = "lab tests associated with Cryptosporidiosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9b42e16b-cc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Cyclosporiasis",
                    ValueSetName = "Lab Test Name (Cyclosporiasis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4139",
                    DefinitionText = "lab tests associated with Cyclosporiasis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7ba6979e-cc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Cysticercosis",
                    ValueSetName = "Lab Test Name (Cysticercosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4140",
                    DefinitionText = "lab tests associated with Cysticercosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5be324cf-cc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Dengue",
                    ValueSetName = "Lab Test Name (Dengue)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4141",
                    DefinitionText = "lab tests associated with Dengue",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b57b40a-cd96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Diphtheria",
                    ValueSetName = "Lab Test Name (Diphtheria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4142",
                    DefinitionText = "lab tests associated with Diphtheria",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb21818d-cd96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_EasternEquineEncephalitisVirus",
                    ValueSetName = "Lab Test Name (Eastern equine encephalitis virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4143",
                    DefinitionText = "lab tests associated with Eastern equine encephalitis virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bbe1afbc-cd96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_EcoliSTEC",
                    ValueSetName = "Lab Test Name (E. coli STEC)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4145",
                    DefinitionText = "lab tests associated with E. coli STEC",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fbad67e8-cd96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_EhrlichiaChaffeensis",
                    ValueSetName = "Lab Test Name (Ehrlichia chaffeensis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4146",
                    DefinitionText = "lab tests associated with Ehrlichia chaffeensis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b973d15-ce96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_EhrlichiaEwingii",
                    ValueSetName = "Lab Test Name (Ehrlichia ewingii)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4147",
                    DefinitionText = "lab tests associated with Ehrlichia ewingii",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fbe9084e-ce96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_EhrlichiosisAnaplasmosis",
                    ValueSetName = "Lab Test Name (Ehrlichiosis Anaplasmosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4148",
                    DefinitionText = "lab tests associated with Ehrlichiosis Anaplasmosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b581817-d696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Giardiasis",
                    ValueSetName = "Lab Test Name (Giardiasis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4149",
                    DefinitionText = "lab tests associated with Giardiasis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb6c8e19-d796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Glanders",
                    ValueSetName = "Lab Test Name (Glanders)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4150",
                    DefinitionText = "lab tests associated with Glanders",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fbced841-d796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Gonorrhea",
                    ValueSetName = "Lab Test Name (Gonorrhea)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4151",
                    DefinitionText = "lab tests associated with Gonorrhea",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dba80d7d-d796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_GranulomaInguinale",
                    ValueSetName = "Lab Test Name (Granuloma Inguinale)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4152",
                    DefinitionText = "lab tests associated with Granuloma Inguinale",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b3da2bd-d796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_HaemophilusInfluenzae",
                    ValueSetName = "Lab Test Name (Haemophilus influenzae)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4153",
                    DefinitionText = "lab tests associated with Haemophilus influenzae",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b92ebf1-d796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_HantavirusPulmonarySyndrome",
                    ValueSetName = "Lab Test Name (Hantavirus Pulmonary Syndrome)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4155",
                    DefinitionText = "lab tests associated with Hantavirus Pulmonary Syndrome",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bbf01a23-d896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_HepatitisA",
                    ValueSetName = "Lab Test Name (Hepatitis A)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4157",
                    DefinitionText = "lab tests associated with Hepatitis A",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dbcf0751-d896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_HepatitisB",
                    ValueSetName = "Lab Test Name (Hepatitis B)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4158",
                    DefinitionText = "lab tests associated with Hepatitis B",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dbcb3482-d896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_HepatitisC",
                    ValueSetName = "Lab Test Name (Hepatitis C)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4159",
                    DefinitionText = "lab tests associated with Hepatitis C",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3bee21ad-d896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_HepatitisD",
                    ValueSetName = "Lab Test Name (Hepatitis D)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4160",
                    DefinitionText = "lab tests associated with Hepatitis D",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dbf7b8da-d896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_HepatitisE",
                    ValueSetName = "Lab Test Name (Hepatitis E)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4161",
                    DefinitionText = "lab tests associated with Hepatitis E",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb85da4e-d996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_HerpesSimplex",
                    ValueSetName = "Lab Test Name (Herpes Simplex)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4162",
                    DefinitionText = "lab tests associated with Herpes Simplex",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b0a4393-d996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Histoplasmosis",
                    ValueSetName = "Lab Test Name (Histoplasmosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4163",
                    DefinitionText = "lab tests associated with Histoplasmosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9bf5dabf-d996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_HIV",
                    ValueSetName = "Lab Test Name (HIV)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4164",
                    DefinitionText = "lab tests associated with HIV",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db6742f5-d996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_InfluenzaAH1N12009strain",
                    ValueSetName = "Lab Test Name (Influenza A virus, H1N1 2009 strain)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4165",
                    DefinitionText = "lab tests associated with Influenza A virus, H1N1 2009 strain",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb180426-da96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_JamestownCanyonVirus",
                    ValueSetName = "Lab Test Name (Jamestown Canyon virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4166",
                    DefinitionText = "lab tests associated with Jamestown Canyon virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 12, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1bd3a72f-da96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_EhrlichiaChaffeensis",
                    ValueSetName = "Lab Result (Ehrlichia chaffeensis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4030",
                    DefinitionText = "lab results associated with Ehrlichia chaffeensis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb99fa5b-da96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_EhrlichiaEwingii",
                    ValueSetName = "Lab Result (Ehrlichia ewingii)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4031",
                    DefinitionText = "lab results associated with Ehrlichia ewingii",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b3b0464-da96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Legionellosis",
                    ValueSetName = "Lab Test Name (Legionellosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4167",
                    DefinitionText = "lab tests associated with Legionellosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9bb3577f-da96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_EhrlichiosisAnaplasmosis",
                    ValueSetName = "Lab Result (Ehrlichiosis Anaplasmosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4032",
                    DefinitionText = "lab results associated with Ehrlichiosis Anaplasmosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db57d093-da96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Leptospirosis",
                    ValueSetName = "Lab Test Name (Leptospirosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4168",
                    DefinitionText = "lab tests associated with Leptospirosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb37adb0-da96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_GenitalWarts",
                    ValueSetName = "Lab Result (Genital Warts)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4033",
                    DefinitionText = "lab results associated with Genital Warts",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7bfa15d7-da96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Listeriosis",
                    ValueSetName = "Lab Test Name (Listeriosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4169",
                    DefinitionText = "lab tests associated with Listeriosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1bf5a50c-db96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Lyme disease",
                    ValueSetName = "Lab Test Name (Lyme disease)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4170",
                    DefinitionText = "lab tests associated with Lyme disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db477145-db96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_LymphogranulomaVenereum",
                    ValueSetName = "Lab Test Name (Lymphogranuloma Venereum)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4171",
                    DefinitionText = "lab tests associated with Lymphogranuloma Venereum",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7bea9062-db96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Giardiasis",
                    ValueSetName = "Lab Result (Giardiasis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4034",
                    DefinitionText = "lab results associated with Giardiasis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b280e82-db96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Glanders",
                    ValueSetName = "Lab Result (Glanders)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4035",
                    DefinitionText = "lab results associated with Glanders",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b867d93-db96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Malaria",
                    ValueSetName = "Lab Test Name (Malaria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4172",
                    DefinitionText = "lab tests associated with Malaria",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b2856aa-db96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Gonorrhea",
                    ValueSetName = "Lab Result (Gonorrhea)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4036",
                    DefinitionText = "lab results associated with Gonorrhea",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fbd168d3-db96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Measles",
                    ValueSetName = "Lab Test Name (Measles)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4174",
                    DefinitionText = "lab tests associated with Measles",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("01d268d3-db96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_GranulomaInguinale",
                    ValueSetName = "Lab Result (Granuloma Inguinale)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4037",
                    DefinitionText = "lab results associated with Granuloma Inguinale",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b1cb3f3-db96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_HaemophilusInfluenzae",
                    ValueSetName = "Lab Result (Haemophilus influenzae)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4038",
                    DefinitionText = "lab results associated with Haemophilus influenzae",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5bc43710-dc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_HansensDisease",
                    ValueSetName = "Lab Result (Hansen's Disease)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4039",
                    DefinitionText = "lab results associated with Hansen's Disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb235730-dc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_HantavirusPulmonarySyndrome",
                    ValueSetName = "Lab Result (Hantavirus Pulmonary Syndrome)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4040",
                    DefinitionText = "lab results associated with Hantavirus Pulmonary Syndrome",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c1235730-dc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Melioidosis",
                    ValueSetName = "Lab Test Name (Melioidosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4175",
                    DefinitionText = "lab tests associated with Melioidosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb2c8555-dc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_HendraVirus",
                    ValueSetName = "Lab Result (Hendra virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4041",
                    DefinitionText = "lab results associated with Hendra virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fba7ce63-dc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_MeningococcalDisease",
                    ValueSetName = "Lab Test Name (Meningococcal Disease)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4176",
                    DefinitionText = "lab tests associated with Meningococcal Disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b544c75-dc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_HepatitisA",
                    ValueSetName = "Lab Result (Hepatitis A)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4042",
                    DefinitionText = "lab results associated with Hepatitis A",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1bde1595-dc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_HepatitisB",
                    ValueSetName = "Lab Result (Hepatitis B)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4043",
                    DefinitionText = "lab results associated with Hepatitis B",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1bb6fca3-dc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Yersiniosis",
                    ValueSetName = "Lab Test Name (Yersiniosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4231",
                    DefinitionText = "lab tests associated with Yersiniosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 8, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b7db4b4-dc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_HepatitisC",
                    ValueSetName = "Lab Result (Hepatitis C)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4044",
                    DefinitionText = "lab results associated with Hepatitis C",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 4, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb0da2d1-dc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_YellowFever",
                    ValueSetName = "Lab Test Name (Yellow Fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4230",
                    DefinitionText = "lab tests associated with Yellow Fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 18)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("010ea2d1-dc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_HepatitisD",
                    ValueSetName = "Lab Result (Hepatitis D)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4045",
                    DefinitionText = "lab results associated with Hepatitis D",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db2c0eff-dc96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_WestNileVirus",
                    ValueSetName = "Lab Test Name (West Nile virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4229",
                    DefinitionText = "lab tests associated with West Nile virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3bc5661f-dd96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_HepatitisE",
                    ValueSetName = "Lab Result (Hepatitis E)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4046",
                    DefinitionText = "lab results associated with Hepatitis E",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3ba7582f-dd96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_WesternEquineEncephalitisVirus",
                    ValueSetName = "Lab Test Name (Western equine encephalitis virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4228",
                    DefinitionText = "lab tests associated with Western equine encephalitis virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb2f7240-dd96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_HerpesSimplex",
                    ValueSetName = "Lab Result (Herpes Simplex)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4047",
                    DefinitionText = "lab results associated with Herpes Simplex",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5bc18461-dd96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_ViralHemorrhagicFever",
                    ValueSetName = "Lab Test Name (Viral Hemorrhagic Fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4225",
                    DefinitionText = "lab tests associated with Viral Hemorrhagic Fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 1, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db247b74-dd96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Histoplasmosis",
                    ValueSetName = "Lab Result (Histoplasmosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4048",
                    DefinitionText = "lab results associated with Histoplasmosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b6eb3a3-dd96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_HIV",
                    ValueSetName = "Lab Result (HIV)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4049",
                    DefinitionText = "lab results associated with HIV",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3be029c8-dd96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_InfluenzaAH1N12009strain",
                    ValueSetName = "Lab Result (Influenza A virus, H1N1 2009 strain)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4050",
                    DefinitionText = "lab results associated with Influenza A virus, H1N1 2009 strain",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 1, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b3663eb-dd96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_VibriosisNonCholera",
                    ValueSetName = "Lab Test Name (Non-Cholera Vibrio)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4224",
                    DefinitionText = "lab tests associated with Non-Cholera Vibrio",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 18)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b823b18-de96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_VesicularStomatitis",
                    ValueSetName = "Lab Test Name (Vesicular Stomatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4223",
                    DefinitionText = "lab tests associated with Vesicular Stomatitis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 2, 18)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb48372d-de96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_JamestownCanyonVirus",
                    ValueSetName = "Lab Result (Jamestown Canyon virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4051",
                    DefinitionText = "lab results associated with Jamestown Canyon virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db20403e-de96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Varicella",
                    ValueSetName = "Lab Test Name (Varicella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4222",
                    DefinitionText = "lab tests associated with Varicella",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bbbe0c4d-de96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Legionellosis",
                    ValueSetName = "Lab Result (Legionellosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4052",
                    DefinitionText = "lab results associated with Legionellosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5beabd72-de96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Leptospirosis",
                    ValueSetName = "Lab Result (Leptospirosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4053",
                    DefinitionText = "lab results associated with Leptospirosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dbfe7192-de96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Listeriosis",
                    ValueSetName = "Lab Result (Listeriosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4054",
                    DefinitionText = "lab results associated with Listeriosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e1fe7192-de96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_VancomycinResistantEnterococcus",
                    ValueSetName = "Lab Test Name (Vancomycin resistant Enterococcus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4221",
                    DefinitionText = "lab tests associated with Vancomycin resistant Enterococcus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9bc196b4-de96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Lyme disease",
                    ValueSetName = "Lab Result (Lyme disease)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4055",
                    DefinitionText = "lab results associated with Lyme disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db9031c0-de96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Vaccinia",
                    ValueSetName = "Lab Test Name (Vaccinia)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4220",
                    DefinitionText = "lab tests associated with Vaccinia",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9b7d88ea-de96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_LymphogranulomaVenereum",
                    ValueSetName = "Lab Result (Lymphogranuloma Venereum)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4056",
                    DefinitionText = "lab results associated with Lymphogranuloma Venereum",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5be037f7-de96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_TyphusGroupRickettsiosis",
                    ValueSetName = "Lab Test Name (Typhus group rickettsiosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4219",
                    DefinitionText = "lab tests associated with Typhus group rickettsiosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb6d8214-df96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Malaria",
                    ValueSetName = "Lab Result (Malaria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4057",
                    DefinitionText = "lab results associated with Malaria",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb524c39-df96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_TyphoidFever",
                    ValueSetName = "Lab Test Name (Typhoid Fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4218",
                    DefinitionText = "lab tests associated with Typhoid Fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dbf14170-df96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Tularemia",
                    ValueSetName = "Lab Test Name (Tularemia)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4217",
                    DefinitionText = "lab tests associated withTularemia",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fbcc35a9-df96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Tuberculosis",
                    ValueSetName = "Lab Test Name (Tuberculosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4216",
                    DefinitionText = "lab tests associated with Tuberculosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db945ae6-df96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Trichinellosis",
                    ValueSetName = "Lab Test Name (Trichinellosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4215",
                    DefinitionText = "lab tests associated with Trichinellosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bbc6ec26-e096-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Toxoplasmosis",
                    ValueSetName = "Lab Test Name (Toxoplasmosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4214",
                    DefinitionText = "lab tests associated with Toxoplasmosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1ba9d78f-e096-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Tetanus",
                    ValueSetName = "Lab Test Name (Tetanus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4213",
                    DefinitionText = "lab tests associated with Tetanus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b8dcfa3-e096-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Marburgvirus",
                    ValueSetName = "Lab Result (Marburgvirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4058",
                    DefinitionText = "lab results associated with Marburgvirus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b0433d0-e096-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Syphilis",
                    ValueSetName = "Lab Test Name (Syphilis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4212",
                    DefinitionText = "lab tests associated with Syphilis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5bff36d9-e096-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Measles",
                    ValueSetName = "Lab Result (Measles)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4059",
                    DefinitionText = "lab results associated with Measles",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b4d8d01-e196-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_StreptococcusGroupB",
                    ValueSetName = "Lab Test Name (Streptococcus, group B)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4211",
                    DefinitionText = "lab tests associated with Streptococcus, group B",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b5ac72e-e196-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Melioidosis",
                    ValueSetName = "Lab Result (Melioidosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4060",
                    DefinitionText = "lab results associated with Melioidosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1bedc93e-e196-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_StreptococcusGroupA",
                    ValueSetName = "Lab Test Name (Streptococcus, group A)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4210",
                    DefinitionText = "lab tests associated with Streptococcus, group A",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db214e4e-e196-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_MeningococcalDisease",
                    ValueSetName = "Lab Result (Meningococcal Disease)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4061",
                    DefinitionText = "lab results associated with Meningococcal Disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5bb58875-e196-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_StrepPneumo",
                    ValueSetName = "Lab Test Name (Streptococcus pneumoniae)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4208",
                    DefinitionText = "lab tests associated with Streptococcus pneumoniae",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb57d983-e196-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_MonkeypoxOrthopox",
                    ValueSetName = "Lab Result (Monkeypox Orthopox)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4062",
                    DefinitionText = "lab results associated with Monkeypox Orthopox",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fbde46aa-e196-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_StLouisEncephalitisVirus",
                    ValueSetName = "Lab Test Name (St. Louis encephalitis virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4207",
                    DefinitionText = "lab tests associated with St. Louis encephalitis virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 1, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb40afb0-e196-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_MRSA",
                    ValueSetName = "Lab Result (MRSA)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4063",
                    DefinitionText = "lab results associated with Methicillin resistant Staphylococcus aureus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb6f47da-e196-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Mumps",
                    ValueSetName = "Lab Result (Mumps)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4064",
                    DefinitionText = "lab results associated with Mumps",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bbf4f200-e296-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_NipahVirus",
                    ValueSetName = "Lab Result (Nipah Virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4065",
                    DefinitionText = "lab results associated with Nipah Virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c1f4f200-e296-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_StaphylococcalTSS",
                    ValueSetName = "Lab Test Name (Staphylococcal TSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4206",
                    DefinitionText = "lab tests associated with Staphylococcal TSS",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dbbbbd24-e296-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_NongonococcalUrethritis",
                    ValueSetName = "Lab Result (Nongonococcal Urethritis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4066",
                    DefinitionText = "lab results associated with Nongonococcal Urethritis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b78232e-e296-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_StaphAureusFoodPoisoning",
                    ValueSetName = "Lab Test Name (Staphylococcus aureus food poisoning)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4205",
                    DefinitionText = "lab tests associated with Staphylococcus aureus food poisoning",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3bf9d55f-e296-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_StaphAureusEnterotoxinB",
                    ValueSetName = "Lab Test Name (Staphylococcus aureus enterotoxin B)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4204",
                    DefinitionText = "lab tests associated with Staphylococcus aureus enterotoxin B",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("41f9d55f-e296-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_NontuberculousMycobacteria",
                    ValueSetName = "Lab Result (Nontuberculous Mycobacteria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4067",
                    DefinitionText = "lab results associated with Nontuberculous Mycobacteria",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b7f8488-e296-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Norovirus",
                    ValueSetName = "Lab Result (Norovirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4068",
                    DefinitionText = "lab results associated with Norovirus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("417f8488-e296-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_StaphAureus",
                    ValueSetName = "Lab Test Name (Staphylococcus aureus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4203",
                    DefinitionText = "lab tests associated with Staphylococcus aureus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db29bcb5-e296-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResultRCMT_Pertussis",
                    ValueSetName = "Lab Result RCMT (Pertussis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4069",
                    DefinitionText = "lab results associated with Pertussis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e129bcb5-e296-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_SpottedFeverRickettsiosis",
                    ValueSetName = "Lab Test Name (Spotted fever rickettsiosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4202",
                    DefinitionText = "lab tests associated with Spotted fever rickettsiosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb9371e1-e296-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Smallpox",
                    ValueSetName = "Lab Test Name (Smallpox)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4201",
                    DefinitionText = "lab tests associated with Smallpox",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c19371e1-e296-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Plague",
                    ValueSetName = "Lab Result (Plague)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4070",
                    DefinitionText = "lab results associated with Plague",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b05b412-e396-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Polio",
                    ValueSetName = "Lab Result (Polio)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4071",
                    DefinitionText = "lab results associated with Polio",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2105b412-e396-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Shigella",
                    ValueSetName = "Lab Test Name (Shigella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4200",
                    DefinitionText = "lab tests associated with Shigella",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b5d373e-e396-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_PowassanVirus",
                    ValueSetName = "Lab Result (Powassan virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4072",
                    DefinitionText = "lab results associated with Powassan virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("215d373e-e396-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_SARS",
                    ValueSetName = "Lab Test Name (SARS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4199",
                    DefinitionText = "lab tests associated with SARS",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b8c6961-e396-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_PrionDisease",
                    ValueSetName = "Lab Result (Prion Disease)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4073",
                    DefinitionText = "lab results associated with Prion Disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb26a683-e396-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Psittacosis",
                    ValueSetName = "Lab Result (Psittacosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4074",
                    DefinitionText = "lab results associated with Psittacosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c126a683-e396-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Salmonellosis",
                    ValueSetName = "Lab Test Name (Salmonellosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4198",
                    DefinitionText = "lab tests associated with Salmonellosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9b13dbab-e396-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Q Fever",
                    ValueSetName = "Lab Result (Q Fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4075",
                    DefinitionText = "lab results associated with Q Fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b4c6bc3-e396-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Rubella",
                    ValueSetName = "Lab Test Name (Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4197",
                    DefinitionText = "lab tests associated with Rubella",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fbe775d2-e396-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Rabies",
                    ValueSetName = "Lab Result (Rabies)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4076",
                    DefinitionText = "lab results associated with Rabies",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dba67ffd-e396-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Rotavirus",
                    ValueSetName = "Lab Test Name (Rotavirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4196",
                    DefinitionText = "lab tests associated with Rotavirus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9bbef81e-e496-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_RelapsingFever",
                    ValueSetName = "Lab Result (Relapsing Fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4077",
                    DefinitionText = "lab results associated with Relapsing Fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3bc77937-e496-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_RiftValleyFever",
                    ValueSetName = "Lab Test Name (Rift Valley Fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4195",
                    DefinitionText = "lab tests associated with Rift Valley Fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b22e042-e496-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_RespiratorySyncytialVirus",
                    ValueSetName = "Lab Result (Respiratory Syncytial Virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4078",
                    DefinitionText = "lab results associated with Respiratory Syncytial Virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dbd11367-e496-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_RickettsialInfectionOther",
                    ValueSetName = "Lab Test Name (Rickettsial infection, other)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4194",
                    DefinitionText = "lab tests associated with Rickettsial infection, other",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e1d11367-e496-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_RickettsialInfectionOther",
                    ValueSetName = "Lab Result (Rickettsial infection, other)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4079",
                    DefinitionText = "lab results associated with Rickettsial infection, other",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3bbbc791-e496-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_RiftValleyFever",
                    ValueSetName = "Lab Result (Rift Valley Fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4080",
                    DefinitionText = "lab results associated with Rift Valley Fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b7f549a-e496-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_MonkeypoxOrthopox",
                    ValueSetName = "Lab Test Name (Monkeypox Orthopox)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4177",
                    DefinitionText = "lab tests associated with Monkeypox Orthopox",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b94e6b7-e496-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Rotavirus",
                    ValueSetName = "Lab Result (Rotavirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4081",
                    DefinitionText = "lab results associated with Rotavirus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1bbf2ed5-e496-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_MRSA",
                    ValueSetName = "Lab Test Name (MRSA)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4178",
                    DefinitionText = "lab tests associated with Methicillin resistant Staphylococcus aureus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fbb04ce1-e496-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResultRCMT_Rubella",
                    ValueSetName = "Lab Result RCMT (Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4082",
                    DefinitionText = "lab results associated with Rubella",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fbf3b608-e596-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Mumps",
                    ValueSetName = "Lab Test Name (Mumps)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4179",
                    DefinitionText = "lab tests associated with Mumps",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7bd1372c-e596-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_RespiratorySyncytialVirus",
                    ValueSetName = "Lab Test Name (Respiratory Syncytial Virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4193",
                    DefinitionText = "lab tests associated with Respiratory Syncytial Virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3bdf9239-e596-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Salmonellosis",
                    ValueSetName = "Lab Result (Salmonellosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4083",
                    DefinitionText = "lab results associated with Salmonellosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b998d5a-e596-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_SARS",
                    ValueSetName = "Lab Result (SARS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4084",
                    DefinitionText = "lab results associated with SARS",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db379280-e596-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_NongonococcalUrethritis",
                    ValueSetName = "Lab Test Name (Nongonococcal Urethritis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4181",
                    DefinitionText = "lab tests associated with Nongonococcal Urethritis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b987f8d-e596-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Shigella",
                    ValueSetName = "Lab Result (Shigella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4085",
                    DefinitionText = "lab results associated with Shigella",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3badcda6-e596-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_RelapsingFever",
                    ValueSetName = "Lab Test Name (Relapsing Fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4192",
                    DefinitionText = "lab tests associated with Relapsing Fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("41adcda6-e596-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Smallpox",
                    ValueSetName = "Lab Result (Smallpox)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4086",
                    DefinitionText = "lab results associated with Smallpox",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7ba2b4d8-e596-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_SpottedFeverRickettsiosis",
                    ValueSetName = "Lab Result (Spotted fever rickettsiosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4087",
                    DefinitionText = "lab results associated with Spotted fever rickettsiosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b7895e3-e596-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_NontuberculousMycobacteria",
                    ValueSetName = "Lab Test Name (Nontuberculous Mycobacteria)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4182",
                    DefinitionText = "lab tests associated with Nontuberculous Mycobacteria",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb9c6610-e696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_StaphAureus",
                    ValueSetName = "Lab Result (Staphylococcus aureus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4088",
                    DefinitionText = "lab results associated with Staphylococcus aureus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("019d6610-e696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Rabies",
                    ValueSetName = "Lab Test Name (Rabies)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4191",
                    DefinitionText = "lab tests associated with Rabies",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb190d3a-e696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_StaphAureusEnterotoxinB",
                    ValueSetName = "Lab Result (Staphylococcus aureus enterotoxin B)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4089",
                    DefinitionText = "lab results associated with Staphylococcus aureus enterotoxin B",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b7f3a42-e696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Norovirus",
                    ValueSetName = "Lab Test Name (Norovirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4183",
                    DefinitionText = "lab tests associated with Norovirus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb002167-e696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_StaphAureusFoodPoisoning",
                    ValueSetName = "Lab Result (Staphylococcus aureus food poisoning)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4090",
                    DefinitionText = "lab results associated with Staphylococcus aureus food poisoning",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("01012167-e696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Q Fever",
                    ValueSetName = "Lab Test Name (Q Fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4190",
                    DefinitionText = "lab tests associated with Q Fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5bccb38e-e696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_StaphylococcalTSS",
                    ValueSetName = "Lab Result (Staphylococcal TSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4091",
                    DefinitionText = "lab results associated with Staphylococcal TSS",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b2d3b95-e696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Pertussis",
                    ValueSetName = "Lab Test Name (Pertussis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4184",
                    DefinitionText = "lab tests associated with Pertussis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 7, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9b20e7ad-e696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_StLouisEncephalitisVirus",
                    ValueSetName = "Lab Result (St. Louis encephalitis virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4092",
                    DefinitionText = "lab results associated with St. Louis encephalitis virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7bcebdb6-e696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Psittacosis",
                    ValueSetName = "Lab Test Name (Psittacosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4189",
                    DefinitionText = "lab tests associated with Psittacosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 4, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1bfd64cf-e696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_StrepPneumo",
                    ValueSetName = "Lab Result (Streptococcus pneumoniae)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4093",
                    DefinitionText = "lab results associated with Streptococcus pneumoniae",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb13fdf0-e696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_StreptococcalTSS",
                    ValueSetName = "Lab Result (Streptococcal TSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4094",
                    DefinitionText = "lab results associated with Streptococcal TSS",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7ba6ddfe-e696-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Plague",
                    ValueSetName = "Lab Test Name (Plague)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4185",
                    DefinitionText = "lab tests associated with Plague",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb310016-e796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_StreptococcusGroupA",
                    ValueSetName = "Lab Result (Streptococcus, group A)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4095",
                    DefinitionText = "lab results associated with Streptococcus, group A",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b6b0825-e796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_PrionDisease",
                    ValueSetName = "Lab Test Name (Prion Disease)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4188",
                    DefinitionText = "lab tests associated with Prion Disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7bd96352-e796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_Polio",
                    ValueSetName = "Lab Test Name (Polio)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4186",
                    DefinitionText = "lab tests associated with Polio",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b764f61-e796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_StreptococcusGroupB",
                    ValueSetName = "Lab Result (Streptococcus, group B)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4096",
                    DefinitionText = "lab results associated with Streptococcus, group B",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b843579-e796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestName_PowassanVirus",
                    ValueSetName = "Lab Test Name (Powassan virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4187",
                    DefinitionText = "lab tests associated with Powassan virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 12, 17)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db1d7e88-e796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Syphilis",
                    ValueSetName = "Lab Result (Syphilis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4097",
                    DefinitionText = "lab results associated with Syphilis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5be9eead-e796-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Tetanus",
                    ValueSetName = "Lab Result (Tetanus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4098",
                    DefinitionText = "lab results associated with Tetanus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fbeacc2a-e896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Toxoplasmosis",
                    ValueSetName = "Lab Result (Toxoplasmosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4099",
                    DefinitionText = "lab results associated with Toxoplasmosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9b46c264-e896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Trichinellosis",
                    ValueSetName = "Lab Result (Trichinellosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4100",
                    DefinitionText = "lab results associated with Trichinellosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9b08b393-e896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Tuberculosis",
                    ValueSetName = "Lab Result (Tuberculosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4101",
                    DefinitionText = "lab results associated with Tuberculosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 1, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9bd3bed4-e896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Tularemia",
                    ValueSetName = "Lab Result (Tularemia)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4102",
                    DefinitionText = "lab results associated withTularemia",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb3428fd-e896-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_TyphoidFever",
                    ValueSetName = "Lab Result (Typhoid Fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4103",
                    DefinitionText = "lab results associated with Typhoid Fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bbb0de37-e996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_TyphusGroupRickettsiosis",
                    ValueSetName = "Lab Result (Typhus group rickettsiosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4104",
                    DefinitionText = "lab results associated with Typhus group rickettsiosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b05f478-e996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Vaccinia",
                    ValueSetName = "Lab Result (Vaccinia)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4105",
                    DefinitionText = "lab results associated with Vaccinia",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b7059b3-e996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_VancomycinResistantEnterococcus",
                    ValueSetName = "Lab Result (Vancomycin resistant Enterococcus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4106",
                    DefinitionText = "lab results associated with Vancomycin resistant Enterococcus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7be0fee8-e996-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Varicella",
                    ValueSetName = "Lab Result (Varicella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4107",
                    DefinitionText = "lab results associated with Varicella",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b6de421-ea96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_VesicularStomatitis",
                    ValueSetName = "Lab Result (Vesicular Stomatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4108",
                    DefinitionText = "lab results associated with Vesicular Stomatitis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb404b55-ea96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_VibriosisNonCholera",
                    ValueSetName = "Lab Result (Vibriosis, non-cholera)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4109",
                    DefinitionText = "lab results associated with Vibriosis, non-cholera",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b486487-ea96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_ViralHemorrhagicFever",
                    ValueSetName = "Lab Result (Viral Hemorrhagic Fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4110",
                    DefinitionText = "lab results associated with Viral Hemorrhagic Fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9b9893e6-ea96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_VISA",
                    ValueSetName = "Lab Result (VISA)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4111",
                    DefinitionText = "lab results associated with Vancomycin intermediate Staphylococcus aureus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b0ead0a-eb96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_VRSA",
                    ValueSetName = "Lab Result (VRSA)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4112",
                    DefinitionText = "lab results associated with Vancomycin resistant Staphylococcus aureus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3ba84f33-eb96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_WesternEquineEncephalitisVirus",
                    ValueSetName = "Lab Result (Western equine encephalitis virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4113",
                    DefinitionText = "lab results associated with Western equine encephalitis virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b0cb372-eb96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_WestNileVirus",
                    ValueSetName = "Lab Result (West Nile virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4114",
                    DefinitionText = "lab results associated with West Nile virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb6cf796-eb96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_YellowFever",
                    ValueSetName = "Lab Result (Yellow Fever)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4115",
                    DefinitionText = "lab results associated with Yellow Fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1bb60dc4-eb96-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_Yersiniosis",
                    ValueSetName = "Lab Result (Yersiniosis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4116",
                    DefinitionText = "lab results associated with Yersiniosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db8d965b-6d97-e011-a0bd-00188b39829b"),
                    ValueSetCode = "PHVS_LabResult_EasternEquineEncephalitisVirus",
                    ValueSetName = "Lab Result (Eastern equine encephalitis virus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.4027",
                    DefinitionText = "lab results associated with Eastern equine encephalitis virus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4ed384c0-9676-e011-a0ea-00188b39829b"),
                    ValueSetCode = "PHVS_UniversalIdentiferType_PHLIP",
                    ValueSetName = "Universal Identifier (HL7) (PHLIP)",
                    ValueSetOID = "2.16.840.1.114222.4.11.5000",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ee9ff406-9a76-e011-a0ea-00188b39829b"),
                    ValueSetCode = "PHVS_OrderControlCodes_PHLIP",
                    ValueSetName = "Order Control Codes (HL7) (PHLIP)",
                    ValueSetOID = "2.16.840.1.114222.4.11.5002",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6ea77804-9b76-e011-a0ea-00188b39829b"),
                    ValueSetCode = "PHVS_LabTestOrder_PHLIP_Sal",
                    ValueSetName = "Lab Test Order (PHLIP Sal)",
                    ValueSetOID = "2.16.840.1.114222.4.11.5005",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2ea31aff-4677-e011-a0ea-00188b39829b"),
                    ValueSetCode = "PHVS_ValueType_PHLIP",
                    ValueSetName = "Value Type (HL7) (PHLIP)",
                    ValueSetOID = "2.16.840.1.114222.4.11.5006",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ae8e8503-4c77-e011-a0ea-00188b39829b"),
                    ValueSetCode = "PHVS_SuspectedAgent_PHLIP_Sal",
                    ValueSetName = "Suspected Agent (PHLIP Sal)",
                    ValueSetOID = "2.16.840.1.114222.4.11.5013",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ae35a179-4d77-e011-a0ea-00188b39829b"),
                    ValueSetCode = "PHVS_ObservationResultStatus_PHLIP",
                    ValueSetName = "Observation Result Status (PHLIP)",
                    ValueSetOID = "2.16.840.1.114222.4.11.5014",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4e239b2b-5377-e011-a0ea-00188b39829b"),
                    ValueSetCode = "PHVS_SpecimenRelObs_PHLIP_Sal",
                    ValueSetName = "Specimen Related Observations (PHLIP Sal)",
                    ValueSetOID = "2.16.840.1.114222.4.11.5007",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("aedc6099-5477-e011-a0ea-00188b39829b"),
                    ValueSetCode = "PHVS_SpecimenRejectReason (SCT) PHLIP",
                    ValueSetName = "Specimen Reject Reason (SCT) (PHLIP)",
                    ValueSetOID = "2.16.840.1.114222.4.11.5004",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 6, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2eb49129-627b-e011-a0ea-00188b39829b"),
                    ValueSetCode = "PHVS_ValueType_IIS",
                    ValueSetName = "Value Type (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3392",
                    DefinitionText = "Value Type (IIS)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("eec1fb18-ee7b-e011-a0ea-00188b39829b"),
                    ValueSetCode = "PHVS_Role_PHLIP",
                    ValueSetName = "Role (PHLIP)",
                    ValueSetOID = "2.16.840.1.114222.4.11.5015",
                    DefinitionText = "Used in ROL.3 - extension of HL70403",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 5, 11)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ae01ed8a-ee7b-e011-a0ea-00188b39829b"),
                    ValueSetCode = "PHVS_OrganizationUnit_PHLIP",
                    ValueSetName = "Organization Unit (PHLIP)",
                    ValueSetOID = "2.16.840.1.114222.4.11.5016",
                    DefinitionText = "extension of HL70406 for use with ROL.10",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 5, 11)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("eb9623ca-825f-e011-a0ec-00188b39829b"),
                    ValueSetCode = "PHVS_Serogroup_NETSS",
                    ValueSetName = "Serogroup (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3432",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 8, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ab3f07cc-895f-e011-a0ec-00188b39829b"),
                    ValueSetCode = "PHVS_AntimicrobialAgent_NETSS",
                    ValueSetName = "Antimicrobial Agent NETSS",
                    ValueSetOID = "2.16.840.1.114222.4.11.3434",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 4, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6b9250b0-995f-e011-a0ec-00188b39829b"),
                    ValueSetCode = "PHVS_Serotype_NETSS",
                    ValueSetName = "Serotype (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3435",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 8, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a8c949ef-e91f-e011-b71b-00188b39829b"),
                    ValueSetCode = "PHVS_ResultStatus_NETSS",
                    ValueSetName = "Result Status (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3428",
                    DefinitionText = "Result Status (NETSS)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("08bdf425-e623-e011-b71b-00188b39829b"),
                    ValueSetCode = "PHVS_RaceCategory_CDC_Unk",
                    ValueSetName = "Race Category including Unknown",
                    ValueSetOID = "2.16.840.1.114222.4.11.3405",
                    DefinitionText = "Based on CDC Race Category Value Set but included Unknown from the Null Flavor value set.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("081911bc-e324-e011-b71b-00188b39829b"),
                    ValueSetCode = "PHVS_IdentifierType_SyndromicSurveillance",
                    ValueSetName = "Identifier Type (Syndromic Surveillance)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3597",
                    DefinitionText = "Subset of HL7 2.x Identifier Type table (excluding organization identifier)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("087b1183-9c2d-e011-b71b-00188b39829b"),
                    ValueSetCode = "PHVS_WoundDepth_Tetanus_NETSS",
                    ValueSetName = "Wound Depth Tetanus (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3598",
                    DefinitionText = "Wound Depth Tetanus (NETSS)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("084cbe60-9e2d-e011-b71b-00188b39829b"),
                    ValueSetCode = "PHVS_TimePeriod_Tetanus_NETSS",
                    ValueSetName = "Time Period Tetanus (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3599",
                    DefinitionText = "Time Period Tetanus (NETSS)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e861e04d-9f2d-e011-b71b-00188b39829b"),
                    ValueSetCode = "PHVS_StayPeriod_Hepatitis_NETSS",
                    ValueSetName = "Stay Period Hepatitis (NETSS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3600",
                    DefinitionText = "Stay Period Hepatitis (NETSS)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 1, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("79ff5981-7182-df11-bf71-00188b39829b"),
                    ValueSetCode = "PHVS_SusceptibilityResult_IPD",
                    ValueSetName = "Susceptibility Result (IPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3336",
                    DefinitionText = "Susceptibility result for Invasive Pneumococcal Disease (IPD).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("379c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_MedicationReceived_VZ",
                    ValueSetName = "Medication Received (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3147",
                    DefinitionText = "Medication received to treat Varicella",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("389c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_PCRSpecimenSource_VZ",
                    ValueSetName = "PCR Specimen Source (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3148",
                    DefinitionText = "Source of PCR specimen",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("399c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_LabTestMethod_VZ",
                    ValueSetName = "Lab Test Method (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3149",
                    DefinitionText = "Other types of varicella lab testing that may have been performed",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3a9c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_IgMTestType_VZ",
                    ValueSetName = "IgM Test Type (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3150",
                    DefinitionText = "Type of IgM Test for Varicella",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b9c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_IgGTestType_VZ",
                    ValueSetName = "IgG Test Type (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3151",
                    DefinitionText = "Type of IgG Test for Varicella",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3c9c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_WholeCellELISAManufacturer_VZ",
                    ValueSetName = "Whole Cell ELISA Manufacturer (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3152",
                    DefinitionText = "Manufacturer of Whole Cell ELISA test",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3d9c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_gpELISAManufacturer_VZ",
                    ValueSetName = "gp ELISA Manufacturer (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3153",
                    DefinitionText = "Manufacturer of gp ELISA test",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3e9c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_VaccinesAdministered_VZ",
                    ValueSetName = "Vaccines Administered (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3154",
                    DefinitionText = "Varicella-specific vaccines - subset of CVX",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3f9c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_VaccineManufacturer_VZ",
                    ValueSetName = "Vaccine Manufacturer (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3155",
                    DefinitionText = "Varicella-specific vaccine manufacturers",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("409c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_ReportingArea_TB",
                    ValueSetName = "Reporting Area (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3156",
                    DefinitionText = "TB national reporting area",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("419c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_RVCTLinkReason_TB",
                    ValueSetName = "RVCT Link Reason (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3157",
                    DefinitionText = "Reason to explain why linking to another TB case is desired",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("429c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_CaseCountStatus_TB",
                    ValueSetName = "Case Count Status (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3158",
                    DefinitionText = "Case count status for Tuberculosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("439c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_ReportingLabType_NND",
                    ValueSetName = "Reporting Lab Type",
                    ValueSetOID = "2.16.840.1.114222.4.11.3159",
                    DefinitionText = "Type of laboratory reporting the result",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("449c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_MicroscopicExamType_TB",
                    ValueSetName = "Microscopic Exam Type (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3160",
                    DefinitionText = "Type of microscopic examination performed",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("459c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_PrimaryReasonForEvaluation_TB",
                    ValueSetName = "Primary Reason For Evaluation (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3161",
                    DefinitionText = "Primary or initial reason the patient was evaluated for TB disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("469c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_RiskFactors_TB",
                    ValueSetName = "Risk Factors (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3162",
                    DefinitionText = "Additional TB risk factors that the TB patient may have",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("479c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_ImmigrationStatus_NND",
                    ValueSetName = "Immigration Status",
                    ValueSetOID = "2.16.840.1.114222.4.11.3163",
                    DefinitionText = "Patient's immigration status answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("489c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_SputumCultureConversionNotDocumentedReason_TB",
                    ValueSetName = "Sputum Culture Conversion Not Documented Reason",
                    ValueSetOID = "2.16.840.1.114222.4.11.3164",
                    DefinitionText = "The list of reasons for not documenting the sputum culture conversion",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("499c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_CauseOfDeathRelatedTo_TB",
                    ValueSetName = "Cause of Death Related to TB",
                    ValueSetOID = "2.16.840.1.114222.4.11.3166",
                    DefinitionText = "Answer list to indicate whether cause of death was related to TB",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4a9c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_TherapyExtendedReason_TB",
                    ValueSetName = "Therapy Extended Reason (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3167",
                    DefinitionText = "Answer list for the reason the therapy extended beyond 12 months",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4b9c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_EducationLevel_HL7_V3",
                    ValueSetName = "Education Level",
                    ValueSetOID = "2.16.840.1.114222.4.11.3168",
                    DefinitionText = "Highest Level of Education Received",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4c9c28d9-65a0-dd11-8a3f-00188b398520"),
                    ValueSetCode = "PHVS_BirthCountry_TB",
                    ValueSetName = "Birth Country (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3169",
                    DefinitionText = "Country of Birth. This includes current countries as well as historical countries (eg. USSR). This list is derived from ISO 3166-1, ISO 3166-3 (retired countries) and FIPS 10-4 (US Territories, Countries)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 11, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2082b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_XRayBasedPatientCondition_NND",
                    ValueSetName = "Abnormal Chest X-ray Condition Status",
                    ValueSetOID = "2.16.840.1.114222.4.11.1060",
                    DefinitionText = "Patient's condition based on abnormal Chest X-ray results",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2182b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AbnormalChestXRayFinding_TB",
                    ValueSetName = "Abnormal Chest X-Ray Finding (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.957",
                    DefinitionText = "Indicates whether any of the x-rays done at any time during this episode of tuberculosis showed a cavity or cavities, was noncavitary consistent with tuberculosis, or was noncavitary inconsistent with tuberculosis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2282b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AbnormalFlag_HL7_2x",
                    ValueSetName = "Abnormal Flag (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.800",
                    DefinitionText = "HL7 version 2.5 User-Defined Table 0078 Abnormal Flags used for laboratory result interpretation",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2382b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AcknowledgmentCode_HL7_2x",
                    ValueSetName = "Acknowledgment Code (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.958",
                    DefinitionText = "Acknowledgment code indicating receipt of message.  (See message processing rules.  Refer to HL7 Table 0008 - Acknowledgment code for valid values.)  Null flavors are not allowed.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2482b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AcuteConvalescentIgGDiff_VPD",
                    ValueSetName = "Acute Convalescent IgG Difference (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3119",
                    DefinitionText = "Answer list of interpretative results of the difference between the values for the acute and convalescent IgG tests",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2582b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AdditionalDiseaseSite_TB",
                    ValueSetName = "Additional Site of Disease (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.959",
                    DefinitionText = "Other body sites where Tuberculosis found",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2682b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AddressType_CDC",
                    ValueSetName = "Address Type",
                    ValueSetOID = "2.16.840.1.114222.4.11.961",
                    DefinitionText = "HL7 version 2.5 Table 0190 Address Type codes.  Information regarding the type of address being passed in the message (e.g., Mailing, Home, Business).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2782b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AddressType_HL7_2x",
                    ValueSetName = "Address Type (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.801",
                    DefinitionText = "Address Type",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2882b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AdministrationDevice_HL7_2x",
                    ValueSetName = "Administration Device (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.802",
                    DefinitionText = "HL7 version 2.5 Table 0164 Administration Device codes used for Substance Administration",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2982b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AdministrationMethod_HL7_2x",
                    ValueSetName = "Administration Method (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.803",
                    DefinitionText = "HL7 version 2.5 Table 0165 Administration Method codes used for Substance Administration",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2a82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AdministrativeSex_HL7_2x",
                    ValueSetName = "Administrative Sex (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.927",
                    DefinitionText = "HL7 version 2.5 User-Defined Table 0001 Administrative sex code",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2b82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AdmissionLevelOfCareCode_HL7_2x",
                    ValueSetName = "Admission Level of Care (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.912",
                    DefinitionText = "HL7 version 2.5 User-Defined Table 0432 Admission Level of Care codes used in ADT messages",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2c82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AdmitSource_HL7_2x",
                    ValueSetName = "Admission Source (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.918",
                    DefinitionText = "HL7 version 2.5 User-Defined Table 0023 Admit Source codes used in ADT messages",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2d82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AdmissionType_HL7_2x",
                    ValueSetName = "Admission Type (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.913",
                    DefinitionText = "HL7 version 2.5 User-Defined Table 0007 Admit Type codes used in ADT messages",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2e82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AdverseEventPreviouslyReported_CDC",
                    ValueSetName = "Adverse Event Previously Reported",
                    ValueSetOID = "2.16.840.1.114222.4.11.964",
                    DefinitionText = "Indicates whether Adverse Event previously reporting, and to whom (Manufacturer, Health Department, Doctor)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2f82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AnimalAgeCategory_NND",
                    ValueSetName = "Age Category (Animal)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3065",
                    DefinitionText = "Age category of animal answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3082b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AgeUnit_UCUM",
                    ValueSetName = "Age unit",
                    ValueSetOID = "2.16.840.1.114222.4.11.878",
                    DefinitionText = "Units of measure for age",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3282b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Allergen_CDC",
                    ValueSetName = "Allergen",
                    ValueSetOID = "2.16.840.1.114222.4.11.834",
                    DefinitionText = "List of specific drug, food and environmental allergens (e.g. Peanut, Penicillin, Pollen)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3382b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AllergenType_HL7_2x",
                    ValueSetName = "Allergen Type (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.806",
                    DefinitionText = "HL7 version 2.5 User-Defined Table 0127 Allergen Type codes",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3482b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AllergySeverity_HL7_2x",
                    ValueSetName = "Allergy Severity (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.807",
                    DefinitionText = "HL7 version 2.5 User-Defined Table 0128 Allergy Severity codes",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3582b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AmplificationAndExtractionKit_CDC",
                    ValueSetName = "Amplification and Extraction Kit",
                    ValueSetOID = "2.16.840.1.114222.4.11.965",
                    DefinitionText = "Amplification and Extraction Kit",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3682b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Animal_CDC",
                    ValueSetName = "Animal",
                    ValueSetOID = "2.16.840.1.114222.4.11.1074",
                    DefinitionText = "Animal Keyword: Animal Type based on SNOMED domain (387961004)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3782b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AnimalSpecies_AnimalRabies",
                    ValueSetName = "Animal Species (Animal Rabies)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3068",
                    DefinitionText = "Animal species answer list for animal rabies",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3882b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AnimalType_FDD",
                    ValueSetName = "Animal Type (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3072",
                    DefinitionText = "Animal contact answer list for Foodborne and Diarrheal Diseases",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3982b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AntibioticReceived_Pertussis",
                    ValueSetName = "Antibiotic Received (Pertussis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3120",
                    DefinitionText = "Antibiotic patient received for Pertussis answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3a82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_BatSpecies_AnimalRabies",
                    ValueSetName = "Bat Species (Animal Rabies)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3066",
                    DefinitionText = "Species of bat answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SubstanceBatchDeactivationReason_CRA",
                    ValueSetName = "Batch Deactivation Reason",
                    ValueSetOID = "2.16.840.1.114222.4.11.1050",
                    DefinitionText = "Reason the prepared substance batch was deactivated",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3c82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_BioSenseRTObservations_CDC",
                    ValueSetName = "BioSense Observations",
                    ValueSetOID = "2.16.840.1.114222.4.11.954",
                    DefinitionText = "Value set for observations used for BioSense RT",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3d82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_BirthAttendees_VPD",
                    ValueSetName = "Birth Attendees (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3121",
                    DefinitionText = "Types of attendees at delivery answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3e82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_BirthLocation_VPD",
                    ValueSetName = "Birth Location (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3122",
                    DefinitionText = "Infant's birth place location answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3f82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_BirthOutcome_VPD",
                    ValueSetName = "Birth Outcome (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3123",
                    DefinitionText = "Infant's birth outcome answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4082b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_BloodContactFrequency_Hepatitis",
                    ValueSetName = "Blood Contact Frequency (Hepatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3024",
                    DefinitionText = "Codes indicating general levels of frequency.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4182b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_BloodPressureUnit_UCUM",
                    ValueSetName = "Blood Pressure Unit",
                    ValueSetOID = "2.16.840.1.114222.4.11.920",
                    DefinitionText = "Units of measure for Blood Pressure",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4282b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_BodyRegion_Tetanus",
                    ValueSetName = "Body Region (Tetanus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3124",
                    DefinitionText = "Anatomic site of acute wound or injury answer list for tetanus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4382b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_BodySite_CDC",
                    ValueSetName = "Body site",
                    ValueSetOID = "2.16.840.1.114222.4.11.967",
                    DefinitionText = "Body site from which specimen taken or where disease or injury occurs. This is based on the SNOMED hierarchy (Anatomical Structure - 91723000) .",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4482b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_BodySite_FDD",
                    ValueSetName = "Body Site (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3117",
                    DefinitionText = "Body site answer list for Foodborne and Diarrheal Diseases",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4582b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_BodySubstance_CDC",
                    ValueSetName = "Body Substance",
                    ValueSetOID = "2.16.840.1.114222.4.11.1067",
                    DefinitionText = "Body Substance based on SNOMED domain (91720002)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4682b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_BotulinumToxinType_FDD",
                    ValueSetName = "Botulinum Toxin Type (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3073",
                    DefinitionText = "Botulism toxin types answer list for Foodborne and Diarrheal Diseases",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4782b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_BotulismFoodSourceType_FDD",
                    ValueSetName = "Botulism Food Source Type (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3070",
                    DefinitionText = "Food source of botulism answer list for Foodborne and Diarrheal Diseases",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4882b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Botulism-like_Syndrome_BT",
                    ValueSetName = "Botulism-like Syndrome (BT)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1089",
                    DefinitionText = "ACUTE condition that may represent exposure to botulinum toxin. ACUTE paralytic conditions consistent with botulism: cranial nerve VI (lateral rectus) palsy, ptosis, dilated pupils, decreased gag reflex, media rectus palsy. ACUTE descending motor paralysis (including muscles of respiration). ACUTE symptoms consistent with botulism: diplopia, dry mouth, dysphagia, difficulty focusing to a near point",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4982b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CancerType_CDC",
                    ValueSetName = "Cancer Type",
                    ValueSetOID = "2.16.840.1.114222.4.11.3058",
                    DefinitionText = "Types of cancer answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4a82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CaseClassificationExposureSource_NND",
                    ValueSetName = "Case Classification Exposure Source",
                    ValueSetOID = "2.16.840.1.114222.4.11.3125",
                    DefinitionText = "Answer list for how the case should be classified by source",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4b82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CaseClassStatus_NND",
                    ValueSetName = "Case Classification Status",
                    ValueSetOID = "2.16.840.1.114222.4.11.968",
                    DefinitionText = "Indicates how the Nationally Notifiable Disease case was classified at its close",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4c82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CaseConfirmationMethod_NND",
                    ValueSetName = "Case Confirmation Method",
                    ValueSetOID = "2.16.840.1.114222.4.11.3025",
                    DefinitionText = "Codes specifying  the mechanism by which a case was classified, providing information about how the case classification status was derived.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4d82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CaseDetectionMethod_NND",
                    ValueSetName = "Case Detection Method",
                    ValueSetOID = "2.16.840.1.114222.4.11.3026",
                    DefinitionText = "Codes specifying the method by which the public health department was made aware of the case.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4e82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CaseInvestigationClosureReason_NND",
                    ValueSetName = "Case investigation closure reason",
                    ValueSetOID = "2.16.840.1.114222.4.11.969",
                    DefinitionText = "If the value specified in Case Status is Closed, this is the reason why the case was closed",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4f82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CaseInvestigationStatus_NND",
                    ValueSetName = "Case Investigation Status",
                    ValueSetOID = "2.16.840.1.114222.4.11.970",
                    DefinitionText = "The current status of the investigation (open or closed)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5082b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CaseTracedToCarrier_FDD",
                    ValueSetName = "Case Traced to Carrier",
                    ValueSetOID = "2.16.840.1.114222.4.11.3074",
                    DefinitionText = "Answer list for typhoid carrier tracing",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5182b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CaseTransmissionMode_NND",
                    ValueSetName = "Case Transmission Mode",
                    ValueSetOID = "2.16.840.1.114222.4.11.3027",
                    DefinitionText = "Codes specifying the mechanism by which disease or condition was acquired.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5282b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CaseVerification_TB",
                    ValueSetName = "Case Verification (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.972",
                    DefinitionText = "Current status of the RVCT.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5382b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ChestXRayResult_CDC",
                    ValueSetName = "Chest XRay Result",
                    ValueSetOID = "2.16.840.1.114222.4.11.930",
                    DefinitionText = "Chest X-ray Results",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5482b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CholeraRiskFactor_FDD",
                    ValueSetName = "Cholera Risk Factor (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3075",
                    DefinitionText = "Cholera risk factor answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5582b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CholeraSequelae_FDD",
                    ValueSetName = "Cholera Sequelae (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3076",
                    DefinitionText = "Cholera sequelae answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5682b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CholeraSignsSymptoms_FDD",
                    ValueSetName = "Cholera Signs Symptoms (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3077",
                    DefinitionText = "Cholera signs and symptoms answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5782b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_City_USGS_GNIS",
                    ValueSetName = "City",
                    ValueSetOID = "2.16.840.1.114222.4.11.973",
                    DefinitionText = "US Geological Survey Geographic Names Information System - location codes",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 7, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5882b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ClinicalSyndrome_Arbovirus",
                    ValueSetName = "Clinical Syndrome (Arbovirus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3059",
                    DefinitionText = "Clinical syndrome associated with Arboviral diseases",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 4, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5982b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CommentType_CDC",
                    ValueSetName = "Comment Type",
                    ValueSetOID = "2.16.840.1.114222.4.11.975",
                    DefinitionText = "Type of comment",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5a82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ConfidentialityCode_HL7_2x",
                    ValueSetName = "Confidentiality Code (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.976",
                    DefinitionText = "Identifier of the confidentiality level that should be associated with this order.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AdverseEventConsequence_CDC",
                    ValueSetName = "Consequence of Adverse Event",
                    ValueSetOID = "2.16.840.1.114222.4.11.963",
                    DefinitionText = "Adverse event consequence [adapted from HL7-defined Table 0240]",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5c82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ContactRole_CDC",
                    ValueSetName = "Contact Role",
                    ValueSetOID = "2.16.840.1.114222.4.11.977",
                    DefinitionText = "Role played by the contact person",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5d82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ContactType_HepatitisA",
                    ValueSetName = "Contact Type (Hepatitis A)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3028",
                    DefinitionText = "Codes specifying the type of contact  with another person.  This value set or answer list is specific to Hepatitis A.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5e82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ContactType_HepatitisBandC",
                    ValueSetName = "Contact Type (Hepatitis B and C)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3029",
                    DefinitionText = "Codes specifying the type of contact  with another person.  This value set or answer list is specific to Hepatitis B and or to Hepatitis C.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6082b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_EncounterPurpose_CRA",
                    ValueSetName = "Countermeasure Encounter Purpose",
                    ValueSetOID = "2.16.840.1.114222.4.11.988",
                    DefinitionText = "List of Countermeasure Response Administration encounter reasons",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6182b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_EncounterType_CRA",
                    ValueSetName = "Countermeasure Encounter Type",
                    ValueSetOID = "2.16.840.1.114222.4.11.989",
                    DefinitionText = "List of Countermeasure Response Administration encounter types",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6282b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Country_ISO_3166-1",
                    ValueSetName = "Country",
                    ValueSetOID = "2.16.840.1.114222.4.11.828",
                    DefinitionText = "Codes representing country of origin, nationality, citizenship, address country",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 11, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6382b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_County_FIPS_6-4",
                    ValueSetName = "County",
                    ValueSetOID = "2.16.840.1.114222.4.11.829",
                    DefinitionText = "Codes representing county of origin, address county, reporting county.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6482b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CyclosporiasisSignsSymptoms_FDD",
                    ValueSetName = "Cyclosporiasis Signs Symptoms (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3078",
                    DefinitionText = "Cyclosporiasis signs and symptoms answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6582b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_MIME_MediaSubType_IANA",
                    ValueSetName = "Data Subtype",
                    ValueSetOID = "2.16.840.1.114222.4.11.1011",
                    DefinitionText = "Encoding as defined by MIME (Multipurpose Internet Mail Extensions)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6682b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DayCareType_FDD",
                    ValueSetName = "Day Care Type (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3079",
                    DefinitionText = "Type of day care answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6782b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DegreeLicenseCertificate_HL7_2x",
                    ValueSetName = "Degree License Certification (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.808",
                    DefinitionText = "The standard classification awarded upon completion of a unified program of study.  HL7 2.5 User-defined Table 0360 - Degree.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6882b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Ethnicity_CDC",
                    ValueSetName = "Detailed Ethnicity",
                    ValueSetOID = "2.16.840.1.114222.4.11.877",
                    DefinitionText = "List of detailed ethnicity codes reported on a limited basis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6982b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Race_CDC",
                    ValueSetName = "Detailed Race",
                    ValueSetOID = "2.16.840.1.114222.4.11.876",
                    DefinitionText = "Specific race codes reported on a limited basis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6a82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DiagnosedBy_VZ",
                    ValueSetName = "Diagnosed by (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.980",
                    DefinitionText = "Indicates who diagnosed the illness - varicella specific",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 7, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6b82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DiagnosedPneumoniaBy_VZ",
                    ValueSetName = "Diagnosed Pneumonia By (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.981",
                    DefinitionText = "Indicates how pneumonia was diagnosed - varicella specific",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6c82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AdministrativeDiagnosis_CDC_ICD-9CM",
                    ValueSetName = "Diagnosis (ICD-9 CM)",
                    ValueSetOID = "2.16.840.1.114222.4.11.856",
                    DefinitionText = "ICD-9 CM Administrative Diagnosis Codes used for billing purposes, Reason for Study, DG1 Diagnosis segments Keyword: ICD-9 Vol 1 & 2.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6d82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DiagnosisPriority_HL7_2x",
                    ValueSetName = "Diagnosis Priority (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.914",
                    DefinitionText = "The number from HL7 Table 0359 - Diagnosis Priority that identifies the significance or priority of the diagnosis code, with 1 being the Primary diagnosis, etc.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6e82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DiagnosisType_HL7_2x",
                    ValueSetName = "Diagnosis Type (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.827",
                    DefinitionText = "A code from HL7 2.5 User-defined Table 0052 - Diagnosis Type that identifies the type of diagnosis being sent (Admitting, Working, Final).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6f82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DiagnosticServiceSectionID_HL7_2x",
                    ValueSetName = "Diagnostic service section ID (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.922",
                    DefinitionText = "The section of the diagnostic service where the observation was performed.  Uses HL7 2.5 Table 0074 - Diagnostic Service Section ID",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7082b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DirectlyObservedTherapy_TB",
                    ValueSetName = "Directly Observed Therapy (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.982",
                    DefinitionText = "The therapy that was directly observed by the health care provider (directly observed therapy, or DOT)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7182b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DischargeDisposition_HL7_2x",
                    ValueSetName = "Discharge Disposition (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.915",
                    DefinitionText = "The disposition of the patient at time of discharge (i.e., discharged to home, expired, etc.).  Uses User-defined Table 0112 - Discharge Disposition; this field is used on UB92 FL22.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7282b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Disease_CDC",
                    ValueSetName = "Disease",
                    ValueSetOID = "2.16.840.1.114222.4.11.909",
                    DefinitionText = "Disease or Disorder - 64572001 SNOMED Domain",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 9, 25)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7382b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DiseaseAcquiredJurisdiction_NND",
                    ValueSetName = "Disease Acquired Jurisdiction",
                    ValueSetOID = "2.16.840.1.114222.4.11.3030",
                    DefinitionText = "Codes specifying where the disease/condition was likely acquired.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7482b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DrugActiveIngredients_FDA_SRS_UNII",
                    ValueSetName = "Drug Active Ingredients",
                    ValueSetOID = "2.16.840.1.114222.4.11.1102",
                    DefinitionText = "Drug Active Ingredients from FDA SRS. This also includes ingredients for combination drugs.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7582b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DrugClasses_NDF-RT",
                    ValueSetName = "Drug Classes (NDF-RT)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1108",
                    DefinitionText = "Drug Clasification based on Ingredients",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7682b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DrugManufacturers_FDA_NDC",
                    ValueSetName = "Drug Manufacturers (NDC)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1106",
                    DefinitionText = "Drug Manufacturing Firm information.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7782b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DrugProduct_FDA_NDC",
                    ValueSetName = "Drug Product (NDC)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1105",
                    DefinitionText = "Commercial Drug  Products",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7882b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DrugSusceptibilityTestResultName_CDC",
                    ValueSetName = "Drug Susceptibility Test Result Name",
                    ValueSetOID = "2.16.840.1.114222.4.11.1071",
                    DefinitionText = "Drug / Antimicrobial Test Result Name",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7982b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DwellingType_NND",
                    ValueSetName = "Dwelling Type",
                    ValueSetOID = "2.16.840.1.114222.4.11.984",
                    DefinitionText = "Type of housing",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7a82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ECOTOX_EPA",
                    ValueSetName = "ECOTOX Chemicals (EPA)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3055",
                    DefinitionText = "Chemicals present in ECOTOX database. The ECOTOX (ECOTOXicology) database provides single chemical toxicity information for aquatic and terrestrial life.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7b82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_EmergencyDepartmentAcuity_CDC",
                    ValueSetName = "Emergency Department Acuity",
                    ValueSetOID = "2.16.840.1.114222.4.11.921",
                    DefinitionText = "Level of care required in the Emergency Department",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7c82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_EmploymentStatus_NND",
                    ValueSetName = "Employment Status",
                    ValueSetOID = "2.16.840.1.114222.4.11.985",
                    DefinitionText = "Employment status",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7d82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Encoding_HL7_2x",
                    ValueSetName = "Encoding Type (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.986",
                    DefinitionText = "The type of encoding used to represent successive octets of binary data as displayable ASCII characters.  HL7 Table 0299 - Encoding for valid values.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7e82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_EnvironmentalInvestigationReason_CDC",
                    ValueSetName = "Environmental Investigation Reason",
                    ValueSetOID = "2.16.840.1.114222.4.11.991",
                    DefinitionText = "Reasons for initiating an environmental investigation",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("7f82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_EosinUnits_FDD",
                    ValueSetName = "Eosin Units (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3080",
                    DefinitionText = "Specifies whether the eosin result is expressed in percent or numeric",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8082b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_EpilinkedCaseType_VZ",
                    ValueSetName = "Epilinked Case Type (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.992",
                    DefinitionText = "Type of case the varicella case is linked to e",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8182b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ErrorSeverity_HL7_2x",
                    ValueSetName = "Error Severity (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.993",
                    DefinitionText = "Identifies severity of an application error when messaging. Knowing if something is Error, Warning, or Information is intrinsic to how an application handles the content contained in the message. Uses HL7 Table 0516.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8282b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_EthnicityGroup_CDC",
                    ValueSetName = "Ethnicity group",
                    ValueSetOID = "2.16.840.1.114222.4.11.837",
                    DefinitionText = "Whether the patient is hispanic or not",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8382b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_EthnicityGroup_CDC_Unk",
                    ValueSetName = "Ethnicity Group including Unknown",
                    ValueSetOID = "2.16.840.1.114222.4.11.3015",
                    DefinitionText = "Ethnicity Group including Unknown",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8482b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Event_CDC",
                    ValueSetName = "Event",
                    ValueSetOID = "2.16.840.1.114222.4.11.1068",
                    DefinitionText = "Event based on SNOMED domain (272379006)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8582b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ExpandedYesNo_HL7_2x",
                    ValueSetName = "Expanded Yes No (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.820",
                    DefinitionText = "HL7 Table 0532 that contains Yes, No, and some flavors of null",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8682b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ExtendedPriorityCodes_HL7_2x",
                    ValueSetName = "Extended Priority Codes (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1024",
                    DefinitionText = "Extended Order Priority",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8782b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_FetalNeonatallnfectionType_FDD",
                    ValueSetName = "Fetal Neonatal Infection Type (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3081",
                    DefinitionText = "Type of infection in fetus/neonate answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8882b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_FetalNeonatalSpecimenType_CDC",
                    ValueSetName = "Fetal Neonatal Specimen Type",
                    ValueSetOID = "2.16.840.1.114222.4.11.3082",
                    DefinitionText = "Source of specimen collected from fetus/neonate answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8982b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Fever_Syndrome_BT",
                    ValueSetName = "Fever Syndrome (BT)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1090",
                    DefinitionText = "ACUTE potentially febrile illness of origin not specified. INCLUDES fever and septicemia not otherwise specified. INCLUDES unspecified viral illness even though unknown if fever is present. EXCLUDE entry in this syndrome category if more specific diagnostic code is present allowing same patient visit to be categorized as respiratory, neurological or gastrointestinal illness syndrome",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8a82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_FoodCookingMethod_FDD",
                    ValueSetName = "Food Cooking Method (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3083",
                    DefinitionText = "Method of cooking the suspect food answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8b82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_FoodProcessingMethod_FDD",
                    ValueSetName = "Food Processing Method (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3084",
                    DefinitionText = "Method of processing the suspect food answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8c82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_FreshBerries_FDD",
                    ValueSetName = "Fresh Berries (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3085",
                    DefinitionText = "Fresh berries consumed answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8d82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_FreshHerbs_FDD",
                    ValueSetName = "Fresh Herbs (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3086",
                    DefinitionText = "Fresh herbs consumed answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8e82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_FreshProduce_FDD",
                    ValueSetName = "Fresh Produce (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3087",
                    DefinitionText = "Fresh produce consumed answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8f82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Gastrointestinal_Syndrome_BT",
                    ValueSetName = "Gastrointestinal Syndrome (BT)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1091",
                    DefinitionText = "ACUTE infection of the upper and/ or lower gastrointestinal (GI) tract. SPECIFIC diagnosis of acute GI distress such as Salmonella gastroenteritis. ACUTE non-specific symptoms of GI distress such as nausea, vomiting, or diarrhea. EXCLUDES any chronic conditions such as inflammatory bowel syndrome",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9082b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_GeneralConditionStatus_CDC",
                    ValueSetName = "General Condition Status",
                    ValueSetOID = "2.16.840.1.114222.4.11.994",
                    DefinitionText = "Patient's general status (alive, dead)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9182b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Genotype_Measles",
                    ValueSetName = "Genotype (Measles)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3126",
                    DefinitionText = "Measles genotypes answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9282b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Genotype_Rubella",
                    ValueSetName = "Genotype (Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3127",
                    DefinitionText = "Rubella genotypes answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9382b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_HealthCarePracticeType_TB",
                    ValueSetName = "Health Care Practice Type (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.995",
                    DefinitionText = "TB-specific healthcare practice types",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9482b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_HealthcareProviderTaxonomy_HIPAA",
                    ValueSetName = "Healthcare Provider Taxonomy (HIPAA)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1066",
                    DefinitionText = "The Health Care Provider Taxonomy code set is a collection of unique alphanumeric codes, ten characters in length. The code set is structured into three distinct Levels including Provider Type, Classification, and Area of Specialization. The Health Care Provider Taxonomy code set allows a single provider (individual, group, or institution) to identify their specialty category. Providers may have one or more than one value associated to them. When determining what value or valuess to associate with a provider, the user needs to review the requirements of the trading partner with which the value(s) are being used.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9582b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_HeightUnit_UCUM",
                    ValueSetName = "Height Unit",
                    ValueSetOID = "2.16.840.1.114222.4.11.891",
                    DefinitionText = "Units for measuring height",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9682b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_HemorrhagicIllness_Syndrome_BT",
                    ValueSetName = "Hemorrhagic Illness Syndrome (BT)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1092",
                    DefinitionText = "SPECIFIC diagnosis of any virus that causes viral hemorrhagic fever (VHF): yellow fever, dengue, Rift Valley fever, Crimean-Congo HF, Kyasanur Forest disease, Omsk HF, Hantaan, Junin, Machupo, Lassa, Marburg, . ACUTE condition with multiple organ involvement that may be consistent with exposure to any virus that causes VHF. ACUTE blood abnormalities consistent with VHF: leukopenia, neutropenia, thrombocytopenia, decreased clotting factors, albuminuria",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9782b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_HistorySource_CRA",
                    ValueSetName = "History Source (CRA)",
                    ValueSetOID = "2.16.840.1.114222.4.11.996",
                    DefinitionText = "CRA-specific source of medical history",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9882b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_HIVDiagnosisBasedOn_NND",
                    ValueSetName = "HIV Diagnosis Based On",
                    ValueSetOID = "2.16.840.1.114222.4.11.997",
                    DefinitionText = "If the patient is determined to be the basis for the value entered (patient history, medical documentation, or unknown).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9982b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_HIVStatusQualitativeResult_NND",
                    ValueSetName = "HIV Status",
                    ValueSetOID = "2.16.840.1.114222.4.11.998",
                    DefinitionText = "The patient's HIV status (e.g., Positive, Negative, Indeterminate)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9a82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_IdentifierType_CDC",
                    ValueSetName = "Identifier Type",
                    ValueSetOID = "2.16.840.1.114222.4.11.999",
                    DefinitionText = "Identifier type codes.  Builds on HL7 Table 0203 Identifier Type",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9b82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_IdentityReliabilityCode_HL7_2x",
                    ValueSetName = "Identity Reliability Code (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1000",
                    DefinitionText = "Values used to communicate information about the reliability of the person information transmitted in the message.  This value set draws from User Defined table 0445-Identity Reliability Code.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9c82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ImmunizationBodySite_CDC",
                    ValueSetName = "Immunization Body Site",
                    ValueSetOID = "2.16.840.1.114222.4.11.3023",
                    DefinitionText = "Specifies anatomical location of immunization / Vaccination",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9d82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ImmunizationInformationSource_CRS",
                    ValueSetName = "Immunization Information Source (CRS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3128",
                    DefinitionText = "Source of information for patient immunization history answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9e82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ImmunosuppressedCondition_CDC",
                    ValueSetName = "Immunosuppressed Condition",
                    ValueSetOID = "2.16.840.1.114222.4.11.3060",
                    DefinitionText = "Immunosuppressed conditions answer list based on SNOMED domain (234532001)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9f82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_IncarcerationType_Hepatitis",
                    ValueSetName = "Incarceration Type (Hepatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3031",
                    DefinitionText = "Codes specifying the types of incarceration or jail-type facilities.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a082b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Industry_NAICS_2007",
                    ValueSetName = "Industry (NAICS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1100",
                    DefinitionText = "The North American Industry Classification System (NAICS) consists of a set of six digit codes that classify and categorize industries.  It also organizes the categories on a production/process-oriented basis.  This new, uniform, industry-wide classification system has been designed as the index for statistical reporting of all economic activities of the U.S., Canada, and Mexico.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a182b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Industry_SIC_1987",
                    ValueSetName = "Industry (SIC)",
                    ValueSetOID = "2.16.840.1.114222.4.11.945",
                    DefinitionText = "Industry - SIC 1987",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a282b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_InformationSource_CDC",
                    ValueSetName = "Information Source",
                    ValueSetOID = "2.16.840.1.114222.4.11.3088",
                    DefinitionText = "Source of information for patient history answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a382b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_InjuryOccurredEnvironment_VPD",
                    ValueSetName = "Injury Occurred Environment (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3129",
                    DefinitionText = "Environment where the acute wound or injury occurred answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a482b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_InjuryType_VPD",
                    ValueSetName = "Injury Type (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3130",
                    DefinitionText = "Injury type answer list for tetanus",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a582b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_InterviewStatus_CDC",
                    ValueSetName = "Interview Status",
                    ValueSetOID = "2.16.840.1.114222.4.11.3089",
                    DefinitionText = "Answer list for status of patient interview for international travel history",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a682b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_IsolateAvailabilityEIPTesting_NND",
                    ValueSetName = "Isolate Availability EIP Testing",
                    ValueSetOID = "2.16.840.1.114222.4.11.3039",
                    DefinitionText = "Indicates isloate availability for Emerging Infectious Program (EIP) Testing",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a782b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_IsolateNotAvailableEIPTestReason_NND",
                    ValueSetName = "Isolate Not Available EIP Test Reason",
                    ValueSetOID = "2.16.840.1.114222.4.11.3040",
                    DefinitionText = "Specifies reason isolate not available for Emerging Infectious Program (EIP) Testing",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a882b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_IsolateNotReceivedReason_NND",
                    ValueSetName = "Isolate Not Received Reason",
                    ValueSetOID = "2.16.840.1.114222.4.11.3041",
                    DefinitionText = "Specifies reason isolate was not received.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a982b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_IsolateNotSentToNARMSReason_NND",
                    ValueSetName = "Isolate Not Sent To NARMS Reason",
                    ValueSetOID = "2.16.840.1.114222.4.11.3042",
                    DefinitionText = "Specifies reason isolate not sent to National Antimicrobial Resistance Management System",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("aa82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_LabResult_Pertussis",
                    ValueSetName = "Lab Result (Pertussis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3131",
                    DefinitionText = "Bordetella Pertussis Lab Testing Result",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ab82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_LabResult_Rubella",
                    ValueSetName = "Lab Result (Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3132",
                    DefinitionText = "Rubella Lab Testing Result",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ac82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_LabTestInterpretation_CDC",
                    ValueSetName = "Lab Test Interpretation",
                    ValueSetOID = "2.16.840.1.114222.4.11.3048",
                    DefinitionText = "Codes specifying qualitative lab test interpretation.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ad82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_LabTestOrder_PHLIP_Flu",
                    ValueSetName = "Lab Test Order (PHLIP Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3016",
                    DefinitionText = "Lab Test orderables that could be used in OBRsegment (PHLIP Flu)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ae82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_LabTestResult_PHLIP_Flu",
                    ValueSetName = "Lab Test Result (PHLIP Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3017",
                    DefinitionText = "Lab Test Result that could be used in OBX-5  (PHLIP Flu)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("af82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_LabTestName_CDC",
                    ValueSetName = "Lab Test Result Name",
                    ValueSetOID = "2.16.840.1.114222.4.11.1002",
                    DefinitionText = "Laboratory Resulted Test identifiers and names - LOINC is the starter set",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b082b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_LabTestResultName_Hepatitis",
                    ValueSetName = "Lab Test Result Name (Hepatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3043",
                    DefinitionText = "Name of Hepatitis test result.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b182b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_LabTestResultQualitative_CDC",
                    ValueSetName = "Lab Test Result Qualitative",
                    ValueSetOID = "2.16.840.1.114222.4.11.3049",
                    DefinitionText = "Codes specifying non-microorganism qualitative lab test results including coded comments. Subset of lab test related Modifier or Qualifier concepts from SNOMED CT.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b282b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Language_ISO_639-2_Alpha3",
                    ValueSetName = "Language",
                    ValueSetOID = "2.16.840.1.114222.4.11.831",
                    DefinitionText = "Primary spoken language",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b382b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PHINQuestions_LeadCase",
                    ValueSetName = "PHIN Questions (Lead Case)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1063",
                    DefinitionText = "PHIN Questions value set for Lead Case reporting",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b482b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PHINQuestions_LeadEnvironmental",
                    ValueSetName = "PHIN Questions (Lead Environmental)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1065",
                    DefinitionText = "PHIN Questions value set for Lead Environmental reporting",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b582b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PHINQuestions_LeadLabReport",
                    ValueSetName = "PHIN Questions (Lead Laboratory Report)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1064",
                    DefinitionText = "PHIN Questions value set for Lead Laboratory reporting",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b682b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_LettuceType_FDD",
                    ValueSetName = "Lettuce Type (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3090",
                    DefinitionText = "Type of lettuce consumed answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b782b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_LiveBirthOutcome_Rubella",
                    ValueSetName = "Live Birth Outcome (Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3133",
                    DefinitionText = "Types of live birth outcome of pregnancy",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b882b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_LocalizedCutaneousLesion_Syndrome_BT",
                    ValueSetName = "Localized Cutaneous Lesion Syndrome (BT)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1093",
                    DefinitionText = "SPECIFIC diagnosis of localized cutaneous lesion/ ulcer consistent with cutaneous anthrax or tularemia. ACUTE localized edema and/ or cutaneous lesion/ vesicle, ulcer, eschar that may be consistent with cutaneous anthrax or tularemia. INCLUDES insect bites. EXCLUDES any lesion disseminated over the body or generalized rash. EXCLUDES diabetic ulcer and ulcer associated with peripheral vascular disease",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b982b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Lymphadenitis_Syndrome_BT",
                    ValueSetName = "Lymphadenitis Syndrome (BT)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1094",
                    DefinitionText = "ACUTE regional lymph node swelling and/ or infection (painful bubo- particularly in groin, axilla or neck)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ba82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_MajorDiseaseSite_TB",
                    ValueSetName = "Major Site of Disease (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1007",
                    DefinitionText = "Main body site where TB manifested",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bb82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ManufacturersOfVaccinesMVX_CDC_NIP",
                    ValueSetName = "Manufacturers of vaccines (MVX)",
                    ValueSetOID = "2.16.840.1.114222.4.11.826",
                    DefinitionText = "The CDC's National Immunization Program (NIP) maintains the HL7 external code set MVX. HL7 version 2.x Manufacturers of vaccines (code=MVX) used in chapter(s) 4.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bc82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_MaritalStatus_HL7_2x",
                    ValueSetName = "Marital Status (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.809",
                    DefinitionText = "HL7 Table 0002 Marital Status codes",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bd82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Material_CDC",
                    ValueSetName = "Material",
                    ValueSetOID = "2.16.840.1.114222.4.11.1069",
                    DefinitionText = "Object / Material based on SNOMED domain (260769002)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("be82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_MaternalInfection_FDD",
                    ValueSetName = "Maternal Infection (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3091",
                    DefinitionText = "Type of infection in mother answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bf82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_MeatPurchaseInfo_FDD",
                    ValueSetName = "Meat Purchase Info (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3092",
                    DefinitionText = "Where suspect meat obtained answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c082b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecialtyType_HL7_2x",
                    ValueSetName = "Medical Specialty (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.916",
                    DefinitionText = "Medical service under which patient is being treated.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c182b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_MedicationTreatment_FDD",
                    ValueSetName = "Medication Treatment (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3118",
                    DefinitionText = "Treatments/medications before Vibrio illness began answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c282b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_MessageErrorConditionCodes_HL7_2x",
                    ValueSetName = "Message Error Condition Codes (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.974",
                    DefinitionText = "Type of error that occurred while processing the message identified in MSA.2",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c382b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_MicrobiologicalStrain_CDC",
                    ValueSetName = "Microbiology  strain",
                    ValueSetOID = "2.16.840.1.114222.4.11.3044",
                    DefinitionText = "Codes specifying the strain of an organism.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c482b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_MicrobiologyLabTestResultName_CDC",
                    ValueSetName = "Microbiology Test Result Name",
                    ValueSetOID = "2.16.840.1.114222.4.11.1073",
                    DefinitionText = "List of Microbiology test result names",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c582b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Microorganism_CDC",
                    ValueSetName = "Microorganism",
                    ValueSetOID = "2.16.840.1.114222.4.11.1009",
                    DefinitionText = "Microorganisms/infectious agents",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 1, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c682b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Microorganism_Hepatitis",
                    ValueSetName = "Microorganism (Hepatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3045",
                    DefinitionText = "Value set from the Reportable Condition Mapping Tables (RCMT) Project for the  organisms associated with Hepatitis. Hepatitis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c782b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_MicroscopicExamCultureSite_TB",
                    ValueSetName = "Microscopic Exam Culture Site (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1010",
                    DefinitionText = "Culture sites for TB",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c882b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_MissingLabResult_CDC",
                    ValueSetName = "Missing Lab Result Reason",
                    ValueSetOID = "2.16.840.1.114222.4.11.1013",
                    DefinitionText = "Reason lab result not performed",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c982b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ModifierOrQualifier_CDC",
                    ValueSetName = "Modifier or Qualifier",
                    ValueSetOID = "2.16.840.1.114222.4.11.1014",
                    DefinitionText = "Qualitatitve codes used for laboratory test results. This uses SNOMED hierarchy (362981000). These codes need to be used appropriately using SNOMED post-coordination rules.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ca82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_NameType_HL7_2x",
                    ValueSetName = "Name Type (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.810",
                    DefinitionText = "HL7 table 0200 contains types of person names, including Maiden and Alias.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 8, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cb82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_NotifiableEvent_Disease_Condition_CDC_NNDSS",
                    ValueSetName = "Nationally Notifiable Disease Surveillance System (NNDSS) & Other Conditions of Public Health Importance",
                    ValueSetOID = "2.16.840.1.114222.4.11.1015",
                    DefinitionText = "List of notifiable events, which includes infectious and non-infectious diseases or conditions. This list includes events that are notifiable at the state and national level.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cc82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_NationallyNotifiableInfectiousDisease_CDC_NNDSS",
                    ValueSetName = "Nationally Notifiable Infectious Disease reportable to the Nationally Notifiable Disease Surveillance System",
                    ValueSetOID = "2.16.840.1.114222.4.11.1016",
                    DefinitionText = "List of notifiable events, which includes only infectious disease that are notifiable at the national level.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 21)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cd82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_NatureOfAbnormalTesting_HL7_2x",
                    ValueSetName = "Nature of Abnormal Test (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1017",
                    DefinitionText = "HL7 Table 0080 contains the nature of the abnormal testing (ex. age-related and/or sex-related and/or race-related values)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ce82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Neurological_Syndrome_BT",
                    ValueSetName = "Neurological Syndrome (BT)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1095",
                    DefinitionText = "ACUTE neurological infection of the central nervous system (CNS). SPECIFIC diagnosis of acute CNS infection such as pneumoccocal meningitis, viral encephailitis. ACUTE non-specific diagnosis of CNS infection such as meningitis not otherwise specified (NOS), encephailitis NOS, encephalopathy NOS. ACUTE non-specific symptoms of CNS infection such as meningismus, delerium. EXCLUDES any chronic, hereditary or degenerative conditions of the CNS such as obstructive hydrocephalus, Parkinson s, Alzheimer s",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cf82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_NoCaseReason_CRS",
                    ValueSetName = "No Case Reason (CRS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3134",
                    DefinitionText = "Reason list for why the case is not Congenital Rubella Syndrome",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d082b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_NonPaintLeadSource_PB",
                    ValueSetName = "Non Paint Lead Source",
                    ValueSetOID = "2.16.840.1.114222.4.11.1018",
                    DefinitionText = "List of non-paint lead exposure sources",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d182b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_NonPorkType_FDD",
                    ValueSetName = "Non Pork Type (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3093",
                    DefinitionText = "Type of non-pork consumed answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d282b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_NonLiveBirthOutcome_VPD",
                    ValueSetName = "Non-Live Birth Outcome (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3135",
                    DefinitionText = "Types of non-live birth outcome of pregnancy",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d382b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_NonPaintLeadSourceHobby_PB",
                    ValueSetName = "Non-paint lead source - hobby related",
                    ValueSetOID = "2.16.840.1.114222.4.11.1019",
                    DefinitionText = "List of hobbies that could result in exposure to lead",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d482b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_NotifiableCondition_FDD",
                    ValueSetName = "Notifiable Condition (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3116",
                    DefinitionText = "Notifiable conditions specific to Foodborne and Diarrheal Diseases",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d582b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_NotifiableConditions_Hepatitis",
                    ValueSetName = "Notifiable Condition (Hepatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3032",
                    DefinitionText = "List of hepatitis specific notifiable events. This list includes events that are notifiable at the state and national level.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d682b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_NotificationSectionHeader_CDC",
                    ValueSetName = "Notification Section Header",
                    ValueSetOID = "2.16.840.1.114222.4.11.1107",
                    DefinitionText = "List of Notification Section Headers. Type of notification event (Case, Environmental, Lab Report turn-around to CDC)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 5, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d782b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_NullFlavor_HL7_V3",
                    ValueSetName = "Null Flavor (HL7 V3)",
                    ValueSetOID = "2.16.840.1.114222.4.11.875",
                    DefinitionText = "HL7 V3 coding system with codes to indicate the null responses (e.g. unknown, other, not present)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d882b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_NumberOfLesions_VZ",
                    ValueSetName = "Number Of Lesions (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1021",
                    DefinitionText = "Ranges of numbers of varicella lesions, as counted",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d982b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_NumOfSexPartners_Hepatitis",
                    ValueSetName = "Number Of Sex Partners (Hepatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3033",
                    DefinitionText = "Codes specifying the number of sex partners the person had.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("da82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_LabTestMethods_CDC",
                    ValueSetName = "Observation Method",
                    ValueSetOID = "2.16.840.1.114222.4.11.1003",
                    DefinitionText = "Laboratory test method identifiers",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("db82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ObservationResultStatus_HL7_2x",
                    ValueSetName = "Observation Result Status (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.811",
                    DefinitionText = "The status of the observation. This field is required when the OBX segment is contained in a message.  Uses HL7 2.5 Table 0085-Observation Result Status.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dc82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Occupation_CDC",
                    ValueSetName = "Occupation",
                    ValueSetOID = "2.16.840.1.114222.4.11.887",
                    DefinitionText = "Occupations or job codes",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("dd82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_OccupationRiskCategory_TB",
                    ValueSetName = "Occupation Risk Category (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1022",
                    DefinitionText = "Occupations that are high risk for contracting Tuberculosis",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("de82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_OrderControlCodes_HL7_2x",
                    ValueSetName = "Order Control Code (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.923",
                    DefinitionText = "Order Control Codes that determine the function of the order segment.  Uses HL7 Table 0119-Order Control Codes.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("df82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_OrderStatus_HL7_2x",
                    ValueSetName = "Order Status (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1025",
                    DefinitionText = "Reports the status of an order upon request or when the status changes.  It may be used in a message with Order Control value of SR or SC.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e082b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_LabTestOrderables_CDC",
                    ValueSetName = "Ordered Test",
                    ValueSetOID = "2.16.840.1.114222.4.11.1004",
                    DefinitionText = "Lab test orderables that could be used in OBR segment. This value set also includes panels from LOINC. Keywords: Lab Test Orderables, Lab Test Order",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 11)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e182b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_OtherRelatedCases_FDD",
                    ValueSetName = "Other Related Cases",
                    ValueSetOID = "2.16.840.1.114222.4.11.3094",
                    DefinitionText = "Other cases related to this one answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e282b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_OutbreakType_FDD",
                    ValueSetName = "Outbreak Type (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3095",
                    DefinitionText = "Type of outbreak answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e382b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_OutbreakType_Hepatitis",
                    ValueSetName = "Outbreak Type (Hepatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3034",
                    DefinitionText = "Codes specifying the type of outbreak with which the person is associated.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e482b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PassFailUnk_CDC",
                    ValueSetName = "Passed Failed Unknown",
                    ValueSetOID = "2.16.840.1.114222.4.11.950",
                    DefinitionText = "Values used when the result of an observation is Passed or Failed based on reporting parameters.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e582b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PatientClass_HL7_2x",
                    ValueSetName = "Patient Class (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.917",
                    DefinitionText = "General type of patient.  HL7 User-defined table 0004",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e682b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PatientLocationStatusAtSpecimenCollection",
                    ValueSetName = "Patient Location Status at Specimen Collection",
                    ValueSetOID = "2.16.840.1.114222.4.11.3018",
                    DefinitionText = "Patient's location status at the time of specimen collection",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e782b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PCRPerformedLabLocation_VPD",
                    ValueSetName = "PCR Performed Lab Location (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3136",
                    DefinitionText = "Type of lab where PCR testing performed",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e882b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PharmacyOrderType_HL7_2x",
                    ValueSetName = "Pharmacy Order Type (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.925",
                    DefinitionText = "HL7 table 0480 contains values that define the general category of the pharmacy order.  This may be used to determine the processing path of the order or how to group related orders for reports.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e982b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PHINQuestions_CDC",
                    ValueSetName = "PHIN Questions",
                    ValueSetOID = "2.16.840.1.114222.4.11.883",
                    DefinitionText = "Legacy PHIN Questions that are used as data element or observation identifer (OBX-3) in the HL7 messaging implementation guides.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 11, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("eb82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PHINQuestions_AnimalRabies",
                    ValueSetName = "PHIN Questions (Animal Rabies)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3050",
                    DefinitionText = "PHIN Questions value set for Animal Rabies",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ec82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PHINQuestions_ArboNet",
                    ValueSetName = "PHIN Questions (ArboNet)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3051",
                    DefinitionText = "PHIN Questions value set for ArboNet",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ed82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PHINQuestions_FDD",
                    ValueSetName = "PHIN Questions (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3052",
                    DefinitionText = "PHIN Questions value set for FDD",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ee82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PHINQuestions_Generic",
                    ValueSetName = "PHIN Questions (Generic)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3053",
                    DefinitionText = "PHIN Questions value set for Generic data elements.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 8, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ef82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PHINQuestions_VPD",
                    ValueSetName = "PHIN Questions (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3054",
                    DefinitionText = "PHIN Questions value set for VPD",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f082b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PHLIP_Questions_Flu",
                    ValueSetName = "PHLIP Questions (Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3000",
                    DefinitionText = "List of questions used in the PHLIP Flu Message Specification Guide",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f182b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PhysicalObject_CDC",
                    ValueSetName = "Physical Object",
                    ValueSetOID = "2.16.840.1.114222.4.11.1075",
                    DefinitionText = "Physical Object  based on SNOMED domain(260787004)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f282b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PorkType_FDD",
                    ValueSetName = "Pork Type (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3096",
                    DefinitionText = "Type of pork consumed answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f382b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PosNegUnkNotDone_CDC",
                    ValueSetName = "Positive Negative Unknown Not Done",
                    ValueSetOID = "2.16.840.1.114222.4.11.929",
                    DefinitionText = "Values used for limited qualitative result reporting",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f482b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PreferredMethodOfContact_HL7_2x",
                    ValueSetName = "Preferred Method of Contact (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3021",
                    DefinitionText = "HL7 version 2.x Preferred method of contact used in chapter(s) 15; HL7 table 0185.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f582b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PregnancyOutcome_FDD",
                    ValueSetName = "Pregnancy Outcome (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3071",
                    DefinitionText = "Outcome of pregnancy answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f682b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PregnancyTrimester_CDC",
                    ValueSetName = "Pregnancy Trimester",
                    ValueSetOID = "2.16.840.1.114222.4.11.1026",
                    DefinitionText = "Although HL7 Table 0038 - Order status contains many of the same values contained in HL7 Table 0119 -",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f782b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PrenatalCareProvider_Rubella",
                    ValueSetName = "Prenatal Care Provider (Rubella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3137",
                    DefinitionText = "Whether prenatal care was obtained through public or private resources",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f882b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PresentAbsentUnkNotExamined_CDC",
                    ValueSetName = "Present Absent Unknown Not Examined",
                    ValueSetOID = "2.16.840.1.114222.4.11.3097",
                    DefinitionText = "Larvae found in suspect food answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f982b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PreviousVaccinationHistory_CDC",
                    ValueSetName = "Previous Vaccine History",
                    ValueSetOID = "2.16.840.1.114222.4.11.1027",
                    DefinitionText = "Order control codes and their meaning, the purpose is different. Order status may typically be used in a",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fa82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AdministrativeProcedure_CDC_ICD-9-CM",
                    ValueSetName = "Procedure (ICD-9 CM)",
                    ValueSetOID = "2.16.840.1.114222.4.11.962",
                    DefinitionText = "ICD-9 CM Volume 3 Procedure Codes used for billing purposes, Reason for Study, PR1 Diagnosis segments",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fb82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ProcedureBySite_CDC",
                    ValueSetName = "Procedure by Site (SNOMED)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1109",
                    DefinitionText = "Procedures by body site",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fc82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ProcessingID_HL7_2x",
                    ValueSetName = "Processing ID (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1028",
                    DefinitionText = "HL7 table 0103 contains values that define whether the message is part of a production, training or debugging system.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fd82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ProcessingMode_HL7_2x",
                    ValueSetName = "Processing Mode (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1029",
                    DefinitionText = "HL7 table 0207 contains values that define whether the message is part of an archival process or an initial load.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("fe82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ProductionClass_HL7_2x",
                    ValueSetName = "Production Class (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.812",
                    DefinitionText = "User-defined table 0429 contains the code and description that indicates the primary use for which the living subject was bred or grown.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("ff82b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PublicHealthCaseRecordType_NND",
                    ValueSetName = "Public Health Case Record Type",
                    ValueSetOID = "2.16.840.1.114222.4.11.1031",
                    DefinitionText = "Notification record type reflects whether this is an individual Case Notification or a Summary notification.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0083b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PublicPrivateLab_NND",
                    ValueSetName = "Public Private Lab",
                    ValueSetOID = "2.16.840.1.114222.4.11.3061",
                    DefinitionText = "Whether specimen was tested in public health or commercial laboratories",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0183b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_RaceCategory_CDC",
                    ValueSetName = "Race Category",
                    ValueSetOID = "2.16.840.1.114222.4.11.836",
                    DefinitionText = "General race category reported by the patient - subject may have more than one",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0283b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_RashDistribution_VZ",
                    ValueSetName = "Rash Distribution (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1032",
                    DefinitionText = "The anatomical location where the rash was located.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0383b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_RashLocationFirstNoted_VZ",
                    ValueSetName = "Rash Location First Noted (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1033",
                    DefinitionText = "Where the varicella rash was first noted",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0483b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Rash_Syndrome_BT",
                    ValueSetName = "Rash Syndrome (BT)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1096",
                    DefinitionText = "ACUTE condition that may present as consistent with smallpox (macules, papules, vesicles predominantly of face/arms/legs). SPECIFIC diagnosis of acute rash such as chicken pox in person > XX years of age (base age cut-off on data interpretation) or smallpox. ACUTE non-specific diagnosis of rash compatible with infectious disease, such as viral exanthem. EXCLUDES allergic or inflammatory skin conditions such as contact or seborrheaic dermatitis, rosacea. EXCLUDES rash NOS, rash due to poison ivy, sunburn, and eczema",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0583b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ReasonForTest_Hepatitis",
                    ValueSetName = "Reason For Test (Hepatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3035",
                    DefinitionText = "Codes specifying the reason(s) the patient was tested for hepatitis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0683b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ReasonTherapyStopped_TB",
                    ValueSetName = "Reason Therapy Stopped (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1035",
                    DefinitionText = "Primary reason that Tuberculosis therapy was ended",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0783b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_RecreationalWater_FDD",
                    ValueSetName = "Recreational Water (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3098",
                    DefinitionText = "Recreational water exposure type answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0883b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ReferralDisposition_HL7_2x",
                    ValueSetName = "Referral Disposition (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.825",
                    DefinitionText = "Type of response or action requested by the referring provider from the referred-to provider.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0983b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ReferralPriority_HL7_2x",
                    ValueSetName = "Referral Priority (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.822",
                    DefinitionText = "Urgency of the referral.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0a83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ReferralReason_HL7_2x",
                    ValueSetName = "Referral Reason (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.823",
                    DefinitionText = "Specific reason for referral, if the Referral Type and Referral Category were not considered reasons in themselves.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0b83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ReferralStatus_CRA",
                    ValueSetName = "Referral Status (CRA)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1036",
                    DefinitionText = "Status of the referral as defined by the referring provider.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0c83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Relationship_HL7_2x",
                    ValueSetName = "Relationship (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.813",
                    DefinitionText = "Relationship codes as specified by HL7.v2: Added 'Household' concept",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 8, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0d83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Relationship_VPD",
                    ValueSetName = "Relationship (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3138",
                    DefinitionText = "Case contact relationships answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0e83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Religion_HL7_2x",
                    ValueSetName = "Religion (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.814",
                    DefinitionText = "User-defined table 0006 contains a list of religions.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("0f83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ReportingSourceType_NND",
                    ValueSetName = "Reporting Source Type",
                    ValueSetOID = "2.16.840.1.114222.4.11.3036",
                    DefinitionText = "Codes specifying the type of facility or provider associated with the source of information sent to Public Health.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1083b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Respiratory_Syndrome_BT",
                    ValueSetName = "Respiratory Syndrome (BT)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1097",
                    DefinitionText = "ACUTE infection of the upper and/ or lower respiratory tract (from the oropharynx to the lungs, includes otitis media). SPECIFIC diagnosis of acute respiratory tract infection (RTI) such as pneumonia due to parainfluenza virus.ACUTE non-specific diagnosis of RTI such as sinusitis, pharyngitis, laryngitis.ACUTE non-specific symptoms of RTI such as cough, stridor, shortness of breath, throat pain.EXCLUDES chronic conditions such as chronic bronchitis, asthma without acute exacerbation, chronic sinusitis, allergic conditions (Note: INCLUDE acute exacerbation of chronic illnesses)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1183b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ResponseFlag_HL7_2x",
                    ValueSetName = "Response Flag (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1023",
                    DefinitionText = "Response Flag",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1283b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ResultStatus_HL7_2x",
                    ValueSetName = "Result status (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.815",
                    DefinitionText = "The status of the results. This field is required when the OBR segment is contained in a message.  Uses HL7 2.5 Table 0123-Result Status.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1383b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ResultedLabTestName_PHLIP_Flu",
                    ValueSetName = "Resulted Lab Test Name (PHLIP Flu)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3019",
                    DefinitionText = "Resulted lab test name that could be used in OBX-3 (PHLIP Flu)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1483b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_RiskCategory_CRA",
                    ValueSetName = "Risk Category",
                    ValueSetOID = "2.16.840.1.114222.4.11.1037",
                    DefinitionText = "Risk categories used in Countermeasure Response",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1583b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_RouteOfAdministration_HL7_2x",
                    ValueSetName = "Route of Administration (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.816",
                    DefinitionText = "User-defined table 0162 contains a list of the routes of administration of a drug or treatment.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1683b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SeafoodPurchaseInfo_FDD",
                    ValueSetName = "Seafood Purchase Info (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3099",
                    DefinitionText = "Where raw seafood obtained answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1783b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SeafoodType_FDD",
                    ValueSetName = "Seafood Type (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3100",
                    DefinitionText = "Type of raw seafood answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1883b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SemanticClinicalDrug_RxNORM",
                    ValueSetName = "Semantic Clinical Drug (Ingredient plus strength and dose form)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1103",
                    DefinitionText = "Semantic Clinical Drug E.g. Amoxicillin 750 MG Oral Tablet",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1983b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SemanticClinicalDrugForm_RxNORM",
                    ValueSetName = "Semantic Clinical Drug Form (Ingredient plus dose form)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1104",
                    DefinitionText = "Semantic Clinical Drug Form . E.g. Amoxicillin Oral Tablet",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1a83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SerologyPerformedLabLocation_Pertussis",
                    ValueSetName = "Serology Performed Lab Location (Pertussis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3139",
                    DefinitionText = "Type of lab where serology testing performed",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1b83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SevereIllnessOrDeath_Syndrome_BT",
                    ValueSetName = "Severe Illness Or Death Syndrome (BT)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1098",
                    DefinitionText = "ACUTE onset of shock or coma from potentially infectious causes. EXCLUDES shock from trauma. INCLUDES SUDDEN death, death in emergency room, intrauterine deaths, fetal death, spontaneous abortion, and still births. EXCLUDES induced fetal abortions, deaths of unknown cause, and unattended deaths",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1c83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Sex_MFU",
                    ValueSetName = "Sex (MFU)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1038",
                    DefinitionText = "Constrained list of sex codes in use by public health. Keyword: Administrative Sex.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1d83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_DirectlyObservedTherapySite_TB",
                    ValueSetName = "Sites of Directly Observed Therapy (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.983",
                    DefinitionText = "If any medication was administered under DOT conditions, the site(s) where this occurred",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1e83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SituationWithExplicitContext_CDC",
                    ValueSetName = "Situation with Explicit Context",
                    ValueSetOID = "2.16.840.1.114222.4.11.1076",
                    DefinitionText = "Clinical Context (e.g. History of, Rule out, Family History) based on SNOMED domain (243796009)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1f83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SkinExposure_FDD",
                    ValueSetName = "Skin Exposure (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3101",
                    DefinitionText = "Patient’s skin exposure history answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2083b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SkinExposureActivity_FDD",
                    ValueSetName = "Skin Exposure Activity (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3102",
                    DefinitionText = "Activity that resulted in skin exposure answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2183b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SourceOfComment_HL7_2x",
                    ValueSetName = "Source of Comment (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3014",
                    DefinitionText = "HL7 version 2.5 Table 0105 - Source of Comment.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2283b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecificInfection_Syndrome_BT",
                    ValueSetName = "Specific Infection Syndrome (BT)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1099",
                    DefinitionText = "ACUTE infection of known cause not covered in other syndrome groups, usually has more generalized symptoms (i.e., not just respiratory or gastrointestinal). INCLUDES septicemia from known bacteria. INCLUDES other febrile illnesses such as scarlet fever",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2383b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_Specimen_CDC",
                    ValueSetName = "Specimen",
                    ValueSetOID = "2.16.840.1.114222.4.11.946",
                    DefinitionText = "Specimen based on SNOMED hierarchy (123038009) Keyword: Specimen Source, Specimen Type",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2483b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_AdditiveOrPreservative_HL7_2x",
                    ValueSetName = "Specimen Additive or Preservative (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.960",
                    DefinitionText = "HL7 version 2.5 Table 0371 Additive/Preservative codes.  Information regarding any substances added to the specimen before or at the time of specimen collection.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2583b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecimenAppropriateness_HL7_2x",
                    ValueSetName = "Specimen Appropriateness (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1039",
                    DefinitionText = "The suitability of the specimen for the particular planned use as determined by the filler.  Refer to User-defined Table 0492   Specimen Appropriateness",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2683b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecimenChildRole_HL7_2x",
                    ValueSetName = "Specimen Child Role (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1040",
                    DefinitionText = "For child specimens, this field identifies the relationship between this specimen and the parent specimen.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2783b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecimenCollectionMethod_HL7_2x",
                    ValueSetName = "Specimen Collection Method (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1041",
                    DefinitionText = "Describes the procedure or process by which the specimen was collected. Any nationally recognized coding system might be used for this field including SNOMED; alternatively the HL7 defined table 0488 may be used",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2883b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecimenCondition_CDC",
                    ValueSetName = "Specimen Condition",
                    ValueSetOID = "2.16.840.1.114222.4.11.1042",
                    DefinitionText = "A mode or state of being that describes the nature of the specimen.  Refers to HL7 User-defined Table 0493 Specimen Condition.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2983b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_EntityHandling_CDC",
                    ValueSetName = "Specimen Handling Code",
                    ValueSetOID = "2.16.840.1.114222.4.11.990",
                    DefinitionText = "Special handling codes for specimens",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2a83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecimenQuality_HL7_2x",
                    ValueSetName = "Specimen Quality (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1043",
                    DefinitionText = "The degree or grade of excellence of the specimen at receipt.  The filler populates this attribute.  Refers to User-defined Table 0491   Specimen Quality.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2b83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecimenRejectReason_HL7_2x",
                    ValueSetName = "Specimen Reject Reason (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1044",
                    DefinitionText = "One or more reasons the specimen is rejected for the specified observation/result/analysis.  Refers to HL7 table 0490-Specimen Reject Reason.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2c83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecimenReshipmentReason_NND",
                    ValueSetName = "Specimen Reshipment Reason",
                    ValueSetOID = "2.16.840.1.114222.4.11.3046",
                    DefinitionText = "Codes specifying the reason for specimen reshipment.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2d83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecimenRisk_CDC",
                    ValueSetName = "Specimen Risk",
                    ValueSetOID = "2.16.840.1.114222.4.11.1045",
                    DefinitionText = "Any known or suspected specimen hazards, e.g., exceptionally infectious agent  or blood from a hepatitis patient. Refers to User-defined Table 0489   Risk Codes.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2e83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecimenRole_CDC",
                    ValueSetName = "Specimen Role",
                    ValueSetOID = "2.16.840.1.114222.4.11.1046",
                    DefinitionText = "The role of the sample. If this field is not populated, then the specimen described has no special, or specific, role other than serving as the focus of the observation.  Refers to User-defined Table 0369   Specimen role.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2f83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecimenShipped_NND",
                    ValueSetName = "Specimen Shipped",
                    ValueSetOID = "2.16.840.1.114222.4.11.3047",
                    DefinitionText = "Codes specifying the status or  destination of specimen shipped, specific to Emerging Infectious Program (EIP) .",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3083b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecimenSource_CRS",
                    ValueSetName = "Specimen Source (CRS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3140",
                    DefinitionText = "Specimen sources answer list for congenital rubella syndrome",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3183b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecimenSource_PHLIP",
                    ValueSetName = "Specimen Source (PHLIP)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3020",
                    DefinitionText = "Specimen Source from HL7 Table 0070. PHLIP is migrating to use of SNOMED as specimen source - need to review if doable with next release or the release after that",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3283b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecimenSource_VPD",
                    ValueSetName = "Specimen Source (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3141",
                    DefinitionText = "Specimen source answer list for rubella",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3383b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SpecimenTreatment_CDC",
                    ValueSetName = "Specimen Treatment",
                    ValueSetOID = "2.16.840.1.114222.4.11.1047",
                    DefinitionText = "Specimen treatment performed during laboratory processing",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3483b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_State_FIPS_5-2",
                    ValueSetName = "State",
                    ValueSetOID = "2.16.840.1.114222.4.11.830",
                    DefinitionText = "State codes for U.S. based on FIPS 5-2",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3583b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_STORET_EPA",
                    ValueSetName = "STORET Chemicals (EPA)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3056",
                    DefinitionText = "STORET (short for STOrage and RETrieval) is a repository for water quality, biological, and physical data and is used by state environmental agencies, EPA and other federal agencies, universities, private citizens, and many others",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3683b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_StrainType_VZ",
                    ValueSetName = "Strain Type (VZ)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1048",
                    DefinitionText = "Varicella strain type - wild or vaccine",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3783b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SubstanceAdministered_CRA",
                    ValueSetName = "Substance Administered (CRA)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1049",
                    DefinitionText = "Vaccine/substance administered as countermeasure response",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3883b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SubstanceTreatmentRefusalReason_CRA",
                    ValueSetName = "Substance Treatment Refusal Reason",
                    ValueSetOID = "2.16.840.1.114222.4.11.1051",
                    DefinitionText = "Reason a countermeasure referral subject refused treatment",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3983b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SusceptibilityResult_CDC",
                    ValueSetName = "Susceptibility Result",
                    ValueSetOID = "2.16.840.1.114222.4.11.941",
                    DefinitionText = "Limited antibiotic susceptibility results list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3a83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SuspectedFoodConsumed_FDD",
                    ValueSetName = "Suspected Food Consumed (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3103",
                    DefinitionText = "Suspect foods consumed answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3b83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_SwimmingPoolType_FDD",
                    ValueSetName = "Swimming Pool Type (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3104",
                    DefinitionText = "Swimming pool types answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3c83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TapWaterSource_FDD",
                    ValueSetName = "Tap Water Source (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3105",
                    DefinitionText = "Source of tap water answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3d83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TattooObtainedFrom_Hepatitis",
                    ValueSetName = "Tattoo Obtained From (Hepatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3037",
                    DefinitionText = "Codes specifying the type of location(s) or organizations where people often go to get tatoos or piercings.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 8, 27)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3e83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PHINQuestions_TB",
                    ValueSetName = "PHIN Questions (TB)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1061",
                    DefinitionText = "PHIN Questions value set for TB reporting",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3f83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TelecommunicationEquipmentType_HL7_2x",
                    ValueSetName = "Telecommunication Equipment Type (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.817",
                    DefinitionText = "HL7 table 0202 contains a list of types of telecommunication equipment",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4083b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TelecommunicationUseCode_HL7_2x",
                    ValueSetName = "Telecommunication Use Code (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.818",
                    DefinitionText = "HL7 table 0201 contains a list that represents a specific use of a telecommunication number",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 14)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4183b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TemperatureUnit_UCUM",
                    ValueSetName = "Temperature Unit",
                    ValueSetOID = "2.16.840.1.114222.4.11.919",
                    DefinitionText = "Units of measure for temperature",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4283b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TestMethodEIAIgM_CDC",
                    ValueSetName = "Test Method EIA IgM",
                    ValueSetOID = "2.16.840.1.114222.4.11.3142",
                    DefinitionText = "Method used for IgM EIA testing",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4383b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TetanusType_VPD",
                    ValueSetName = "Tetanus Type (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3143",
                    DefinitionText = "Type of tetanus disorder answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4483b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TransmissionSetting_NND",
                    ValueSetName = "Transmission Setting (NND)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1052",
                    DefinitionText = "Location where the patient was exposed to the illness",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 12, 2)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4583b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TransplantOrgan_CDC",
                    ValueSetName = "Transplant Organ",
                    ValueSetOID = "2.16.840.1.114222.4.11.3062",
                    DefinitionText = "Organs transplanted answer list based on SNOMED domain (24486003)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2010, 8, 13)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4683b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TravelDestinationType_FDD",
                    ValueSetName = "Travel Destination Type",
                    ValueSetOID = "2.16.840.1.114222.4.11.3106",
                    DefinitionText = "Whether travel was domestic or international",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4783b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TravelMode_CDC",
                    ValueSetName = "Travel Mode",
                    ValueSetOID = "2.16.840.1.114222.4.11.3107",
                    DefinitionText = "Mode of travel answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4883b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TravelPurpose_FDD",
                    ValueSetName = "Travel Purpose",
                    ValueSetOID = "2.16.840.1.114222.4.11.3108",
                    DefinitionText = "Purpose of travel answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4983b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TravelersHealthInfoSource_CDC",
                    ValueSetName = "Travelers Health Info Source",
                    ValueSetOID = "2.16.840.1.114222.4.11.3109",
                    DefinitionText = "Cholera prevention education measures answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4a83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CompletionStatusForValidValues_HL7_2x",
                    ValueSetName = "Treatment Completion Status (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.821",
                    DefinitionText = "status of treatment administration event.  Uses HL7 table 0322",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4b83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TreatmentOutcomeTetanus_VPD",
                    ValueSetName = "Treatment Outcome Tetanus (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3144",
                    DefinitionText = "Final outcome of tetanus answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4c83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TRI_EPA",
                    ValueSetName = "TRI Chemicals (EPA)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3057",
                    DefinitionText = "Toxics Release Inventory (TRI) data help communities identify facilities and chemical disposal or other release patterns that warrant further study and analysis.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4d83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TrichinellosisSignsSymptoms_FDD",
                    ValueSetName = "Trichinellosis Signs Symptoms  (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3110",
                    DefinitionText = "Trichinellosis signs and symptoms answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4e83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TrueFalse_CDC",
                    ValueSetName = "True False (TF)",
                    ValueSetOID = "2.16.840.1.114222.4.11.928",
                    DefinitionText = "True/False values that may be used when the source has a boolean (T/F) input field",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("4f83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_CorrectionalFacilityType_NND",
                    ValueSetName = "Type of Correctional Facility",
                    ValueSetOID = "2.16.840.1.114222.4.11.979",
                    DefinitionText = "Type of correctional facility",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5083b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_MIME_MediaType_IANA",
                    ValueSetName = "Type of Data",
                    ValueSetOID = "2.16.840.1.114222.4.11.1012",
                    DefinitionText = "Encoding as defined by MIME (Multipurpose Internet Mail Extensions)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5183b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_LongTermCareFacilityType_NND",
                    ValueSetName = "Type of Long Term Care Facility",
                    ValueSetOID = "2.16.840.1.114222.4.11.1006",
                    DefinitionText = "Types of long term care facilities",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 5, 8)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5283b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_TyphoidSignsSymptoms_FDD",
                    ValueSetName = "Typhoid Signs Symptoms (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3111",
                    DefinitionText = "Typhoid signs and symptoms answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5383b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_UnderlyingConditions_CDC",
                    ValueSetName = "Underlying Conditions",
                    ValueSetOID = "2.16.840.1.114222.4.11.3112",
                    DefinitionText = "Underlying medical conditions answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5483b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_UnitsOfMeasure_CDC",
                    ValueSetName = "Units of Measure",
                    ValueSetOID = "2.16.840.1.114222.4.11.838",
                    DefinitionText = "Units of Measure based on UCUM std which also includes dimension",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 3, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5583b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_UniversalIdType_HL7_2x",
                    ValueSetName = "Universal ID Type (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1055",
                    DefinitionText = "HL7 table 0301 contains the universal identifier type",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5683b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_VaccinatedAtLocation_CRA",
                    ValueSetName = "Vaccination Location (CRA)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1056",
                    DefinitionText = "Facility where vaccination performed",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5783b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_VaccineContraindications_CDC",
                    ValueSetName = "Vaccine Contraindications",
                    ValueSetOID = "2.16.840.1.114222.4.11.1057",
                    DefinitionText = "A condition which makes administration of a particular substance or treatment inadvisable",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5883b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_VaccineDoseNumber_Hepatitis",
                    ValueSetName = "Vaccine Dose Number (Hepatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3038",
                    DefinitionText = "Codes specifying the number of doses of hepatitis vaccine received.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5983b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_VaccineDosesReceived_Pertussis",
                    ValueSetName = "Vaccine Doses Received (Pertussis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3145",
                    DefinitionText = "Number of vaccine doses received for pertussis answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5a83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_VaccineDosesReceived_Tetanus",
                    ValueSetName = "Vaccine Doses Received (Tetanus)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3146",
                    DefinitionText = "Number of vaccine doses received for tetanus answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5b83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_VaccineNotGivenReasons_CDC",
                    ValueSetName = "Vaccine Not Given Reason",
                    ValueSetOID = "2.16.840.1.114222.4.11.931",
                    DefinitionText = "Reasons vaccine was not given",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 6, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5c83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_VaccinePurchasedWithFunds_CRA",
                    ValueSetName = "Vaccine Purchased With Funds",
                    ValueSetOID = "2.16.840.1.114222.4.11.1058",
                    DefinitionText = "Funding source types for purchasing the vaccine",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5d83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_VaccinesAdministeredCVX_CDC_NIP",
                    ValueSetName = "Vaccines administered (CVX)",
                    ValueSetOID = "2.16.840.1.114222.4.11.934",
                    DefinitionText = "Vaccine Name Keyword: Clinical Vaccines, Vaccine Names",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 7, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5e83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_ValueType_HL7_2x",
                    ValueSetName = "Value Type (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1059",
                    DefinitionText = "HL7 table 0125 contains the list of formats of the observation value in OBX-3.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 12, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("5f83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_PHINQuestions_Varicella",
                    ValueSetName = "PHIN Questions (Varicella)",
                    ValueSetOID = "2.16.840.1.114222.4.11.1062",
                    DefinitionText = "PHIN Questions value set for Varicella reporting",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6083b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_VirusType_ArboviralDisease",
                    ValueSetName = "Virus Type (Arboviral Disease)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3063",
                    DefinitionText = "Virus types answer list specific to Arbovirus/ArboNet reporting. Used with ARB001 data element in Arboviral MMG v1 guide.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 1, 21)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6183b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_VirusVariantType_AnimalRabies",
                    ValueSetName = "Virus Variant Type (Animal Rabies)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3067",
                    DefinitionText = "Animal rabies virus variant type answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6283b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_UnitsOfMeasureMassVolume_UCUM",
                    ValueSetName = "Volume Mass Units",
                    ValueSetOID = "2.16.840.1.114222.4.11.1054",
                    DefinitionText = "Volume Mass units of measure based on UCUM std",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6383b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_UnitsOfMeasureVolume_UCUM",
                    ValueSetName = "Volume Units",
                    ValueSetOID = "2.16.840.1.114222.4.11.1053",
                    DefinitionText = "Volume related units of Measure based on UCUM std",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6483b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_WaterSalinity_FDD",
                    ValueSetName = "Water Salinity (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3113",
                    DefinitionText = "Water type based on saline content or salt (e.g.  Fresh water, sea water)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6583b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_WeightUnit_UCUM",
                    ValueSetName = "Weight Unit",
                    ValueSetOID = "2.16.840.1.114222.4.11.879",
                    DefinitionText = "Units for measuring weight based on UCUM std.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6683b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_WellWaterTreatment_FDD",
                    ValueSetName = "Well Water Treatment (FDD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.3114",
                    DefinitionText = "Well water treatment type answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6783b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_WoundHistory_CDC",
                    ValueSetName = "Wound History",
                    ValueSetOID = "2.16.840.1.114222.4.11.3115",
                    DefinitionText = "Wound History during exposure answer list",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6883b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_YesNo_HL7_2x",
                    ValueSetName = "Yes No Indicator (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.819",
                    DefinitionText = "Value set used to respond to any question that can be answered only Yes or No. This value set is also HL7 table 0136 Yes/No Indicator.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 5, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6983b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_YesNoUnknown_CDC",
                    ValueSetName = "Yes No Unknown (YNU)",
                    ValueSetOID = "2.16.840.1.114222.4.11.888",
                    DefinitionText = "Value set used to respond to any question that can be answered Yes, No, or Unknown.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6a83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_YesNoUnknownNoAnswer_CDC",
                    ValueSetName = "Yes No Unknown No Answer",
                    ValueSetOID = "2.16.840.1.114222.4.11.3064",
                    DefinitionText = "Yes No Unknown No Answer",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6b83b3a0-607f-dd11-b38d-00188b398520"),
                    ValueSetCode = "PHVS_YesNoUnkNotDone_CDC",
                    ValueSetName = "Yes No Unknown Not Done",
                    ValueSetOID = "2.16.840.1.114222.4.11.3069",
                    DefinitionText = "Yes No Unknown Not done",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2008, 10, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("bff49c54-4a12-e211-8b0c-001a4be7fa90"),
                    ValueSetCode = "PHVS_UniversalIdType_ELR",
                    ValueSetName = "Universal ID Type (ELR)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6067",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 10, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("612bd2ff-6d18-e211-989d-001a4be7fa90"),
                    ValueSetCode = "PHVS_Industry_Census",
                    ValueSetName = "Industry (Census)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6037",
                    DefinitionText = "Alphabetical Indexes of Industries and Occupations were developed primarily for use in classifying a respondent's industry (employer's type of business) and occupation (employee's type of work) as reported in the Census 2000, the Current Population Survey, the American Community Survey, and other demographic surveys conducted by the Census Bureau. They list over 21,000 industry and 31,000 occupation titles in alphabetical order. They are comprehensive lists of specific industries and occupations developed over time and continuously updated through review of census and survey responses.For technical questions related to the Industry and Occupation Classification System, contact the Industry and Occupation Statistics Branch at 301-763-3239.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 11, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b7e68c37-7418-e211-989d-001a4be7fa90"),
                    ValueSetCode = "PHVS_Occupation_Census",
                    ValueSetName = "Occupation (Census)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6036",
                    DefinitionText = "Coding system of United States Census Occupation Codes, published by the US Governmetn Bureau of the Census.  Doucmentation and Crosswalk mapping between the COC and the SOC and NAICS code systems available at http://www.census.gov/hhes/www/ioindex/view.html",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 11, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6cf26cd0-852a-e211-9a21-001a4be7fa90"),
                    ValueSetCode = "PHVS_SmokingStatus_MU",
                    ValueSetName = "Smoking Status",
                    ValueSetOID = "2.16.840.1.114222.4.11.6027",
                    DefinitionText = "Smoking Status - Meaningful Use",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 11, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f923336c-8d2a-e211-9a21-001a4be7fa90"),
                    ValueSetCode = "PHVS_ICD10CMCancerReportabilityList_NAACCR",
                    ValueSetName = "NAACCR ICD-10-CM Cancer Reportability List",
                    ValueSetOID = "2.16.840.1.114222.4.11.6069",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 11, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("15247867-8f2a-e211-9a21-001a4be7fa90"),
                    ValueSetCode = "PHVS_ProviderCodes_NUCC",
                    ValueSetName = "Healthcare Provider Taxonomy Code (NUCC)",
                    ValueSetOID = "2.16.840.1.113883.11.19465",
                    DefinitionText = "The Healthcare Provider Taxonomy code set divides health care providers into hierarchical groupings by type, classification, and specialization, and assigns a code to each grouping. The Taxonomy consists of two parts: individuals (e.g., physicians) and non-individuals (e.g., ambulatory health care facilities). All codes are alphanumeric and are 10 positions in length. These codes are not “assigned” to health care providers; rather, health care providers select the taxonomy code(s) that most closely represents their education, license, or certification. If a health care provider has more than one taxonomy code associated with it, a health plan may prefer that the health care provider use one over another when submitting claims for certain services.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 1, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("cf0e03c9-0960-e211-9a66-001a4be7fa90"),
                    ValueSetCode = "PHVS_InfectionsDuringPregnancyLiveBirth_NCHS",
                    ValueSetName = "Infections During Pregnancy - Live Birth (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6070",
                    DefinitionText = "Infections present and/or treated during this pregnancy for live birth as required by the National US Standards. Note: Genital herpes simplex (SNOMED code 33839006) is only a Michigan state-specific requirement.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 12, 12)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("38e63a65-2560-e211-9a66-001a4be7fa90"),
                    ValueSetCode = "PHVS_Gonorrhea_NCHS",
                    ValueSetName = "Gonorrhea (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6071",
                    DefinitionText = "To reflect Gonorrhea as Infections present and treated during this pregnancy",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 26)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("d97ec59a-2560-e211-9a66-001a4be7fa90"),
                    ValueSetCode = "PHVS_Trachoma_NCHS",
                    ValueSetName = "Trachoma (NCHS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6072",
                    DefinitionText = "",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 6, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("56d2318c-aede-e111-ae8b-001a4be7fa90"),
                    ValueSetCode = "PHVS_MessageStructure_SyndromicSurveillance",
                    ValueSetName = "Message Structure (Syndromic Surveillance)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6047",
                    DefinitionText = "List of HL7 Table 0354: Message Structure associated with Syndromic Surveillance",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("80922a25-b0de-e111-ae8b-001a4be7fa90"),
                    ValueSetCode = "PHVS_EventType_SyndromicSurveillance",
                    ValueSetName = "Event Type (Syndromic Surveillance)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6048",
                    DefinitionText = "List of Table 0003: Event Types associated with Syndromic Surveillance IG.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 8, 4)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("2bc3b69f-fade-e111-ae8b-001a4be7fa90"),
                    ValueSetCode = "PHVS_MessageType_SyndromicSurveillance",
                    ValueSetName = "Message Type (Syndromic Surveillance)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6049",
                    DefinitionText = "List of Table 0076 Message Types supported by Syndromic Surveillance IG",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2014, 9, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("47c9bf5f-fede-e111-ae8b-001a4be7fa90"),
                    ValueSetCode = "PHVS_UniversalIDType_SyndromicSurveillance",
                    ValueSetName = "Universal ID Type (Syndromic Surveillance)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6050",
                    DefinitionText = "List of Universal ID Types supported by Syndromic Surveillance IG.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 8, 9)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("37ce5cd0-9ce0-e111-ae8b-001a4be7fa90"),
                    ValueSetCode = "PHVS_FundingEligibilityObsMethod_IIS",
                    ValueSetName = "Funding Eligibility Observation Method (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6039",
                    DefinitionText = "The Funding Eligibility Observation Method identifies the method for capturing funding program eligibility. Note that it is always reported at the immunization level. Used in OBX- 17",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 8, 7)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f712145e-a0e0-e111-ae8b-001a4be7fa90"),
                    ValueSetCode = "PHVS_VISBarcodes_IIS",
                    ValueSetName = "VIS Bar Codes (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6041",
                    DefinitionText = "The purpose of the barcode on the bottom of the Vaccine Information Statement (VIS) is to provide an opportunity to electronically capture the VIS document type (e.g. influenza, MMR) and the edition date of the VIS, as required by the National Childhood Vaccine Injury Act (NCVIA). For more information, please visit - http://www.cdc.gov/vaccines/pubs/vis/vis-barcodes.htm",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 3, 22)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("e4a56495-01eb-e111-ae8b-001a4be7fa90"),
                    ValueSetCode = "PHVS_LabTestName_ReportableConditions",
                    ValueSetName = "Lab Test Name (Reportable Conditions)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6053",
                    DefinitionText = "All Reportable Condition Mappping Tables (RCMT) value sets for test names were consolidated into 1 value set.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2017, 6, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b259e1d7-01eb-e111-ae8b-001a4be7fa90"),
                    ValueSetCode = "PHVS_LabTestResult_ReportableConditions",
                    ValueSetName = "Lab Test Result (Reportable Conditions)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6054",
                    DefinitionText = "All Reportable Condition Mappping Tables (RCMT) value sets for test results were consolidated into 1 value set.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 6, 3)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("361264be-d54a-e211-b38c-001a4be7fa90"),
                    ValueSetCode = "PHVS_MorphologyOfNeoplasmsICD-9-CM",
                    ValueSetName = "Morphology of Neoplasms ICD-9-CM",
                    ValueSetOID = "2.16.840.1.114222.4.11.6038",
                    DefinitionText = "Appendix A",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 12, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f98d415c-8af1-e111-b875-001a4be7fa90"),
                    ValueSetCode = "PHVS_NameType_SyndromicSurveillance",
                    ValueSetName = "Name Type (Syndromic Surveillance)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6056",
                    DefinitionText = "Contains the constrained value set for syndromic surveillance (ED) IG with Legal, psuedonym and Unspecified name types.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 8, 28)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("219633d9-8af1-e111-b875-001a4be7fa90"),
                    ValueSetCode = "PHVS_ValueType_SyndromicSurveillance",
                    ValueSetName = "Value Type (Syndromic Surveillance)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6057",
                    DefinitionText = "Constrained value set of Hl7 Table 0125 Value Type for Syndromic Surveillance (ED).",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 12, 16)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("060d05ff-f1f1-e111-b875-001a4be7fa90"),
                    ValueSetCode = "PHVS_LabTestName_HEDIS",
                    ValueSetName = "Lab Test Name (HEDIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6055",
                    DefinitionText = "The value set is defined as being the set of LOINC values used in HEDIS measures. This material is drawn from the HEDIS 2008 Electronic Coding Tables specification.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 8, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6d1a39ef-0af2-e111-b875-001a4be7fa90"),
                    ValueSetCode = "PHVS_VISVaccines_IIS",
                    ValueSetName = "VIS Vaccines (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6040",
                    DefinitionText = "This table lists the vaccines which require that a Vaccine Information Statement (VIS) be shared with a patient/parent. The VIS document type, edition date and presentation date are reported in a set of OBX.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2016, 7, 21)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a1960ef9-0ef3-e111-b875-001a4be7fa90"),
                    ValueSetCode = "PHVS_ObservationResultStatus_IIS",
                    ValueSetName = "Observation Result Status Interpretation Codes",
                    ValueSetOID = "2.16.840.1.114222.4.11.6062",
                    DefinitionText = "Value set made from HL7 Table 0085",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 8, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3a583f38-11f3-e111-b875-001a4be7fa90"),
                    ValueSetCode = "PHVS_UniversalIDType_IIS",
                    ValueSetName = "Universal ID Type (IIS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6063",
                    DefinitionText = "HL7-defined Table 0301 - Universal ID type constrained for Immunization",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 8, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("be2abfb3-2ff8-e111-b875-001a4be7fa90"),
                    ValueSetCode = "PHVS_ValueType_ELR",
                    ValueSetName = "Value Type (ELR)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6064",
                    DefinitionText = "list of formats from HL7 table 0125 of the observation value in OBX-3 constrained for ELR",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("af46b692-6df8-e111-b875-001a4be7fa90"),
                    ValueSetCode = "PHVS_Race_HL7_2x",
                    ValueSetName = "Race (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6065",
                    DefinitionText = "This race value set is based upon CDC check-digit codes, but using the HL7 table 0005. HL7 adopted the CDC Race and Ethncity codes in HL7 Table 0005 in 2005. This value set has been created for backward compatibility and some historic Implementation guides (E.g. Immunization). Recommend using Race Category value set based upon CDC Race & Ethnicity code system.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("1d88950c-6ef8-e111-b875-001a4be7fa90"),
                    ValueSetCode = "PHVS_EthnicGroup_HL7_2x",
                    ValueSetName = "Ethnic Group (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6066",
                    DefinitionText = "This value set is based upon HL7 table 0189. This has been created for backward compatibility. HL7 has adopted CDC race and ethnicity code system in 2005. CDC recommends to use the Ethnicity group value set based upon CDC Race & Ethnicity code system (Check digit codes)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("016c7281-72f8-e111-b875-001a4be7fa90"),
                    ValueSetCode = "FHIM_ImmunizationFundingSource",
                    ValueSetName = "Immunization Funding Source Excluding Nulls",
                    ValueSetOID = "2.16.840.1.113883.3.2074.1.1.1",
                    DefinitionText = "Category of organization providing funds for an immunization. This value set includes the values in the CDC value set Immunization Funding Source (IIS), (2.16.840.1.114222.4.11.3287), excepting the two null values, and is used in HL7 V2 OBX-5.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 9, 10)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("647af92a-73f8-e111-b875-001a4be7fa90"),
                    ValueSetCode = "FHIM_PatientImmunizationRegistryStatus",
                    ValueSetName = "Pt Immunization Registry Status Excluding Nulls",
                    ValueSetOID = "2.16.840.1.113883.3.2074.1.1.2",
                    DefinitionText = "Standing of registry information regarding a patient. This information indicates whether patient information is current and appropriate for updates, and is used in HL7 V2 segment PD1-16.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("19121408-74f8-e111-b875-001a4be7fa90"),
                    ValueSetCode = "FHIM_RaceCategory",
                    ValueSetName = "Race Category Excluding Nulls",
                    ValueSetOID = "2.16.840.1.113883.3.2074.1.1.3",
                    DefinitionText = "Person's race category, of which a person may have more than one. This value set includes all the codes from PHVS_RaceCategory_CDC (2.16.840.1.114222.4.11.836) except Other Race.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2013, 2, 21)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("47e9f69d-74f8-e111-b875-001a4be7fa90"),
                    ValueSetCode = "FHIM_ImmunizationRefusalReason",
                    ValueSetName = "Immunization Refusal Reason Excluding Nulls",
                    ValueSetOID = "2.16.840.1.113883.3.2074.1.1.4",
                    DefinitionText = "Causes specified for refusing vaccination, combined with roles of those deciding to refuse it. This value set includes all the codes from PHVS_SubstanceRefusalReason_IIS (2.16.840.1.114222.4.11.3380) except Other.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 9, 6)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("88e2efc9-335f-e111-8793-0050568d00f8"),
                    ValueSetCode = "PHVS_LabTestType_Hepatitis",
                    ValueSetName = "Lab Test Type (Hepatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6013",
                    DefinitionText = "Lab Test Type (Hepatitis)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2015, 2, 20)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("250aeed9-615f-e111-8793-0050568d00f8"),
                    ValueSetCode = "PHVS_LabTestTypeEnzymes_Hepatitis",
                    ValueSetName = "Lab Test Type Enzymes (Hepatitis)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6014",
                    DefinitionText = "Lab Test Type Enzymes (Hepatitis)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 2, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9faaf5c6-a9fe-e011-96fc-0050568d00f8"),
                    ValueSetCode = "PHVS_LegacyReportingJurisdiction_NND_CDS",
                    ValueSetName = "Legacy Reporting Jurisdiction (CDS)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6006",
                    DefinitionText = "NETSS - Legacy Reporting Jurisdiction value set for CDS internal use. Not to be used in HL7 messaging. this value set has same concepts as National Reporting Jurisdiction except for the New York City and Palau codes.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 10, 24)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a8d46e18-9ed2-e011-a127-0050568d00f8"),
                    ValueSetCode = "PHVS_OrigSpecimenSourceSite_PHLIP_PLT212",
                    ValueSetName = "Original Specimen Source Site PHLIP (PLT212)",
                    ValueSetOID = "2.16.840.1.114222.4.11.5021",
                    DefinitionText = "Valueset used for Salmonella ETOR pilot to describe the original specimen source ste",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 8, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("3ea92709-0dd3-e011-a127-0050568d00f8"),
                    ValueSetCode = "PHVS_OrigSpecimenCollectionMethod_PHLIP",
                    ValueSetName = "Original Specimen Collection Method PHLIP",
                    ValueSetOID = "2.16.840.1.114222.4.11.5023",
                    DefinitionText = "describes the specimen collection method for the cliniccal (original) specimen - uses SNOMED CT procedure hierarchy",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 8, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("960fd465-1cd3-e011-a127-0050568d00f8"),
                    ValueSetCode = "PHVS_OrigSpecimenSourceSiteMod_PHLIP",
                    ValueSetName = "Original Specimen Source Site Modifier PHLIP",
                    ValueSetOID = "2.16.840.1.114222.4.11.5022",
                    DefinitionText = "describes the source site in more detail than the speicmensource site terems - drawn form SNOMED qualifier hierarchy",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 8, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("eea3a3b0-1dd3-e011-a127-0050568d00f8"),
                    ValueSetCode = "PHVS_OrigSpecimenTypeMod_PHLIP",
                    ValueSetName = "Original Specimen Type Modifier PHLIP",
                    ValueSetOID = "2.16.840.1.11222.4.11.5025",
                    DefinitionText = "describes the specimen type further than the specimen tyoe terms, drawn from SNOMED qualifier hierarchy for now",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 8, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b6c2870c-1fd3-e011-a127-0050568d00f8"),
                    ValueSetCode = "PHVS_OrigSpecimenType_PHLIP",
                    ValueSetName = "Original Specimen Type PHLIP",
                    ValueSetOID = "2.16.840.1.114222.4.11.5024",
                    DefinitionText = "describes the specimentype using SNOMED CT specimen hierarchy terms",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 8, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f66a5aee-20d3-e011-a127-0050568d00f8"),
                    ValueSetCode = "PHVS_SpecimenType_PHLIP",
                    ValueSetName = "Specimen Type PHLIP",
                    ValueSetOID = "2.16.840.1.114222.4.11.5001",
                    DefinitionText = "describes the specimen type submitted using SNOMED CT specimen hierarchy terms",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 8, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("c6237f38-55d3-e011-a127-0050568d00f8"),
                    ValueSetCode = "PHVS_ResultedLabTestName_PHLIP_Sal",
                    ValueSetName = "Resulted Lab Test Name PHLIP Salmonella",
                    ValueSetOID = "2.16.840.1.114222.4.11.5017",
                    DefinitionText = "values for OBX.3 drawn from LOINC and PLT codign systems",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 8, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("b6a99fc0-5ed3-e011-a127-0050568d00f8"),
                    ValueSetCode = "PHVS_LabTestResult_PHLIP_Sal",
                    ValueSetName = "Lab Test Result PHLIP Salmonella",
                    ValueSetOID = "2.16.840.1.114222.4.11.5026",
                    DefinitionText = "results in OBX.5 drawn from SNOMED organism or qualifier hierarchy or PLR coding system",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 8, 30)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a66cd713-f8d3-e011-a127-0050568d00f8"),
                    ValueSetCode = "PHVS_IdentifierType_HL7_PHLIP_PID3.5",
                    ValueSetName = "Identifier Type (HL7) (PHLIP for PID3.5)",
                    ValueSetOID = "2.16.840.1.114222.4.11.5027",
                    DefinitionText = "use for PID.3.5 in ETOR Salmonella phase 1",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 8, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("decbb951-f9d3-e011-a127-0050568d00f8"),
                    ValueSetCode = "PHVS_MethodDetail_PHLIP",
                    ValueSetName = "Method Detail (PHLIP)",
                    ValueSetOID = "2.16.840.1.114222.4.11.5028",
                    DefinitionText = "use with OBX.17",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 8, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("6ee2ff15-0fd4-e011-a127-0050568d00f8"),
                    ValueSetCode = "PHVS_ProblemGoalActionCode_HL7_2x",
                    ValueSetName = "Problem Goal Action Code (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6000",
                    DefinitionText = "Problem Goal Action Code (HL7) - HL7 Table 0287",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2011, 8, 31)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("12b81bd0-2a58-e111-a16f-0050568d00f8"),
                    ValueSetCode = "PHVS_ICD9CMCancerReportabilityList_NAACCR",
                    ValueSetName = "NAACCR ICD-9-CM Cancer Reportability List",
                    ValueSetOID = "2.16.840.1.113883.3.520.4.16",
                    DefinitionText = "NAACCR ICD-9-CM Cancer Reportability List",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 2, 15)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("de399690-f6d4-e111-ac0b-0050568d00f8"),
                    ValueSetCode = "PHVS_SpecimenType_HL7_2x",
                    ValueSetName = "Specimen Type (HL7)",
                    ValueSetOID = "2.16.840.1.114222.4.11.6046",
                    DefinitionText = "Specimen Type (HL7)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2012, 7, 23)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("9214dc8b-1764-e811-9e34-005056990929"),
                    ValueSetCode = "PHVS_SpecimenSourceSite_VPD",
                    ValueSetName = "Specimen Source Site (VPD)",
                    ValueSetOID = "2.16.840.1.114222.4.11.7826",
                    DefinitionText = "Body site from where specimen was taken.",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 6, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("36937698-87c6-e811-8174-005056ab3bbb"),
                    ValueSetCode = "PHVS_ValueSetA_DEV",
                    ValueSetName = "Value Set A (DEV)",
                    ValueSetOID = "2.16.840.1.114222.4.11.9999.124",
                    DefinitionText = "Value Set A (DEV)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 10, 5)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("511e0016-34d2-e811-8174-005056ab3bbb"),
                    ValueSetCode = "PHVS_ValueSetA_DEV12",
                    ValueSetName = "Value Set A (DEV12)",
                    ValueSetOID = "2.16.840.1.114222.4.11.9999.125",
                    DefinitionText = "The U.S. Centers for Disease Control and Prevention (CDC) has prepared a code set for use in coding race and ethnicity data. This code set is based on current federal standards for classifying data on race and ethnicity, specifically the minimum race and (truncated) description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text, description text,(2000)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 10, 29)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("8b7627d8-cd03-e911-8177-005056ab3bbb"),
                    ValueSetCode = "PHVS_ImportingValueset_DEV11",
                    ValueSetName = "Importing ValueSet (DEV11)",
                    ValueSetOID = "2.16.840.1.114222.4.11.9999.126",
                    DefinitionText = "desc",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2018, 12, 19)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("a49edf4e-c154-e911-8181-005056ab3bbb"),
                    ValueSetCode = "PHVS_SearchTest_DEV11",
                    ValueSetName = "Search Test (DEV11)",
                    ValueSetOID = "2.16.840.1.114222.4.11.9999.129",
                    DefinitionText = "Search Test (DEV11)",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2019, 4, 1)
                },
                new ValueSet()
                {
                    ValueSetID = new Guid("f11e1b4c-2856-e911-8181-005056ab3bbb"),
                    ValueSetCode = "PHVS_SearchTest_DEV11_2",
                    ValueSetName = "Search Test (DEV11) 2",
                    ValueSetOID = "2.16.840.1.114222.4.11.9999.130",
                    DefinitionText = "test value set",
                    ScopeNoteText = "",
                    StatusDate = new DateTime(2019, 4, 3)
                },
            };

            context.ValueSets.AddRange(valueSets);
            context.SaveChanges();
        }
    }
}
