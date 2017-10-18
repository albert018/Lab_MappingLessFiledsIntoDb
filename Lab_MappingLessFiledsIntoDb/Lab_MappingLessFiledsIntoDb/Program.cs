using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoMapper;

namespace Lab_MappingLessFiledsIntoDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var Mapper = Factory.GetMapper();

            var DTO = new DailyBillingDTO()
            {
                Serial="T1",
                Amount=777
            };

            using (var entity = new BillingEntities())
            {
                var QDailyBilling = (from x in entity.DailyBilling
                                     where x.Serial == DTO.Serial
                                     select x).First();

                //原本寫法，但少的欄位會被填入 null 或預設值
                //var R = Mapper.Map<DailyBilling>(DTO);

                //修改後寫法
                var R = Mapper.Map<DailyBillingDTO, DailyBilling>(DTO, QDailyBilling);

                entity.Entry<DailyBilling>(R).State = EntityState.Modified;
                entity.SaveChanges();

            }
        }
    }
}
