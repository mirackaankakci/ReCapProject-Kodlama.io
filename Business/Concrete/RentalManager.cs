using Business.Abstract;
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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult delet(Rental rental)
        {
            _rentalDal.Delete(rental);  
            return new SuccessResult(Messages.RentalDelented);
        }

        public IResult deliver(Rental rental)
        {
            _rentalDal.deliverRental(rental);
            return new SuccessResult("Siparisiniz Teslim Edildi!");
        }

        public IDataResult<Rental> listByRentalId(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentalId), Messages.RentalList);
        }

        public IDataResult<List<Rental>> restalList()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.RentalList);
        }

        public IResult update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
