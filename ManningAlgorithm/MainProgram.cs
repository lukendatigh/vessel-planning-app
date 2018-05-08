using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManningAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n -----------------------\n |  MANNING ALGORITHM  |\n -----------------------\n\n");
            int input;
            Console.WriteLine("Select an Option:\n" +
                              "1. Add Seafarer\n" +
                              "2. Delete Seafarer\n" +
                              "3. Edit Seafarer\n");
            input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
                Methods.Data.addSeafarer();


            





            Console.ReadKey();
        }
    }
}
