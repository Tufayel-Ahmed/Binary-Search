using System;

namespace GuessNumberHigherOrLower
{
    public class Solution : GuessGame
    {
        public int GuessNumber(int n)
        {
            int left = 1;
            int right = n;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (guess(mid) == 0)
                {
                    return mid;
                }
                else if (guess(mid) == 1)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
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

            int n = 10;

            int result = solution.GuessNumber(n);
            Console.WriteLine(result);
        }
    }
}