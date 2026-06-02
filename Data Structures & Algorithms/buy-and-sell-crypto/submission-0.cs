public class Solution {
    public int MaxProfit(int[] prices) {

        if (prices.Count() == 1)
            return 0;

        int iLeft = 0;
        int iRight = 1;
        int diff = 0;

        while (iRight < prices.Length)
        {
            diff = Math.Max(prices[iRight] - prices[iLeft], diff);//5
            if (prices[iLeft] > prices[iRight])
            {
                iLeft = iRight;//1
            }
            iRight++;//5
        }

        return diff;
    }
}