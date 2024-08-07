using Business.Concrete;
using DataAccess.Concrete;
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