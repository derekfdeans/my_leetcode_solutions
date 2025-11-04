/*
my original solution worked, but it was incredibly long (using if statements to check characters, nesting ifs when the subtraction issue came up). this revised solution came from peeking at @erenyeagertatakae's solution. 

Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000

For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.

Given a roman numeral, convert it to an integer.

*/

public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> letterToValue = new Dictionary<char, int>();
        letterToValue.Add('I', 1);
        letterToValue.Add('V', 5);
        letterToValue.Add('X', 10);
        letterToValue.Add('L', 50);
        letterToValue.Add('C', 100);
        letterToValue.Add('D', 500);
        letterToValue.Add('M', 1000);

        int sum = 0;
        int previousNumber = 0;

        for (int index = s.Length - 1; index >= 0; index--) {
            int currentNumber = letterToValue[s[index]];

            if (currentNumber < previousNumber) {
                sum -= currentNumber;
            } else {
                sum += currentNumber;
            }

            previousNumber = currentNumber;
        }

        return sum;
    }
}
