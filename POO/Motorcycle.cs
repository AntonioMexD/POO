using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Motorcycle : Vehicle, IClassVehicle
    {
        private string _vehicleStatus;
        public string Make;
        public string Model;
        private float Fuel;
        private int Wheels;
        public int Odometer { get; set; }
        public Motorcycle(float _fuel)
        {
            Make = "BMW";
            Model = "R1250RT";
            Odometer = 0;
            Wheels = 2;
            Fuel = _fuel;
        }
        public void Run()
        {
            _vehicleStatus = "The motorcycle is running";
            Odometer = Odometer + 10;
            Fuel = Fuel - 10;
        }
        public void Go_Slow()
        {
            _vehicleStatus = "The motorcycle is going slow";
            Odometer = Odometer + 5;
        }

        public void On()
        {
            _vehicleStatus = "The motorcycle is on";
        }

        public void Off()
        {
            _vehicleStatus = "The motorcycle is off";
        }

        public void StatusMotorcycle()
        {
            Console.WriteLine(_vehicleStatus);
        }
        public string GetMake()
        {
            return this.Make;
        }
        public string GetModel()
        {
            return this.Model;
        }
        public float GetFuel()
        {
            return Fuel;
        }
        public float ChargeFuel()
        {
            return this.Fuel;
        }
        public int NumberWheels()
        {
            return this.Wheels;
        }
    }
}
