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

            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            car1.Year = 2020;
            car1.Make = "Toyota";
            car1.Model = "Camry";
            car1.EngineNoise = "Skrrt skrrt";
            car1.HonkNoise = "Why hello there";
            car1.IsDriveable = true;

            car2.Year = 2020;
            car2.Make = "Honda";
            car2.Model = "Accord";
            car2.EngineNoise = "Vroom vroom";
            car2.HonkNoise = "Beep beep";
            car2.IsDriveable = true;

            car3.Year = 2020;
            car3.Make = "Tesla";
            car3.Model = "Model X";
            car3.EngineNoise = "*battery engine sound*";
            car3.HonkNoise = "I am from the future";
            car3.IsDriveable = true;

            car1.MakeEngineNoise();
            car1.MakeHonkNoise();

            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            car3.MakeEngineNoise();
            car3.MakeHonkNoise();

            carLot.Cars.Add(car1);
            carLot.Cars.Add(car2);
            carLot.Cars.Add(car3);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine("\nCars in the Car Lot:");
            foreach (var car in carLot.Cars)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }
        }
    }
}
