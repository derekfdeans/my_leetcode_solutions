# You are given a 1-indexed array of distinct integers nums of length n.

# You need to distribute all the elements of nums between two arrays arr1 and arr2 using n operations. In the first operation, append nums[1] to arr1. In the second operation, append nums[2] to arr2. Afterwards, in the ith operation:
#      If the last element of arr1 is greater than the last element of arr2, append nums[i] to arr1. Otherwise, append nums[i] to arr2.

# The array result is formed by concatenating the arrays arr1 and arr2. For example, if arr1 == [1,2,3] and arr2 == [4,5,6], then result = [1,2,3,4,5,6].
# Return the array result.

# runtime: ?
# memory: ?
  
 class Solution:
    def resultArray(self, nums: List[int]) -> List[int]:
        array_1 = [nums[0]] # operation 1
        array_2 = [nums[1]] # operation 2

        number_index = 2
        while (number_index < len(nums)):
            if array_1[-1] > array_2[-1]:
                array_1.append(nums[number_index]) # operation 3
            else:
                array_2.append(nums[number_index])

            number_index += 1
        
        return array_1 + array_2
