using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinarySearchMain
    {
        public static void BinarySearch_MainMethod()
        {
            int[] arr_Asc = { -18, -12, -4, 0, 2, 3, 4, 15, 16, 18, 22, 45, 89 };
            int target = 21;
            int result = SimpleBinarySearch.binarySearch_findIndex(arr_Asc, target);
            //Console.WriteLine($"Binary Search result: target {target}, Index: {result}");

            int[] arr_Dsc = { 45, 39, 36, 24, 21, 17, 11, 8, 3, 0, -4, -9, -25 };
            int target_dsc = 24;
            int result_dsc = SimpleBinarySearch.binarySearch_OrderAgnosticBS(arr_Dsc, target_dsc);
            Console.WriteLine($"Order Agnostic Binary Search result: target {target_dsc}, Index: {result_dsc}");

        }
    }
}
