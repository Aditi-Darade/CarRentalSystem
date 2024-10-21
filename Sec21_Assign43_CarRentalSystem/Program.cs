using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec21_Assign43_CarRentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car[] cars = new Car[]
            {
                new Car() {Make = "1", Model = "Toyota Corolla", RentalPrice = 50, Rented = true},
                new Car() {Make = "2", Model = "Honda Civic", RentalPrice = 60, Rented = false},
                new Car() {Make = "3", Model = "Ford Mustang", RentalPrice = 80, Rented = false}
            }; 
            foreach (Car printCar in cars)
            {
                Console.WriteLine(printCar.Make + " " + printCar.Model + " " + printCar.RentalPrice + " " + printCar.Rented);
            }

            int choice;
            int case1Choice;
            do
            {
                Console.Write("Welcome to the car rental system!\r\n \r\nMenu:\r\n1. Rent a car\r\n2. Return a car\r\n3. View available cars\r\n4. Exit\r\n \r\nPlease enter your choice: ");
                 choice = Convert.ToInt32(Console.ReadLine());
             
                switch (choice)
                {
                    case 1:
                        {
                            do
                            {
                                
                                Console.Write("\nRent a Car:\r\n" + cars[0].Make + ". " + cars[0].Model + " (Rental price: $" + cars[0].RentalPrice + "/day) - " + cars[0].PrintInfo() + "\r\n" + cars[1].Make + ". " + cars[1].Model + " (Rental price: $" + cars[1].RentalPrice + "/day) - " + cars[1].PrintInfo() + "\r\n" + cars[2].Make + ". " + cars[2].Model + " (Rental price: $" + cars[2].RentalPrice + "/day) - " + cars[2].PrintInfo() + "\r\nPlease enter the ID of the car you want to rent: ");
                                case1Choice = Convert.ToInt32(Console.ReadLine());
                                here:
                                {
                                    if (case1Choice == 1 || case1Choice == 2 || case1Choice == 3)
                                    {
                                        cars[case1Choice - 1].Rent();
                                        if (cars[case1Choice - 1].result == true)
                                        {
                                            Console.WriteLine("\nRented the " + cars[case1Choice - 1].Model + " for $" + cars[case1Choice - 1].RentalPrice + "/ day.\n");
                                        }
                                        
                                        break;
                                    }
                                }                             
                                Console.Write("Invalid ID. Please enter a valid ID of the car you want to rent: ");
                                case1Choice = Convert.ToInt32(Console.ReadLine());
                                goto here;

                            }
                            while (case1Choice != 1 && case1Choice != 2 && case1Choice != 3);
                         
                        }
                        break;
                    case 2:
                    {
                            do
                            {

                                Console.Write("\nReturn a Car:\r\n" + cars[0].Make + ". " + cars[0].Model + " (Rental price: $" + cars[0].RentalPrice + "/day) - " + cars[0].PrintInfo() + "\r\n" + cars[1].Make + ". " + cars[1].Model + " (Rental price: $" + cars[1].RentalPrice + "/day) - " + cars[1].PrintInfo() + "\r\n" + cars[2].Make + ". " + cars[2].Model + " (Rental price: $" + cars[2].RentalPrice + "/day) - " + cars[2].PrintInfo() + "\r\nPlease enter the ID of the car you want to return: ");
                                case1Choice = Convert.ToInt32(Console.ReadLine());
                            here:
                                {
                                    if (case1Choice == 1 || case1Choice == 2 || case1Choice == 3)
                                    {
                                        cars[case1Choice - 1].Return();
                                        
                                        if (cars[case1Choice - 1].result == true)
                                        {
                                            Console.WriteLine("\nReturned the " + cars[case1Choice - 1].Model + ".\n");
                                        }                                      
                                       break;
                                    }
                                }
                                Console.Write("Invalid ID. Please enter a valid ID of the car you want to rent: ");
                                case1Choice = Convert.ToInt32(Console.ReadLine());
                                goto here;

                            }
                            while (case1Choice != 1 && case1Choice != 2 && case1Choice != 3);
                        }
                        break;

                    case 3:
                    {
                            Console.Write("\nAvailable cars:\r\n" + cars[0].Make + ". " + cars[0].Model + " (Rental price: $" + cars[0].RentalPrice + "/day) - " + cars[0].PrintInfo() + "\r\n" + cars[1].Make + ". " + cars[1].Model + " (Rental price: $" + cars[1].RentalPrice + "/day) - " + cars[1].PrintInfo() + "\r\n" + cars[2].Make + ". " + cars[2].Model + " (Rental price: $" + cars[2].RentalPrice + "/day) - " + cars[2].PrintInfo() + "\n\n");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Thank you for using the car rental system!\r\n");
                        }
                        break;
                    default:
                    {
                            Console.WriteLine("Invalid Choice.");
                            
                    }
                    break;
                }
            }
            while (choice != 4 );

            Console.ReadKey();
        }
    }
}
