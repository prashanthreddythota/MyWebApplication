using AutoMapper;
using AutoMapper.Configuration;
using MyWebApplication.BusinessEntities;
using Ninject.Activation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DC = MyWebApplication.ServiceLayer.DataContracts;
using DA = MyWebApplication.DataAccess;
using BE = MyWebApplication.BusinessEntities;

namespace MyWebApplication.Composition
{
    public class MappingSetup
    {
        private readonly IContext _context;

        public MappingSetup(IContext context)
        {
            _context = context;
        }

        public void Setup()
        {
            //Add Mapping to baseMappings variable and after creating MapperConfiguration will take care of rest of the work - prashanth (04/04/2017)
            var baseMappings = new MapperConfigurationExpression();

            #region Data Contract to Business Entity
            baseMappings.CreateMap<DC.PersonData, BE.Person>();
            #endregion

            #region Business Entity to Data Contract
            baseMappings.CreateMap<BE.Person, DC.PersonData>();
            #endregion

            #region EntityFramework context to Business Entity
            baseMappings.CreateMap<DA.Person, BE.Person>();
            #endregion


            var config = new MapperConfiguration(baseMappings);
            IMapper mapper = new Mapper(config);
        }
    }
}
