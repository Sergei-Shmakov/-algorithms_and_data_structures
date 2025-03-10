using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 7, 4, 7 };
            int k = 3;
            int c = find(nums, k);
            Console.WriteLine(c);


            //char[] arr = { 'a', 's', 'd', 'f' };
            //Reverse(arr);
            //foreach(var elem in arr)
            //    Console.Write(elem);


            //int[] arr1 = { 2, 7, 8, 13, 5, 10, 7 };
            //int res = Solution(arr1, 25);
            //Console.WriteLine(res);



        }
        //static char[] Reverse(char[] array)
        //{
        //    for (int l = 0, r = array.Length - 1; l < r; l++, r--)
        //    {
        //        char tmp = array[l];
        //        array[l] = array[r];
        //        array[r] = tmp;
        //    }
        //    return array;
        //}
        //        static int Solution(int[] array, int k)
        //        {
        //            int maxCount = 0;
        //            for(int i = 0; i < array.Length; i ++)
        //            {
        //                int count = 0;
        //                int j = i;
        //                int summ = 0;
        //                while (j < array.Length && summ + array[j] < k)
        //                {
        //                    summ += array[j++];
        //                    count++;
        //                }
        //                maxCount = Math.Max(count, maxCount);
        //            }
        //            return maxCount;

        //        }

        static int find(int[] nums, int k)
        {
            int left = 0;
            int curr = 0;
            int ans = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                curr += nums[right];
                while (curr > k)
                {
                    curr -= nums[left];
                    left++;
                }
                ans = Math.Max(ans, right - left + 1);

            }
            return ans;
        }
    }

}
