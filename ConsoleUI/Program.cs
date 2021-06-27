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
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Brand brand1 = new Brand() { BrandId = 1, BrandName = "PEUGEOT" };
            Color color1 = new Color() { ColorId = 1, ColorName = "GRİ" };
            Color color2 = new Color() { ColorId = 2, ColorName = "LACİVERT" };
            Color color3 = new Color() { ColorId = 3, ColorName = "SİYAH" };

            colorManager.Add(color1);  //Db'ye eklendi
            colorManager.Add(color2);
            colorManager.Add(color3);
            brandManager.Add(brand1);



            Car car1 = new Car()
            {
                CarId = 1,
                ColorId = 1,
                BrandId = 1,
                DailyPrice = 41000,
                ModelYear = 2004,
                CarName = "Peugeot 206",
                Description = "Doktordan temiz araba ,Serdar bey kapmadan elinizi çabuk tutun"
            };

            carManager.Add(car1); //Db'ye eklendi




            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç kodu: " + car.CarId + "\n Marka kodu: " + car.BrandId + " \n Model yılı: "
                    + car.ModelYear + "\n Fiyatı: " + car.DailyPrice + "\n Ürün Açıklaması: " + car.Description + "\n Model İsmi:" + car.CarName + "\n*********************");
            }

            Console.ReadLine();
        }
    }
}
