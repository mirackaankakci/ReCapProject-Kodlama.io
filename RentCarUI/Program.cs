﻿// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Core.Utilities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Data;

//RentalManager rentalManager = new RentalManager(new EfRental());
//Rental rental = new Rental();
//rental.RentDate = DateTime.Now;
//rental.CarId = 1002;
//rental.CustomerId = 1;

//var a = rentalManager.listByRentalId(1);

//rentalManager.deliver(a.Data);


BrandManager brandManager = new BrandManager(new EfBrandDal());
var b = brandManager.getAllBrand();

foreach (var a in b.Data)
{
    Console.WriteLine(a.Name);
}


//CarManager colorManager = new CarManager(new EfCarDal());
//var c=colorManager.getAll();

//foreach(var ass in c.Data)
//{
//    Console.WriteLine(ass);
//}
//CarManager carManager = new CarManager(new EfCarDal());
//var reslurt = carManager.GetDetailCar();
//if (reslurt.Success == true)
//{
//    foreach (var car in reslurt.Data)
//    {
//        Console.WriteLine(car.CarName + "-" + car.ColorName + "-" + car.BrandName);
//    } 
//}