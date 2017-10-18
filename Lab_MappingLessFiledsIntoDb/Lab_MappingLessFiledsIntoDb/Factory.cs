using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Lab_MappingLessFiledsIntoDb
{
    public static class Factory
    {
        public static IMapper GetMapper()
        {
            var Config = new MapperConfiguration(cfg =>
             {
                 cfg.CreateMap<DailyBillingDTO, DailyBilling>();
             });
            return Config.CreateMapper();
        }
    }
}
