class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:
        rows, cols = len(grid), len(grid[0])

        count = 0

        def checkNbors(i, j):
            if i < 0 or j < 0 or i >= rows or j >= cols:
                return

            if grid[i][j] == '0' or grid[i][j] == 'v':
                return
            
            grid[i][j] = 'v'

            checkNbors(i + 1, j)
            checkNbors(i - 1, j)
            checkNbors(i, j + 1)
            checkNbors(i, j - 1)

        for i in range(rows):
            for j in range(cols):
                if grid[i][j] == '1':
                    checkNbors(i, j)
                    count += 1
        return count
