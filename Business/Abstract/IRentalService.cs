using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IDataResult<List<Rental>> GetCarsById(int id);
        IDataResult<List<Rental>> GetUserById(int id);
        IDataResult<List<Rental>> GetAll();
    }
}
