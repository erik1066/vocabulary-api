using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Cdc.Vocabulary.Entities;
using Cdc.Vocabulary.WebApi.Helpers;
using Cdc.Vocabulary.WebApi.Models;

namespace Cdc.Vocabulary.Services
{
    public sealed class CodeSystemRepository : ICodeSystemRepository
    {
        private VocabularyContext _context;

        public CodeSystemRepository(VocabularyContext context)
        {
            _context = context;
        }

        public PagedList<CodeSystem> GetCodeSystems(PaginationParameters parameters)
        {
            var collectionBeforePaging = _context.CodeSystems
                .OrderBy(v => v.CodeSystemCode);

            if (!string.IsNullOrWhiteSpace(parameters.SearchQuery))
            {
                var searchQueryStringForWhereClause = parameters.SearchQuery.Trim().ToLowerInvariant();
                collectionBeforePaging = _context.CodeSystems
                    .Where(
                        v =>
                            v.CodeSystemCode.ToLowerInvariant().Contains(searchQueryStringForWhereClause) ||
                            v.CodeSystemName.ToLowerInvariant().Contains(searchQueryStringForWhereClause) ||
                            v.CodeSystemOID.ToLowerInvariant().Contains(searchQueryStringForWhereClause) ||
                            v.CodeSystemDefinitionText.ToLowerInvariant().Contains(searchQueryStringForWhereClause)
                    )
                    .OrderBy(v => v.CodeSystemCode);
            }

            return PagedList<CodeSystem>.Create(collectionBeforePaging,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public IEnumerable<CodeSystem> GetCodeSystems(IEnumerable<Guid> ids)
        {
            return _context.CodeSystems.Where(a => ids.Contains(a.CodeSystemID))
                .OrderBy(a => a.CodeSystemCode)
                .ToList();
        }

        public CodeSystem GetCodeSystem(Guid id)
        {
            return _context.CodeSystems.FirstOrDefault(a => a.CodeSystemID == id);
        }

        public void AddCodeSystem(CodeSystem codeSystem)
        {
            codeSystem.CodeSystemID = Guid.NewGuid();
            codeSystem.StatusDateTime = DateTime.Now;
            _context.CodeSystems.Add(codeSystem);
        }

        public void DeleteCodeSystem(CodeSystem codeSystem)
        {
            _context.CodeSystems.Remove(codeSystem);
        }

        public void UpdateCodeSystem(CodeSystem codeSystem)
        {
            // no code in this implementation
        }

        public bool CodeSystemExists(Guid id)
        {
            return _context.CodeSystems.Any(a => a.CodeSystemID == id);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
