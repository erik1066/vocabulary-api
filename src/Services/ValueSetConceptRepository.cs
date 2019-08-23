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
        private ValueSetConceptContext _context;

        public ValueSetConceptRepository(ValueSetConceptContext context)
        {
            _context = context;
        }

        public PagedList<ValueSetConcept> GetValueSetConcepts(PaginationParameters parameters)
        {
            var collectionBeforePaging = _context.ValueSetConcepts
                .OrderBy(v => v.ConceptCode);

            if (!string.IsNullOrWhiteSpace(parameters.SearchQuery))
            {
                var searchQueryStringForWhereClause = parameters.SearchQuery.Trim().ToLowerInvariant();
                collectionBeforePaging = _context.ValueSetConcepts
                    .Where(
                        v =>
                            v.ConceptCode.ToLowerInvariant().Contains(searchQueryStringForWhereClause) ||
                            v.CDCPreferredDesignation.ToLowerInvariant().Contains(searchQueryStringForWhereClause) ||
                            v.ValueSetConceptDefinitionText.ToLowerInvariant().Contains(searchQueryStringForWhereClause)
                    )
                    .OrderBy(v => v.ConceptCode);
            }

            return PagedList<ValueSetConcept>.Create(collectionBeforePaging,
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
