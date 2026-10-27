class Solution:
    def mySqrt(self, x: int) -> int:

        if x == 0:
            return 0

        l, r = 1, x
        res = 1

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
        #25
        #12, 6, 3 4 5