using System;

namespace LinkedListPractice
{
    public class Node
    {
        public object data;
        public Node next;
    }

    public class SimpleLinkedList
    {
        public Node head;

        public void AddFirst(object data)
        {
            Node first = new Node
            {
                data = data,
                next = head
            };

            //Assign the first as the head as it should be the first node
            head = first;
        }

        public void AddLast(object data)
        {
            //Just create a new node to add data
            Node newItem = new Node
            {
                data = data,
                next = null
            };

            //Check if the head(firt node) is null or not
            if (head == null)
            {
                head = newItem;        
            }
            //If not then add to the last node 
            else
            {
                Node current = head;
                //Loop to find the last node
                while (current.next != null)
                {
                    current = current.next;
                }
                //Null means its last element
                current.next = newItem;
            }
        }

        public void ReadAll()
        {
            Node current = head;

            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
            Console.Read();
        }
    }
}