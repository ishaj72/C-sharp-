// way1 
public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[nums.Length];
        for(int i = 0 ; i < nums.Length ; i ++){
            ans[i] = nums[i];
        }
        int [] result = nums.Concat(ans).ToArray();
        return result;
    }
}

//way2
public class Solution {
    public int[] GetConcatenation(int[] nums) {
        return nums.Concat(nums).ToArray();
    }
}
