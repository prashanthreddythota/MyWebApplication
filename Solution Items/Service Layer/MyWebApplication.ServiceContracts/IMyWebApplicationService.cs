using MyWebApplication.MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApplication.ServiceContracts
{
    public interface IMyWebApplicationService
    {
        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
            ProtectionLevel = ProtectionLevel.None)]
        ListPersonsResponse ListPersons(ListPersonsRequest req);
    }
}
