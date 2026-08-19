class Solution:
    def maxProduct(self, nums: List[int]) -> int:

        leftp, rightp = 1, 1

        ans = nums[0]

        for i in range(len(nums)):
            leftp = (1 if leftp == 0 else leftp) * nums[i]
            rightp = (1 if rightp == 0 else rightp) * nums[len(nums) - i - 1]

            ans = max (ans, leftp, rightp)

        return ans