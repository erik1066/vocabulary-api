using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Cdc.Vocabulary.Entities;
using Cdc.Vocabulary.WebApi.Helpers;
using Cdc.Vocabulary.WebApi.Models;

namespace Cdc.Vocabulary.Services
{
    public sealed class ValueSetConceptRepository : IValueSetConceptRepository
    {
        private VocabularyContext _context;

        public ValueSetConceptRepository(VocabularyContext context)
        {
            _context = context;
        }

        public PagedList<ValueSetConcept> GetValueSetConcepts(ValueSetConceptPaginationParameters parameters)
        {
            var collection = _context.ValueSetConcepts
                .Join(_context.ValueSetVersions,
                    vsc => vsc.ValueSetVersionID,
                    vsv => vsv.ValueSetVersionID,
                    (vsc, vsv) => new ValueSetConcept()
                    {
                        ValueSetConceptID = vsc.ValueSetConceptID,
                        CodeSystemConceptName = vsc.CodeSystemConceptName,
                        ValueSetConceptStatusCode = vsc.ValueSetConceptStatusCode,
                        ValueSetConceptStatusDate = vsc.ValueSetConceptStatusDate,
                        ValueSetConceptDefinitionText = vsc.ValueSetConceptDefinitionText != "NULL" ? vsc.ValueSetConceptDefinitionText : string.Empty,
                        CDCPreferredDesignation = vsc.CDCPreferredDesignation,
                        ScopeNoteText = vsc.ScopeNoteText,
                        ValueSetVersionID = vsc.ValueSetVersionID,
                        CodeSystemOID = vsc.CodeSystemOID,
                        ConceptCode = vsc.ConceptCode,
                        Sequence = vsc.Sequence,
                        ValueSetOID = vsv.ValueSetOID,
                        ValueSetVersionNumber = vsv.ValueSetVersionNumber
                    })
                .Join(_context.ValueSets,
                    vsc => vsc.ValueSetOID,
                    vs => vs.ValueSetOID,
                    (vsc, vs) => new ValueSetConcept()
                    {
                        ValueSetConceptID = vsc.ValueSetConceptID,
                        CodeSystemConceptName = vsc.CodeSystemConceptName,
                        ValueSetConceptStatusCode = vsc.ValueSetConceptStatusCode,
                        ValueSetConceptStatusDate = vsc.ValueSetConceptStatusDate,
                        ValueSetConceptDefinitionText = vsc.ValueSetConceptDefinitionText,
                        CDCPreferredDesignation = vsc.CDCPreferredDesignation,
                        ScopeNoteText = vsc.ScopeNoteText,
                        ValueSetVersionID = vsc.ValueSetVersionID,
                        CodeSystemOID = vsc.CodeSystemOID,
                        ConceptCode = vsc.ConceptCode,
                        Sequence = vsc.Sequence,
                        ValueSetOID = vsc.ValueSetOID,
                        ValueSetVersionNumber = vsc.ValueSetVersionNumber,
                        ValueSetCode = vs.ValueSetCode
                    })
                .Join(_context.CodeSystems,
                    vsc => vsc.CodeSystemOID,
                    cs => cs.CodeSystemOID,
                    (vsc, cs) => new ValueSetConcept()
                    {
                        ValueSetConceptID = vsc.ValueSetConceptID,
                        CodeSystemConceptName = vsc.CodeSystemConceptName,
                        ValueSetConceptStatusCode = vsc.ValueSetConceptStatusCode,
                        ValueSetConceptStatusDate = vsc.ValueSetConceptStatusDate,
                        ValueSetConceptDefinitionText = vsc.ValueSetConceptDefinitionText,
                        CDCPreferredDesignation = vsc.CDCPreferredDesignation,
                        ScopeNoteText = vsc.ScopeNoteText,
                        ValueSetVersionID = vsc.ValueSetVersionID,
                        CodeSystemOID = vsc.CodeSystemOID,
                        ConceptCode = vsc.ConceptCode,
                        Sequence = vsc.Sequence,
                        ValueSetOID = vsc.ValueSetOID,
                        ValueSetVersionNumber = vsc.ValueSetVersionNumber,
                        ValueSetCode = vsc.ValueSetCode,
                        HL70396Identifier = cs.HL70396Identifier
                    });

            if (!string.IsNullOrWhiteSpace(parameters.Code))
            {
                collection = collection.Where(c =>
                    c.ValueSetCode != null ?
                        c.ValueSetCode.Equals(parameters.Code, StringComparison.OrdinalIgnoreCase) :
                        true
                    );
            }
            if (!string.IsNullOrWhiteSpace(parameters.Oid))
            {
                collection = collection.Where(c =>
                    c.ValueSetOID != null ?
                        c.ValueSetOID.Equals(parameters.Oid) :
                        true
                    );
            }
            if (parameters.ValueSetVersionId != null)
            {
                collection = collection.Where(c =>
                    c.ValueSetVersionID != null ?
                        c.ValueSetVersionID == parameters.ValueSetVersionId :
                        true
                    );
            }
            if (parameters.ValueSetVersionNumber != null)
            {
                collection = collection.Where(c =>
                    c.ValueSetVersionNumber != null ?
                        c.ValueSetVersionNumber == parameters.ValueSetVersionNumber :
                        true
                    );
            }
            if (!string.IsNullOrWhiteSpace(parameters.SearchQuery))
            {
                var searchQueryStringForWhereClause = string.Empty;
                searchQueryStringForWhereClause = parameters.SearchQuery.Trim().ToLowerInvariant();

                if (parameters.SearchType == MatchType.Contains)
                {
                    collection = collection.Where(v =>
                        v.ValueSetConceptDefinitionText.ToLowerInvariant().Contains(searchQueryStringForWhereClause) ||
                        v.CDCPreferredDesignation.ToLowerInvariant().Contains(searchQueryStringForWhereClause)
                    );
                }
                else if (parameters.SearchType == MatchType.StartsWith)
                {
                    collection = collection.Where(v =>
                        v.ValueSetConceptDefinitionText.ToLowerInvariant().StartsWith(searchQueryStringForWhereClause) ||
                        v.CDCPreferredDesignation.ToLowerInvariant().StartsWith(searchQueryStringForWhereClause)
                    );
                }
            }

            return PagedList<ValueSetConcept>.Create(collection,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public IEnumerable<ValueSetConcept> GetValueSetConcepts(IEnumerable<Guid> ids)
        {
            return _context.ValueSetConcepts.Where(a => ids.Contains(a.ValueSetConceptID))
                .OrderBy(a => a.ConceptCode)
                .ToList();
        }

        public ValueSetConcept GetValueSetConcept(Guid id)
        {
            return _context.ValueSetConcepts.FirstOrDefault(a => a.ValueSetConceptID == id);
        }

        public void AddValueSetConcept(ValueSetConcept valueSetConcept)
        {
            valueSetConcept.ValueSetConceptID = Guid.NewGuid();
            valueSetConcept.ValueSetConceptStatusDate = DateTime.Now;
            _context.ValueSetConcepts.Add(valueSetConcept);
        }

        public void DeleteValueSetConcept(ValueSetConcept valueSetConcept)
        {
            _context.ValueSetConcepts.Remove(valueSetConcept);
        }

        public void UpdateValueSetConcept(ValueSetConcept valueSetConcept)
        {
            // no code in this implementation
        }

        public bool ValueSetConceptExists(Guid id)
        {
            return _context.ValueSetConcepts.Any(a => a.ValueSetConceptID == id);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}