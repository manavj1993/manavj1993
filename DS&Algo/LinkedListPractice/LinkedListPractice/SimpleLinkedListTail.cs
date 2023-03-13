using System;

namespace LinkedListPractice
{
    public class SimpleLinkedListTail
    {
        public Node head;
        public Node tail;

        public void AddFirst(object data)
        {
            Node newItem = new Node
            {
                data = data
            };

            //Assign the first as the head as it should be the first node
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                //No need to change the tail as we are setting first node
                newItem.next = head;
                head = newItem;
            }
        }

        public void AddLast(object data)
        {
            //Just create a new node to add data
            Node newItem = new Node
            {
                data = data
            };

            //Check if the head(firt node) is null or not
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            //If not then add to the last node 
            else
            {
                tail.next = newItem;
                tail = newItem;
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
