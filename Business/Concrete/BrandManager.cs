using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal brandDal;
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
            Console.WriteLine(brand.BrandName + "Adlı marka başarıyla eklendi.");
        }

        public void Delete(Brand brand)
        {
            _brandDal.Add(brand);
            Console.WriteLine(brand.BrandName + "Adlı marka başarıyla silindi.");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public void Update(Brand brand)
        {
            _brandDal.Add(brand);
            Console.WriteLine(brand.BrandName + "Adlı marka başarıyla güncelleştirildi.");
        }
    }
}
