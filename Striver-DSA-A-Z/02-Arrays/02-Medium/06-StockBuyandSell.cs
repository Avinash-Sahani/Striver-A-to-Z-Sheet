namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays{
    public int MaxProfit(int[] prices) {
        if(prices.Length ==1)
            return 0;
        int buy = prices[0];
        int sell = -1;
        int p = sell - buy;;
        int max_profit = p;
        for(int i=1; i<prices.Length;i++)
        {   

            if(prices[i] < buy)
            {
                buy = prices[i];
                sell = -1;
            }

            else if( prices[i] > sell  )
                sell = prices[i];

            p = sell - buy;
            if(p>max_profit )
                max_profit = p;


        }

        if(max_profit < 0)
            return 0;
        return max_profit;


        

    }
}