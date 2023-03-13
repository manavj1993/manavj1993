using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedListPractice
{
    public class Node
    {
        public int data;
        public Node nextNode;
        public Node prevNode;
    }

    public class DoubleLinkedList
    {
        static DateTime time;
        private Node head, tail;

        public void Add(int data)
        {
            if (time == null)
                Console.Write("");

            Node newItem = new Node()
            {
                data = data
            };

            if (head == null)
            {
                head = newItem;
                tail = head; //Since its first element, tail and head are same
            }
            else
            {
                tail.nextNode = newItem;
                newItem.prevNode = tail;
                tail = newItem;
            }
        }

        public void GetAll()
        {
            Node current = head;

            while (current.nextNode != null)
            {
                Console.WriteLine(current.data);
                current = current.nextNode;
            }
            Console.WriteLine(current.data);
        }

        public void Remove(int data)
        {
            if (head == null)
                return;

            Node current = head, previous = null;

            if (current != null && current.data.Equals(data))
            {
                head = current.nextNode;
                head.prevNode = null;
                return;
            }

            //Search for the key to be deleted using while loop and capture the previous as need to change current.next
            while (current != null && !current.data.Equals(data))
            {
                previous = current;
                current = current.nextNode;
            }

            //if current is null means data doesnt exist
            if (current == null)
                return;

            previous.nextNode = current.nextNode;
            previous.prevNode = current.prevNode;
        }
    }
}