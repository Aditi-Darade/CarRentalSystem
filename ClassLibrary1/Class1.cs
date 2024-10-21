using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Car
    {
        private string make;
        private string model;
        private decimal rentalPrice;
        private bool rented;

        public string Make { get; set; }
        public string Model { get; set; }
        public decimal RentalPrice { get; set; }
        public bool Rented { get; set; }

        //public int case1Choice;

        public bool result;
        public bool Rent() 
        {
            if (Rented == false) //car not rented
            {
                Rented = true; //now car is rented
                result = true;
                return result;
            }
            else //Rented == true     car is already rented
            {
                Console.WriteLine("\nSorry, the selected car is not available for rent.\n");
                result = false;
                return result;
            }
        }
        public bool Return()
        {
            if (Rented == true) //car is rented
            {
                Rented = false; //now car is returned
                result = true;
                return result;
            }
            else //Rented == false     car is available
            {
                Console.WriteLine("\nCar cannot be returned as it was never rented.\n");
                result = false;
                return result;
            }
        }
        public string PrintInfo()
        {
            if (Rented == false)
            {
                return "Available";
            }
            else
            {
                return "Rented";

            }
        }
    }
}
