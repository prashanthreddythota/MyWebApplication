using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApplication.Common
{
    public interface IMappingService
    {
        TTo Convert<TFrom, TTo>(TFrom item);
    }
}
