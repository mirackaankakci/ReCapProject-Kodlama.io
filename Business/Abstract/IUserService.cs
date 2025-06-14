﻿using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> getAllUser();
        IDataResult<User> GetUser(int userId);
        IResult Add(User user);
        IResult Remove(User user);
        IResult Update(User user);
    }
}
