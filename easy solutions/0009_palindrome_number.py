# Given an integer x, return true if x is a palindrome, and false otherwise.

class Solution:
    def isPalindrome(self, x: int) -> bool:
        number_as_string = str(x)
        for number in range(1,len(number_as_string)):
            if (number_as_string[number] != number_as_string[-(number+1)]):
                return False

        return True 
