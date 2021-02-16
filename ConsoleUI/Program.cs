using System;
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetCarDetails();
            //GetUserList();
            //AddUser();
            //GetUserList();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental rental = new Rental();

            rental.CarId = 1;
            rental.CustomerId = 1;
            rental.RentDate = new DateTime();
            rental.ReturnDate = new DateTime();

            Console.WriteLine(rental.RentDate);

            //rentalManager.Add(rental);
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

        private static void AddUser()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            User user = new User();

            user.FirstName = "Asuman";
            user.LastName = "Karagöz";
            user.Password = "guclu parola";
            user.Email = "yapma@asuman.com";

            IResult result = userManager.Add(user);

            if (!result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine("Added");
            }


            



        }
    }
}
