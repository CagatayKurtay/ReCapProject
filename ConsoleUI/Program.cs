using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç kodu: " + car.CarId + "\n Marka kodu: " + car.BrandId + " \n Model yılı: " + car.ModelYear + "\n Fiyatı: " + car.DailyPrice + "\n Ürün Açıklaması: " + car.Description + "\n*********************");
            }

            Console.ReadLine();
        }
    }
}
