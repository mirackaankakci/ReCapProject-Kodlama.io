﻿using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
           _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IDataResult<List<Brand>> getAllBrand()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),Messages.BrandList); 
        }

        public IDataResult<Brand> GetBrand(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p=>p.Id==brandId),Messages.BrandList);
        }

        public IResult Remove(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDelented);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdate);
        }

        
    }
}
