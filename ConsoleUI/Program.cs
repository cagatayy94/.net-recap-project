using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("->" + item.ColorName);
            }
        }
    }
}
