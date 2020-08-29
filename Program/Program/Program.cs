using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new Queue<int>();
            string answer = "";
            int input = 0;
            var queue = new Queue<int>();

            while (true)
            {
                Console.WriteLine("Would you like to enqueue, dequeue, peek, or exit?");
                answer = Console.ReadLine().ToLower();
                if (answer == "enqueue")
                {
                    Console.WriteLine("What would you like to enqueue?");
                    input = int.Parse(Console.ReadLine());
                    queue.Enqueue(input);
                }
                else if (answer == "dequeue")
                {
                    queue.Dequeue();
                }
                else if (answer == "peek")
                {
                    queue.Peek();
                }
                else if (answer == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Check your spelling.");
                }
            }
        }
    }
}
