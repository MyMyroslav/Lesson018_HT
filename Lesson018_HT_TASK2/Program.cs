using System;

namespace Lesson013_Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[6];
            Vehicle[] results = new Vehicle[6];


            Vehicle bicycle = new Bicycle();
            //Bicycle bicycle1 = new Bicycle();
            //bicycle.VehicleEve += DisplayMessage;

            bicycle.Height = 1;
            bicycle.Price = 3_000.00m;
            bicycle.MaxSpeed = 40;
            bicycle.Weight = 2;
            bicycle.Width = 20;



            Vehicle bus = new Bus();
            bus.Height = 3;
            bus.Price = 35_000.00m;
            bus.MaxSpeed = 180;
            bus.Weight = 10_000;
            bus.Width = 16;



            Vehicle car = new Car();
            car.Height = 1;
            car.Price = 30_000.00m;
            car.MaxSpeed = 250;
            car.Weight = 2000;
            car.Width = 2;



            Vehicle motorcycle = new Motorcycle();
            motorcycle.Height = 1;
            motorcycle.Price = 38_000.00m;
            motorcycle.MaxSpeed = 250;
            motorcycle.Weight = 1000;
            motorcycle.Width = 2;


            Vehicle plane = new Plane();
            plane.Height = 30;
            plane.Price = 3_000_000.00m;
            plane.MaxSpeed = 1800;
            plane.Weight = 30_000;
            plane.Width = 30;



            Vehicle truck = new Truck();
            truck.Height = 4;
            truck.Price = 50_000.00m;
            truck.MaxSpeed = 180;
            truck.Weight = 10_000;
            truck.Width = 20;


            vehicles[0] = bicycle;
            vehicles[1] = bus;
            vehicles[2] = car;
            vehicles[3] = motorcycle;
            vehicles[4] = plane;
            vehicles[5] = truck;

            Garage garage = new Garage(vehicles);
            garage.Notify += DisplayMessage;

            bus.Foo += DisplayMessage;
            for (int i = 0; i < vehicles.Length; i++)
            {

                vehicles[i].Start();
                vehicles[i].Stop();

            }

            Vehicle index = garage.GetVehicle(0);
            Console.WriteLine(index);
            index.Start();

            for (int i = 0; i < 6; i++)
            {
                garage.SetVehicle(i, vehicles[i]);
                Console.WriteLine(garage.GetVehicle(i));

            }

            //indexers
            var garageCollection = new Garage();

            garageCollection.Notify += DisplayMessage;
            bicycle.Foo += DisplayMessage;
            bus.Foo += DisplayMessage;
            garageCollection[0] = bicycle;
            garageCollection[1] = bus;
            garageCollection[2] = car;
            garageCollection[3] = motorcycle;
            garageCollection[4] = plane;
            garageCollection[5] = truck;

            for (int i = 0; i < vehicles.Length; i++)
            {
                garageCollection[i].Start();
                garageCollection[i].Stop();
            }
        }

        private static void DisplayMessage(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
