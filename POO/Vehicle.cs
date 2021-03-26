using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public abstract class Vehicle
    {
        protected string _type;
        string vehicle_Registration;
        public Vehicle()
        {
            _type = "Sport";
            vehicle_Registration = "1234ABC";
        }
        protected void Move() { }
        public string State()
        {
            return "El vehiculo esta sin combustible"; 
        }
        public string getVehicleRegistration()
        {
            return vehicle_Registration;
        }

    }
}
