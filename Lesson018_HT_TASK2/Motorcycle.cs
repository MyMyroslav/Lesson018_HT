using System;
namespace Lesson013_Task1
{
    public class Motorcycle : Vehicle
    {
        //private double weight;
        //private double height;
        //private double width;
        //private double price;
        //private double maxSpeed;
        public override void Start()
        {
            Console.WriteLine("START MOTOR");
        }
        public override void Stop()
        {
            Console.WriteLine("STOP MOTOR");
        }
        public Motorcycle()
        {
        }
    }
}
