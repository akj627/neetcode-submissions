class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        
        #xored = len(nums)

        #for i, num in enumerate(nums):
         #   xored = xored ^ i ^ nums[i]
        
        #return xored
        #>

        sum1 = 0
        sum2 = len(nums)

        for i, num in enumerate(nums):
            sum1 += num
            sum2 += i

        return sum2 - sum1        