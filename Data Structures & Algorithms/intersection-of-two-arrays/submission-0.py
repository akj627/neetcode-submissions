class Solution:
    def intersection(self, nums1: list[int], nums2: list[int]) -> list[int]:
        res = set()
        ret = set()

        for i in nums1:
            res.add(i)

        for i in nums2:
            if i in res:
                ret.add(i)

        return list(ret)