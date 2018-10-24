using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bc
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No line provided!");
                return;
            }

            int number = 0;
            number = int.Parse(args[0]);
            Console.WriteLine("The number you gave is " + number);

            int[] bindigits = new int[32];
            int i = 0;


            while (number / 2 >= 1)
            {
                bindigits[i] = number % 2;
                number = number / 2;
                i = i + 1;

            }
            bindigits[i] = number;
            while(i>=0)
            {
                Console.Write(bindigits[i]);
                i = i - 1;
            }



            Console.ReadKey();
        }
    }
}
    

