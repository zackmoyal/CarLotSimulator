using System;
using System.Reflection.Metadata.Ecma335;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            var carLot = new CarLot();

            Car toyota = new Car();
            Console.WriteLine($"The number of cars in the lot is: {CarLot.numberOfCars}");
            Console.WriteLine();

            Car honda = new Car();
            Console.WriteLine($"The number of cars in the lot is: {CarLot.numberOfCars}");
            Console.WriteLine();

            Car tesla = new Car();
            Console.WriteLine($"The number of cars in the lot is: {CarLot.numberOfCars}");
            Console.WriteLine();

            toyota.Year = 2020;
            toyota.Make = "Toyota";
            toyota.Model = "Camry";
            toyota.EngineNoise = "Skrrt skrrt";
            toyota.HonkNoise = "Why hello there";
            toyota.IsDriveable = true;

            honda.Year = 2020;
            honda.Make = "Honda";
            honda.Model = "Accord";
            honda.EngineNoise = "Vroom vroom";
            honda.HonkNoise = "Beep beep";
            honda.IsDriveable = true;

            tesla.Year = 2020;
            tesla.Make = "Tesla";
            tesla.Model = "Model X";
            tesla.EngineNoise = "*battery engine sound*";
            tesla.HonkNoise = "I am from the future";
            tesla.IsDriveable = true;

            //toyota.MakeEngineNoise();
            //toyota.MakeHonkNoise();
            //Console.WriteLine();

            //honda.MakeEngineNoise();
            //honda.MakeHonkNoise();
            //Console.WriteLine();

            //tesla.MakeEngineNoise();
            //tesla.MakeHonkNoise();

            carLot.Cars.Add(toyota);

            carLot.Cars.Add(honda);

            carLot.Cars.Add(tesla);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            //Console.WriteLine("\nCars in the Car Lot:");
            //foreach (var car in carLot.Cars)
            //{
            //    Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            //}
        }
    }
}
