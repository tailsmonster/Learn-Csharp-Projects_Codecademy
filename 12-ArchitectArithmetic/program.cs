using System;

namespace ArchitectArithmetic
{
    class Program
    {
        static double Area(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }
        static double Area(double l, double w)
        {
            return l * w;
        }
        static double Radius(double l, double w)
        {
            return 0.5 * l * w;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Area(4,5));
            Console.WriteLine(Area(4));
            Console.WriteLine(Radius(10,9));
        }
    }
}

// I dont think I need more practice with methods rn lol