using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService

    {
        ICarDal _carDal;  //Injection


        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Lütfen minumum iki karakterden oluşan bir isim giriniz!\n Araba fiyatı 0₺ olamaz ");
            }


        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int ıd)
        {
            return _carDal.GetAll(p => p.BrandId == ıd);
        }

        public List<Car> GetCarsByColorId(int ıd)
        {
            return _carDal.GetAll(P => P.ColorId == ıd);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
