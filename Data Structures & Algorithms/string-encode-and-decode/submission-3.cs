public class Solution {

    public string Encode(IList<string> strs) {
        string encoded_string = "";
        foreach(string s in strs)
        {
            encoded_string += s.Length.ToString() + "#" + s;
        }
        return encoded_string;
    }

    public List<string> Decode(string s) {
        var decodedList = new List<string>();
        int i = 0;  
        while(i<s.Length)
        {
            int j=i;
            while(s[j] != '#')
            {
                j++;
            }
            int length = int.Parse(s.Substring(i, j-i));
            i = j+1;
            j = i+length;
            decodedList.Add(s.Substring(i, length));
            i = j;
        }
        return decodedList;
   }
}
