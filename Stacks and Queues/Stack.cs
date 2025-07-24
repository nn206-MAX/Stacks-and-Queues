using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
    internal class Stack
    {
        public void initial()
        {
            Console.Clear();
            int[] stack = { 0, 0, 0, 0, 0 };
            int pointer = -1; //pointer

            Console.WriteLine("Stack editor \n \n");
            Thread.Sleep(1500);

            optionMenu(ref stack, ref pointer);
        }

        public void optionMenu(ref int[] stack, ref int pointer)
        {
            int option;

            Console.WriteLine("Select an option: \n \n 1. PUSH (insert item) \n 2. POP (remove item) \n 3. VIEW STACK \n \n ");
            option = int.Parse(Console.ReadLine()); /* option selection system - if 1 is typed, push function called,
                                                     * but if 2 is typed, pop function called */

            if (option == 1)
            {
                push(ref stack, ref pointer);
            }
            else if (option == 2)
            {
                pop(ref stack, ref pointer);
            }
            else if (option == 3)
            {
                for (int i = 0; i < stack.Length; i++)
                {
                    Console.Write(stack[i] + " ");
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

        public void push(ref int[] stack, ref int pointer)
        {
            int input; //user input

            Console.WriteLine("Enter value: ");
            input = int.Parse(Console.ReadLine()); //adds value to stack

            int end = stack.Length; //refers to stack length - the last element is (stack.Length - 1)

            if (stack[end - 1] != 0)
            {
                Console.WriteLine("OVERFLOW ERROR - STACK FULL"); //the stack is full
            }

            else
            {
                pointer++; //pointer incremented by 1
                stack[pointer] = input; //entered value (input) passed into 

                Console.WriteLine("Current stack: ");

                for (int i = 0; i < end; i++)
                {
                    Console.Write(stack[i] + " ");
                }

                Console.WriteLine("\n \n Any more changes? Y/N \n"); //displays current stack
                string furtherOption = Console.ReadLine();
                if (furtherOption == "y" || furtherOption == "Y")
                {
                    optionMenu(ref stack, ref pointer);
                }

                else if (furtherOption == "n" || furtherOption == "N")
                {
                    Console.Clear();
                    Thread.Sleep(1000);
                    Environment.Exit(0); //terminates the program
                }
            }
        }

        public void pop(ref int[] stack, ref int pointer)
        {
            string option;

            Console.WriteLine("Delete last added item? Y/N ");
            option = Console.ReadLine();

            if (option == "y" || option == "Y")
            {
                if (stack[0] == 0)
                {
                    Console.WriteLine("UNDERFLOW ERROR - STACK EMPTY");
                }
                else
                {
                    int tempValueHolder = stack[pointer]; //temporary value holder
                    stack[pointer] = 0; //value within stack reset to 0
                    pointer--; //decrements pointer value

                    Console.WriteLine("Current stack: ");

                    for (int i = 0; i < stack.Length; i++)
                    {
                        Console.Write(stack[i] + " ");
                    }

                    Console.WriteLine("\n \n Any more changes? Y/N \n"); //displays current stack

                    string furtherOption = Console.ReadLine();
                    if (furtherOption == "y" || furtherOption == "Y")
                    {
                        optionMenu(ref stack, ref pointer);
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
                pop(ref stack, ref pointer); //function recalled
            }

        }
    }
}
