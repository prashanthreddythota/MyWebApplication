using MyWebApplication.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApplication.BusinessLogic.Interfaces
{
    public interface IPersonHandler
    {
        List<Person> ListPersons();
    }
}
