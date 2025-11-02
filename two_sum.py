#Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
#You may assume that each input would have exactly one solution, and you may not use the same element twice.
# You can return the answer in any order.

# runtime: ?
# memory: ?

class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        for i in range(0,len(nums)): # starting loop for first number
            for j in range(0, len(nums)): # loop back to add to first number
                if (nums[i] + nums[j]) == target and i != j: # if indexes are not the same, adding the list's index results are equal to target
                    return [i, j] # return the indexes -> correct solution
        
        return [0,0] # if nothing was added through the loops
