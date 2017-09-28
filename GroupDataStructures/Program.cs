using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int iMainMenuChoice = 0;
            int iDataStructure = 0;

            while(iMainMenuChoice != 4)
            {
                Console.WriteLine("1. Stack");
                Console.WriteLine("2. Queue");
                Console.WriteLine("3. Dictionary");
                Console.WriteLine("4. Exit");
                Console.Read();

                switch (iMainMenuChoice)
                {
                    case 1:
                        //Stack Stuff
                        Console.WriteLine("Case 1");
                        break;
                    case 2:
                        Console.WriteLine("Case 2");
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;

                }
            }
        }
    }
}
