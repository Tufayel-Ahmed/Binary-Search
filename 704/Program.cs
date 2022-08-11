using System;

namespace BinarySearch
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {

            int left = 0;
            int right = nums.Length - 1;
            int mid = 0;

            if (nums[0] == target)
            {
                return 0;
            }
            if (nums[nums.Length - 1] == target)
            {
                return right;
            }

            while (left <= right)
            {

                mid = left + (right - right) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int target = 10;

            int result = solution.Search(nums, target);
            Console.WriteLine(result);
        }
    }
}
