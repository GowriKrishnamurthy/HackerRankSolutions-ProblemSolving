using System;
using System.ComponentModel;

namespace HackerRank
{
    public class LinkedList
    {
        public class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                data = nodeData;
                next = null;
            }
        }

        public class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                head = null;
                tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (head == null)
                    head = node;
                else
                    tail.next = node;

                tail = node;
            }
        }

        public static void PrintLinkedList(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode node = head;
            while (node != null) {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }
        public static SinglyLinkedListNode InsertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

            if (head == null)
                head = newNode;
            else
            {
                var currentNode = head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                //reached the tail
                currentNode.next = newNode;
            }
            return head;
        }
        public static SinglyLinkedListNode InsertNodeAtHead(SinglyLinkedListNode llist, int data)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

            if (llist != null)
                newNode.next = llist;
            return newNode;
        }
        public static SinglyLinkedListNode InsertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
            if (head == null)
            {
                // create a new node                
                newNode.next = null;
                head = newNode;
                return head;
            }
            else
            {
                if (position == 0)
                {
                    newNode.next = head;
                    head = newNode;
                    return head;
                }

                SinglyLinkedListNode currentNode = head;
                for (int i = 0; i < position - 1; i++)
                {
                    if (currentNode.next != null)
                        currentNode = currentNode.next;
                    else
                        break;
                }
                newNode.next = currentNode.next;
                currentNode.next = newNode;
            }

            return head;
        }

        public static SinglyLinkedListNode DeleteNode(SinglyLinkedListNode head, int position)
        {
            if (head != null)
            {
                if (position == 0)
                {
                    head = head.next;
                    return head;
                }

                SinglyLinkedListNode currentNode = head;
                for (int i = 0; i < position - 1; i++)
                {
                    if (currentNode.next != null)
                        currentNode = currentNode.next;
                    else
                        break;
                }

                currentNode.next = currentNode.next.next;
            }

            return head;
        }
        public static void ReversePrint(SinglyLinkedListNode head)
        {
            if (head!=null)
            {
                ReversePrint(head.next);
                Console.WriteLine(head.data);
            }
        }
    }
}