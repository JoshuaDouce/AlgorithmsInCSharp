using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SinglyLinkedList();

            list.InsertFirst(5);
            list.InsertFirst(9);
            list.InsertFirst(92);
            list.InsertFirst(4);
            list.InsertFirst(6);
            list.InsertLast(9999);

            list.DisplayList();

            list.DeleteFirst();
            list.DisplayList();
        }
    }

    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public void DisplayNode() {
            Console.WriteLine($"< {Data} >");
        }
    }

    class SinglyLinkedList
    {
        private Node First;
        public bool IsEmpty() {
            return First == null;
        }
        public void InsertFirst(int data) {
            var newNode = new Node { Data = data };
            newNode.Next = First;
            First = newNode;

        }

        public Node DeleteFirst() {
            var temp = First;

            First = First.Next;

            return temp;
        }

        public void InsertLast(int data) {
            var current = First;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new Node { Data = data };
        }

        public void DisplayList() {
            Console.WriteLine("List (First -- Last)");
            var current = First;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
            Console.WriteLine(" ");
        }
    }

}
