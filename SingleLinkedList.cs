using System;
namespace sllNode
{
    public class singleLinkedList
    {
        public Node head;
        public singleLinkedList()
        {
            this.head = null;
        }
        public void add(int value)
        {
            Node newNode = new Node(value);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node itr = this.head;
                while (itr.next != null)
                {
                    itr = itr.next;
                }
                itr.next = newNode;


            }


        }

        public void pop()
        {
            Node itr = this.head;

            while (itr.next.next != null)
            {
                itr = itr.next;
            }
            itr.next = null;
        }

        public void printValues()
        {
            Node itr = this.head;
            while (itr!= null)
            {
                Console.WriteLine("Node value: "+itr.value);
                itr = itr.next;
            }
        }
    }

}