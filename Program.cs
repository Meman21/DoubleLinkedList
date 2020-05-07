using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinked myList = new DoublyLinked();
            myList.Add(5);
            myList.Add(24);
            myList.Add(100);
            myList.Add(53);
            Console.WriteLine(myList.Remove(53));
            myList.PrintValues();
        }
    }
}
