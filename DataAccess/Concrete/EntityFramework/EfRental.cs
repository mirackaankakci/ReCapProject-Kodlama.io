using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.ReCapSql;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRental : EfEntityRepositortyBase<Rental, ReCapContext>, IRentalDal
    {
        ReCapContext context = new ReCapContext();
        public void deliverRental(Rental entity)
        {
            using (ReCapContext context = new ReCapContext())
            {

                var result = from c in context.Rentals
                             where c.Id == entity.Id
                             select c;
                foreach(Rental a in result)
                {
                    a.ReturnDate = DateTime.Now;

                }
                context.SaveChanges();

                             
            }
        }
    }
}
