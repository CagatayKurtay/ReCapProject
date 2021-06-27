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
    public class ColorManager : IColorService
    {

        IColorDal colorDal;
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        
        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine(color.ColorName + "Adlı renk başarıyla eklendi.");
        }

        public void Delete(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine(color.ColorName + "Adlı renk başarıyla silindi.");
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public void Update(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine(color.ColorName + "Adlı renk başarıyla güncelleştirildi.");
        }
    }
}
