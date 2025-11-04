/*

We have n chips, where the position of the ith chip is position[i].

We need to move all the chips to the same position. In one step, we can change the position of the ith chip from position[i] to:
     position[i] + 2 or position[i] - 2 with cost = 0.
     position[i] + 1 or position[i] - 1 with cost = 1.

Return the minimum cost needed to move all the chips to the same position.

*/

public class Solution {
    public int MinCostToMoveChips(int[] position) {
        int amount_on_odd = 0;
        int amount_on_even = 0;

        foreach (int number in position) {
            if (number % 2 == 0) {
                amount_on_even += 1;
            } else {
                amount_on_odd += 1;
            }
        }

        return Math.Min(amount_on_odd, amount_on_even);
    }
}
