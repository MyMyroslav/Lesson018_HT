using System;
namespace Lesson013_Task1
{
    public class Truck : Vehicle
    {
        //private double weight;
        //private double height;
        //private double width;
        //private double price;
        //private double maxSpeed;
        public override void Start()
        {
            Console.WriteLine("START TRUCK");
        }
        public override void Stop()
        {
            Console.WriteLine("STOP TRUCK");
        }
        public Truck()
        {
        }
    }
}
