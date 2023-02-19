using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        public IResult Add(Car car);
        public IResult Update(Car car);
        public IResult Delete(Car car);
        IDataResult<Car> GetById(int id);
        IDataResult<List<CarDetailsDto>> GetCarDetails();
        IDataResult<List<Car>> GetAllColorId(int colorId);
        IDataResult<List<Car>> GetAllBrandId(int brandId);

    }
}
