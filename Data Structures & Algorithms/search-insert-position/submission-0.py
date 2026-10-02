class Solution:
    def searchInsert(self, nums: List[int], target: int) -> int:
        lenth = len(nums) - 1
        l, r = 0, lenth

        if nums[0] > target:
            return 0

        if nums[lenth] < target:
            return lenth + 1

        while (l <= r):
            mid = (l + r)//2

            if nums[mid] > target:
                if mid > 0 and target > nums[mid - 1]:
                    return mid
                r -= 1
            elif nums[mid] < target:
                if mid < lenth and target < nums[mid + 1]:
                    return mid + 1
                l += 1
            else:
                return mid
        return -1