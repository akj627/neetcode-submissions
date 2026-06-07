"""
Definition of Interval:
class Interval(object):
    def __init__(self, start, end):
        self.start = start
        self.end = end
"""
import heapq

class Solution:
    def minMeetingRooms(self, intervals: List[Interval]) -> int:

        if not intervals:
            return 0;

        intervals.sort(key = lambda i : i.start)

        count = 0
        heap = []

        heapq.heappush(heap, intervals[0].end)

        for i in range (1, len(intervals)):
            current = intervals[i]

            if current.start >= heap[0]:
                heapq.heappop(heap)

            heapq.heappush(heap, current.end)
            
        return len(heap)
        