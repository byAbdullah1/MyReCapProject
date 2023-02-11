using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Drawing;
using System.Xml.Linq;
using Color = Entities.Concrete.Color;

namespace MyFirstConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
          

            foreach (var c in carManager.GetCarDetails())
            {
                Console.WriteLine(c.Name + "/" + c.ColorName + "/" + c.Description + "/" + c.DailyPrice  );
                
            }

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            
            foreach (var b in brandManager.GetAll())
            {
                Console.WriteLine(b.Name);
                
            }





        }

    }
}