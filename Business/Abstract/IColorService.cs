using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        public void Add(Color color);
        public void Delete(Color color);
        public void Update(Color color);
        Color GetById(int id);
        List<Color> GetAll();
    }
}
