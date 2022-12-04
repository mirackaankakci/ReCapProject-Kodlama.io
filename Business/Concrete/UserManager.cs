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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IDataResult<List<User>> getAllUser()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserList);
        }

        public IDataResult<User> GetUser(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(p=>p.Id==userId),Messages.UserList);
        }

        public IResult Remove(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDelented);        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdate);
        }
    }
}
