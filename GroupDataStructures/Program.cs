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
            int iStackMenu = 0;
            int iQueueMenu = 0;
            int iDictionaryMenu = 0;
            bool bMenuCheck = false;
            bool bStackCheck = false;
            bool bQueueCheck = false;
            bool bDictionaryCheck = false;


            while (iMainMenuChoice != 4)
            {
                while (!bMenuCheck)
                {
                    try
                    {
                        Console.WriteLine("1. Stack");
                        Console.WriteLine("2. Queue");
                        Console.WriteLine("3. Dictionary");
                        Console.WriteLine("4. Exit");
                    
                        iMainMenuChoice = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter a number: ");
                    }
                    bMenuCheck = true;
                }
                switch (iMainMenuChoice)
                {
                    case 1:
                        while (!bStackCheck)
                        {
                            try
                            {
                                Console.WriteLine("1. Add One Time to Stack");
                                Console.WriteLine("2. Add Huge List of Items to Stack");
                                Console.WriteLine("3. Display Stack");
                                Console.WriteLine("4. Delete From Stack");
                                Console.WriteLine("5. Clear Stack");
                                Console.WriteLine("6. Search Stack");
                                Console.WriteLine("7. Return to Main Menu");
                                iStackMenu = Convert.ToInt32(Console.ReadLine());

                                switch (iStackMenu)
                                {
                                    case 1:
                                        //Stuff
                                        break;
                                    case 2:
                                        //Stuff
                                        break;
                                    case 3:
                                        //Stuff
                                        break;
                                    case 4:
                                        //Stuff
                                        break;
                                    case 5:
                                        //Stuff
                                        break;
                                    case 6:
                                        //Stuff
                                        break;
                                    case 7:
                                        //Stuff
                                        break;
                                    default:
                                        iStackMenu = 0;
                                        Console.WriteLine("Please Enter a Menu Option: ");
                                        bStackCheck = false;
                                        break;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Please enter a number: ");
                            }
                            bStackCheck = true;
                        }
                        break;
                    case 2:
                        while (!bQueueCheck)
                        {
                            try
                            {
                                Console.WriteLine("1. Add One Time to Queue");
                                Console.WriteLine("2. Add Huge List of Items to Queue");
                                Console.WriteLine("3. Display Queue");
                                Console.WriteLine("4. Delete From Queue");
                                Console.WriteLine("5. Clear Queue");
                                Console.WriteLine("6. Search Queue");
                                Console.WriteLine("7. Return to Main Menu");
                                iQueueMenu = Convert.ToInt32(Console.ReadLine());

                                switch (iQueueMenu)
                                {
                                    case 1:
                                        //Stuff
                                        break;
                                    case 2:
                                        //Stuff
                                        break;
                                    case 3:
                                        //Stuff
                                        break;
                                    case 4:
                                        //Stuff
                                        break;
                                    case 5:
                                        //Stuff
                                        break;
                                    case 6:
                                        //Stuff
                                        break;
                                    case 7:
                                        //Stuff
                                        break;
                                    default:
                                        iQueueMenu = 0;
                                        Console.WriteLine("Please Enter a Menu Option: ");
                                        bQueueCheck = false;
                                        break;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Please enter a number: ");
                            }
                            bQueueCheck = true;
                        }
                        break;
                    case 3:
                        while (!bDictionaryCheck)
                        {
                            try
                            {
                                Console.WriteLine("1. Add One Time to Dictionary");
                                Console.WriteLine("2. Add Huge List of Items to Dictionary");
                                Console.WriteLine("3. Display Dictionary");
                                Console.WriteLine("4. Delete From Dictionary");
                                Console.WriteLine("5. Clear Dictionary");
                                Console.WriteLine("6. Search Dictionary");
                                Console.WriteLine("7. Return to Main Menu");
                                iDictionaryMenu = Convert.ToInt32(Console.ReadLine());

                                switch (iDictionaryMenu)
                                {
                                    case 1:
                                        //Stuff
                                        break;
                                    case 2:
                                        //Stuff
                                        break;
                                    case 3:
                                        //Stuff
                                        break;
                                    case 4:
                                        //Stuff
                                        break;
                                    case 5:
                                        //Stuff
                                        break;
                                    case 6:
                                        //Stuff
                                        break;
                                    case 7:
                                        //Stuff
                                        break;
                                    default:
                                        iDictionaryMenu = 0;
                                        Console.WriteLine("Please Enter a Menu Option: ");
                                        bDictionaryCheck = false;
                                        break;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Please enter a number: ");
                            }
                            bDictionaryCheck = true;
                        }
                        break;
                    default:
                        iMainMenuChoice = 0;
                        Console.WriteLine("Please Select a menu option: ");
                        bMenuCheck = false;
                        break;
                }
            }
        }
    }
}
