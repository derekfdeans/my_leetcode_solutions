/*

You are given a 0-indexed integer array nums of size n.

Define two arrays leftSum and rightSum where:
     leftSum[i] is the sum of elements to the left of the index i in the array nums. If there is no such element, leftSum[i] = 0.
     rightSum[i] is the sum of elements to the right of the index i in the array nums. If there is no such element, rightSum[i] = 0.

Return an integer array answer of size n where answer[i] = |leftSum[i] - rightSum[i]|.

*/

public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        List<int> left_sum = new List<int> {0};
        for (int index = 0; index < nums.Length - 1; index++) {
            left_sum.Add(left_sum[index] + nums[index]);
        }

        List<int> right_sum = new List<int> {0};
        for (int index = nums.Length - 1; index != 0; index--) {
            right_sum.Insert(0, nums[index] + right_sum[0]);
        }

        List<int> answer = new List<int>();
        for (int index = 0; index < right_sum.Count; index++) {
            answer.Add(Math.Abs(left_sum[index] - right_sum[index]));
        }

        return answer.ToArray();
    }
}
