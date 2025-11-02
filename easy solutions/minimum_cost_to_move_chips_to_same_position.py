# We have n chips, where the position of the ith chip is position[i].

# We need to move all the chips to the same position. In one step, we can change the position of the ith chip from position[i] to:
#      position[i] + 2 or position[i] - 2 with cost = 0.
#      position[i] + 1 or position[i] - 1 with cost = 1.

# Return the minimum cost needed to move all the chips to the same position.

class Solution:
    def minCostToMoveChips(self, position: List[int]) -> int:
        # record number of chips on odd and even indexes, return amount of whichever is lower
        amount_of_odd = 0 # count odds
        amount_of_even = 0 # count evens

        for index in range(0, len(position)): # check every index
            if position[index] % 2 == 0: # if it's odd,
                amount_of_even += 1 # add to odd
            else: #otherwise,
                amount_of_odd += 1 # add to even
        
        return min(amount_of_odd, amount_of_even) # return whichever has a lower count
