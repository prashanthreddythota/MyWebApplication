using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyWebApplication.DataAccess.Interfaces;
using MyWebApplication.BusinessEntities;
using MyWebApplication.Common;

namespace MyWebApplication.DataAccess
{
    public class PersonDbContext : IPersonDbContext
    {
        private readonly IMappingService _mappingService;
        public PersonDbContext(
            IMappingService mappingService)
        {
            _mappingService = mappingService;
        }
        public List<MyWebApplication.BusinessEntities.Person> ListPersons()
        {
            using(var context = new AdventureWorks2012Entities())
            {
                var list = context.People.Select(x => new BusinessEntities.Person
                {
                    PersonKey = x.BusinessEntityID,
                    PersonType = x.PersonType,
                    PersonStyle = x.NameStyle,
                    Title = x.Title,
                    FirstName = x.FirstName,
                    MiddleName = x.MiddleName,
                    LastName = x.LastName,
                    Suffix = x.Suffix,
                    EmailPromotion = x.EmailPromotion,
                    AdditionalContactInfo = x.AdditionalContactInfo,
                    Demographics = x.Demographics,
                    RowGuid = x.rowguid,
                    ModifiedDate = x.ModifiedDate,
                }).ToList();
                return list;
            }
        }
    }
}
