class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        #001205,100205,120005,125000
        if len(nums) <= 1:
            return

        l, r = 0, 0

        
        while r < len(nums):
            if nums[r] != 0:
                temp = nums[l]
                nums[l] = nums[r]
                nums[r] = temp
                l += 1
            r += 1
            
            #[0, 1, 0, 3, 12]

        