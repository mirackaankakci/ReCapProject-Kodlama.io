using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> restalList();
        IDataResult<Rental> listByRentalId(int rentalId);
        IResult add(Rental rental);
        IResult update(Rental rental);
        IResult delet(Rental rental);
        IResult deliver(Rental rental); 
        
    }
}
