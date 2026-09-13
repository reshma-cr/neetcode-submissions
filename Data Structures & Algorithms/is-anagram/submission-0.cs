public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] countArray = new int[26];
        for(int i=0; i<s.Length; i++){
            countArray[s[i] - 'a']++;
            countArray[t[i] - 'a']--;
        }

        foreach(var count in countArray){
            if(count != 0){
                return false;
            }
        }
        return true;
    }
}
