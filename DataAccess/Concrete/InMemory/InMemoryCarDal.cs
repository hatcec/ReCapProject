using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1, BrandId=1,ColorId=3, ModelYear=2014, DailyPrice=150,Description="1.6 motor"},
                new Car{Id=2, BrandId=2,ColorId=4, ModelYear=2013, DailyPrice=120,Description="1.3 motor"},
                new Car{Id=3, BrandId=3,ColorId=1, ModelYear=2015, DailyPrice=160,Description="1.6 motor"}
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteToCar = _car.SingleOrDefault(p => p.Id == car.Id);
            _car.Remove(deleteToCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
           return _car.Where(p => p.Id == id).ToList();
           
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updateToCar = _car.SingleOrDefault(p => p.Id == car.Id);
            updateToCar.Id = car.Id;
            updateToCar.ColorId = car.ColorId;
            updateToCar.BrandId = car.BrandId;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;
        }
    }
}
