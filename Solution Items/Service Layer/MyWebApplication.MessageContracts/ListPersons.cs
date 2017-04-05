using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebApplication.ServiceLayer.DataContracts;
using System.ServiceModel;

namespace MyWebApplication.MessageContracts
{
    [MessageContract(WrapperName = "ListPersonsRequest",
        WrapperNamespace = "http://www.dashboard.state.oh.us/dashboard.ws")]
    public class ListPersonsRequest
    {
    }

    [MessageContract(WrapperName = "GetPersonsResponse",
       WrapperNamespace = "http://www.dashboard.state.oh.us/dashboard.ws")]
    public class ListPersonsResponse
    {
        [MessageBodyMember(Namespace = "http://www.dashboard.state.oh.us/dashboard.ws", Name = "PersonList")]
        public List<PersonData> PersonList { get; set; }
    }
}
