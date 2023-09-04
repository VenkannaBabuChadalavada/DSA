namespace BinarySearch
{
    public class SimpleBinarySearch
    {
        //find the target index
        //return -1 if it doesn't exists.
        public static int binarySearch_findIndex(int[] arr, int target)
        {
            int start_index = 0;
            int end_index = arr.Length - 1;

            while (start_index <= end_index)
            {
                //find the middle element
                //int mid = (start + end)/2 => might be possible that start+end exceeds the range of int.
                int mid_index = start_index + (end_index - start_index) / 2;

                //This approach is also correct we need to remove last else condition if we use this approach.
                //if (arr[mid_index] == target)
                //    return mid_index;

                if (target < arr[mid_index])
                {
                    //Search in the left part of the array
                    end_index = mid_index - 1;
                }
                else if (target > arr[mid_index])
                {
                    //Search in the right part of the array
                    start_index = mid_index + 1;
                }
                else
                {
                    //ans found
                    return mid_index;
                }
            }
            return -1;
        }

        public static int binarySearch_OrderAgnosticBS(int[] arr, int target)
        {
            int start_index = 0;
            int end_index = arr.Length - 1;

            //find whether the array is sorted in ascending or descending
            bool isAs = arr[start_index] < arr[end_index];

            while (start_index <= end_index)
            {
                //find the middle element
                int mid_index = start_index + (end_index - start_index) / 2;

                if (arr[mid_index] == target)
                    return mid_index;

                if (isAs)
                {
                    if (target < arr[mid_index])
                        //Search in the left part of the array
                        end_index = mid_index - 1;
                    else
                        //Search in the right part of the array
                        start_index = mid_index + 1;
                }
                else
                {
                    if (target > arr[mid_index])
                        //Search in the left part of the array
                        end_index = mid_index - 1;
                    else
                        //Search in the right part of the array
                        start_index = mid_index + 1;
                }
            }
            return -1;
        }
    }
}