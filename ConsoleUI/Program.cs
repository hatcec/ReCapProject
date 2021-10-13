using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                BrandId=1,
                ColorId=2,
                ModelYear = 1996,
                DailyPrice = 10,
                Description = "Beyaz Opel Corsa"
            });
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Description);
            }
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description);
            }

        }
    }
}
