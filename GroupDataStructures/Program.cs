using System;
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
            Stack<string> holdingStack = new Stack<string>();
            Queue<string> qMyQueue = new Queue<string>();
            Queue <string> qHoldQueue = new Queue<string>();
            Dictionary<string, int> dMyDictionary = new Dictionary<string, int>();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            // do the program until they do the 4th option (exit)
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
                        Console.WriteLine("\nPlease enter a number!\n");
                        continue;
                    }
                   bMenuCheck = true;
                }
                bMenuCheck = false;
                switch (iMainMenuChoice)
                {
                    case 1:
                        // enter unless they choose 7
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
                                            // grab user input
                                            Console.Write("\nPlease Enter a String: ");
                                            sValue = Console.ReadLine();
                                            stMyStack.Push(sValue);

                                            // add to stack
                                            Console.Write("\nSuccessfully added item to Stack!");
                                            Console.WriteLine();
                                            break;

                                        case 2:
                                            //generate 2000 new entries and push into stack
                                            for(int i = 2000; i > 0; i--)
                                            {
                                                stMyStack.Push("New Entry " + i);
                                            }
                                            Console.WriteLine("\nSuccessfully Added Huge List of Items to Stack!");
                                            break;

                                        case 3:
                                            // display contents of stack
                                            if (stMyStack.Count() > 0)
                                            {
                                                Console.WriteLine();
                                                foreach (string s in stMyStack)
                                                {
                                                    Console.WriteLine(s);
                                                }
                                            }
                                            // inform that the stack was empty
                                            else
                                            {
                                                Console.WriteLine("\nThere is nothing in the stack!");
                                            }
                                            break;

                                        case 4:
                                            // break if nothing is in the stack to delete
                                            if (stMyStack.Count() == 0)
                                            {
                                                Console.WriteLine("\nCannot Delete Because Stack is Empty!");
                                                break;
                                            }

                                            // get user input
                                            Console.Write("\nWhich item would you like to delete? (please enter a string): ");
                                            string del_item = Console.ReadLine();

                                            // save original stack count
                                            int count = stMyStack.Count();
                                            bool found = false;

                                            //loop through stack to find item user wants to delete
                                            for(int i = 0; i < count; i++)
                                            {
                                                // enter if the item in the stack matches the item to be deleted
                                                if(stMyStack.Peek() == del_item)
                                                {
                                                    // remove item from the stack and break out of the loop
                                                    stMyStack.Pop();
                                                    found = true;
                                                    break;
                                                }
                                                // add unmatched stack item to holding stack
                                                else
                                                {
                                                    holdingStack.Push(stMyStack.Pop());
                                                }
                                            }

                                            // store original count of holding stack
                                            int hCount = holdingStack.Count();

                                            // push holding stack items back onto original stack
                                            for(int i = 0; i < hCount; i++)
                                            {
                                                stMyStack.Push(holdingStack.Pop());
                                            }

                                            Console.WriteLine();

                                            // if the item was found in the stack, inform that it was deleted
                                            if (found)
                                            {
                                                Console.WriteLine(del_item + " was deleted!");
                                            }
                                            // if the item was not found in the stack, inform user
                                            else
                                            {
                                                Console.WriteLine(del_item + " cannot be deleted because it does not exist in the Stack!");
                                            }
                                            break;

                                        case 5:
                                            // clear the stack
                                            stMyStack.Clear();
                                            Console.WriteLine("\nStack Cleared!");
                                            break;

                                        case 6:

                                            // don't search stack if it is empty
                                            if (stMyStack.Count() == 0)
                                            {
                                                Console.WriteLine("\nCannot Search Because Stack is Empty!");
                                                break;
                                            }

                                            // get user input on which item to search for
                                            Console.Write("\nWhich item would you like to search for? (please enter a string): ");
                                            string findItem = Console.ReadLine();

                                            // start a stop watch to see how long it takes to find the item
                                            sw.Start();
                                            if (stMyStack.Contains(findItem))
                                            {
                                                //stop the stopwatch and inform user that the item was found
                                                sw.Stop();
                                                Console.WriteLine(findItem + " was found!");
                                            }
                                            else
                                            {
                                                //stop the stopwatch and inform user that the item was not found
                                                sw.Stop();
                                                Console.WriteLine(findItem + " was not found!");
                                            }

                                            // show how long each search took
                                            Console.WriteLine("This search took " + sw.Elapsed + " seconds");
                                            break;

                                        case 7:
                                            // newline (this will break out of the while loop 
                                            Console.WriteLine();
                                            break;

                                        default:
                                            // prompt user to input a menu option
                                            iStackMenu = 0;
                                            Console.WriteLine("\nPlease Enter a Menu Option: ");
                                            bStackCheck = false;
                                            break;
                                    }
                                }
                                // catch any strings that are entered when they should be numbers
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

                    case 2: //Queue
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
                                        case 1: //Add One Time to Queue
                                            Console.Write("\nPlease Enter a String: ");
                                            sValue = Console.ReadLine();
                                            qMyQueue.Enqueue(sValue);

                                            Console.WriteLine("\nSuccessfully Added Item to Queue!"); //Confirmation for the user.
                                            break;

                                        case 2: //Add Huge List of Items to Queue
                                            qMyQueue.Clear(); //Clear the queue prior to entering 2000 items

                                            for(int iQCount2 = 0; iQCount2 < 2000; iQCount2++)
                                            {
                                                qMyQueue.Enqueue("New Entry " + (iQCount2 + 1));
                                            }
                                            Console.WriteLine("\nSuccessfully Added Huge List of Items to Queue!");
                                            break;

                                        case 3: //Display Queue
                                            if (qMyQueue.Count() > 0)
                                            {
                                                Console.WriteLine("\nCurrently in the Queue:\n");
                                                foreach (string s in qMyQueue)
                                                {
                                                    Console.WriteLine(s);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nThere is nothing in the Queue!");
                                            }
                                            break;

                                        case 4: //Delete From Queue
                                            if (qMyQueue.Count() == 0)
                                            {
                                                Console.WriteLine("\nCannot Delete Because Queue is Empty!");
                                                break;
                                            }
                                            Console.WriteLine("\nWhich item would you like to delete? (Please Enter a String)");
                                            sValue = Console.ReadLine();

                                            int iMyQCount = qMyQueue.Count(); //Local variable only used in the following for loop
                                            for(int iQCount4 = 0; iQCount4 < iMyQCount; iQCount4++) //This loop iterates through MyQueue and deletes the desired item
                                            {
                                                if (qMyQueue.ElementAt(0) == sValue)
                                                {
                                                    qMyQueue.Dequeue();
                                                }
                                                else //Putting the MyQueue items in the HoldQueue
                                                {
                                                    qHoldQueue.Enqueue(qMyQueue.Dequeue());
                                                }
                                            }
                                            if (iMyQCount > qHoldQueue.Count())
                                            {
                                                iMyQCount = qHoldQueue.Count();
                                                for (int iQCount4 = 0; iQCount4 < iMyQCount; iQCount4++) //This loop transfers all the items from the holding queue to the queue we want to use
                                                {
                                                    qMyQueue.Enqueue(qHoldQueue.Dequeue());
                                                }

                                                Console.WriteLine("\nSuccessfully Deleted '" + sValue + "' From Queue!");
                                                break;
                                            }
                                            else
                                            {
                                                iMyQCount = qHoldQueue.Count();
                                                for (int iQCount4 = 0; iQCount4 < iMyQCount; iQCount4++) //This loop transfers all the items from the holding queue to the queue we want to use
                                                {
                                                    qMyQueue.Enqueue(qHoldQueue.Dequeue());
                                                }

                                                Console.WriteLine("\n" + sValue + " not found in Queue");
                                                break;
                                            }

                                        case 5: //Clear Queue
                                            qMyQueue.Clear();
                                            Console.WriteLine("\nSuccessfully Cleared Queue!");
                                            break;

                                        case 6: //Search Queue
                                            if (qMyQueue.Count() == 0)
                                            {
                                                Console.WriteLine("\nCannot Search Because Queue is Empty!");
                                                break;
                                            }
                                            Console.WriteLine("\nWhich item would you like to search for? (please enter a string): ");
                                            sValue = Console.ReadLine();

                                            sw.Start(); //starting the stopwatch
                                            if (qMyQueue.Contains(sValue))
                                            {
                                                sw.Stop();
                                                Console.WriteLine("\n" + sValue + " was found!");
                                            }
                                            else
                                            {
                                                sw.Stop();
                                                Console.WriteLine("\n" + sValue + " was not found!");
                                            }

                                            Console.WriteLine("\nIt took " + sw.Elapsed + " seconds");
                                            break;

                                        case 7: //Return to Main Menu
                                            Console.WriteLine();
                                            break;

                                        default:
                                            iQueueMenu = 0;
                                            Console.WriteLine("\nPlease Enter a Menu Option: \n");
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

                    case 3: //dictionary
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
                                        case 1: //add one item to dictionary
                                            Console.Write("\nPlease Enter a Name for the Key (enter a string): ");
                                            sValue = Console.ReadLine();
                                            Console.Write("\nPlease Enter a Value (enter an int): ");
                                            iKeyValue = Convert.ToInt32(Console.ReadLine());
                                            dMyDictionary.Add(sValue, iKeyValue);
                                            Console.WriteLine("\nSuccessfully added item to dictionary");
                                            break;

                                        case 2: //add 2000 items to queue
                                            dMyDictionary.Clear();
                                            for (int iCount3 = 0; iCount3 < 2000; iCount3++)
                                            {
                                                dMyDictionary.Add("New Entry " + (iCount3 + 1), iCount3 + 1);
                                            }
                                            Console.WriteLine("\nSuccessfully Added Huge List of Items to Queue!");
                                            break;

                                        case 3: //display all items in dictionary
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

                                        case 4: //delete item in dictionary
                                            if(dMyDictionary.Count() == 0)
                                            {
                                                Console.WriteLine("\nCannot Delete Because Dictionary is Empty!");
                                                break;
                                            }
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

                                        case 5: //clear dictionary
                                            dMyDictionary.Clear();
                                            Console.WriteLine("\nDictionary Cleared!");
                                            break;

                                        case 6: //search dictionary

                                            if (dMyDictionary.Count() == 0)
                                            {
                                                Console.WriteLine("\nCannot Search Because Dictionary is Empty!");
                                                break;
                                            }
                                            Console.Write("\nWhich item would you like to search? ");

                                            string sSearch_dictionary = Console.ReadLine();
                                            sw.Start();
                                            if (dMyDictionary.ContainsKey(sSearch_dictionary))
                                            {
                                                sw.Stop();//start stopwatch
                                                Console.WriteLine("\nItem Found!");
                                            }
                                            else
                                            {
                                                sw.Stop();//stop stopwatch
                                                Console.WriteLine("\nItem Not Found!");
                                            }
                                            Console.WriteLine("\nTime elapsed: " + sw.Elapsed);
                                            Console.WriteLine("\n");
                                            break;

                                        case 7://return to the menu
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
