using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _12TimesTableGame
{
    public class GetRandomArray
    {
        public int[] AssignSidesAndTop()
        {
            var rand = new Random();
            int[] nums = Enumerable.Range(1, 12).ToArray();
            for (int x = nums.Length - 1; x > 0; x--)
            {
                int y = rand.Next(x + 1);
                int temp = nums[x];
                nums[x] = nums[y];
                nums[y] = temp;
            }
            return nums;
        }
    }
}
