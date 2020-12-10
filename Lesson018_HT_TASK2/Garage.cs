using System;
namespace Lesson013_Task1
{
    public class Garage
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;

        Vehicle [] vehicles = new Vehicle[6];

        public Garage()
        {
        }
        public Garage(Vehicle [] vehicles)
        {
                this.vehicles = vehicles;
        }
        public Vehicle this[int index]
        {
            get
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Notify?.Invoke("Car was returning");
                return vehicles[index];
            }

            set
            {
                Console.BackgroundColor = ConsoleColor.Green;
                vehicles[index] = value;
                Notify?.Invoke($"{value} is setted");
            }
        }
        public virtual Vehicle GetVehicle(int index)
        {
            Vehicle el;
            if (this.vehicles[index] != null)
            {
                el = this.vehicles[index];
                this.vehicles[index] = null;
                Console.BackgroundColor = ConsoleColor.Green;
                Notify?.Invoke("Car was returning by getter");
                return el;
            }
            else
            {
                //Console.WriteLine("There are not vehicle on that garage");
                Console.BackgroundColor = ConsoleColor.Green;
                Notify?.Invoke("There are not vehicle on that garage by getter");
            }
            return null;
        }
        public void SetVehicle(int index, Vehicle vehicle)
        {
            if (this.vehicles[index] == null)
            {
                this.vehicles[index] = vehicle;
                Console.BackgroundColor = ConsoleColor.Green;
                Notify?.Invoke($"{vehicle} is setted by setter");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Notify?.Invoke($"There are standing {this.vehicles[index]}");
                //Console.WriteLine($"There are standing {this.vehicles[index]}");
            }
        }
        
    }
}
