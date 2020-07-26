public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
    int max = candies.Max();
	bool[] results = new bool[candies.Length];
	for(int i = 0; i < candies.Length; i++){
		if(candies[i] + extraCandies >= max )
			results[i] = true;
		else
			results[i] = false;
	}

	return results;
    }
}