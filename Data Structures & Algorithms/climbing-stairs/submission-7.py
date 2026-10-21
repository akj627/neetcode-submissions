class Solution:
    def climbStairs(self, n: int) -> int:
        
        if n <= 2:
            return n

        one, two = 1, 2
        # 1, 2, 3, 5
        for i in range(2, n):
            temp = two # 2, 3
            two = one + two # 3, 5
            one = temp # 2, 3

        return two

