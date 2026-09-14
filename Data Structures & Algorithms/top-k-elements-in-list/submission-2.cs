public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>(); //1, 1; 2, 2; 3, 3
        foreach(int num in nums)
        {
            map[num] = map.GetValueOrDefault(num, 0) + 1;
        }
        List<int>[] freq = new List<int>[nums.Length+1];
        foreach(var item in map)
        {
            if(freq[item.Value] == null)
            {
                freq[item.Value] = new List<int>();
            }
            freq[item.Value].Add(item.Key);
        }
        int[] result = new int[k];
        int index=0;
        for(int i=freq.Length-1; i>=0; i--)
        {
            if(freq[i] != null)
            {
                foreach(int value in freq[i])
                {
                    result[index] = value;
                    index++;
                    if(index == k) return result;
                }
            }
        }
        return result;
    }
}
