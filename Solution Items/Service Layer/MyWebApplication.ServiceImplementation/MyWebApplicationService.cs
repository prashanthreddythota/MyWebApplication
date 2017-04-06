using MyWebApplication.BusinessEntities;
using MyWebApplication.BusinessLogic.Interfaces;
using MyWebApplication.Common;
using MyWebApplication.MessageContracts;
using MyWebApplication.ServiceContracts;
using MyWebApplication.ServiceLayer.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;
using WCF = System.ServiceModel;

namespace MyWebApplication.ServiceImplementation
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [WCF.ServiceBehaviorAttribute(Name = "MyWebApplicationService",
        Namespace = "http://www.ode.state.oh.us/DashbaordAdmin",
        InstanceContextMode = WCF.InstanceContextMode.PerSession,
        ConcurrencyMode = WCF.ConcurrencyMode.Single)]
    public class MyWebApplicationService : IMyWebApplicationService
    {
        private readonly IPersonHandler _personHandler;
        private readonly IMappingService _mappingService;
        public MyWebApplicationService(
            IMappingService mappingService,
            IPersonHandler personHandler)
        {
            _mappingService = mappingService;
            _personHandler = personHandler;
        }
        public ListPersonsResponse ListPersons(ListPersonsRequest req)
        {
            var response = new ListPersonsResponse();
            try
            {
                var list = _personHandler.ListPersons();
                response.PersonList = _mappingService.Convert<List<Person>,List<PersonData>>(list);
                return response;
            }
            catch(Exception ex)
            {
                //Logging code can be placed here to log the error.
                throw;
            }
        }
    }
}
