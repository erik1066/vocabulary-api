using System;
using System.Collections.Generic;
using Cdc.Vocabulary.Entities;
using Cdc.Vocabulary.WebApi.Helpers;
using Cdc.Vocabulary.WebApi.Models;

namespace Cdc.Vocabulary.Services
{
    public interface ICodeSystemRepository
    {
        PagedList<CodeSystem> GetCodeSystems(PaginationParameters parameters);

        IEnumerable<CodeSystem> GetCodeSystems(IEnumerable<Guid> ids);

        CodeSystem GetCodeSystem(Guid id);

        // void AddCodeSystem(CodeSystem codeSystem);

        // void DeleteCodeSystem(CodeSystem codeSystem);

        // void UpdateCodeSystem(CodeSystem codeSystem);

        bool CodeSystemExists(Guid id);

        bool Save();
    }
}
