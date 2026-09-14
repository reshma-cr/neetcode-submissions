public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();
        foreach(string s in strs)
        {
            int[] counts = new int[26];
            foreach(char c in s)
            {
                counts[c - 'a']++;
            }
            string key = string.Join(",", counts);
            if(!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            map[key].Add(s);
        }
        return map.Values.ToList<List<string>>();
    }
}
