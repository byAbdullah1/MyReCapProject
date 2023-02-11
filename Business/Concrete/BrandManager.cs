using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public  class BrandManager:IBrandService

    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal=brandDal;
            
        }
        

        public void Add(Brand brand)
        {
            //iş kodları
            _brandDal.Add(brand);
            
        }

        public void Delete(Brand brand)
        {
            
            //iş kodları
            _brandDal.Delete(brand);
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(b=> b.Id == id);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public void Update(Brand brand)
        {
            //iş kodları
            _brandDal.Update(brand);
        }
    }
}
