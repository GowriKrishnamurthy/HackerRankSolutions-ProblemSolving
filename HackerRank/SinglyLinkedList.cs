using System;
using System.ComponentModel;

namespace HackerRank.Solution
{
    public class LinkedListSolution
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

    }
}