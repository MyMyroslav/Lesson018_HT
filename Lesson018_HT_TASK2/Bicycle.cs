using System;
namespace Lesson013_Task1
{
    public class Bicycle : Vehicle
    {
        //private double weight;
        //private double height;
        //private double width;
        //private double price;
        //private double maxSpped;
        public override void Start()
        {
            Console.WriteLine("START BCLE");
        }
        public override void Stop()
        {
            Console.WriteLine("STOP BCLE");
        }
        public override event EventHandler Foo
        {
            add
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("START BCLE OVERRIDE EVENT");
                Console.WriteLine("STOP BCLE OVERRIDE EVENT");
            }
            remove
            {
                Console.WriteLine("YOU ARE UNFOLLOWED");
            }
        }
        public Bicycle()
        {
        }
    }
}
