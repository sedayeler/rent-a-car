using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new InMemoryCarDal());
foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}

Console.WriteLine("--Güncelleme--");
Car carToUpdate = carManager.GetById(1);
carToUpdate.Description = "Hatchback";
foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}

Console.WriteLine("--Car Details--");
CarManager carManager1 = new CarManager(new EfCarDal());
foreach (var car in carManager1.GetCarDetails())
{
    Console.WriteLine(car.Name);
    Console.WriteLine(car.BrandName);
    Console.WriteLine(car.ColorName);
}
