using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Cdc.Vocabulary.Entities;

namespace Cdc.Vocabulary.Services
{
    public interface IValueSetRepository
    {
        IEnumerable<ValueSet> GetValueSets();

        IEnumerable<ValueSet> GetValueSets(IEnumerable<Guid> ids);

        ValueSet GetValueSet(Guid id);

        void AddValueSet(ValueSet valueSet);

        void DeleteValueSet(ValueSet valueSet);

        void UpdateValueSet(ValueSet valueSet);

        bool ValueSetExists(Guid id);

        bool Save();
    }
}
