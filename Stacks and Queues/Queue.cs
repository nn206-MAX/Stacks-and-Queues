using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
    internal class Queue
    {
        public void initial()
        {
            Console.Clear();
            int[] queue = { 0, 0, 0, 0, 0, 0 };
            int pointer1 = -1; //1st pointer
            int pointer2 = -1; //2nd pointer

            Console.WriteLine("Queue editor \n \n");
            Thread.Sleep(1500);

            optionMenu(ref queue, ref pointer1, ref pointer2);
        }

        public void optionMenu(ref int[] queue, ref int pointer1, ref int pointer2)
        {
            int option;

            Console.WriteLine("Select an option: \n \n 1. PUSH (insert item) \n 2. POP (remove item) \n 3. VIEW queue \n \n ");
            option = int.Parse(Console.ReadLine()); /* option selection system - if 1 is typed, push function called,
                                                     * but if 2 is typed, pop function called 
                                                     
                                                     3 lets you view the queue */

            if (option == 1)
            {
                push(ref queue, ref pointer1, ref pointer2);
            }
            else if (option == 2)
            {
                pop(ref queue, ref pointer1, ref pointer2);
            }
            else if (option == 3)
            {
                for (int i = 0; i < queue.Length; i++)
                {
                    Console.Write(queue[i] + " ");
                }
                Thread.Sleep(5000); //5 second delay so that you can see the numbers

                Console.Clear();
                initial();
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }

        public void push(ref int[] queue, ref int pointer1, ref int pointer2)
        {
            int input; //user input

            Console.WriteLine("Enter value: ");
            input = int.Parse(Console.ReadLine()); //adds value to queue

            int end = queue.Length; //refers to queue length - the last element is (queue.Length - 1)

            if (queue[end - 1] != 0)
            {
                Console.WriteLine("OVERFLOW ERROR - queue FULL"); //the queue is full
            }

            else
            {
                pointer2++; //pointer2 incremented by 1
                queue[pointer2] = input; //entered value (input) passed into 

                Console.WriteLine("Current queue: ");

                for (int i = 0; i < end; i++)
                {
                    Console.Write(queue[i] + " "); //displays current queue
                }

                Console.WriteLine("\n \n Any more changes? Y/N \n");

                string furtherOption = Console.ReadLine();
                if (furtherOption == "y" || furtherOption == "Y")
                {
                    optionMenu(ref queue, ref pointer1, ref pointer2);
                }

                else if (furtherOption == "n" || furtherOption == "N")
                {
                    Console.Clear();
                    Thread.Sleep(1000);
                    Environment.Exit(0); //terminates the program
                }
            }
        }

        public void pop(ref int[] queue, ref int pointer1, ref int pointer2)
        {
            string option;

            Console.WriteLine("Delete item at back of queue? Y/N ");
            option = Console.ReadLine();

            if (option == "y" || option == "Y")
            {
                if (queue[0] == 0)
                {
                    Console.WriteLine("UNDERFLOW ERROR - queue EMPTY");
                }
                else
                {
                    pointer1++; //increments pointer
                    int tempValueHolder = queue[pointer1]; //temporary value holder
                    queue[pointer1] = 0; //value within queue reset to 0

                    Console.WriteLine("Current queue: ");

                    for (int i = 0; i < queue.Length; i++)
                    {
                        Console.Write(queue[i] + " "); //prints current queue
                    }

                    Console.WriteLine("\n \n Any more changes? Y/N \n"); //displays current queue

                    string furtherOption = Console.ReadLine();
                    if (furtherOption == "y" || furtherOption == "Y")
                    {
                        optionMenu(ref queue, ref pointer1, ref pointer2);
                    }

                    else if (furtherOption == "n" || furtherOption == "N")
                    {
                        Console.Clear();
                        Thread.Sleep(1000);
                        Environment.Exit(0); //terminates the program
                    }
                }
            }
            else if (option == "n" || option == "N")
            {
                Console.Clear(); //clears screen
                initial(); //restarts the program
            }

            else
            {
                Console.WriteLine("Invalid option.");
                pop(ref queue, ref pointer1, ref pointer2); //function recalled
            }

        }
    }
}
