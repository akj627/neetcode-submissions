public class Solution {
    public int HammingWeight(uint n) {
        var cnt = 0;
        while (n != 0)
        {
            if (n % 2 == 1)
                cnt++;
            n = n >> 1;
        }
        return cnt;
    }
}
