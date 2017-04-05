using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApplication.Common
{
    public class MappingService : IMappingService
    {
        public TTo Convert<TFrom, TTo>(TFrom item)
        {
            return Mapper.Map<TFrom, TTo>(item);
        }
    }
}
