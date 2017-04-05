using Ninject;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApplication.Composition
{
    public abstract class ServiceComposition : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {
            var Kernel = new StandardKernel(new ServiceModule());
            var mappingSetup = Kernel.Get<MappingSetup>();
            mappingSetup.Setup();
            return Kernel;
        }
    }
}
