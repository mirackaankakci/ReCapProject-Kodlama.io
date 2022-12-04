using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> getAllBrand();
        IDataResult<Brand> GetBrand(int brandId);
        IResult Add(Brand brand);
        IResult Remove(Brand brand);
        IResult Update(Brand brand);
    }
}
