using System;
namespace Lesson013_Task1
{
    public class Bus : Vehicle
    {
        //private double weight;
        //private double height;
        //private double width;
        //private double price;
        //private double maxSpeed;
        public override void Start()
        {
            Console.WriteLine("START BUS");
        }
        public override void Stop()
        {
            Console.WriteLine("STOP BUS");
        }
        public override event EventHandler Foo
        {
            add
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine("START CAR OVERRIDE EVENT");
                Console.WriteLine("STOP CAR OVERRIDE EVENT");
            }
            remove
            {
                Console.WriteLine("YOU ARE UNFOLLOWED");
            }
        }
        public Bus()
        {
        }
    }
}
