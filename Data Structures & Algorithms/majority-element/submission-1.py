class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        can, cnt = 0, 0

        for i in nums:
            if cnt == 0:
                can = i
            if can == i:
                cnt = cnt + 1
            else:
                cnt = cnt - 1
        return can

'''
        dict = {}
        n = len(nums) // 2

        for i in nums:
            if i in dict:
                dict[i] = dict[i] + 1
            else:
                dict[i] = 1
            if dict[i] > n:
                return i

        return -1

'''



    #can = 5
    #cnt = 1