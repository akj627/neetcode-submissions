class Solution:
    def lexicographicallySmallestArray(self, nums: List[int], limit: int) -> List[int]:
        res = []
        snums = sorted(nums)
        groups = []
        numsGroups = {}

        for n in snums:
            if not groups or abs(n - groups[-1][-1]) > limit:
                groups.append(deque())
            groups[-1].append(n)
            numsGroups[n] = len(groups) - 1

        for n in nums:
            j = numsGroups[n]
            res.append(groups[j].popleft())
        
        return res