using System;

namespace Circle
{
    class Circle
    {
        double radius;
		public Circle(){}
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius=radius;
        }
        public double calcDiameter() {
            return radius * 2;
        }
        public double calcArea() {
            return 3.14 * radius * radius;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius: ");
            int radius = int.Parse(Console.ReadLine());
            Circle c1 = new Circle();
            c1.SetRadius(radius);
            Console.WriteLine($"Radius: {c1.GetRadius()}");
            Console.WriteLine(String.Format("Diameter: {0:0.##}", c1.calcDiameter()));
            Console.WriteLine(String.Format("Area: {0:0.##}", c1.calcArea()));

        }
    }
}
