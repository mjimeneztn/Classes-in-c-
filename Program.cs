using System;
using System.Collections.Generic;

namespace carz
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> car1 = new Dictionary<string, string>() {
                { "Year", "2001" }, { "Make", "honda" }, { "Model", "civic" }, { "Price", "500" }
            };
            Dictionary<string, string> car2 = new Dictionary<string, string>() {
                { "Year", "2007" }, { "Make", "subaru" }, { "Model", "wrx" }, { "Price", "4000" }
            };


            List<Dictionary<string, string>> garage = new List<Dictionary<string, string>>();

            garage.Add(car1);
            garage.Add(car2);


            Car ford = new Car();
            ford.Make = "Ford";
            ford.Model = "Explorer";
            ford.Year = 1999;
            ford.Price = 1000.50;

            Car car22 = new Car()
            {
                Make = "Mazda",
                Model = "B2500",
                Price = 115.99,
                Year = 1999
            };
            List<Car> garage2 = new List<Car>()
            { ford, car22 };

            foreach (Car car in garage2)
            {
                car.Accelerate();
               int age= car.GetAge();
               Console.WriteLine(age);
               Console.WriteLine(car.Description);

               car.Drive(1000);
            }

        }
    }
}
