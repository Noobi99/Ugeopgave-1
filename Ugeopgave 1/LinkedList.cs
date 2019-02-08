using System;

namespace Ugeopgave_1
{
    public class LinkedList
    {
        private Node Head;

        public LinkedList(Node node)
        {
            Head = node;
        }

        public void Add(int value)
        {
            Node current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            // Når den er null, så laves der en ny
            current.Next = new Node() { Data = value };
        }

        public int Get(int index)
        {
            // Sætter returnNode lig Head node
            Node returnNode = Head;
            int iterator = 0;

            while (returnNode.Next != null && index > iterator)
            {
                returnNode = returnNode.Next;
                iterator++;
            }

            return returnNode.Data;
        }

        public void Remove(int index)
        {
            // Sætter start node
            Node deleteNode = Head;
            int iterator = 0;

            while (deleteNode.Next != null && index - 1 > iterator) // -1 så vi får den tidligere og pointer den 2 frem i stedet for
            {
                deleteNode = deleteNode.Next;
                iterator++;
            }

            Node newNode = Head;
            iterator = 0;

            while (newNode.Next != null && index + 1 > iterator)
            {
                newNode = newNode.Next;
                iterator++;
            }

            // Fjerner referencen fra denne node og peger den 1 længere frem
            deleteNode.Next = newNode;


        }

        // Get count from beginning
        public int GetCount()
        {
            Node startNode = Head;

            int length = 0;

            while (startNode.Next != null)
            {
                startNode = startNode.Next;
                length += 1;
            }

            return length;
        }

        // InsertAt(int index, int value)
        public void InsertAt(int index, int value)
        {
            Node insertNode = Head;
            int iterator = 0;

            while (insertNode.Next != null && index > iterator)
            {
                insertNode = insertNode.Next;
                iterator++;
            }

            insertNode.Data = value;
        }


        // bool IsEmpty()
        public bool IsEmpty()
        {
            if (Head == null)
            {
                return true;
            }
            return false;
        }
    }
}