using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from p in context.cars
                             join b in context.brands on p.BrandId equals b.Id
                             join c in context.colors on p.ColorId equals c.Id
                             select new CarDetailDto { Name = p.Name, BrandName = b.Name, ColorName = c.Name, DailyPrice = p.DailyPrice };
                return result.ToList();
            }
        }
    }
}
