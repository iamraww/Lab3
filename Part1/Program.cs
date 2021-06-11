using System;

namespace Part1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car car;
            Console.WriteLine("Creating a Car object and assigning "
            + "its memory location to car");
            car = new Car();
            
            car.make = "Toyota";
            car.model = "MR2";
            car.color = "black";
            car.yearBuilt = 1995;
            
            Console.WriteLine("car details:");
            Console.WriteLine("car.make = "+ car.make);
            Console.WriteLine("car.model= "+car.model);
            Console.WriteLine("car.color = "+car.color);
            Console.WriteLine("car.yearBuilt=" +car.yearBuilt);
            
            car.Start();
            car.Stop();
            
            Console.WriteLine("Creating another Car object and"+"assigning its memory location to redPorsche");
            Car redPorsche = new Car();
            redPorsche.make = "Porsche";
            redPorsche.model = "Boxster";
            redPorsche.color = "red";
            redPorsche.yearBuilt = 2000;
            Console.WriteLine("redPorsche is a " + redPorsche.model);
            
            Console.WriteLine("Assigning redPorsche to car");
            car = redPorsche;
            Console.WriteLine("car details:");
            Console.WriteLine("car.make = " + car.make);
            Console.WriteLine("car.model = " +car.model);
            Console.WriteLine("car.color = " +car.color);
            Console.WriteLine("car.yearBuilt = "+car.yearBuilt);
            car = null;
            Console.ReadLine();
        }
    }
}