class Solution:
    def mySqrt(self, x: int) -> int:

        if x == 0:
            return 0

        l, r = 0, x
        res = 0

        while l <= r:
            mid = (l + r) // 2 # 3, 1
            if mid * mid > x:
                r = mid - 1 # r = 2
            elif mid * mid == x:
                return mid
            else:
                l = mid + 1 # 2
                res = mid 

        return res