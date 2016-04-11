using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _001TwoSum
{
    /// <summary>
    //  Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    //  You may assume that each input would have exactly one solution.

    //  Example:
    //            Given nums = [2, 7, 11, 15], target = 9,
    //            Because nums[0] + nums[1] = 2 + 7 = 9,
    //            return [0, 1].

    //  UPDATE(2016/2/13):
    //  The return format had been changed to zero-based indices.Please read the above updated description carefully.
    /// </summary>


    //FirstViewIdea-->O(n^2)
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((nums[j] == target - nums[i]) && (i!=j))
                    {
                        return new []{i,j};
                    }
                }
            }
            throw new Exception("NO WAY!!!");
        }
    }


    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
