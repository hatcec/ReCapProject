using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;



namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarContext>, IRentalDal
    {
        //public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        //{
        //    using (CarContext context = new CarContext())
        //    {
        //        var result = from c in context.Rentals
        //                     join b in context.Users on c.CustomerId equals b.Id
        //                     join aa in context.Customers on c.CustomerId equals aa.UserId
        //                     select new CustomerDetailDto
        //                     {
        //                         UserName = b.FirstName,
        //                         UserLastName = b.LastName,
        //                         CompanyName = aa.CompanyName
        //                     };
        //        return new SuccessDataResult<List<RentalDetailDto>>( result.ToList());
        //    }
        //}
    }
}
