class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:
        
        lx = len(grid)
        ly = len(grid[0])

        sum = 0

        def recur(x, y):
            if x < 0 or y < 0 or x == lx or y == ly or grid[x][y] == "v" or grid[x][y] == "0":
                return

            if grid[x][y] == "1":
                grid[x][y] = "v"

            recur (x + 1, y)
            recur (x, y + 1)
            recur (x - 1, y)
            recur (x, y - 1)
        

        for i in range(lx):
            for j in range(ly):
                if grid[i][j] != "0" and grid[i][j] != "v":
                    recur (i, j)
                    sum += 1
            
        return sum
