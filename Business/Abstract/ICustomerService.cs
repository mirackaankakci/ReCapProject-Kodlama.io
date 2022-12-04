using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> getAllCustomer();
        IDataResult<Customer> GetCustomer(int userId);
        IResult Add(Customer user);
        IResult Remove(Customer user);
        IResult Update(Customer user);
    }
}
