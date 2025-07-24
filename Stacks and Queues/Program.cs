using System.Net.Security;

namespace Stacks_and_Queues
{
    internal class Program
    {
        public static void optionSelection()
        {
            char option; //option selection

            Console.WriteLine("Enter S to manipulate a stack or Q to manipulate a queue: ");
            option = char.Parse(Console.ReadLine());

            if (option == 'S' || option == 's')
            {
                Stack stack = new Stack();
                stack.initial();
            }
            else if (option == 'Q' ||  option == 'q')
            {
                 Queue queue = new Queue();
                 queue.initial();
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("STACKS AND QUEUES");
            Thread.Sleep(5000);
            Console.Clear();

            optionSelection();
        }
    }
}
