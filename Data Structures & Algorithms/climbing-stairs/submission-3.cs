public class Solution {
    public int ClimbStairs(int n) {     
        return Climb(n);
    }

    private int Climb(int n)
    {
        if (n <= 2)
            return n;
        
        var a = 1;
        var b = 2;

        var total = 0;
        for (var i = 3; i <= n;i++)
        {
            total = a + b;
            a = b;
            b = total;
        }

        return total;

        //return Climb(n - 1) + Climb(n - 2);
    }
}
