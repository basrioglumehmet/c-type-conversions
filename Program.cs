using System;

namespace type_conversion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Implicit Conversion (Implicit or automatic conversion)
            // An int can be implicitly converted to a float because a float can hold larger values and decimal points.
            float a;
            int b;
            b = 777;
            a = b;
            Console.WriteLine("a: " + a); // Output: a: 777

            // Explicit Conversion (Explicit or manual conversion)
            // A short can be explicitly cast to an int, even though in this case it is redundant
            // because an int can hold any value that a short can. This is just for demonstration.
            short x = 10;
            int y = (int)x;
            Console.WriteLine("y: " + y); // Output: y: 10

            // Example of a necessary explicit conversion
            double c = 9.78;
            int d = (int)c; // Explicit conversion needed because int cannot hold decimal part
            Console.WriteLine("d: " + d); // Output: d: 9
        }
    }
}
