using HackerRank.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Choose the action:
            1.Decrypt password
            2.Hourglass sum
            3.Array rotate left
            4.Compare triplets
            5.Plus minus ratio
            6.sock merchant
            7.Counting valleys
            8.Repeated string
            9.Time conversion
            10.Halloween sales - how many games
            11.stair case
            12.Diagonal Difference
            13.miniMaxSum
            14.Birthday Cake Candles
            15.GradingStudents
            16.AVeryBigSum
            17.BubbleSort
            18.MinimumSwaps
            19.NotesStore");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Decrypt password");
                    Console.WriteLine(DecryptPassword.decryptPassword("pTo*Ta*O")); //poTaTO
                    Console.WriteLine(DecryptPassword.decryptPassword("1Bl*Kg*u0")); //lBgKu1
                    Console.WriteLine(DecryptPassword.decryptPassword("51Pa*0Lp*0e")); //aP1pL5e
                    break;
                case 2:
                    Console.WriteLine("Hourglass sum");
                    int[][] arr = new int[6][];
                    for (int i = 0; i < 6; i++)
                        arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

                    Console.WriteLine(HourglassSum.hourglassSum(arr));
                    break;
                case 3:
                    Console.WriteLine("Array rotate left");
                    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
                    int n = 5; // Convert.ToInt32(firstMultipleInput[0]);
                    int d = 4; // Convert.ToInt32(firstMultipleInput[1]);

                    List<int> arr1 = new List<int> { 1, 2, 3, 4, 5 };
                    //Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                    List<int> result = RotateLeft.rotateLeft(d, arr1);

                    Console.WriteLine(String.Join(" ", result));
                    break;
                case 4:
                    Console.WriteLine("Compare triplets");
                    List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
                    List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
                    List<int> newList = CompareTriplet.CompareTriplets(a, b);
                    Console.WriteLine(String.Join(" ", newList));
                    break;
                case 5:
                    Console.WriteLine("Plus minus ratio");
                    n = Convert.ToInt32(Console.ReadLine());
                    int[] plusMinusArr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                    PlusMinusRatio.plusMinus(plusMinusArr);
                    break;
                case 6:
                    Console.WriteLine("Sock merchant");
                    n = Convert.ToInt32(Console.ReadLine());
                    int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
                    Console.WriteLine(SockMerchant.sockMerchant(n, ar));
                    break;
                case 7:
                    Console.WriteLine("Counting valleys");
                    Console.WriteLine("Enter number of steps");
                    int steps = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter path");
                    string path = Console.ReadLine(); ;
                    Console.WriteLine(CountingValleys.countingValleys(steps, path));
                    break;
                case 8:
                    Console.WriteLine("Repeated string");
                    Console.WriteLine("Enter the text");
                    string s = Console.ReadLine();

                    Console.WriteLine("Enter number of occurences to find");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(RepeatedString.repeatedString(s, n));
                    break;
                case 9:
                    Console.WriteLine("Time conversion");
                    s = Console.ReadLine();
                    Console.WriteLine(TimeConversion.timeConversion(s));
                    break;
                case 10:
                    Console.WriteLine("Halloween sales - how many games");
                    string[] pdms = Console.ReadLine().Split(' ');
                    int p1 = Convert.ToInt32(pdms[0]);
                    int d1 = Convert.ToInt32(pdms[1]);
                    int m1 = Convert.ToInt32(pdms[2]);
                    int s1 = Convert.ToInt32(pdms[3]);

                    int answer = HalloweenSale.howManyGames(p1, d1, m1, s1);
                    Console.WriteLine(answer);
                    //answer = HalloweenSale.howManyGames(20, 3, 6, 85);
                    //Console.WriteLine(answer);

                    //answer = HalloweenSale.howManyGames(20, 3, 6, 80);
                    //Console.WriteLine(answer);
                    break;
                case 11:
                    Console.WriteLine("stair case");
                    n = Convert.ToInt32(Console.ReadLine());
                    Staircase.staircase(n);
                    break;
                case 12:
                    Console.WriteLine("Diagonal Difference");
                    n = Convert.ToInt32(Console.ReadLine().Trim());
                    List<List<int>> lstDiagonalDifference = new List<List<int>>();
                    for (int i = 0; i < n; i++)
                        lstDiagonalDifference.Add(Array.ConvertAll(Console.ReadLine().TrimEnd().Split(' '), arTemp => Convert.ToInt32(arTemp)).ToList());                    
                    int resultVal = DiagonalDifference.diagonalDifference(lstDiagonalDifference);
                    Console.WriteLine(resultVal);
                    break;
                case 13:
                    Console.WriteLine("miniMaxSum");
                    int[] arrMiniMaxSum = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                    MiniMaxSum.miniMaxSum(arrMiniMaxSum);
                    break;
                case 14:
                    Console.WriteLine("Birthday Cake Candles");
                    Console.WriteLine("Enter the # of candles");
                    int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());
                    Console.WriteLine("Enter the candles");
                    List<int> candlesList = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
                    resultVal = BirthdayCakeCandles.birthdayCakeCandles(candlesList);

                    Console.WriteLine("Total number of tallest candles");
                    Console.WriteLine(resultVal);
                    break;
                case 15:
                    Console.WriteLine("Grading Students");
                    int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());
                    List<int> grades = new List<int>();
                    for (int i = 0; i < gradesCount; i++)
                    {
                        int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                        grades.Add(gradesItem);
                    }

                    List<int> result1 = GradingStudents.gradingStudents(grades);
                    Console.WriteLine("Final grades:");
                    result1.ForEach(i => Console.WriteLine(i));
                    break;
                case 16:
                    Console.WriteLine("AVeryBigSum");
                    int arCount = Convert.ToInt32(Console.ReadLine());
                    long[] arrAVeryBigSum = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));                    
                    Console.WriteLine(VeryBigSum.AVeryBigSum(arrAVeryBigSum));
                    break;
                case 17:
                    Console.WriteLine("Bubble Sort");
                    Console.WriteLine("Enter number of elements");
                    Convert.ToInt32(Console.ReadLine());

                    int[] arrBubbleSort = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
                    BubbleSorting.CountSwaps(arrBubbleSort);
                    break;
                case 18:
                    Console.WriteLine("Minimum Swaps");
                    Console.WriteLine("Enter number of elements");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the elements");
                    int[] numArr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                    int res = MinimumSwaps.minimumSwaps(numArr);
                    Console.WriteLine(res);
                    break;
                case 19:
                    var notesStoreObj = new NotesStore();
                    n = int.Parse(Console.ReadLine());
                    for (var i = 0; i < n; i++)
                    {
                        var operationInfo = Console.ReadLine().Split(' ');
                        try
                        {
                            if (operationInfo[0] == "AddNote")
                                notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                            else if (operationInfo[0] == "GetNotes")
                            {
                                var reslt = notesStoreObj.GetNotes(operationInfo[1]);
                                if (reslt.Count == 0)
                                    Console.WriteLine("No Notes");
                                else
                                    Console.WriteLine(string.Join(",", reslt));
                            }
                            else
                            {
                                Console.WriteLine("Invalid Parameter");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }
                    }
                    break;
            }
        }
    }
}