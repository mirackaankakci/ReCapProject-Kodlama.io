 using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.BrandId == 0)
            {
                return new ErrorResult("Arabae eklemedi lütfen markası bilgisini giriniz!");

            }
            _carDal.Add(car);
            return new SuccessResult("Araba sisteme eklendi");
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDelented);
        }

        public IDataResult<List<Car>> getAll()
        {
            
            if(DateTime.Now.Hour==17)
            {
                return new ErrorDataResult<List<Car>>("Hata!, Arabalar Listelenemedi");
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),"Ürünler Listelendi");
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == carId));
        }

        public IDataResult<List<Car>>GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id));

        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }

        public IDataResult<List<CarDetailDto>> GetDetailCar()
        {
            if (DateTime.Now.Hour == 12)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.ColorListError);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail());
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdate);
        }

        List<CarDetailDto> ICarService.GetDetailCar()
        {
            throw new NotImplementedException();
        }
    }
}
