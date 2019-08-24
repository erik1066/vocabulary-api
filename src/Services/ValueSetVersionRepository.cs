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
        private VocabularyContext _context;

        public ValueSetVersionRepository(VocabularyContext context)
        {
            _context = context;
        }

        private IQueryable<ValueSetVersion> JoinOnValueSet(IQueryable<ValueSetVersion> collectionBeforePaging)
        {
            collectionBeforePaging = collectionBeforePaging.Join(_context.ValueSets, // the source table of the inner join
                vsv => vsv.ValueSetOID,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
                vs => vs.ValueSetOID,   // Select the foreign key (the second part of the "on" clause)
                (vsv, vs) => new ValueSetVersion()
                {
                    ValueSetVersionID = vsv.ValueSetVersionID,
                    ValueSetVersionNumber = vsv.ValueSetVersionNumber,
                    ValueSetVersionDescriptionText = vsv.ValueSetVersionDescriptionText,
                    AssigningAuthorityVersionText = vsv.AssigningAuthorityVersionText,
                    StatusCode = vsv.StatusCode,
                    StatusDate = vsv.StatusDate,
                    AssigningAuthorityReleaseDate = vsv.AssigningAuthorityReleaseDate,
                    NoteText = vsv.NoteText,
                    EffectiveDate = vsv.EffectiveDate,
                    ExpiryDate = vsv.ExpiryDate,
                    ValueSetOID = vsv.ValueSetOID,
                    ValueSetCode = vs.ValueSetCode,
                    ValueSetName = vs.ValueSetName,
                    DefinitionText = vs.DefinitionText
                });

            return collectionBeforePaging;
        }

        public PagedList<ValueSetVersion> GetValueSetVersions(ValueSetVersionPaginationParameters parameters)
        {
            IQueryable<ValueSetVersion> collectionBeforePaging = _context.ValueSetVersions;

            collectionBeforePaging = JoinOnValueSet(collectionBeforePaging);

            if (!string.IsNullOrWhiteSpace(parameters.Oid))
            {
                collectionBeforePaging = collectionBeforePaging.Where(v => v.ValueSetOID.Equals(parameters.Oid));
            }

            if (!string.IsNullOrWhiteSpace(parameters.Code))
            {
                collectionBeforePaging = collectionBeforePaging.Where(v => v.ValueSetCode.Equals(parameters.Code, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(parameters.SearchQuery))
            {
                var searchQueryStringForWhereClause = string.Empty;
                searchQueryStringForWhereClause = parameters.SearchQuery.Trim().ToLowerInvariant();
                collectionBeforePaging = collectionBeforePaging.Where(v =>
                    v.ValueSetVersionDescriptionText.ToLowerInvariant().Contains(searchQueryStringForWhereClause) ||
                    v.DefinitionText.ToLowerInvariant().Contains(searchQueryStringForWhereClause) ||
                    v.ValueSetCode.ToLowerInvariant().Contains(searchQueryStringForWhereClause) ||
                    v.ValueSetName.ToLowerInvariant().Contains(searchQueryStringForWhereClause)
                );
            }

            collectionBeforePaging = collectionBeforePaging
                .OrderBy(a => a.ValueSetCode)
                .ThenBy(a => a.ValueSetVersionNumber);

            return PagedList<ValueSetVersion>.Create(collectionBeforePaging,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public IEnumerable<ValueSetVersion> GetValueSetVersions(IEnumerable<Guid> ids)
        {
            IQueryable<ValueSetVersion> collection = _context.ValueSetVersions;
            collection = JoinOnValueSet(collection);

            return collection.Where(a => ids.Contains(a.ValueSetVersionID))
                .OrderBy(a => a.ValueSetOID)
                .ThenBy(a => a.ValueSetVersionNumber)
                .ToList();
        }

        public ValueSetVersion GetValueSetVersion(Guid id)
        {
            IQueryable<ValueSetVersion> collection = _context.ValueSetVersions;
            collection = JoinOnValueSet(collection);

            return collection.FirstOrDefault(a => a.ValueSetVersionID == id);
        }

        public void AddValueSetVersion(ValueSetVersion valueSetVersion)
        {
            valueSetVersion.ValueSetVersionID = Guid.NewGuid();

            valueSetVersion.StatusDate = DateTime.Now;
            int newVersionNumber = _context.ValueSetVersions.Max(v => v.ValueSetVersionNumber) + 1;
            valueSetVersion.ValueSetVersionNumber = newVersionNumber;

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
