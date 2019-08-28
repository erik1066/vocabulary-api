using System;
using System.Collections.Generic;
using Cdc.Vocabulary.Entities;
using Cdc.Vocabulary.WebApi.Helpers;
using Cdc.Vocabulary.WebApi.Models;

namespace Cdc.Vocabulary.Services
{
    public interface IValueSetConceptRepository
    {
        PagedList<ValueSetConcept> GetValueSetConcepts(ValueSetConceptPaginationParameters parameters);

        IEnumerable<ValueSetConcept> GetValueSetConcepts(IEnumerable<Guid> ids);

        ValueSetConcept GetValueSetConcept(Guid id);

        // void AddValueSetConcept(ValueSetConcept valueSetConcept);

        // void DeleteValueSetConcept(ValueSetConcept valueSetConcept);

        // void UpdateValueSetConcept(ValueSetConcept valueSetConcept);

        bool ValueSetConceptExists(Guid id);

        bool Save();
    }
}
