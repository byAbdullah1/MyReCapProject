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


            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Update(new Rental()
            {
                Id = 2, CarId = 15, CustomerId = 7, RentDate = new DateTime(2023, 02, 18),
                ReturnDate = new DateTime(2023, 02, 27)
            });
            Console.WriteLine(result.Message);









        }

    }
}