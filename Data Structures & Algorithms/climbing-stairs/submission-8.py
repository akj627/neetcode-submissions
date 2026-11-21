class Solution:
    def climbStairs(self, n: int) -> int:
    #   1, 2 , 3
    #
        if n <= 2:
            return n

        one, two = 1, 2

        for i in range (3, n + 1):
            two, one = one + two, two

        return two