using Business.Abstract;
using Business.Constants;
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
            List<Rental> rentalListByCarId = _rentalDal.GetAll(x => x.CarId == rental.CarId);
            var lastRentalOfCar = rentalListByCarId[(rentalListByCarId.Count) - 1];
            var lastReturnDate = lastRentalOfCar.ReturnDate;



            if (lastReturnDate == null)
            {
                return new ErrorResult("Araç süresiz kiralanmıştır. Dönüş tarihi belli değildir");
            }
            else
            {
                int result = DateTime.Compare(lastReturnDate , rental.RentDate);

                if (result < 0)
                {
                    _rentalDal.Add(rental);
                    return new SuccessResult("Araç başarıyla kiralanmıştır.");
                }

                return new ErrorResult("Kiralamaya başlama tarihinizde aracımız maalesef doludur !!! ");

            }
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
