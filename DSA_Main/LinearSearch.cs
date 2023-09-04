using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Main
{
    public class LinearSearch_Main
    {
        public static void LinearSearch_MainMethod()
        {
            int[] arr = { 23, 45, 1, 2, 8, 19, -13, 16, -11, 28 };
            int target = 16;

            string inputString = "Linear";
            char sTarget = 'e';

            Console.WriteLine("*********************************************************");
            Console.WriteLine($"Array: {string.Join(",", arr)}");
            Console.WriteLine($"target: {target}");
            Console.WriteLine("*********************************************************");

            //LinearSearch FindIndex of Item
            int index = LinearSearch.linearSearch_findIndex(arr, target);
            Console.WriteLine($"linearSearch_findIndex : {index}");
            Console.WriteLine();

            //LinearSearch Find target item and Return item
            int element = LinearSearch.linearSearch_findElement(arr, target);
            Console.WriteLine($"linearSearch_Find_target_item : {element}");
            Console.WriteLine();

            //LinearSearch Find target item and Return true or false
            bool result = LinearSearch.findElement_returnTrueorFalse(arr, target);
            Console.WriteLine($"Find_element_return_TrueorFalse : {result}");
            Console.WriteLine();

            //LinearSearch Find max and min number in array and return the value.
            int minValue = LinearSearch.linearSearch_FindMinNumber(arr);
            Console.WriteLine($"Find the Min number in Array: {minValue}");

            Console.WriteLine("*********************************************************");
            Console.WriteLine($"Input String: {inputString}");
            Console.WriteLine($"Target Char: {sTarget} ");
            Console.WriteLine("*********************************************************");

            //LinearSearch String Find target item and Return true or false
            bool sResult = LinearSearch.string_findElement_returnTrueorFalse(inputString, sTarget);
            Console.WriteLine($"Find_char_In_String_return_TrueorFalse : {sResult}");
            Console.WriteLine();

            Console.WriteLine("*********************************************************");
            //Search a target in 2d Array and find the index
            int[] result2d = LinearSearch.Search2dArray();
            Console.WriteLine($"Find the target in 2d array and print the index: {string.Join(",", result2d)}");
            Console.WriteLine();

            //Search a target in 2d Array and find the max value
            int result2d_maxValue = LinearSearch.Search2dArray_MaxValue();
            Console.WriteLine($"Find the max value in 2d array and print the value: {result2d_maxValue}");
            Console.WriteLine("*********************************************************");

            //Find Number of Even Num Digits in an Array 
            //21 - Even num digit
            //332 - odd number digit
            int evenNumberDigits = LinearSearch.Find_Numberof_EvenNumDigits_Array();
            Console.WriteLine($"Find Number of Even Num Digits in an Array: {evenNumberDigits}");
            Console.WriteLine();

            //Find the biggest row in 2d array. 
            //We need to sum the values of each row and find the biggest row in the given array and return the sum.
            int[,] arr_2d = new int[4, 2]{
                            {2, 4},
                            {19, 212},
                            {78, 99},
                            {18, 14 }
                         };

            int[,] arr_2d_2 = new int[2, 3]{
                            {2, 4,9},
                            {19, 21, 8}
                         };
            int biggestSum = LinearSearch.Find_biggestRow_returnSum(arr_2d_2);
            Console.WriteLine($"Find the biggest row in 2d array and print the sum: {biggestSum}");
        }
    }

    public class LinearSearch
    {
        //Search in the array- return the index if the item found
        // return -1 if the item not found 
        public static int linearSearch_findIndex(int[] arr, int target)
        {
            if (arr.Length == 0) return -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target) return i;
            }
            return -1;
        }

        public static int linearSearch_findElement(int[] arr, int target)
        {
            if (arr.Length == 0) return -1;

            foreach (int item in arr)
            {
                if (item == target) return item;
            }
            return int.MaxValue;
        }

        public static bool findElement_returnTrueorFalse(int[] arr, int target)
        {
            if (arr.Length == 0) return false;

            foreach (int item in arr)
            {
                if (item == target) return true;
            }
            return false;
        }

        public static bool string_findElement_returnTrueorFalse(string input, char target)
        {
            if (input.Length == 0) return false;

            //Process 1 
            //Other way of converting string to char arr
            //char[] cArr = new char[input.Length];
            //for(int i =0; i<input.Length;i++) {
            //    cArr[i] = input[i];
            //}

            //Process 2
            //foreach (int item in input.ToCharArray()) {
            //    if (item == target) return true;
            //}

            //Process 3
            //for(int i =0; i< input.Length; i++) {
            //    if (target == input.ElementAt(i)) { return true; }
            //}

            //Process 4
            for (int i = 0; i < input.Length; i++)
            {
                if (target == input[i]) { return true; }
            }
            return false;
        }

        public static int linearSearch_FindMinNumber(int[] arr)
        {
            if (arr.Length == 0) return int.MinValue;

            //Linq Process
            //ans = arr.Min();

            int ans = arr[0];
            //Without Linq
            foreach (int item in arr)
            {
                if (item < ans)
                    ans = item;
            }
            return ans;
        }

        public static int[] Search2dArray()
        {
            int target = 99;
            int[,] arr_2d = new int[4, 2]{
                            {2, 4},
                            {19, 12},
                            {78, 99},
                            {18, 14 }
                         };

            for (int row = 0; row < arr_2d.GetLength(0); row++)
            {
                for (int col = 0; col < arr_2d.GetLength(1); col++)
                {
                    if (arr_2d[row, col] == target)
                    {
                        return new int[] { row, col };
                    }
                }
            }
            return new int[] { -1, -1 };
        }

        public static int Search2dArray_MaxValue()
        {
            int[,] arr_2d = new int[4, 2]{
                            {2, 4},
                            {19, 212},
                            {78, 99},
                            {18, 14 }
                         };
            int MaxValue = int.MinValue;

            for (int row = 0; row < arr_2d.GetLength(0); row++)
            {
                for (int col = 0; col < arr_2d.GetLength(1); col++)
                {
                    if (arr_2d[row, col] > MaxValue)
                    {
                        MaxValue = arr_2d[row, col];
                    }
                }
            }
            return MaxValue;
        }

        public static int Find_Numberof_EvenNumDigits_Array()
        {
            int[] numArray = { 12, 0, 345, 2, 6, 7896, -45 };
            int evenCounter = 0;

            foreach (int num in numArray)
            {
                int digitCount = digitCounter(num);

                if (digitCount % 2 == 0)
                {
                    evenCounter++;
                }
            }
            return evenCounter;
        }

        //Other approach 
        static int digitCounter(int input)
        {
            int counter = 0;

            if (input == 0)
                return 1;

            if (input < 0)
                input = input * -1;

            //Approach 2 - Faster than while loop
            //counter = (int)Math.Log10(input) + 1;

            while (input > 0)
            {
                counter++;
                input = input / 10;
            }
            return counter;
        }

        public static int Find_biggestRow_returnSum(int[,] arr2d)
        {
            int biggest = int.MinValue;

            for (int row = 0; row < arr2d.GetLength(0); row++)
            {
                int sum = 0;

                for (int col = 0; col < arr2d.GetLength(1); col++)
                {
                    sum += arr2d[row, col];
                }

                if (sum > biggest)
                    biggest = sum;
            }
            return biggest;
        }
    }
}
