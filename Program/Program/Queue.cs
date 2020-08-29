using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Queue <T>
    {
        const int defaultSize = 4;
        public T[] values = new T[defaultSize];
        int head = 0;
        int tail = 0;
        public int Count = 0;

        public void Resize()
        {
            T[] temp = new T[values.Length*2];
            for (int i = 0; i < Count; i++)
            {
                temp[i] = values[i];
                tail = i;
            }
            values = temp;
        }

        public void Enqueue(T value)
        {
            if (Count == 0)
            {
                values[head] = value;
                tail = head;
            }
            else if (tail == values.Length)
            {
                Resize();
            }
            values[tail] = value;
            tail++;
            Count++;
        }

        public void Dequeue()
        {
            if (Count == 0)
            
                {Console.WriteLine("Queue is empty.");                
                head = 0;
                tail = 0;
                Count = 0;
                return;
            }
            else
            {
                Count--;
                head++;
            }
        }

        public void Peek()
        {
            if (Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
            Console.WriteLine(values[head]);
        }
    }
}
