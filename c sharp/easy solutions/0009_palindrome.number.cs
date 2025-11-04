/*

Given an integer x, return true if x is a palindrome, and false otherwise.

*/

public class Solution {
    public bool IsPalindrome(int x) {
        string numberToString = x.ToString();
        string reversedString = new string(numberToString.Reverse().ToArray());
        return numberToString == reversedString;
    }
}
