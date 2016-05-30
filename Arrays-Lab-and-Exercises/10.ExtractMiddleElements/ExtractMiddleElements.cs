using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] result = MiddleElements(nums);

            Console.WriteLine("{ " + string.Join(", ", result) + " }");
        }

        private static int[] MiddleElements(int[] nums)
        {
            int n = nums.Length;

            if (n == 1) return nums;
            if (n % 2 == 1) return new int[] { nums[n / 2 - 1], nums[n / 2], nums[n / 2 + 1] };
            return new int[] { nums[n / 2 -1], nums[n / 2]  };
        }
    }
}
