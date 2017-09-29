﻿using System;
using System.Collections;
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
            int iKeyValue = 0;
            bool bMenuCheck = false;
            bool bStackCheck = false;
            bool bQueueCheck = false;
            bool bDictionaryCheck = false;
            string sValue = "";
            Stack<string> stMyStack = new Stack<string>();
            Queue<string> qMyQueue = new Queue<string>();
            Dictionary<string, int> dMyDictionary = new Dictionary<string, int>();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            while (iMainMenuChoice != 4)
            {
                while (!bMenuCheck)
                {
                    try
                    {
                        Console.WriteLine("1. Stack");
                        Console.WriteLine("2. Queue");
                        Console.WriteLine("3. Dictionary");
                        Console.WriteLine("4. Exit\n");
                        Console.Write("Menu Choice: ");

                        iMainMenuChoice = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nPlease enter a number!");
                    }
                   bMenuCheck = true;
                }
                bMenuCheck = false;
                switch (iMainMenuChoice)
                {
                    case 1:
                        while (iStackMenu != 7)
                        {
                            while (!bStackCheck)
                            {
                                try
                                {
                                    Console.WriteLine("\n1. Add One Time to Stack");
                                    Console.WriteLine("2. Add Huge List of Items to Stack");
                                    Console.WriteLine("3. Display Stack");
                                    Console.WriteLine("4. Delete From Stack");
                                    Console.WriteLine("5. Clear Stack");
                                    Console.WriteLine("6. Search Stack");
                                    Console.WriteLine("7. Return to Main Menu\n");

                                    Console.Write("Stack Menu Choice: ");

                                    iStackMenu = Convert.ToInt32(Console.ReadLine());

                                    switch (iStackMenu)
                                    {
                                        case 1:
                                            Console.Write("\nPlease Enter a String: ");
                                            sValue = Console.ReadLine();
                                            stMyStack.Push(sValue);
                                            break;
                                        case 2:
                                            //Stuff
                                            break;
                                        case 3:
                                            if (stMyStack.Count() > 0)
                                            {
                                                int iCount = 0;
                                                Console.WriteLine("\nCurrently in the stack:\n");
                                                foreach (string s in stMyStack)
                                                {
                                                    Console.WriteLine(stMyStack.ElementAt(iCount));
                                                    iCount++;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nThere is nothing in the stack!");
                                            }
                                            break;
                                        case 4:
                                            //Stuff
                                            break;
                                        case 5:
                                            stMyStack.Clear();
                                            Console.WriteLine("\nStack Cleared!");
                                            break;
                                        case 6:
                                            //Stuff
                                            break;
                                        case 7:
                                            Console.WriteLine();
                                            break;
                                        default:
                                            iStackMenu = 0;
                                            Console.WriteLine("\nPlease Enter a Menu Option: ");
                                            bStackCheck = false;
                                            break;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("\nPlease enter a number!");
                                }
                                bStackCheck = true;
                            }
                            bStackCheck = false;
                        }
                        iStackMenu = 0;
                        break;
                    case 2:
                        while (iQueueMenu != 7)
                        {
                            while (!bQueueCheck)
                            {
                                try
                                {
                                    Console.WriteLine("\n1. Add One Time to Queue");
                                    Console.WriteLine("2. Add Huge List of Items to Queue");
                                    Console.WriteLine("3. Display Queue");
                                    Console.WriteLine("4. Delete From Queue");
                                    Console.WriteLine("5. Clear Queue");
                                    Console.WriteLine("6. Search Queue");
                                    Console.WriteLine("7. Return to Main Menu\n");

                                    Console.Write("Queue Menu Choice: ");

                                    iQueueMenu = Convert.ToInt32(Console.ReadLine());

                                    switch (iQueueMenu)
                                    {
                                        case 1:
                                            Console.Write("\nPlease Enter a String: ");
                                            sValue = Console.ReadLine();
                                            qMyQueue.Enqueue(sValue);
                                            break;
                                        case 2:
                                            //Stuff
                                            break;
                                        case 3:
                                            if (qMyQueue.Count() > 0)
                                            {
                                                int iCount = 0;
                                                Console.WriteLine("\nCurrently in the Queue:\n");
                                                foreach (string s in qMyQueue)
                                                {
                                                    Console.WriteLine(qMyQueue.ElementAt(iCount));
                                                    iCount++;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nThere is nothing in the Queue!");
                                            }
                                            break;
                                        case 4:
                                            //Stuff
                                            break;
                                        case 5:
                                            qMyQueue.Clear();
                                            Console.WriteLine("\nQueue Cleared!");
                                            break;
                                        case 6:
                                            //Stuff
                                            break;
                                        case 7:
                                            Console.WriteLine();
                                            break;
                                        default:
                                            iQueueMenu = 0;
                                            Console.WriteLine("\nPlease Enter a Menu Option: ");
                                            bQueueCheck = false;
                                            break;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("\nPlease enter a number!");
                                }
                                bQueueCheck = true;
                            }
                            bQueueCheck = false;
                        }
                        iQueueMenu = 0;
                        break;
                    case 3:
                        while (iDictionaryMenu != 7)
                        {
                            while (!bDictionaryCheck)
                            {
                                try
                                {
                                    Console.WriteLine("\n1. Add One Time to Dictionary");
                                    Console.WriteLine("2. Add Huge List of Items to Dictionary");
                                    Console.WriteLine("3. Display Dictionary");
                                    Console.WriteLine("4. Delete From Dictionary");
                                    Console.WriteLine("5. Clear Dictionary");
                                    Console.WriteLine("6. Search Dictionary");
                                    Console.WriteLine("7. Return to Main Menu\n");

                                    Console.Write("Dictionary Menu Choice: ");
                                    iDictionaryMenu = Convert.ToInt32(Console.ReadLine());

                                    switch (iDictionaryMenu)
                                    {
                                        case 1:
                                            Console.Write("\nPlease Enter a Name for the Key: ");
                                            sValue = Console.ReadLine();
                                            Console.Write("\nPlease Enter a Value: ");
                                            iKeyValue = Convert.ToInt32(Console.ReadLine());
                                            dMyDictionary.Add(sValue, iKeyValue);
                                            Console.WriteLine("\nSuccessfully added item to dictionary");
                                            break;
                                        case 2:
                                            dMyDictionary.Clear();
                                            for (int iCount3 = 0; iCount3 < 2000; iCount3++)
                                            {
                                                dMyDictionary.Add("New Entry " + (iCount3 + 1), iCount3 + 1);
                                            }
                                            Console.WriteLine("\nSuccessfully added items to dictionary");
                                            break;
                                        case 3:
                                            if (dMyDictionary.Count() > 0)
                                            {
                                                foreach(KeyValuePair<string, int> entry in dMyDictionary)
                                                {
                                                    Console.WriteLine(entry.Key.PadRight(16) + entry.Value);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nThere is nothing in the dictionary!");
                                            }
                                            break;
                                        case 4:
                                            Console.Write("Which item would you like to delete? ");
                                            string sDel_dictionary = Console.ReadLine();
                                            if(dMyDictionary.Remove(sDel_dictionary))
                                            {
                                                Console.WriteLine("\nItem removed!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nDictionary doesn't contain the key!");
                                            }
                                            break;
                                        case 5:
                                            dMyDictionary.Clear();
                                            Console.WriteLine("\nDictionary Cleared!");
                                            break;
                                        case 6:
                                            Console.Write("\nWhich item would you like to search? ");
                                            string sSearch_dictionary = Console.ReadLine();
                                            sw.Start();
                                            if (dMyDictionary.ContainsKey(sSearch_dictionary))
                                            {
                                                sw.Stop();
                                                Console.WriteLine("\nItem Found!");
                                            }
                                            else
                                            {
                                                sw.Stop();
                                                Console.WriteLine("\nItem Not Found!");
                                            }
                                            Console.WriteLine("\nTime elapsed: " + sw.Elapsed);
                                            Console.WriteLine("\n");
                                            break;
                                        case 7:
                                            Console.WriteLine();
                                            break;
                                        default:
                                            iDictionaryMenu = 0;
                                            Console.WriteLine("\nPlease Enter a Menu Option: ");
                                            bDictionaryCheck = false;
                                            break;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("\nPlease enter a number!");
                                }
                                bDictionaryCheck = true;
                            }
                            bDictionaryCheck = false;
                        }
                        iDictionaryMenu = 0;
                        break;
                    case 4:
                        break;
                    default:
                        iMainMenuChoice = 0;
                        Console.WriteLine("\nPlease Select a menu option: ");
                        bMenuCheck = false;
                        break;
                }
            }
        }
    }
}
