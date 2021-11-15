using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _CustomerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _CustomerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            _CustomerDal.Add(customer);
            return new SuccessResult(Messages.Added);

        }

        public IResult Delete(Customer customer)
        {
            _CustomerDal.Delete(customer);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetCustomersById(int id)
        {
            return new SuccessDataResult<List<Customer>>(_CustomerDal.GetAll(p => p.UserId == id));
        }

        public IResult Update(Customer customer)
        {
            _CustomerDal.Update(customer);
            return new SuccessResult(Messages.Updated);
        }
    }
}
