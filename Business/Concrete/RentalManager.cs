using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            //using (CarContext context=new CarContext())
            //{
            //    var result = context.Rentals.FirstOrDefault(p => p.CarId == rental.CarId);
            //    //if (result.ReturnDate != null )
            //    {
            //        _rentalDal.Add(rental);
            //        return new SuccessResult(Messages.Added);
            //    }
            //    else
            //    {
            //        return new ErrorResult(Messages.Date);
            //    }
            // }

            ValidationTool.Validate(new RentalValidator(), rental);
            _rentalDal.Add(rental);
            return new SuccessResult("Araç başarıyla kiralanmıştır.");



        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<Rental>> GetCarsById(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.CarId == id));
        }

        public IDataResult<List<Rental>> GetUserById(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.CustomerId == id));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
