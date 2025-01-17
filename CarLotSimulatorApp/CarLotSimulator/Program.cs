﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();
            //TODO
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            CarLot carLot = new CarLot();
            
            CarLot.numberOfCars++;
            
            
            var carOne = new Car();
            carOne.Make = "BMW";
            carOne.Model = "M3";
            carOne.Year = 2005;
            carOne.IsDriveable = true;
            
            carOne.MakeEngineNoise("Vroom");
            carOne.MakeHonkNoise("Honk");

            carLotOne.ParkingLot.Add(carOne);
            
            var carTwo = new Car()
            {
                Make = "Nissan",
                Model = "Frontier",
                Year = 2018,
                IsDriveable = true
            };
            
            carTwo.MakeEngineNoise("Mumumum");
            carTwo.MakeHonkNoise("Awooga");
            
            carLotOne.ParkingLot.Add(carTwo);

            var carThree = new Car(make: "Ford", model: "Bronco", year: 2018, isDriveable: true);
            
            carThree.MakeEngineNoise("Varrroom");
            carThree.MakeHonkNoise("Toop Toop");
            
            carLotOne.ParkingLot.Add(carThree);
            
            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            carLotOne.CheckCars();

            Console.WriteLine($"The number of cars in the lot is: {CarLot.numberOfCars}");
        }
    }
}
