using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentaCarContext>, ICarDal
    {
        //public List<CarDetailDto> CarDetailDtos()
        //{
        //    using (RentaCarContext context = new RentaCarContext())
        //    {
        //        var result = from car in context.Cars
        //                     join brand in context.Brands
        //                     on car.BrandId equals brand.Id
        //                     join color in context.Colors
        //                      on car.ColorId equals color.Id
        //                     select new CarDetailDto
        //                     {
        //                         CarName = car.Description,
        //                         BrandName = brand.BrandName,
        //                         ColorName = color.ColorName,
        //                         DailyPrice = car.DailyPrice
        //                     };
        //        return result.ToList();

        //    }
        //}
    }
}