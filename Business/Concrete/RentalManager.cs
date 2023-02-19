using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant;
using Core.Utilities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{ 
    public class RentalManager:IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
                _rentalDal=rentalDal;
        }
        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Rental>>(Messages.GetAllInvalidMessage);
            }

            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalGetAll);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentalId));
        }

        public IResult Add(Rental rental)
        {
           var carToRent = _rentalDal.Get(r => r.CarId == rental.CarId&&r.ReturnDate==null);
           if (carToRent == null)
           {
               _rentalDal.Add(rental);
               return new SuccessResult(Messages.RentalAdded);
           }

           return new ErrorResult(Messages.RentalInvalidAdded);
        }

        public IResult Update(Rental rental)
        {
            var carRentUpdate = _rentalDal.Get(r => r.CarId == rental.CarId && r.ReturnDate == null);

            if (carRentUpdate != null)
            {
                _rentalDal.Update(rental);

                return new SuccessResult(Messages.RentalUpdated);
            }

            return new ErrorResult(Messages.RentalInvalidUpdated);
        }
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);

            return new SuccessResult(Messages.RentalDeleted);
        }
    }

       
    }

