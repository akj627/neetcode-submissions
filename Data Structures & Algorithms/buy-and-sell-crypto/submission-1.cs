public class Solution {
    public int MaxProfit(int[] prices) {

        var left = 0;
        var right = 1;
        var diff = 0;

        while (right < prices.Length)
        {
            diff = Math.Max(prices[right] - prices[left], diff);

            if (prices[right] < prices[left])
            {
                left = right;
            }
            right++;
        }

        return diff;        
    }
}