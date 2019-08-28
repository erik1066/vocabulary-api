using System;
using System.Collections.Generic;
using Cdc.Vocabulary.Entities;
using Cdc.Vocabulary.WebApi.Helpers;
using Cdc.Vocabulary.WebApi.Models;

namespace Cdc.Vocabulary.Services
{
    public interface IValueSetVersionRepository
    {
        PagedList<ValueSetVersion> GetValueSetVersions(ValueSetVersionPaginationParameters parameters);

        IEnumerable<ValueSetVersion> GetValueSetVersions(IEnumerable<Guid> ids);

        ValueSetVersion GetValueSetVersion(Guid id);

        // void AddValueSetVersion(ValueSetVersion valueSetVersion);

        // void DeleteValueSetVersion(ValueSetVersion valueSetVersion);

        // void UpdateValueSetVersion(ValueSetVersion valueSetVersion);

        bool ValueSetVersionExists(Guid id);

        bool Save();
    }
}
