class Solution:
    def mySqrt(self, x: int) -> int:
        lo, hi = 0, x
        ret = 1
        while lo <= hi:
            mid = lo + (hi - lo) // 2 # 13, 6,2
            sq = mid * mid

            if sq == x:
                return mid
            
            if sq > x:
                hi = mid - 1 # 12, 5
            else:
                lo = mid + 1 #3
                ret = mid

        return ret