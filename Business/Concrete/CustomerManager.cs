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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer user)
        {
            _customerDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IDataResult<List<Customer>> getAllCustomer()
        {
            return new SuccessDataResult<List<Customer>>(Messages.UserList);
        }

        public IDataResult<Customer> GetCustomer(int userId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(u=>u.Id==userId),Messages.UserList);
        }

        public IResult Remove(Customer user)
        {
            _customerDal.Delete(user);
            return new SuccessResult(Messages.UserDelented);
        }

        public IResult Update(Customer user)
        {
           _customerDal.Update(user);
            return new SuccessResult(Messages.UserUpdate);
        }
    }
}
