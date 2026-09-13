public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        foreach(string str in strs){
            var countArray = new int[26];
            for(int i=0; i<str.Length; i++){
                countArray[str[i] - 'a']++;
            }
            var countArrayString = String.Join(",", countArray);
            if(!dict.ContainsKey(countArrayString)){
                dict.Add(countArrayString, new List<string>{str});
            }
            else{
                dict[countArrayString].Add(str);
            }
        }
        return dict.Values.ToList();
    }
}
