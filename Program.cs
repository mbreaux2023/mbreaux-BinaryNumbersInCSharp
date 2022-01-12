using System;

namespace mbreaux_BinaryNumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 42;
            Console.WriteLine(x);

           

            // Converts to a number in base 2
            string x_binary = "0b" + Convert.ToString(x, 2);
            Console.WriteLine(x_binary);

            // Converts to number in base 16
            string x_hex = "0x" + Convert.ToString(x, 16);
            Console.WriteLine(x_hex);

            int y;
            y = -1;
            Console.WriteLine(x);

            string y_binary = "0b" + Convert.ToString(y, 2);
            Console.WriteLine(y_binary); 

            int z;
            z = y - 1;
            string z_binary = "Ob" + Convert.ToString(z, 2);
            Console.WriteLine(z_binary);
            
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            int max = int.MaxValue ;
            int max_plus_1 = max + 1;
            Console.WriteLine(max_plus_1);
            string max_plus_1_binary = "0b" + Convert.ToString(max_plus_1, 2);
            Console.WriteLine(max_plus_1_binary);
        }
    }
}
