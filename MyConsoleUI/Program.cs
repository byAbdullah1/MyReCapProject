using Business.Concrete;
using DataAccess.Concrete;

namespace MyConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

        }
    }
}