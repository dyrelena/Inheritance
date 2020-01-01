using System;
using System.Drawing;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane boing = new Plane("Plane") { Coordinates = new Point(5, 6), Price = 100000, Speed = 988, Height = 4000, Passengers = 600, YearManufacture = 2002};            
            Car ford = new Car("Car") { Coordinates = new Point (34, 56), Price = 40000, Speed = 180, YearManufacture = 2014};
            Ship titanic = new Ship("Ship") { Coordinates = new Point(34, 105), Price = 10000000, Speed = 300, YearManufacture = 1861, Passengers = 2000, Port = "Liverpul"};

            PrintVehicle(new Vehicle[] { boing, ford, titanic });
            Console.ReadLine();
            
            //Console.WriteLine("Hello World!");
        }

        static void PrintVehicle(Vehicle[] vehicles)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.VehicleInfo();
                Console.WriteLine("\n");
            }
        }
    }

    public class Vehicle
    {
        Point coordinates = new Point();
        double price;
        int speed;
        int yearManufacture;
        String name;

        public Point Coordinates { get => coordinates; set => coordinates = value; }
        public double Price { get => price; set => price = value; }
        public int Speed { get => speed; set => speed = value; }
        public int YearManufacture { get => yearManufacture; set => yearManufacture = value; }
        public string Name { get => name; set => name = value; }

        public virtual void VehicleInfo()
        {
            Console.WriteLine("{0}: \nCoordinates {1}, \nPrice = {2}, \nSpeed = {3} km/h, \nYear = {4}", Name, Coordinates, Price, Speed, YearManufacture); 
        }
    }

    public class Plane: Vehicle
    {
        double height;
        int passengers;

        public double Height { get => height; set => height = value; }
        public int Passengers { get => passengers; set => passengers = value; }

        public Plane(string name)
        {
            Name = name;
        }
        public override void VehicleInfo()
        {
            base.VehicleInfo();
            Console.WriteLine("Height = {0} m, \nPassengers = {1}", Height, Passengers);
        }
    }

    public class Car: Vehicle
    {
        public Car(string name)
        {
            Name = name;
        }
    }

    public class Ship: Vehicle
    {
        int passengers;
        String port;

        public int Passengers { get => passengers; set => passengers = value; }
        public string Port { get => port; set => port = value; }

        public Ship(string name)
        {
            Name = name;
        }

        public override void VehicleInfo()
        {
            base.VehicleInfo();
            Console.WriteLine("Port = {0}, \nPassengers = {1}", Port, Passengers);
        }
    }
}
