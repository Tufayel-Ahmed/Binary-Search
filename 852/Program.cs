using System;

namespace PeakIndexInAMountainArray
{
    public class Solution
    {
        public int PeakIndexInMountainArray(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] > arr[mid + 1])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
    }
    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int result = solution.PeakIndexInMountainArray(arr);
            Console.WriteLine(result);
        }
    }
}