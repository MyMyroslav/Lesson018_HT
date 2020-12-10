using System;
namespace Lesson013_Task1
{
    public abstract class Vehicle : Garage
    {
        public virtual event EventHandler Foo
        {
            add
            {
                Console.WriteLine("Base Foo.add called");
            }
            remove
            {
                Console.WriteLine("Base Foo.remove called");
            }
        }

        private double weight;
        private double height;
        private double width;
        private decimal price;
        private double maxSpeed;
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public decimal Price { get; set; }
        public double MaxSpeed { get; set; }

        public Vehicle()
        {
        }
        public Vehicle(double weight, double height, double width, decimal price, double maxSpeed)
        {
            this.weight = weight;
            this.height = height;
            this.width = width;
            this.price = price;
            this.maxSpeed = maxSpeed;
        }
        public virtual void Start()
        {
            Console.WriteLine("START");
        }
        public virtual void Stop()
        {
            Console.WriteLine("STOP");
        }
    }
}
