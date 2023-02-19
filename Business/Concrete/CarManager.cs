using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Constant;
using Core.Utilities;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService

    {
       private ICarDal _carDal;

       public CarManager(ICarDal carDal)
       {
           _carDal = carDal;
       }


       public IDataResult<List<Car>> GetAll()
       {
           if (DateTime.Now.Hour == 22)
           {
               return new ErrorDataResult<List<Car>>(Messages.GetAllInvalidMessage);
           }

           
           return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.GetAllMessage);
       }

       public IResult Add(Car car)
       {
           if (car.Name.Length<2)
           {
               return new ErrorResult(Messages.AddedInvalidMessage);
           }
           _carDal.Add(car);
           return new SuccessResult(Messages.AddedMessage);
       }

       public IResult Update(Car car)
       {
           if (car.Name.Length<2)
           {
               return new ErrorResult(Messages.UpdatedInvalidMessage);
           }
           _carDal.Update(car);
           return new SuccessResult(Messages.UpdatedMessage);

       }

       public IResult Delete(Car car)
       {
           _carDal.Delete(car);
           return new SuccessResult(Messages.DeletedMessage);
       }

       public IDataResult<Car> GetById(int id)
       {
           return new SuccessDataResult<Car>(_carDal.Get(c => c.Id==id));
       }

       public IDataResult<List<CarDetailsDto>> GetCarDetails()
       {
           return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails());
       }

       public IDataResult<List<Car>> GetAllColorId(int colorId)
       {
           return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
       }

       public IDataResult<List<Car>> GetAllBrandId(int brandId)
       {
           return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
       }
    }
}
