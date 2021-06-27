using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;   //Injection
        

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {

                new Car(){CarId = 1, BrandId = 1, ColorId = 1, ModelId = 1 ,ModelYear = 2006, DailyPrice = 40000, Description = "PEUGEOT 206"},
                new Car(){CarId = 2, BrandId = 1, ColorId = 2, ModelId = 2 ,ModelYear = 2008, DailyPrice = 100000, Description = "PEUGEOT 208"},
                new Car(){CarId = 3, BrandId = 2, ColorId = 3, ModelId = 13 ,ModelYear = 2017, DailyPrice = 1500000, Description = "FERRARI 458"},
                new Car(){CarId = 4, BrandId = 3, ColorId = 2, ModelId = 11 ,ModelYear = 2020, DailyPrice = 215000, Description = "OPEL CORSA"},

            };


        }





        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == c.CarId);

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == c.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == c.CarId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    } 

}
