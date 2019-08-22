using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Cdc.Vocabulary.Entities;
using Cdc.Vocabulary.WebApi.Helpers;
using Cdc.Vocabulary.WebApi.Models;

namespace Cdc.Vocabulary.Services
{
    public sealed class ValueSetRepository : IValueSetRepository
    {
        private ValueSetContext _context;

        public ValueSetRepository(ValueSetContext context)
        {
            _context = context;
        }

        public PagedList<ValueSet> GetValueSets(PaginationParameters parameters)
        {
            var collectionBeforePaging = _context.ValueSets
                .OrderBy(v => v.ValueSetCode);

            return PagedList<ValueSet>.Create(collectionBeforePaging,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public IEnumerable<ValueSet> GetValueSets(IEnumerable<Guid> ids)
        {
            return _context.ValueSets.Where(a => ids.Contains(a.ValueSetID))
                .OrderBy(a => a.ValueSetCode)
                .ToList();
        }

        public ValueSet GetValueSet(Guid id)
        {
            return _context.ValueSets.FirstOrDefault(a => a.ValueSetID == id);
        }

        public void AddValueSet(ValueSet valueSet)
        {
            valueSet.ValueSetID = Guid.NewGuid();
            valueSet.ValueSetCreatedDate = DateTime.Now;
            valueSet.ValueSetLastRevisionDate = DateTime.Now;
            valueSet.StatusDate = DateTime.Now;
            _context.ValueSets.Add(valueSet);
        }

        public void DeleteValueSet(ValueSet valueSet)
        {
            _context.ValueSets.Remove(valueSet);
        }

        public void UpdateValueSet(ValueSet valueSet)
        {
            // no code in this implementation
            valueSet.ValueSetLastRevisionDate = DateTime.Now;
        }

        public bool ValueSetExists(Guid id)
        {
            return _context.ValueSets.Any(a => a.ValueSetID == id);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
