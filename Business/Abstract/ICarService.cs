using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int ıd);
        List<Car> GetCarsByColorId(int ıd);
        List<CarDetailDto> GetCarDetails();
    }
}
