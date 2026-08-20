class Solution:
    def findMin(self, nums: List[int]) -> int:

        l, r = 0, len(nums) - 1
        res = nums[0]

        while (l <= r):
            if nums[l] <= nums[r]:
                res = min(res, nums[l])
                break;

            mid = (l + r)//2
            res = min(res, nums[mid])
            if nums[mid] >= nums[l]:
                l = mid + 1
            else:
                r = mid - 1

        return res


        left, right = 0, len(nums) - 1
        minIndex = -1

        while left <= right:
            mid = left + (right - left)//2
            if nums[mid] <= nums[-1]:
                right = mid - 1
                minIndex = mid
            else:
                left = mid + 1
        
        return nums[minIndex]        