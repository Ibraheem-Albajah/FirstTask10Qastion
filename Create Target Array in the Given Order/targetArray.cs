public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index) {
     int[] ans = new int[nums.Length];
		 for (int i = 0; i < ans.Length; i++)
        {
            ans[i] = -1;
        }

		for (int i = 0; i < nums.Length; i++) {
			int indexValue = index[i];
			int numsValue = nums[i];
			int Tokept = ans[indexValue];

			if (Tokept == -1) {
				ans[indexValue] = numsValue;
			} else {
				int shfit = ans[indexValue];
				ans[indexValue] = numsValue;

				for (int j = indexValue + 1; j < nums.Length; j++) {
					if (ans[j] == -1) {
						ans[j] = shfit;
						break;
					} else {
						int temp = ans[j];
						ans[j] = shfit;
						shfit = temp;
					}

				}
			}
		}

		return ans;
    }
}