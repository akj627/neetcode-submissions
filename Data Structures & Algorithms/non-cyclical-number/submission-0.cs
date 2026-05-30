public class Solution {
    public bool IsHappy(int n) {
        var stk = new HashSet<int>();

        while (true)
        {
            var nSquared = Squared(n);
            if (nSquared == 1)
                return true;
            if (stk.Contains(nSquared))
                return false;
            else
                stk.Add(nSquared);
            n = nSquared;
        }
    }

    private int Squared(int n)
    {
        var sum = 0;
        while (n != 0)
        {
            var div = n % 10;
            sum += div * div;
            n = n / 10;
        }
        return sum;
    }
}
