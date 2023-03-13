using System;

namespace SimpleGenericLinkedListPractice
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;
    }

    public class SimpleLinkedListTail<T>
    {
        public Node<T> head;
        public Node<T> tail;

        public void AddFirst(T data)
        {
            Node<T> newItem = new Node<T>
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

        public void AddLast(T data)
        {
            //Just create a new node to add data
            Node<T> newItem = new Node<T>
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

        public void Remove(T data)
        {
            if (head == null)
                return;

            Node<T> current = head, previous = null;
            //Node<T> previous;

            if (current != null && current.data.Equals(data))
            {
                head = current.next;
                return;
            }

            //Search for the key to be deleted using while loop and capture the previous as need to change current.next
            while (current != null && !current.data.Equals(data))
            {
                previous = current;    
                current = current.next;
            }

            //if current is null means data doesnt exist
            if (current == null)
                return;

            //Change the next of previous to next of current while will unlink the current and link next of current
            previous.next = current.next;
        }

        public void ReadAll()
        {
            Node<T> current = head;

            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
            Console.ReadLine();
        }
    }
}
