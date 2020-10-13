using HackerRank.Solution;
using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Program
    {
       static void Main(string[] args)
        {
            /*
            // Decrypt password
            Console.WriteLine(DecryptPassword.decryptPassword("pTo*Ta*O")); //poTaTO
            Console.WriteLine(DecryptPassword.decryptPassword("1Bl*Kg*u0")); //lBgKu1
            Console.WriteLine(DecryptPassword.decryptPassword("51Pa*0Lp*0e")); //aP1pL5e

            //Hourglass sum
            int[][] arr = new int[6][];
            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            Console.WriteLine(HourglassSum.hourglassSum(arr));
            
            //Array rotate left
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = 5; // Convert.ToInt32(firstMultipleInput[0]);
            int d = 4; // Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr1 = new List<int> { 1, 2, 3, 4, 5 };
            //Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = RotateLeft.rotateLeft(d, arr1);

            Console.WriteLine(String.Join(" ", result));
            

            // Printing Linked List
            var llist = new LinkedListSolution.SinglyLinkedList();
            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }
            Console.WriteLine("Printing Linked List");
            LinkedListSolution.PrintLinkedList(llist.head);
            
            // Insert a node at tail
            var llist2 = new LinkedListSolution.SinglyLinkedList();

            var llistCount2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount2; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                LinkedListSolution.SinglyLinkedListNode llist_head = LinkedListSolution.InsertNodeAtTail(llist2.head, llistItem);
                llist2.head = llist_head;
            }
            LinkedListSolution.PrintLinkedList(llist2.head);

            */
            // Insert a node at tail
            LinkedListSolution.SinglyLinkedList llist = new LinkedListSolution.SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                LinkedListSolution.SinglyLinkedListNode llist_head = LinkedListSolution.InsertNodeAtHead(llist.head, llistItem);
                llist.head = llist_head;
            }

            LinkedListSolution.PrintLinkedList(llist.head);
        }
    }
}
