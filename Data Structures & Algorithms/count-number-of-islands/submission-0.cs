public class Solution {
    public int NumIslands(char[][] grid) {
        var count = 0;
        
        for (var x = 0; x < grid.Length; x++)
            for (var y = 0; y < grid[x].Length; y++)
            {
                if (grid[x][y] == '1')
                {
                    CheckNbors(grid, x, y);
                    count++;
                }        
            }        
        return count;
    }
    
    private void CheckNbors(char[][] grid, int x, int y)
    {
        if (x < 0 || y < 0 || x == grid.Length || y == grid[x].Length)
            return;
        if (grid[x][y] == 'v' || grid[x][y] == '0')
            return;
        
        if (grid[x][y] == '1')
            grid[x][y] = 'v';
            
        CheckNbors(grid, x + 1, y);
        CheckNbors(grid, x - 1, y);
        CheckNbors(grid, x, y + 1);
        CheckNbors(grid, x, y - 1);
    }
}