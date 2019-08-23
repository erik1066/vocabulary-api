using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Cdc.Vocabulary.Entities;
using Cdc.Vocabulary.WebApi.Helpers;
using Cdc.Vocabulary.WebApi.Models;

namespace Cdc.Vocabulary.Services
{
    public sealed class ValueSetVersionRepository : IValueSetVersionRepository
    {
        private ValueSetVersionContext _context;

        public ValueSetVersionRepository(ValueSetVersionContext context)
        {
            _context = context;
        }

        public PagedList<ValueSetVersion> GetValueSetVersions(ValueSetVersionPaginationParameters parameters)
        {
            var collectionBeforePaging = _context.ValueSetVersions;

            if (!string.IsNullOrWhiteSpace(parameters.Oid))
            {
                collectionBeforePaging.Where(v => v.ValueSetOID.Equals(parameters.Oid));    
            }

            // if (!string.IsNullOrWhiteSpace(parameters.Code))
            // {
            //     collectionBeforePaging.Where(v => v.ValueSetCode.Contains(parameters.Code));    
            // }

            var searchQueryStringForWhereClause = string.Empty;

            if (!string.IsNullOrWhiteSpace(parameters.SearchQuery))
            {
                searchQueryStringForWhereClause = parameters.SearchQuery.Trim().ToLowerInvariant();
            }

            collectionBeforePaging
                .Where(v => 
                    !string.IsNullOrWhiteSpace(parameters.Oid) ? v.ValueSetOID.Equals(parameters.Oid) : true)
                .Where(v => 
                    !string.IsNullOrWhiteSpace(searchQueryStringForWhereClause) ? v.ValueSetVersionDescriptionText.ToLowerInvariant().Contains(searchQueryStringForWhereClause) : true)
                .OrderBy(a => a.ValueSetOID)
                .ThenBy(a => a.ValueSetVersionNumber);

            return PagedList<ValueSetVersion>.Create(collectionBeforePaging,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public IEnumerable<ValueSetVersion> GetValueSetVersions(IEnumerable<Guid> ids)
        {
            return _context.ValueSetVersions.Where(a => ids.Contains(a.ValueSetVersionID))
                .OrderBy(a => a.ValueSetOID)
                .ThenBy(a => a.ValueSetVersionNumber)
                .ToList();
        }

        public ValueSetVersion GetValueSetVersion(Guid id)
        {
            return _context.ValueSetVersions.FirstOrDefault(a => a.ValueSetVersionID == id);
        }

        public void AddValueSetVersion(ValueSetVersion valueSetVersion)
        {
            valueSetVersion.ValueSetVersionID = Guid.NewGuid();
            // TODO: Increment version #
            valueSetVersion.StatusDate = DateTime.Now;
            _context.ValueSetVersions.Add(valueSetVersion);
        }

        public void DeleteValueSetVersion(ValueSetVersion valueSetVersion)
        {
            _context.ValueSetVersions.Remove(valueSetVersion);
        }

        public void UpdateValueSetVersion(ValueSetVersion valueSetVersion)
        {
            // no code in this implementation
        }

        public bool ValueSetVersionExists(Guid id)
        {
            return _context.ValueSetVersions.Any(a => a.ValueSetVersionID == id);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
