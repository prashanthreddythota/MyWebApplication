using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWebApplication.BusinessLogic.Interfaces;
using MyWebApplication.Composition;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApplication.UnitTest.BusinessLogicUT
{
    [TestClass]
    public class WhenUsingPersonHandler
    {
        [TestMethod]
        public void ThenGetPersonList()
        {
            var kernel = new StandardKernel(new ServiceModule());
            var mappingSetup = kernel.Get<MappingSetup>();
            mappingSetup.Setup();
            var personHandler = kernel.Get<IPersonHandler>();

            var response = personHandler.ListPersons();
            Assert.IsTrue(response.Count > 0);
        }
    }
}
