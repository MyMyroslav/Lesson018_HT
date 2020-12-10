using System;
namespace Lesson013_Task1
{
    public class Car : Vehicle
    {
        //private double weight;
        //private double height;
        //private double width;
        //private double price;
        //private double maxSpeed;
        public override void Start()
        {
            Console.WriteLine("START CAR");
        }
        public override void Stop()
        {
            Console.WriteLine("STOP CAR");
        }
        public Car()
        {
        }
    }
}
