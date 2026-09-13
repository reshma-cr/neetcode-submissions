public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(int num in nums){
            if(dict.ContainsKey(num)){
                dict[num]++;
            }
            else{
                dict.Add(num, 1);
            }
        }
        return dict.Keys
                    .OrderByDescending(k => dict[k])
                    .Take(k)
                    .ToArray();
    }
}
