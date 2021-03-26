using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstraccion y encapsulacion

            Motorcycle Motocicleta = new Motorcycle(100);
            Motocicleta.On();
            Motocicleta.StatusMotorcycle();
            Motocicleta.Run();
            Motocicleta.StatusMotorcycle();
            Motocicleta.Off();
            Motocicleta.StatusMotorcycle();
            Console.WriteLine($"The current fuel of " + Motocicleta.GetFuel());

            //Herencia y polimorfismo

            Vehicle vehiculo = new Motorcycle(200);
            IClassVehicle classVehicle = new Motorcycle(1000);

            Console.WriteLine($"The vehicle registration is " + vehiculo.getVehicleRegistration());

        }
    }
}
