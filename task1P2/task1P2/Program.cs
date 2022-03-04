using System;

namespace task1P2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 6, 3, 1, 7, 8, 5 };
            int small = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (small>nums[i])
                {
                    small = nums[i];
                }
                //else if (small<nums[i])
                //{
                //    Console.WriteLine("Bu en boyuk elementidir" );
                //} 
            }
            Console.WriteLine("Bu en kicik elementdir" + small);
        } 
    }
}
