using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new Queue(5);

            q.Insert(1);
            q.Insert(2);
            q.Insert(3);


            Console.WriteLine($"Peeking Front: {q.Peek()}");

            q.Insert(4);
            q.Insert(5);
            q.Insert(6);

            q.View();

            q.Remove();
            q.Remove();

            q.Insert(7);

            Console.WriteLine($"Peeking Front: {q.Peek()}");

            q.View();
        }
    }

    class Queue {
        private int MaxSize;
        private long[] MyQueue;
        private int Front;
        private int Rear;
        private int Items;

        public Queue(int size)
        {
            MaxSize = size;
            MyQueue = new long[MaxSize];
            Front = 0;
            Rear = -1;
            Items = 0;
        }

        public void Insert(long j)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
            }
            else {
                if (Rear == MaxSize - 1)
                {
                    Rear = -1;
                }
                Rear++;
                MyQueue[Rear] = j;
                Items++;
            }
        }

        public long Remove() {
            var temp = MyQueue[Front];
            Front++;
            Items--;
            if (Front == MaxSize)
            {
                Front = 0;
            }
            return temp;   
        }

        public long Peek() {
            return MyQueue[Front];
        }

        public bool IsEmpty() {
            return Items == 0;
        }

        public bool IsFull()
        {
            return Items == MaxSize;
        }

        public void View() {
            Console.Write("[");

            for (int i = 0; i < MyQueue.Length; i++)
            {
                Console.Write($"{MyQueue[i]}, ");
            }

            Console.Write("]");
            Console.WriteLine("");
        }
    }
}
