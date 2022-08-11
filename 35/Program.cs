using System;

namespace SearchInsertPosition
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
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

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int target = 10;

            int result = solution.SearchInsert(nums, target);
            Console.WriteLine(result);
        }
    }
}