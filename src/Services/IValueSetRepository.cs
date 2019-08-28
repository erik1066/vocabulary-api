using System;
using System.Collections.Generic;
using Cdc.Vocabulary.Entities;
using Cdc.Vocabulary.WebApi.Helpers;
using Cdc.Vocabulary.WebApi.Models;

namespace Cdc.Vocabulary.Services
{
    public interface IValueSetRepository
    {
        PagedList<ValueSet> GetValueSets(PaginationParameters parameters);

        IEnumerable<ValueSet> GetValueSets(IEnumerable<Guid> ids);

        ValueSet GetValueSet(Guid id);

        ValueSet GetValueSet(string id);

        // void AddValueSet(ValueSet valueSet);

        // void DeleteValueSet(ValueSet valueSet);

        // void UpdateValueSet(ValueSet valueSet);

        bool ValueSetExists(Guid id);

        bool Save();
    }
}
