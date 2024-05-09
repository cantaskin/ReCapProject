// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new EfCarDal());

        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.BrandId + car.ModelYear + car.ColorId);
        }
    }
}