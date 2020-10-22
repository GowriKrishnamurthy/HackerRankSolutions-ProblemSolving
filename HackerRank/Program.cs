using HackerRank.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using static HackerRank.LinkedList;

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
            */


            /* *** *** *** LINKED LIST  *** *** *** */
            /*
            // Printing Linked List
            var llist = new SinglyLinkedList();
            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }
            Console.WriteLine("Printing Linked List");
            PrintLinkedList(llist.head);
            
            // Insert a node at tail //
            var llist2 = new SinglyLinkedList();

            var llistCount2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount2; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = InsertNodeAtTail(llist2.head, llistItem);
                llist2.head = llist_head;
            }
            PrintLinkedList(llist2.head);

            //  Insert a node at tail //
            SinglyLinkedList llist3 = new SinglyLinkedList();

            var llistCount3 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount3; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = InsertNodeAtHead(llist3.head, llistItem);
                llist3.head = llist_head;
            }

            PrintLinkedList(llist3.head);

            // Insert a node at a specific position //
            SinglyLinkedList llist4 = new SinglyLinkedList();

            Console.WriteLine("How many elements ?");
            var llistCount4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements");
            for (int i = 0; i < llistCount4; i++)
            {
                int llistItem4 = Convert.ToInt32(Console.ReadLine());
                llist4.InsertNode(llistItem4);                
            }

            Console.WriteLine("Enter new data");
            int data = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter position to add this data at");
            int position = Convert.ToInt32(Console.ReadLine());

            SinglyLinkedListNode llist_newHead = InsertNodeAtPosition(llist4.head, data, position);

            PrintLinkedList(llist_newHead);
            */

            // Delete a node at a specific position //
            /*
            SinglyLinkedList llist = new SinglyLinkedList();

            Console.WriteLine("How many elements ?");
            int llistCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements");
            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            Console.WriteLine("Enter position to delete data from.");
            int position = Convert.ToInt32(Console.ReadLine());

            SinglyLinkedListNode llist1 = DeleteNode(llist.head, position);
            PrintLinkedList(llist1);

            
            // Print linked list in reverse //
            SinglyLinkedList llist = new SinglyLinkedList();

            Console.WriteLine("How many elements ?");
            int llistCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements");
            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }
            Console.WriteLine("Linked list printed in Reverse");
            ReversePrint(llist.head);

            
            // Print linked list in reverse - Option 1//
            SinglyLinkedList llist = new SinglyLinkedList();

            Console.WriteLine("How many elements ?");
            int llistCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements");
            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }
            
            Console.WriteLine("Reversed linked list . Option1..");
            PrintLinkedList(ReverseOption1(llist.head));

            // Print linked list in reverse - Option 2 //
            llist = new SinglyLinkedList();

            Console.WriteLine("How many elements ?");
            llistCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements");
            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            Console.WriteLine("Reversed linked list . Option2..");
            PrintLinkedList(ReverseOption2(llist.head));

            */

            /* *** *** *** LINKED LIST  *** *** *** */
            /*
            // Compare triplets
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
            List<int> result = CompareTriplet.CompareTriplets(a, b);
            Console.WriteLine(String.Join(" ", result));
            
            int arCount = Convert.ToInt32(Console.ReadLine());
            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = VeryBigSum.AVeryBigSum(ar);

            Console.WriteLine(result);
            
            // Plus minus ratio
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            PlusMinusRatio.plusMinus(arr);

            //sock merchant
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            
            Console.WriteLine(SockMerchant.sockMerchant(n, ar));
            
            // Counting valleys
            Console.WriteLine("Enter number of steps");
            int steps = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter path");
            string path = Console.ReadLine(); ;

            Console.WriteLine(CountingValleys.countingValleys(steps, path));
            
            //Repeated string
            Console.WriteLine("Enter the text");
            string s = Console.ReadLine();

            Console.WriteLine("Enter number of occurences to find");
            long n = Convert.ToInt64(Console.ReadLine());
            
            Console.WriteLine(RepeatedString.repeatedString(s, n));
            
            // Time conversion
            string s = Console.ReadLine();
            Console.WriteLine(TimeConversion.timeConversion(s));
            
            // Halloween sales - how many games
            string[] pdms = Console.ReadLine().Split(' ');
            int p = Convert.ToInt32(pdms[0]);
            int d = Convert.ToInt32(pdms[1]);
            int m = Convert.ToInt32(pdms[2]);
            int s = Convert.ToInt32(pdms[3]);
            
            int answer = HalloweenSale.howManyGames(p, d, m, s);
            
            answer = HalloweenSale.howManyGames(20,3,6, 85);                       
            Console.WriteLine(answer);

            answer = HalloweenSale.howManyGames(20, 3, 6, 80);
            Console.WriteLine(answer);
         
            //stair case
            int n = Convert.ToInt32(Console.ReadLine());
            Staircase.staircase(n);
            
            //Diagonal Difference
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DiagonalDifference.diagonalDifference(arr);
            Console.WriteLine(result);
            */

            // miniMaxSum
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            MiniMaxSum.miniMaxSum(arr);
        }
    }
}