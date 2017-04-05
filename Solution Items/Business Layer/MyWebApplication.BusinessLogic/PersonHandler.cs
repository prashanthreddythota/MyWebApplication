using MyWebApplication.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebApplication.BusinessEntities;
using MyWebApplication.DataAccess.Interfaces;

namespace MyWebApplication.BusinessLogic
{
    public class PersonHandler : IPersonHandler
    {
        private readonly IPersonDbContext _personDbContext;
        public PersonHandler(IPersonDbContext personDbContext)
        {
            _personDbContext = personDbContext;
        }
        public List<Person> ListPersons()
        {
            return _personDbContext.ListPersons();
        }
    }
}
