using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        public void Add(Brand brand);
        public void Update(Brand brand);
        public void Delete(Brand brand);
        Brand GetById(int id);
        List<Brand> GetAll();
    }
}
