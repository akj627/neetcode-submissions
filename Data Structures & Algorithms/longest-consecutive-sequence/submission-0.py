class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
    
    #nx + (0 + 1 + 2 + (b-1)) = sum
    #nx + b(b-1)/2 = 
    #hash = 2, 20, 4, 10, 3,4,5
    #
        nset = set(nums)
        longest = 0

        for n in nums:
            if (n -1) not in nset:
                length = 0
                while (n + length) in nset:
                    length += 1
                longest = max(length, longest)

        return longest        
