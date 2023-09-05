public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int n = nums.Length;
        int[] ans = Enumerable.Repeat(0,n).ToArray();
        for(int i = 0 ; i < n ; i ++){
            for(int j = 0 ; j < n ; j ++){
                if(nums[i]>nums[j]){
                    ans[i]++;
                }
            }
        }
        return ans;
    }
}
