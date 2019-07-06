using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack(4);

            stack.Push("Star Wars");
            stack.Push("Jaws");
            stack.Push("LOTR");
            stack.Push("The Hobbit");
            stack.Push("Titanic");

            Console.WriteLine("Peek");
            Console.WriteLine(stack.Peek());

            Console.WriteLine("The Stack Contains");
            while (!stack.IsEmpty())
            {
                var m = stack.Pop();
                Console.WriteLine(m);
            }
        }
    }

    class Stack
    {
        private int MaxSize;
        private string[] StackArray;
        private int Top;

        public Stack(int size)
        {
            MaxSize = size;
            StackArray = new string[MaxSize];
            Top = -1;
        }

        public void Push(string m) {
            if (IsFull())
            {
                Console.WriteLine("Stack is Full");
            }
            else {
                Top++;
                StackArray[Top] = m;
            }
        }

        public string Pop() {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return "";
            }
            else {
                var item = StackArray[Top];
                Top--;
                return item;
            }
        }

        public bool IsEmpty()
        {
            return Top == -1;
        }

        public bool IsFull()
        {
            return (MaxSize - 1 == Top);
        }

        public string Peek() {
            return StackArray[Top];
        }
    }
}
