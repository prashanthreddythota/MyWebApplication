using MyWebApplication.BusinessLogic;
using MyWebApplication.BusinessLogic.Interfaces;
using MyWebApplication.Common;
using MyWebApplication.DataAccess;
using MyWebApplication.DataAccess.Interfaces;
using MyWebApplication.ServiceContracts;
using MyWebApplication.ServiceImplementation;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyWebApplication.Composition
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            #region Setup
            Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            #endregion Setup

            #region mapping setup and injectable service
            Bind<MappingSetup>().ToMethod(context => { var c = context; return new MappingSetup(c); });
            Bind<IMappingService>().To<MappingService>();
            #endregion mapping setup and injectable service

            #region service implementations
            Bind<IMyWebApplicationService>().To<MyWebApplicationService>();
            #endregion service implementations

            #region factories

            //Bind<IFactory<IOpenTasks>>().ToMethod(context => new Factory<IOpenTasks>(() => new OpenTasks()));

            #region data access
            
            #endregion data access

            #region Business Logic
            Bind<IPersonHandler>().To<PersonHandler>();
            #endregion Business Logic

            #region Repositories
            // Added - kevin.low 03/31/16
            Bind<IPersonDbContext>().To<PersonDbContext>();

            #endregion Repositories

            #endregion factories
        }
    }
}
