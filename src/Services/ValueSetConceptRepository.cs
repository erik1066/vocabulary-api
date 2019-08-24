using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Cdc.Vocabulary.Entities;
using Cdc.Vocabulary.WebApi.Helpers;
using Cdc.Vocabulary.WebApi.Models;

namespace Cdc.Vocabulary.Services
{
    public class ValueSetConceptInfo
    {
        public ValueSetConcept ValueSetConcept { get; set; }
        public ValueSetVersion ValueSetVersion { get; set; }
    }

    public class ValueSetInfo
    {
        public ValueSetConceptInfo ValueSetConceptInfo { get; set; }
        public ValueSet ValueSet { get; set; }
    }

    public sealed class ValueSetConceptRepository : IValueSetConceptRepository
    {
        private VocabularyContext _context;

        public ValueSetConceptRepository(VocabularyContext context)
        {
            _context = context;
        }

        public PagedList<ValueSetInfo> GetValueSetConcepts(ValueSetVersionPaginationParameters parameters)
        {
            IQueryable<ValueSetInfo> collectionBeforePaging = _context.ValueSetConcepts
                .Join(_context.ValueSetVersions, // the source table of the inner join
                    vsc => vsc.ValueSetVersionID,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
                    vsv => vsv.ValueSetVersionID,   // Select the foreign key (the second part of the "on" clause)
                    (vsc, vsv) => new ValueSetConceptInfo()
                    {
                        ValueSetConcept = vsc,
                        ValueSetVersion = vsv
                    })
                .Join(_context.ValueSets,
                    a => a.ValueSetVersion.ValueSetOID,
                    vs => vs.ValueSetOID,
                    (a, vs) => new ValueSetInfo()
                    {
                        ValueSet = vs,
                        ValueSetConceptInfo = a
                    })
                .Where(vs => vs.ValueSet.ValueSetCode == parameters.Code || vs.ValueSet.ValueSetOID == parameters.Oid);//ValueSetVersion.ValueSetVersionID == parameters.Code); // selection



            return PagedList<ValueSetInfo>.Create(collectionBeforePaging,
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