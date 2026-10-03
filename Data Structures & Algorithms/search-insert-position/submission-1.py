class Solution:
    def searchInsert(self, nums: List[int], target: int) -> int:
        lenth = len(nums) - 1
        l, r = 0, lenth

        while (l <= r):
            mid = (l + r)//2

            if nums[mid] > target:
                r = mid - 1
            elif nums[mid] < target:
                l = mid + 1
            else:
                return mid
        return l