public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int[] countArr = new int[26];
        for(int i=0; i<s.Length; i++){
            countArr[s[i] - 'a']++;
            countArr[t[i] - 'a']--;
        }
        foreach(int val in countArr){
            if(val != 0) return false;
        }
        return true;
    }
}
