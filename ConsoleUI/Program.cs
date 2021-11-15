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
            AddUserTest();
            AddRentalCar();
            // AddCarTest();
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarName+"/"+car.BrandName+"/"+car.ColorName+"/"+car.DailyPrice);
            //}

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //Console.WriteLine(brandManager.GetAll());
        }

        private static void AddUserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                FirstName = "Hatice",
                LastName = "Ateş",
                Email = "htcn@gmail.com",
                Password = "1234"
            });
        }
        private static void AddRentalCar()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental
            {
                CarId=1,
                CustomerId=1,
                RentDate=new DateTime(2021,11,12),
                ReturnDate= new DateTime(2021, 11, 14)

            });
            
        }
        //private static void AddCarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    carManager.Add(new Car
        //    {
        //        CarName="Opel",
        //        BrandId = 1,
        //        ColorId = 2,
        //        ModelYear = 1996,
        //        DailyPrice = 10,
        //        Description = "Beyaz Opel Corsa"
        //    });
        //    foreach (var car in carManager.GetCarsByBrandId(1))
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //    foreach (var car in carManager.GetCarsByColorId(1))
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //}
    }
}
