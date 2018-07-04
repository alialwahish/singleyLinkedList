using System;

namespace sllNode
{
    class Program
    {
        static void Main(string[] args)
        {
        singleLinkedList sll= new singleLinkedList();
        sll.add(5);
        sll.add(10);
        sll.add(66);
        sll.printValues();
        sll.pop();
        sll.printValues();
        }
    }
}
