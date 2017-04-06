using MyWebApplication.MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF = System.ServiceModel;

namespace MyWebApplication.ServiceContracts
{
    [ServiceContractAttribute(Namespace = "http://www.ode.state.oh.us/IDashboardQuery/",
        SessionMode = WCF::SessionMode.Allowed, ProtectionLevel = ProtectionLevel.None)]
    public interface IMyWebApplicationService
    {
        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
            ProtectionLevel = ProtectionLevel.None)]
        ListPersonsResponse ListPersons(ListPersonsRequest req);
    }
}
