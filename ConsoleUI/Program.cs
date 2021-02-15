using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetCarDetails();
            //GetUserList();
        }

        private static void GetUserList()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            foreach (var item in userManager.GetAll().Data)
            {
                Console.WriteLine("First Name: " + item.FirstName);
                Console.WriteLine("Last Name: " + item.LastName);
                Console.WriteLine("____________________________");
            }
        }

        private static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("->" + item.ColorName);
            }
        }
    }
}
