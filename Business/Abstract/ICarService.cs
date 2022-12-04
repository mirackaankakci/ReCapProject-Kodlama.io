using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>>getAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>>GetCarsByColorId(int id);
        List<CarDetailDto> GetDetailCar();
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);
    }
}
