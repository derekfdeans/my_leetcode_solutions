# You are given a 0-indexed integer array nums of size n.

# Define two arrays leftSum and rightSum where:
#      leftSum[i] is the sum of elements to the left of the index i in the array nums. If there is no such element, leftSum[i] = 0.
#      rightSum[i] is the sum of elements to the right of the index i in the array nums. If there is no such element, rightSum[i] = 0.

#Return an integer array answer of size n where answer[i] = |leftSum[i] - rightSum[i]|.

# runtime: ?
# memory: ?

class Solution:
    def leftRightDifference(self, nums: List[int]) -> List[int]:
        if len(nums) < 2:
            return [0]

        leftSum = [0] # "sum of elements to the left of index"
        for number in range(0,(len(nums)-1)):
            number_to_add = leftSum[number] + nums[number]
            leftSum.append(number_to_add)

        rightSum = [0] # "sum of elements to the right of index"
        for number in range(1,(len(nums))):
            number_to_add = rightSum[0] + nums[-number]
            rightSum.insert(0, number_to_add)

        print(leftSum)
        print(rightSum)

        answer = []
        for index in range(0,len(leftSum)):
            answer.append(abs(leftSum[index]-rightSum[index]))

        return answer # "where answer[i] = leftSum[i] - rightSum[i]
