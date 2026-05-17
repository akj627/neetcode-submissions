public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for (var i=0;i<9;i++)
        {
            if (IsRowValid(i) == false)
                return false;
            if (IsColValid(i) == false)
                return false;
        }

        for (var i=0;i<3;i++)
            for (var j=0;j<3;j++)
            {
                if (IsSqValid(i * 3,j * 3) == false)
                    return false;
            }
        
        return true;
    
        bool IsRowValid(int row)
    {
        var sudSet = new HashSet<char>();
        for (var col=0;col < 9;col++)
        {
            if (IsValid(sudSet, board[row][col]) == false)
                return false;
        }
        return true;
    }
    
    bool IsColValid(int col)
    {
        var sudSet = new HashSet<char>();
        for (var row=0;row < 9;row++)
        {
            if (IsValid(sudSet, board[row][col]) == false)
                return false;
        }
        return true;
    }
    
    bool IsSqValid(int x, int y)
    {
        var sudSet = new HashSet<char>();
        for (var row=x;row < x + 3;row++)
            for (var col=y;col < y + 3;col++)
            {
                if (IsValid(sudSet, board[row][col]) == false)
                    return false;
            }
        return true;
    }
}
    
    bool IsValid(HashSet<char> sudSet, char val)
    {
        if (val == '.')
        {
            return true;
        }

        if (sudSet.Contains(val))
            return false;
        else
        {
            sudSet.Add(val);
            return true;
        }
    }
}