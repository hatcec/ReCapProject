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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarContext>, ICustomerDal
    {
     

        //IDataResult<List<CustomerDetailDto>> ICustomerDal.GetCustomerDetails()
        //{
        //    using (CarContext context = new CarContext())
        //    {
        //        var result = from c in context.Customers
        //                     join b in context.Users on c.UserId equals b.Id
        //                     select new CustomerDetailDto
        //                     {
        //                         UserName =b.FirstName,
        //                         UserLastName = b.LastName,
        //                         CompanyName = c.CompanyName
        //                     };
        //        return new SuccessDataResult<List<CustomerDetailDto>>( result.ToList());
        //    }
        //}
    }
}
