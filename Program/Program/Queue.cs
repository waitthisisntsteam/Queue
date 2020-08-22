using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Queue <T>
    {
        const int defaultSize = 4;
        public T[] values = new T[defaultSize];
        int index = 0;
        public int Count => index;

        public void Resize()
        {
            T[] temp = new T[values.Length*2];          
            for (int i = 0; i < index; i++)
            {
                temp[i] = values[i];
            }
            values = temp;
        }

        public void Enqueue(T value)
        {
            if (index == values.Length)
            {
                Resize();
            }
            values[index] = value;
            index++;
        }

        public void Dequeue()
        {
            index--;
        }

        public void Peek()
        {
            Console.WriteLine(values[index]);
        }
    }
}
