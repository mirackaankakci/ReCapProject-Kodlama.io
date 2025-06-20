﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.ReCapSql;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositortyBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (ReCapContext context = new ReCapContext())
            {

                var result = from c in context.Cars
                             join co in context.Colors on c.ColorId equals co.Id
                             join b in context.Brands on c.BrandId equals b.Id
                             select new CarDetailDto
                             {

                                 CarId = c.Id,
                                 CarName = c.Description,
                                 BrandName = b.Name,
                                 ColorName =co.Name

                             };

                return result.ToList();
                           
                           
            
            }
        }
    }
}
