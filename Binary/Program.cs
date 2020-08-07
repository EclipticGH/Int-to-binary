using System;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Convert int to binary";
            try
            {
                string val;
                int output;
                Console.WriteLine("Enter a number too convert to binary: ");
                val = Console.ReadLine();
                output = Convert.ToInt32(val);

                string binary = Convert.ToString(output, 2);
                Console.WriteLine(binary);
                Console.ReadKey(); //Stops program from stopping until a key is pressed
            }
            catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Task.Delay(10000);
            };
        }
    }
}
